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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.cbIgnoreConfig = new System.Windows.Forms.CheckBox();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.cbEmbedMetadata = new System.Windows.Forms.CheckBox();
            this.cbEmbedThumbnail = new System.Windows.Forms.CheckBox();
            this.cbKeepVideo = new System.Windows.Forms.CheckBox();
            this.cbFreeFormats = new System.Windows.Forms.CheckBox();
            this.cbNoCacheDir = new System.Windows.Forms.CheckBox();
            this.cbNoPlaylist = new System.Windows.Forms.CheckBox();
            this.tbFilenameFormat = new System.Windows.Forms.TextBox();
            this.cbFilenameFormat = new System.Windows.Forms.CheckBox();
            this.cbIngoreErrors = new System.Windows.Forms.CheckBox();
            this.lblDocumentation = new System.Windows.Forms.LinkLabel();
            this.lblFile = new System.Windows.Forms.Label();
            this.lblAudio = new System.Windows.Forms.Label();
            this.lblVideo = new System.Windows.Forms.Label();
            this.comboFile = new System.Windows.Forms.ComboBox();
            this.comboAudio = new System.Windows.Forms.ComboBox();
            this.comboVideo = new System.Windows.Forms.ComboBox();
            this.tbDirectory = new System.Windows.Forms.TextBox();
            this.btnDirectory = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbURL
            // 
            this.tbURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbURL.Location = new System.Drawing.Point(93, 14);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(429, 20);
            this.tbURL.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Download";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // groupBox
            // 
            this.groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox.Controls.Add(this.cbIgnoreConfig);
            this.groupBox.Controls.Add(this.btnSaveSettings);
            this.groupBox.Controls.Add(this.cbEmbedMetadata);
            this.groupBox.Controls.Add(this.cbEmbedThumbnail);
            this.groupBox.Controls.Add(this.cbKeepVideo);
            this.groupBox.Controls.Add(this.cbFreeFormats);
            this.groupBox.Controls.Add(this.cbNoCacheDir);
            this.groupBox.Controls.Add(this.cbNoPlaylist);
            this.groupBox.Controls.Add(this.tbFilenameFormat);
            this.groupBox.Controls.Add(this.cbFilenameFormat);
            this.groupBox.Controls.Add(this.cbIngoreErrors);
            this.groupBox.Controls.Add(this.lblDocumentation);
            this.groupBox.Controls.Add(this.lblFile);
            this.groupBox.Controls.Add(this.lblAudio);
            this.groupBox.Controls.Add(this.lblVideo);
            this.groupBox.Controls.Add(this.comboFile);
            this.groupBox.Controls.Add(this.comboAudio);
            this.groupBox.Controls.Add(this.comboVideo);
            this.groupBox.Location = new System.Drawing.Point(15, 71);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(507, 128);
            this.groupBox.TabIndex = 3;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Options";
            // 
            // cbIgnoreConfig
            // 
            this.cbIgnoreConfig.AutoSize = true;
            this.cbIgnoreConfig.Location = new System.Drawing.Point(207, 94);
            this.cbIgnoreConfig.Name = "cbIgnoreConfig";
            this.cbIgnoreConfig.Size = new System.Drawing.Size(87, 17);
            this.cbIgnoreConfig.TabIndex = 16;
            this.cbIgnoreConfig.Text = "ignore config";
            this.cbIgnoreConfig.UseVisualStyleBackColor = true;
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveSettings.Location = new System.Drawing.Point(417, 104);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(84, 23);
            this.btnSaveSettings.TabIndex = 15;
            this.btnSaveSettings.Text = "Save settings";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // cbEmbedMetadata
            // 
            this.cbEmbedMetadata.AutoSize = true;
            this.cbEmbedMetadata.Location = new System.Drawing.Point(6, 94);
            this.cbEmbedMetadata.Name = "cbEmbedMetadata";
            this.cbEmbedMetadata.Size = new System.Drawing.Size(105, 17);
            this.cbEmbedMetadata.TabIndex = 14;
            this.cbEmbedMetadata.Text = "embed metadata";
            this.cbEmbedMetadata.UseVisualStyleBackColor = true;
            // 
            // cbEmbedThumbnail
            // 
            this.cbEmbedThumbnail.AutoSize = true;
            this.cbEmbedThumbnail.Location = new System.Drawing.Point(293, 71);
            this.cbEmbedThumbnail.Name = "cbEmbedThumbnail";
            this.cbEmbedThumbnail.Size = new System.Drawing.Size(106, 17);
            this.cbEmbedThumbnail.TabIndex = 13;
            this.cbEmbedThumbnail.Text = "embed thumbnail";
            this.cbEmbedThumbnail.UseVisualStyleBackColor = true;
            // 
            // cbKeepVideo
            // 
            this.cbKeepVideo.AutoSize = true;
            this.cbKeepVideo.Location = new System.Drawing.Point(422, 49);
            this.cbKeepVideo.Name = "cbKeepVideo";
            this.cbKeepVideo.Size = new System.Drawing.Size(79, 17);
            this.cbKeepVideo.TabIndex = 11;
            this.cbKeepVideo.Text = "keep video";
            this.cbKeepVideo.UseVisualStyleBackColor = true;
            // 
            // cbFreeFormats
            // 
            this.cbFreeFormats.AutoSize = true;
            this.cbFreeFormats.Location = new System.Drawing.Point(176, 71);
            this.cbFreeFormats.Name = "cbFreeFormats";
            this.cbFreeFormats.Size = new System.Drawing.Size(111, 17);
            this.cbFreeFormats.TabIndex = 9;
            this.cbFreeFormats.Text = "prefer free formats";
            this.cbFreeFormats.UseVisualStyleBackColor = true;
            // 
            // cbNoCacheDir
            // 
            this.cbNoCacheDir.AutoSize = true;
            this.cbNoCacheDir.Location = new System.Drawing.Point(84, 71);
            this.cbNoCacheDir.Name = "cbNoCacheDir";
            this.cbNoCacheDir.Size = new System.Drawing.Size(85, 17);
            this.cbNoCacheDir.TabIndex = 7;
            this.cbNoCacheDir.Text = "no cache dir";
            this.cbNoCacheDir.UseVisualStyleBackColor = true;
            // 
            // cbNoPlaylist
            // 
            this.cbNoPlaylist.AutoSize = true;
            this.cbNoPlaylist.Location = new System.Drawing.Point(6, 71);
            this.cbNoPlaylist.Name = "cbNoPlaylist";
            this.cbNoPlaylist.Size = new System.Drawing.Size(72, 17);
            this.cbNoPlaylist.TabIndex = 6;
            this.cbNoPlaylist.Text = "no playlist";
            this.cbNoPlaylist.UseVisualStyleBackColor = true;
            // 
            // tbFilenameFormat
            // 
            this.tbFilenameFormat.Location = new System.Drawing.Point(109, 46);
            this.tbFilenameFormat.Name = "tbFilenameFormat";
            this.tbFilenameFormat.Size = new System.Drawing.Size(307, 20);
            this.tbFilenameFormat.TabIndex = 5;
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
            this.cbIngoreErrors.Location = new System.Drawing.Point(117, 94);
            this.cbIngoreErrors.Name = "cbIngoreErrors";
            this.cbIngoreErrors.Size = new System.Drawing.Size(84, 17);
            this.cbIngoreErrors.TabIndex = 3;
            this.cbIngoreErrors.Text = "ignore errors";
            this.cbIngoreErrors.UseVisualStyleBackColor = true;
            // 
            // lblDocumentation
            // 
            this.lblDocumentation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDocumentation.AutoSize = true;
            this.lblDocumentation.Location = new System.Drawing.Point(332, 109);
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
            this.lblFile.Location = new System.Drawing.Point(340, 22);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(23, 13);
            this.lblFile.TabIndex = 1;
            this.lblFile.Text = "File";
            // 
            // lblAudio
            // 
            this.lblAudio.AutoSize = true;
            this.lblAudio.Location = new System.Drawing.Point(173, 22);
            this.lblAudio.Name = "lblAudio";
            this.lblAudio.Size = new System.Drawing.Size(34, 13);
            this.lblAudio.TabIndex = 1;
            this.lblAudio.Text = "Audio";
            // 
            // lblVideo
            // 
            this.lblVideo.AutoSize = true;
            this.lblVideo.Location = new System.Drawing.Point(6, 22);
            this.lblVideo.Name = "lblVideo";
            this.lblVideo.Size = new System.Drawing.Size(34, 13);
            this.lblVideo.TabIndex = 1;
            this.lblVideo.Text = "Video";
            // 
            // comboFile
            // 
            this.comboFile.FormattingEnabled = true;
            this.comboFile.Items.AddRange(new object[] {
            "auto",
            "mkv",
            "mp4",
            "ogg",
            "webm",
            "flv",
            "mp3"});
            this.comboFile.Location = new System.Drawing.Point(369, 19);
            this.comboFile.Name = "comboFile";
            this.comboFile.Size = new System.Drawing.Size(132, 21);
            this.comboFile.TabIndex = 0;
            // 
            // comboAudio
            // 
            this.comboAudio.FormattingEnabled = true;
            this.comboAudio.Items.AddRange(new object[] {
            "auto",
            "best",
            "aac",
            "vorbis",
            "mp3",
            "m4a",
            "opus",
            "wav"});
            this.comboAudio.Location = new System.Drawing.Point(213, 19);
            this.comboAudio.Name = "comboAudio";
            this.comboAudio.Size = new System.Drawing.Size(121, 21);
            this.comboAudio.TabIndex = 0;
            // 
            // comboVideo
            // 
            this.comboVideo.FormattingEnabled = true;
            this.comboVideo.Items.AddRange(new object[] {
            "auto",
            "best,mp4",
            "1080p,mp4",
            "720p,mp4",
            "1080p",
            "720p",
            "doun\'t download"});
            this.comboVideo.Location = new System.Drawing.Point(46, 19);
            this.comboVideo.Name = "comboVideo";
            this.comboVideo.Size = new System.Drawing.Size(121, 21);
            this.comboVideo.TabIndex = 0;
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
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 211);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.btnDirectory);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tbDirectory);
            this.Controls.Add(this.tbURL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form";
            this.Text = "youtube-dl-gui";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox groupBox;
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
        private System.Windows.Forms.CheckBox cbEmbedMetadata;
        private System.Windows.Forms.CheckBox cbEmbedThumbnail;
        private System.Windows.Forms.CheckBox cbKeepVideo;
        private System.Windows.Forms.CheckBox cbFreeFormats;
        private System.Windows.Forms.CheckBox cbNoCacheDir;
        private System.Windows.Forms.CheckBox cbNoPlaylist;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.CheckBox cbIgnoreConfig;
    }
}

