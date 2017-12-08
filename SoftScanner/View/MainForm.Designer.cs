namespace SoftScanner
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mspMainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadChannelListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveChannelListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.channelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtChannelName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbrVolume = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.lstChannels = new System.Windows.Forms.ListView();
            this.title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.url = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mspMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // mspMainMenu
            // 
            this.mspMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.channelsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mspMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mspMainMenu.Name = "mspMainMenu";
            this.mspMainMenu.Size = new System.Drawing.Size(459, 24);
            this.mspMainMenu.TabIndex = 0;
            this.mspMainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadChannelListToolStripMenuItem,
            this.saveChannelListToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadChannelListToolStripMenuItem
            // 
            this.loadChannelListToolStripMenuItem.Name = "loadChannelListToolStripMenuItem";
            this.loadChannelListToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadChannelListToolStripMenuItem.Text = "Load Config";
            this.loadChannelListToolStripMenuItem.Click += new System.EventHandler(this.loadChannelListToolStripMenuItem_Click);
            // 
            // saveChannelListToolStripMenuItem
            // 
            this.saveChannelListToolStripMenuItem.Name = "saveChannelListToolStripMenuItem";
            this.saveChannelListToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveChannelListToolStripMenuItem.Text = "Save Config";
            this.saveChannelListToolStripMenuItem.Click += new System.EventHandler(this.saveChannelListToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // channelsToolStripMenuItem
            // 
            this.channelsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem});
            this.channelsToolStripMenuItem.Name = "channelsToolStripMenuItem";
            this.channelsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.channelsToolStripMenuItem.Text = "Channels";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.addToolStripMenuItem.Text = "Add Web Stream";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Channel:";
            // 
            // txtChannelName
            // 
            this.txtChannelName.Location = new System.Drawing.Point(104, 41);
            this.txtChannelName.Name = "txtChannelName";
            this.txtChannelName.ReadOnly = true;
            this.txtChannelName.Size = new System.Drawing.Size(187, 20);
            this.txtChannelName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Channels:";
            // 
            // tbrVolume
            // 
            this.tbrVolume.Location = new System.Drawing.Point(352, 41);
            this.tbrVolume.Name = "tbrVolume";
            this.tbrVolume.Size = new System.Drawing.Size(104, 45);
            this.tbrVolume.TabIndex = 7;
            this.tbrVolume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbrVolume.Value = 7;
            this.tbrVolume.Scroll += new System.EventHandler(this.tbrVolume_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Volume:";
            // 
            // lstChannels
            // 
            this.lstChannels.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.title,
            this.priority,
            this.url});
            this.lstChannels.FullRowSelect = true;
            this.lstChannels.Location = new System.Drawing.Point(15, 91);
            this.lstChannels.Name = "lstChannels";
            this.lstChannels.Size = new System.Drawing.Size(432, 170);
            this.lstChannels.TabIndex = 9;
            this.lstChannels.UseCompatibleStateImageBehavior = false;
            this.lstChannels.View = System.Windows.Forms.View.Details;
            this.lstChannels.SelectedIndexChanged += new System.EventHandler(this.lstChannels_SelectedIndexChanged);
            this.lstChannels.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstChannels_KeyDown);
            // 
            // title
            // 
            this.title.Text = "Title";
            this.title.Width = 164;
            // 
            // priority
            // 
            this.priority.Text = "Priority";
            this.priority.Width = 43;
            // 
            // url
            // 
            this.url.Text = "URL";
            this.url.Width = 221;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 273);
            this.Controls.Add(this.lstChannels);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbrVolume);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtChannelName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mspMainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mspMainMenu;
            this.Name = "Form1";
            this.Text = "SoftScanner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mspMainMenu.ResumeLayout(false);
            this.mspMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mspMainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem channelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtChannelName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar tbrVolume;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lstChannels;
        private System.Windows.Forms.ColumnHeader priority;
        private System.Windows.Forms.ColumnHeader title;
        private System.Windows.Forms.ColumnHeader url;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadChannelListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveChannelListToolStripMenuItem;
    }
}

