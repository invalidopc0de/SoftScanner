using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftScanner.SampleProviders
{
    public class SquelchSampleProvider : ISampleProvider
    {
        private ISampleProvider m_source;
        public event EventHandler ActivationEvent;
        public event EventHandler DeactivationEvent;

        private bool m_isActive;
        private DateTime m_lastTrigger;


        public SquelchSampleProvider(ISampleProvider source)
        {
            m_source = source;
            Threshold = 0.1f;
        }

        public float Threshold { get; set; }

        public bool IsActive
        {
            get { return m_isActive; }
            set { m_isActive = value; }
        }

        private double m_delayTime;

        public double DelayTime
        {
            get { return m_delayTime; }
            set { m_delayTime = value; }
        }
        

        public int Read(float[] buffer, int offset, int count)
        {
            int samplesRead = m_source.Read(buffer, offset, count);
            for (int n = 0; n < samplesRead; n++ )
            {
                if(Math.Abs(buffer[offset + n]) > Threshold)
                {
                    // If the sample exceeds the buffer, and the squelch currently isn't active
                    // then raise the event to notify 
                    if (m_isActive == false)
                    {
                        Debug.WriteLine(buffer[offset + n]);
                        m_isActive = true;
                        EventHandler handler = ActivationEvent;
                        if(handler != null)
                        {
                            handler(this, new EventArgs());
                        }
                    }
                    
                    m_lastTrigger = DateTime.Now;
                }
                else
                {
                    if(DateTime.Now.Subtract(m_lastTrigger).TotalMilliseconds > m_delayTime)
                    {
                        buffer[offset + n] = 0.0f;
                        if (m_isActive == true)
                        {
                            EventHandler handler = DeactivationEvent;
                            if(handler != null)
                            {
                                handler(this, new EventArgs());
                            }
                            m_isActive = false;
                        }
                    }
                }
            }

            return samplesRead;
        }

        public WaveFormat WaveFormat
        {
            get { return m_source.WaveFormat; }
        }
    }
}
