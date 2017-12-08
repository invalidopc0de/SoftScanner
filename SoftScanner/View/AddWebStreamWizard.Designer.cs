namespace SoftScanner.View
{
    partial class AddWebStreamWizard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddWebStreamWizard));
            this.glassExtenderProvider1 = new Microsoft.Win32.DesktopWindowManager.GlassExtenderProvider();
            this.wzdNewWebStream = new AeroWizard.WizardControl();
            this.wzpAddStream = new AeroWizard.WizardPage();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStreamName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStreamURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.wzpChooseStream = new AeroWizard.WizardPage();
            this.wzpFinished = new AeroWizard.WizardPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblStreamTitle = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblStreamURL = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblStreamPriority = new System.Windows.Forms.Label();
            this.lstStreams = new System.Windows.Forms.ListView();
            this.label8 = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.wzdNewWebStream)).BeginInit();
            this.wzpAddStream.SuspendLayout();
            this.wzpChooseStream.SuspendLayout();
            this.wzpFinished.SuspendLayout();
            this.SuspendLayout();
            // 
            // wzdNewWebStream
            // 
            this.wzdNewWebStream.Location = new System.Drawing.Point(0, 0);
            this.wzdNewWebStream.Name = "wzdNewWebStream";
            this.wzdNewWebStream.Pages.Add(this.wzpAddStream);
            this.wzdNewWebStream.Pages.Add(this.wzpChooseStream);
            this.wzdNewWebStream.Pages.Add(this.wzpFinished);
            this.wzdNewWebStream.Size = new System.Drawing.Size(552, 364);
            this.wzdNewWebStream.TabIndex = 0;
            this.wzdNewWebStream.Title = "Add New Web Stream";
            this.wzdNewWebStream.TitleIcon = ((System.Drawing.Icon)(resources.GetObject("wzdNewWebStream.TitleIcon")));
            // 
            // wzpAddStream
            // 
            this.wzpAddStream.Controls.Add(this.label3);
            this.wzpAddStream.Controls.Add(this.txtStreamName);
            this.wzpAddStream.Controls.Add(this.label2);
            this.wzpAddStream.Controls.Add(this.txtStreamURL);
            this.wzpAddStream.Controls.Add(this.label1);
            this.wzpAddStream.Name = "wzpAddStream";
            this.wzpAddStream.NextPage = this.wzpChooseStream;
            this.wzpAddStream.Size = new System.Drawing.Size(505, 209);
            this.wzpAddStream.TabIndex = 0;
            this.wzpAddStream.Text = "New Stream Info";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-3, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter a name for this stream:";
            // 
            // txtStreamName
            // 
            this.txtStreamName.Location = new System.Drawing.Point(0, 25);
            this.txtStreamName.Name = "txtStreamName";
            this.txtStreamName.Size = new System.Drawing.Size(264, 23);
            this.txtStreamName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(-3, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(505, 70);
            this.label2.TabIndex = 2;
            this.label2.Text = "The URL should point to either a streaming MP3 file or a M3U playlist file contai" +
    "ng a web stream.  Other streaming types may work but have not been explicitly te" +
    "sted.";
            // 
            // txtStreamURL
            // 
            this.txtStreamURL.Location = new System.Drawing.Point(0, 90);
            this.txtStreamURL.Name = "txtStreamURL";
            this.txtStreamURL.Size = new System.Drawing.Size(502, 23);
            this.txtStreamURL.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the URL of the web stream:";
            // 
            // wzpChooseStream
            // 
            this.wzpChooseStream.Controls.Add(this.label8);
            this.wzpChooseStream.Controls.Add(this.lstStreams);
            this.wzpChooseStream.Name = "wzpChooseStream";
            this.wzpChooseStream.NextPage = this.wzpFinished;
            this.wzpChooseStream.Size = new System.Drawing.Size(505, 209);
            this.wzpChooseStream.TabIndex = 1;
            this.wzpChooseStream.Text = "Choose Stream";
            // 
            // wzpFinished
            // 
            this.wzpFinished.AllowCancel = false;
            this.wzpFinished.Controls.Add(this.lblStreamPriority);
            this.wzpFinished.Controls.Add(this.label7);
            this.wzpFinished.Controls.Add(this.lblStreamURL);
            this.wzpFinished.Controls.Add(this.label6);
            this.wzpFinished.Controls.Add(this.lblStreamTitle);
            this.wzpFinished.Controls.Add(this.label5);
            this.wzpFinished.Controls.Add(this.label4);
            this.wzpFinished.IsFinishPage = true;
            this.wzpFinished.Name = "wzpFinished";
            this.wzpFinished.ShowCancel = false;
            this.wzpFinished.Size = new System.Drawing.Size(505, 209);
            this.wzpFinished.TabIndex = 2;
            this.wzpFinished.Text = "Finished";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(276, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "The following stream will added to the channel list:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Title:";
            // 
            // lblStreamTitle
            // 
            this.lblStreamTitle.AutoEllipsis = true;
            this.lblStreamTitle.Location = new System.Drawing.Point(60, 25);
            this.lblStreamTitle.Name = "lblStreamTitle";
            this.lblStreamTitle.Size = new System.Drawing.Size(442, 15);
            this.lblStreamTitle.TabIndex = 2;
            this.lblStreamTitle.Text = "<Stream Title>";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "URL:";
            // 
            // lblStreamURL
            // 
            this.lblStreamURL.AutoEllipsis = true;
            this.lblStreamURL.Location = new System.Drawing.Point(60, 50);
            this.lblStreamURL.Name = "lblStreamURL";
            this.lblStreamURL.Size = new System.Drawing.Size(442, 15);
            this.lblStreamURL.TabIndex = 4;
            this.lblStreamURL.Text = "<Stream URL>";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Priority:";
            // 
            // lblStreamPriority
            // 
            this.lblStreamPriority.AutoEllipsis = true;
            this.lblStreamPriority.Location = new System.Drawing.Point(57, 74);
            this.lblStreamPriority.Name = "lblStreamPriority";
            this.lblStreamPriority.Size = new System.Drawing.Size(445, 15);
            this.lblStreamPriority.TabIndex = 6;
            this.lblStreamPriority.Text = "<Stream Priority>";
            // 
            // lstStreams
            // 
            this.lstStreams.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstStreams.FullRowSelect = true;
            this.lstStreams.Location = new System.Drawing.Point(3, 18);
            this.lstStreams.MultiSelect = false;
            this.lstStreams.Name = "lstStreams";
            this.lstStreams.Size = new System.Drawing.Size(499, 188);
            this.lstStreams.TabIndex = 0;
            this.lstStreams.UseCompatibleStateImageBehavior = false;
            this.lstStreams.View = System.Windows.Forms.View.Details;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(213, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Please select a stream from the playlist:";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Title";
            this.columnHeader1.Width = 196;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "URL";
            this.columnHeader2.Width = 299;
            // 
            // AddWebStreamWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 364);
            this.Controls.Add(this.wzdNewWebStream);
            this.glassExtenderProvider1.SetGlassMargins(this, new System.Windows.Forms.Padding(0));
            this.Name = "AddWebStreamWizard";
            this.Text = "AddWebStreamWizard";
            ((System.ComponentModel.ISupportInitialize)(this.wzdNewWebStream)).EndInit();
            this.wzpAddStream.ResumeLayout(false);
            this.wzpAddStream.PerformLayout();
            this.wzpChooseStream.ResumeLayout(false);
            this.wzpChooseStream.PerformLayout();
            this.wzpFinished.ResumeLayout(false);
            this.wzpFinished.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Win32.DesktopWindowManager.GlassExtenderProvider glassExtenderProvider1;
        private AeroWizard.WizardControl wzdNewWebStream;
        private AeroWizard.WizardPage wzpAddStream;
        private AeroWizard.WizardPage wzpChooseStream;
        private AeroWizard.WizardPage wzpFinished;
        private System.Windows.Forms.TextBox txtStreamURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStreamName;
        private System.Windows.Forms.Label lblStreamURL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblStreamTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblStreamPriority;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView lstStreams;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}