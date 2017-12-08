using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftScanner.Model
{
    public class Channel : IDisposable
    {
        private bool m_isActive;
        private SampleProviders.SquelchSampleProvider m_squelchProvider;
        private WaveStream m_inputWave;
        private VolumeSampleProvider m_volumeProvider;
        private MediaFoundationResampler m_resampler;
        public event EventHandler ActivationEvent;
        public event EventHandler DeactivationEvent;
        private const int OUTPUT_SAMPLE_RATE = 44100;
        private const double SQUELCH_DELAY = 3000;

        public int Priority { get; set; }
        public String Title { get; set; }
        public String  URL { get; set; }

        [JsonIgnore]
        public bool IsActive
        {
            get { return m_isActive; }
            set { }
        }

        public void enable()
        {
            m_inputWave = new MediaFoundationReader(URL);

            var outFormat = new WaveFormat(OUTPUT_SAMPLE_RATE, 2);
            m_resampler = new MediaFoundationResampler(m_inputWave, outFormat);

            m_squelchProvider = new SampleProviders.SquelchSampleProvider(new Pcm16BitToSampleProvider(m_resampler));
            m_squelchProvider.ActivationEvent += m_squelchProvider_ActivationEvent;
            m_squelchProvider.DeactivationEvent += m_squelchProvider_DeactivationEvent;
            m_squelchProvider.DelayTime = SQUELCH_DELAY;

            m_volumeProvider = new VolumeSampleProvider(m_squelchProvider);            
        }

        public void mute()
        {
            m_volumeProvider.Volume = 0.2f;
        }

        public void unmute()
        {
            m_volumeProvider.Volume = 1.0f;
        }

        private void m_squelchProvider_DeactivationEvent(object sender, EventArgs e)
        {
            m_isActive = false;
            EventHandler handler = DeactivationEvent;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
        }

        private void m_squelchProvider_ActivationEvent(object sender, EventArgs e)
        {
            m_isActive = true;
            EventHandler handler = ActivationEvent;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
        }

        public ISampleProvider getSampleProvider()
        {
            // Return the last provider in the chain
            return m_volumeProvider;
        }

        public void setSquelch(float threashold)
        {
            m_squelchProvider.Threshold = threashold;
        }

        public float getSquelch()
        {
            return m_squelchProvider.Threshold;
        }

        public override string ToString()
        {
            return Priority + ": " + Title + " - " + URL;
        }

        public void Dispose()
        {
            m_resampler.Dispose();
            m_inputWave.Dispose();
        }
    }
}
