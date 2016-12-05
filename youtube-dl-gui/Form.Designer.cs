namespace youtube_dl_gui
{
    partial class Form
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.tbURL = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBoxOptions = new System.Windows.Forms.GroupBox();
            this.cbEmbedThumbnail = new System.Windows.Forms.CheckBox();
            this.cbNoPlaylist = new System.Windows.Forms.CheckBox();
            this.tbPlaylistItems = new System.Windows.Forms.TextBox();
            this.tbFilenameFormat = new System.Windows.Forms.TextBox();
            this.cbCloseOutput = new System.Windows.Forms.CheckBox();
            this.cbNoCacheDir = new System.Windows.Forms.CheckBox();
            this.cbPlaylistItems = new System.Windows.Forms.CheckBox();
            this.cbFilenameFormat = new System.Windows.Forms.CheckBox();
            this.cbIngoreErrors = new System.Windows.Forms.CheckBox();
            this.lblDocumentation = new System.Windows.Forms.LinkLabel();
            this.lblFile = new System.Windows.Forms.Label();
            this.lblAudio = new System.Windows.Forms.Label();
            this.lblVideo = new System.Windows.Forms.Label();
            this.comboFile = new System.Windows.Forms.ComboBox();
            this.comboAudio = new System.Windows.Forms.ComboBox();
            this.comboVideo = new System.Windows.Forms.ComboBox();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.tbDirectory = new System.Windows.Forms.TextBox();
            this.btnDirectory = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBoxActions = new System.Windows.Forms.GroupBox();
            this.btnClearCache = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCheckFormats = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxOptions.SuspendLayout();
            this.groupBoxActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbURL
            // 
            this.tbURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbURL.Location = new System.Drawing.Point(50, 14);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(472, 20);
            this.tbURL.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(429, 19);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Download";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // groupBoxOptions
            // 
            this.groupBoxOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOptions.Controls.Add(this.cbEmbedThumbnail);
            this.groupBoxOptions.Controls.Add(this.cbNoPlaylist);
            this.groupBoxOptions.Controls.Add(this.tbPlaylistItems);
            this.groupBoxOptions.Controls.Add(this.tbFilenameFormat);
            this.groupBoxOptions.Controls.Add(this.cbCloseOutput);
            this.groupBoxOptions.Controls.Add(this.cbNoCacheDir);
            this.groupBoxOptions.Controls.Add(this.cbPlaylistItems);
            this.groupBoxOptions.Controls.Add(this.cbFilenameFormat);
            this.groupBoxOptions.Controls.Add(this.cbIngoreErrors);
            this.groupBoxOptions.Controls.Add(this.lblDocumentation);
            this.groupBoxOptions.Controls.Add(this.lblFile);
            this.groupBoxOptions.Controls.Add(this.lblAudio);
            this.groupBoxOptions.Controls.Add(this.lblVideo);
            this.groupBoxOptions.Controls.Add(this.comboFile);
            this.groupBoxOptions.Controls.Add(this.comboAudio);
            this.groupBoxOptions.Controls.Add(this.comboVideo);
            this.groupBoxOptions.Location = new System.Drawing.Point(12, 71);
            this.groupBoxOptions.Name = "groupBoxOptions";
            this.groupBoxOptions.Size = new System.Drawing.Size(510, 130);
            this.groupBoxOptions.TabIndex = 3;
            this.groupBoxOptions.TabStop = false;
            this.groupBoxOptions.Text = "Options";
            // 
            // cbEmbedThumbnail
            // 
            this.cbEmbedThumbnail.AutoSize = true;
            this.cbEmbedThumbnail.Location = new System.Drawing.Point(398, 74);
            this.cbEmbedThumbnail.Name = "cbEmbedThumbnail";
            this.cbEmbedThumbnail.Size = new System.Drawing.Size(106, 17);
            this.cbEmbedThumbnail.TabIndex = 13;
            this.cbEmbedThumbnail.Text = "embed thumbnail";
            this.cbEmbedThumbnail.UseVisualStyleBackColor = true;
            // 
            // cbNoPlaylist
            // 
            this.cbNoPlaylist.AutoSize = true;
            this.cbNoPlaylist.Location = new System.Drawing.Point(432, 48);
            this.cbNoPlaylist.Name = "cbNoPlaylist";
            this.cbNoPlaylist.Size = new System.Drawing.Size(72, 17);
            this.cbNoPlaylist.TabIndex = 6;
            this.cbNoPlaylist.Text = "no playlist";
            this.cbNoPlaylist.UseVisualStyleBackColor = true;
            // 
            // tbPlaylistItems
            // 
            this.tbPlaylistItems.Location = new System.Drawing.Point(96, 72);
            this.tbPlaylistItems.Name = "tbPlaylistItems";
            this.tbPlaylistItems.Size = new System.Drawing.Size(150, 20);
            this.tbPlaylistItems.TabIndex = 5;
            // 
            // tbFilenameFormat
            // 
            this.tbFilenameFormat.Location = new System.Drawing.Point(109, 46);
            this.tbFilenameFormat.Name = "tbFilenameFormat";
            this.tbFilenameFormat.Size = new System.Drawing.Size(317, 20);
            this.tbFilenameFormat.TabIndex = 5;
            // 
            // cbCloseOutput
            // 
            this.cbCloseOutput.AutoSize = true;
            this.cbCloseOutput.Location = new System.Drawing.Point(162, 98);
            this.cbCloseOutput.Name = "cbCloseOutput";
            this.cbCloseOutput.Size = new System.Drawing.Size(153, 17);
            this.cbCloseOutput.TabIndex = 4;
            this.cbCloseOutput.Text = "Close output log at the end";
            this.cbCloseOutput.UseVisualStyleBackColor = true;
            // 
            // cbNoCacheDir
            // 
            this.cbNoCacheDir.AutoSize = true;
            this.cbNoCacheDir.Location = new System.Drawing.Point(6, 98);
            this.cbNoCacheDir.Name = "cbNoCacheDir";
            this.cbNoCacheDir.Size = new System.Drawing.Size(150, 17);
            this.cbNoCacheDir.TabIndex = 4;
            this.cbNoCacheDir.Text = "Disable filesystem caching";
            this.cbNoCacheDir.UseVisualStyleBackColor = true;
            // 
            // cbPlaylistItems
            // 
            this.cbPlaylistItems.AutoSize = true;
            this.cbPlaylistItems.Location = new System.Drawing.Point(6, 75);
            this.cbPlaylistItems.Name = "cbPlaylistItems";
            this.cbPlaylistItems.Size = new System.Drawing.Size(84, 17);
            this.cbPlaylistItems.TabIndex = 4;
            this.cbPlaylistItems.Text = "playlist items";
            this.cbPlaylistItems.UseVisualStyleBackColor = true;
            // 
            // cbFilenameFormat
            // 
            this.cbFilenameFormat.AutoSize = true;
            this.cbFilenameFormat.Location = new System.Drawing.Point(6, 48);
            this.cbFilenameFormat.Name = "cbFilenameFormat";
            this.cbFilenameFormat.Size = new System.Drawing.Size(97, 17);
            this.cbFilenameFormat.TabIndex = 4;
            this.cbFilenameFormat.Text = "format filename";
            this.cbFilenameFormat.UseVisualStyleBackColor = true;
            // 
            // cbIngoreErrors
            // 
            this.cbIngoreErrors.AutoSize = true;
            this.cbIngoreErrors.Location = new System.Drawing.Point(252, 75);
            this.cbIngoreErrors.Name = "cbIngoreErrors";
            this.cbIngoreErrors.Size = new System.Drawing.Size(140, 17);
            this.cbIngoreErrors.TabIndex = 3;
            this.cbIngoreErrors.Text = "continue playlist on error";
            this.cbIngoreErrors.UseVisualStyleBackColor = true;
            // 
            // lblDocumentation
            // 
            this.lblDocumentation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDocumentation.AutoSize = true;
            this.lblDocumentation.Location = new System.Drawing.Point(425, 114);
            this.lblDocumentation.Name = "lblDocumentation";
            this.lblDocumentation.Size = new System.Drawing.Size(79, 13);
            this.lblDocumentation.TabIndex = 2;
            this.lblDocumentation.TabStop = true;
            this.lblDocumentation.Text = "Documentation";
            this.lblDocumentation.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblDocumentation_LinkClicked);
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(334, 22);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(81, 13);
            this.lblFile.TabIndex = 1;
            this.lblFile.Text = "Local Container";
            // 
            // lblAudio
            // 
            this.lblAudio.AutoSize = true;
            this.lblAudio.Location = new System.Drawing.Point(169, 22);
            this.lblAudio.Name = "lblAudio";
            this.lblAudio.Size = new System.Drawing.Size(71, 13);
            this.lblAudio.TabIndex = 1;
            this.lblAudio.Text = "Audio Source";
            // 
            // lblVideo
            // 
            this.lblVideo.AutoSize = true;
            this.lblVideo.Location = new System.Drawing.Point(6, 22);
            this.lblVideo.Name = "lblVideo";
            this.lblVideo.Size = new System.Drawing.Size(71, 13);
            this.lblVideo.TabIndex = 1;
            this.lblVideo.Text = "Video Source";
            // 
            // comboFile
            // 
            this.comboFile.FormattingEnabled = true;
            this.comboFile.Items.AddRange(new object[] {
            "mp4",
            "mkv",
            "webm",
            "ogg",
            "flv",
            "mp3",
            "opus"});
            this.comboFile.Location = new System.Drawing.Point(421, 19);
            this.comboFile.Name = "comboFile";
            this.comboFile.Size = new System.Drawing.Size(83, 21);
            this.comboFile.TabIndex = 0;
            // 
            // comboAudio
            // 
            this.comboAudio.FormattingEnabled = true;
            this.comboAudio.Items.AddRange(new object[] {
            "best",
            "m4a",
            "opus",
            "vorbis"});
            this.comboAudio.Location = new System.Drawing.Point(246, 19);
            this.comboAudio.Name = "comboAudio";
            this.comboAudio.Size = new System.Drawing.Size(82, 21);
            this.comboAudio.TabIndex = 0;
            // 
            // comboVideo
            // 
            this.comboVideo.FormattingEnabled = true;
            this.comboVideo.Items.AddRange(new object[] {
            "best mp4",
            "1080p mp4",
            "720p mp4",
            "best webm",
            "1080p webm",
            "720p webm",
            "doun\'t download"});
            this.comboVideo.Location = new System.Drawing.Point(81, 19);
            this.comboVideo.Name = "comboVideo";
            this.comboVideo.Size = new System.Drawing.Size(82, 21);
            this.comboVideo.TabIndex = 0;
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Location = new System.Drawing.Point(6, 19);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(84, 23);
            this.btnSaveSettings.TabIndex = 15;
            this.btnSaveSettings.Text = "Save settings";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // tbDirectory
            // 
            this.tbDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDirectory.Location = new System.Drawing.Point(93, 43);
            this.tbDirectory.Name = "tbDirectory";
            this.tbDirectory.Size = new System.Drawing.Size(429, 20);
            this.tbDirectory.TabIndex = 1;
            // 
            // btnDirectory
            // 
            this.btnDirectory.Location = new System.Drawing.Point(12, 41);
            this.btnDirectory.Name = "btnDirectory";
            this.btnDirectory.Size = new System.Drawing.Size(75, 23);
            this.btnDirectory.TabIndex = 2;
            this.btnDirectory.Text = "Directory";
            this.btnDirectory.UseVisualStyleBackColor = true;
            this.btnDirectory.Click += new System.EventHandler(this.btnDirectory_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // groupBoxActions
            // 
            this.groupBoxActions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxActions.Controls.Add(this.btnClearCache);
            this.groupBoxActions.Controls.Add(this.btnUpdate);
            this.groupBoxActions.Controls.Add(this.btnCheckFormats);
            this.groupBoxActions.Controls.Add(this.btnStart);
            this.groupBoxActions.Controls.Add(this.btnSaveSettings);
            this.groupBoxActions.Location = new System.Drawing.Point(12, 207);
            this.groupBoxActions.Name = "groupBoxActions";
            this.groupBoxActions.Size = new System.Drawing.Size(510, 48);
            this.groupBoxActions.TabIndex = 4;
            this.groupBoxActions.TabStop = false;
            this.groupBoxActions.Text = "Actions";
            // 
            // btnClearCache
            // 
            this.btnClearCache.Location = new System.Drawing.Point(96, 19);
            this.btnClearCache.Name = "btnClearCache";
            this.btnClearCache.Size = new System.Drawing.Size(82, 23);
            this.btnClearCache.TabIndex = 18;
            this.btnClearCache.Text = "Clear Cache";
            this.btnClearCache.UseVisualStyleBackColor = true;
            this.btnClearCache.Click += new System.EventHandler(this.btnClearCache_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(323, 19);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(54, 23);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCheckFormats
            // 
            this.btnCheckFormats.Location = new System.Drawing.Point(184, 19);
            this.btnCheckFormats.Name = "btnCheckFormats";
            this.btnCheckFormats.Size = new System.Drawing.Size(133, 23);
            this.btnCheckFormats.TabIndex = 16;
            this.btnCheckFormats.Text = "Check available formats";
            this.btnCheckFormats.UseVisualStyleBackColor = true;
            this.btnCheckFormats.Click += new System.EventHandler(this.btnCheckFormats_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "URL:";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 267);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxActions);
            this.Controls.Add(this.groupBoxOptions);
            this.Controls.Add(this.btnDirectory);
            this.Controls.Add(this.tbDirectory);
            this.Controls.Add(this.tbURL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form";
            this.Text = "youtube-dl-gui";
            this.groupBoxOptions.ResumeLayout(false);
            this.groupBoxOptions.PerformLayout();
            this.groupBoxActions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox groupBoxOptions;
        private System.Windows.Forms.TextBox tbDirectory;
        private System.Windows.Forms.Button btnDirectory;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.Label lblAudio;
        private System.Windows.Forms.Label lblVideo;
        private System.Windows.Forms.ComboBox comboFile;
        private System.Windows.Forms.ComboBox comboAudio;
        private System.Windows.Forms.ComboBox comboVideo;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.LinkLabel lblDocumentation;
        private System.Windows.Forms.TextBox tbFilenameFormat;
        private System.Windows.Forms.CheckBox cbFilenameFormat;
        private System.Windows.Forms.CheckBox cbIngoreErrors;
        private System.Windows.Forms.CheckBox cbEmbedThumbnail;
        private System.Windows.Forms.CheckBox cbNoPlaylist;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.GroupBox groupBoxActions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCheckFormats;
        private System.Windows.Forms.TextBox tbPlaylistItems;
        private System.Windows.Forms.CheckBox cbPlaylistItems;
        private System.Windows.Forms.CheckBox cbCloseOutput;
        private System.Windows.Forms.CheckBox cbNoCacheDir;
        private System.Windows.Forms.Button btnClearCache;
    }
}

