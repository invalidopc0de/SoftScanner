using M3UParser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftScanner.View
{
    public partial class AddWebStreamWizard : Form
    {
        public String StreamURL { get; private set; }
        public String StreamName { get; private set; }

        public int StreamPriority { get; private set; }
          
        private const string M3U_FILEEXTENSION = ".M3U";
        public AddWebStreamWizard()
        {
            InitializeComponent();
            this.wzpAddStream.Commit += wzpAddStream_Commit;
            this.wzpChooseStream.Initialize += wzpChooseStream_Initialize;
            this.wzpChooseStream.Commit += wzpChooseStream_Commit;
            this.wzpFinished.Initialize += wzpFinished_Initialize;
        }

        void wzpChooseStream_Commit(object sender, AeroWizard.WizardPageConfirmEventArgs e)
        {
            if(lstStreams.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Please select a stream!");
                e.Cancel = true;
            }
            else
            {
                // Second element in subitems should be URL
                StreamURL = lstStreams.SelectedItems[0].SubItems[1].Text;
            }
        }

        void wzpFinished_Initialize(object sender, AeroWizard.WizardPageInitEventArgs e)
        {
            lblStreamTitle.Text = StreamName;
            lblStreamURL.Text = StreamURL;
            lblStreamPriority.Text = StreamPriority.ToString();
        }

        void wzpChooseStream_Initialize(object sender, AeroWizard.WizardPageInitEventArgs e)
        {
            try
            {
                List<M3UFileInfo> streams = new List<M3UFileInfo>();
                string[] fileLines;

                using (WebClient client = new WebClient())
                {
                    string s = client.DownloadString(txtStreamURL.Text);
                    fileLines = s.Split('\n');
                }

                for (int i = 0; i < fileLines.Length; i++)
                {
                    fileLines[i] = fileLines[i].Trim();
                }

                streams = M3UParser.M3UParser.parse(fileLines);
                foreach (M3UFileInfo stream in streams)
                {
                    if(stream.Duration < 0){
                        ListViewItem streamItem = new ListViewItem();
                        streamItem.Text = stream.Title;
                        streamItem.SubItems.Add(stream.Location);
                        lstStreams.Items.Add(streamItem);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                e.Cancel = true;
                wzdNewWebStream.PreviousPage();
            }
        }

        void wzpAddStream_Commit(object sender, AeroWizard.WizardPageConfirmEventArgs e)
        {
            if(txtStreamName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a Stream Name!", wzdNewWebStream.Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
            else if (txtStreamURL.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a Stream URL!", wzdNewWebStream.Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
            else
            {
                if (txtStreamURL.Text.Trim().ToUpper().EndsWith(M3U_FILEEXTENSION))
                {
                    this.wzpAddStream.NextPage = this.wzpChooseStream;
                }
                else
                {
                    StreamURL = txtStreamURL.Text;
                    this.wzpAddStream.NextPage = this.wzpFinished;
                }
                StreamName = txtStreamName.Text;
                StreamPriority = 3;
            }
        }

    
    }
}
