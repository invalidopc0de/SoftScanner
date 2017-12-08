using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftScanner.Model
{
    public class Scanner
    {
        private const float DEFAULT_VOLUME = 0.7f;

        List<Channel> m_channels;
        private readonly WaveOut m_waveOut;
        private readonly MixingSampleProvider m_mixer;
        private readonly VolumeSampleProvider m_volumeProvider;
        private Channel m_currentChannel = null;
        private Stack<Channel> m_previousChannels;

        public event EventHandler CurrentChannelUpdatedEvent;
        public event EventHandler ChannelListUpdatedEvent;

        
        private float m_volume = DEFAULT_VOLUME;

        public float Volume
        {
            get { return m_volume; }
            set {
                m_volume = value;
                if (m_volumeProvider != null)
                {
                    m_volumeProvider.Volume = m_volume;
                }
            }
        }
        

        public Scanner()
        {
            m_previousChannels = new Stack<Channel>();
            m_channels = new List<Channel>();
            m_waveOut = new WaveOut();
            m_mixer = new MixingSampleProvider(WaveFormat.CreateIeeeFloatWaveFormat(44100, 2));
            m_mixer.ReadFully = true;
            m_volumeProvider = new VolumeSampleProvider(m_mixer);
            m_volumeProvider.Volume = m_volume;

            m_waveOut.Init(m_volumeProvider);
            m_waveOut.Play();
        }


        public void addChannel(Channel channel)
        {
            m_channels.Add(channel);
            channel.enable();
            channel.mute();
            m_mixer.AddMixerInput(channel.getSampleProvider());
            // Setup listening for activated events, etc
            channel.ActivationEvent += channel_ActivationEvent;
            channel.DeactivationEvent += channel_DeactivationEvent;
            notify(ChannelListUpdatedEvent);
        }

        void channel_DeactivationEvent(object sender, EventArgs e)
        {
            Channel deactivatedChannel = (Channel)sender;
            Debug.WriteLine(deactivatedChannel.Title + " deactivated.");
            if(m_currentChannel == deactivatedChannel)
            {
                m_currentChannel = null;
                deactivatedChannel.mute();

                // Go back until you find an active channel
                // TODO/MS Need to change to change through active channels by priority
                while (m_previousChannels.Count > 0)
                {
                    m_currentChannel = m_previousChannels.Pop();
                    if(m_currentChannel.IsActive)
                    {
                        m_currentChannel.unmute();
                        break;
                    }
                    else
                    {
                        m_currentChannel = null;
                    }
                }
                notify(CurrentChannelUpdatedEvent);
            }
        }

        void channel_ActivationEvent(object sender, EventArgs e)
        {
            Channel activatedChannel = (Channel)sender;
            if (m_currentChannel == null)
            {
                m_currentChannel = activatedChannel;
                activatedChannel.unmute();
                notify(CurrentChannelUpdatedEvent);
            }
            else if (m_currentChannel.Priority < activatedChannel.Priority)
            {
                m_currentChannel.mute();
                m_previousChannels.Push(m_currentChannel);
                m_currentChannel = activatedChannel;
                activatedChannel.unmute();
                notify(CurrentChannelUpdatedEvent);
            }
            Debug.WriteLine(activatedChannel.Title + " activated.");
        }

        public void removeChannel(Channel channel)
        {
            m_channels.Remove(channel);
            // Tear-down listening for activated events, etc
            m_mixer.RemoveMixerInput(channel.getSampleProvider());
            channel.ActivationEvent -= channel_ActivationEvent;
            channel.DeactivationEvent -= channel_DeactivationEvent;
            channel.Dispose();
            notify(ChannelListUpdatedEvent);
        }

        public void notify(EventHandler notifyHandler)
        {
            EventHandler handler = notifyHandler;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
        }
        public IReadOnlyList<Channel> getChannelList()
        {
            // Not sure if this is a good thing to give the actual reference, 
            // or if a copy of the list should be returned.
            return m_channels.AsReadOnly();
        }

        public Channel getCurrentStation()
        {
            return m_currentChannel;
        }

        public void clearChannels()
        {
            foreach (var channel in m_channels)
            {
                removeChannel(channel);
            }
        }
    }
}
