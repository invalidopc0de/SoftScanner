using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftScanner.Model;
using SoftScanner.View;

namespace SoftScanner
{
    public partial class Form1 : Form
    {
        private Scanner m_scanner;

        public Form1()
        {
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            m_scanner = new Model.Scanner();
            m_scanner.CurrentChannelUpdatedEvent += m_scanner_CurrentChannelUpdatedEvent;
            m_scanner.ChannelListUpdatedEvent += m_scanner_ChannelListUpdatedEvent;
        }


        void m_scanner_ChannelListUpdatedEvent(object sender, EventArgs e)
        {
            this.lstChannels.Items.Clear();
            IReadOnlyList<Channel> channels = m_scanner.getChannelList();
            foreach (Channel ch in channels)
            {
                ListViewItem newItem = new ListViewItem();
                newItem.Text = ch.Title;
                newItem.SubItems.Add(ch.Priority.ToString());
                newItem.SubItems.Add(ch.URL);
                lstChannels.Items.Add(newItem);
            }
        }

        void m_scanner_CurrentChannelUpdatedEvent(object sender, EventArgs e)
        {
            Channel currentChannel = m_scanner.getCurrentStation();
            if(currentChannel != null){
                this.txtChannelName.Text = currentChannel.Title;
                foreach (ListViewItem lvi in this.lstChannels.Items)
                {
                    if(lvi.Text == currentChannel.Title && lvi.SubItems[2].Text == currentChannel.URL)
                    {
                        //lvi.ForeColor = Color.Red;
                        lvi.Font = new Font(lvi.Font, FontStyle.Bold);
                    } else {
                        //lvi.ForeColor = Color.Black;
                        lvi.Font = new Font(lvi.Font, FontStyle.Regular);
                    }
                }
            }
        }

        private void tbrVolume_Scroll(object sender, EventArgs e)
        {
            float volume = (float)tbrVolume.Value / tbrVolume.Maximum;
            m_scanner.Volume = volume;
        }

        private void lstChannels_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddWebStreamWizard newStreamWizard = new AddWebStreamWizard();
            if (newStreamWizard.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Channel newChannel = new Channel();
                newChannel.Title = newStreamWizard.StreamName;
                newChannel.Priority = newStreamWizard.StreamPriority;
                newChannel.URL = newStreamWizard.StreamURL;
                m_scanner.addChannel(newChannel);
            }
        }

        private void lstChannels_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (lstChannels.SelectedIndices.Count > 0)
                {
                    deleteChannel(lstChannels.SelectedIndices[0]);
                }
            }
        }

        private void deleteChannel(int index)
        {
            Channel selectedChannel = null;
            ListViewItem selectedItem = lstChannels.Items[index];

            IReadOnlyList<Channel> channels = m_scanner.getChannelList();
            foreach (Channel ch in channels)
            {
                if(ch.Title == selectedItem.SubItems[0].Text &&
                    ch.Priority.ToString() == selectedItem.SubItems[1].Text && 
                    ch.URL == selectedItem.SubItems[2].Text)
                {
                    selectedChannel = ch;
                    break;
                }
            }
            if (selectedChannel != null)
            {
                if(MessageBox.Show("Delete channel \"" + selectedChannel.Title + "\"?", this.Text, MessageBoxButtons.YesNoCancel) == System.Windows.Forms.DialogResult.Yes)
                {
                    m_scanner.removeChannel(selectedChannel);
                }
            }
        }

        private void saveChannelListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fileDialog = new SaveFileDialog();
            fileDialog.Filter = "JSON Config File|*.json";
            fileDialog.Title = "Save an config file";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                Utils.ConfigManagerUtil.saveConfig(fileDialog.FileName, m_scanner.getChannelList());
            }
        }

        private void loadChannelListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fileDialog = new OpenFileDialog();
            fileDialog.Filter = "JSON Config File|*.json";
            fileDialog.Title = "Open config file";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                Utils.ConfigManagerUtil.loadConfig(fileDialog.FileName, m_scanner);
            }
        }
    }
}
