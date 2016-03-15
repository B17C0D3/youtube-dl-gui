using System;
using System.Collections.Generic;

namespace youtube_dl_gui
{
    class Settings : EventArgs
    {
        //public event EventHandler changedIntervall;
        //public event EventHandler statusChanged;
        //public event EventHandler domainsChanged;
        private string cfgFile = "settings.ini";
        private CfgFile config;

        public string Directory
        {
            get { return config.getValue("Settings", "Directory", false); }
            set { config.setValue("Settings", "Directory", value, false); }
        }
        public string NameTemplate
        {
            get { return config.getValue("Settings", "NameTemplate", false); }
            set { config.setValue("Settings", "NameTemplate", value, false); }
        }
        public int Video
        {
            get { return Convert.ToInt32(config.getValue("Settings", "Video", false)); }
            set { config.setValue("Settings", "Video", value.ToString(), false); }
        }
        public int Audio
        {
            get { return Convert.ToInt32(config.getValue("Settings", "Audio", false)); }
            set { config.setValue("Settings", "Audio", value.ToString(), false); }
        }
        public int Container
        {
            get { return Convert.ToInt32(config.getValue("Settings", "Container", false)); }
            set { config.setValue("Settings", "Container", value.ToString(), false); }
        }
        public bool UseNametemplate
        {
            get { return Convert.ToBoolean(config.getValue("Settings", "UseNametemplate", false)); }
            set { config.setValue("Settings", "UseNametemplate", value.ToString(), false); }
        }
        public bool IgnoreErrors
        {
            get { return Convert.ToBoolean(config.getValue("Settings", "IgnoreErrors", false)); }
            set { config.setValue("Settings", "IgnoreErrors", value.ToString(), false); }
        }
        public bool NoPlaylist
        {
            get { return Convert.ToBoolean(config.getValue("Settings", "NoPlaylist", false)); }
            set { config.setValue("Settings", "NoPlaylist", value.ToString(), false); }
        }
        public bool NoCacheDir
        {
            get { return Convert.ToBoolean(config.getValue("Settings", "NoCacheDir", false)); }
            set { config.setValue("Settings", "NoCacheDir", value.ToString(), false); }
        }
        public bool SkipVideo
        {
            get { return Convert.ToBoolean(config.getValue("Settings", "SkipVideo", false)); }
            set { config.setValue("Settings", "SkipVideo", value.ToString(), false); }
        }
        public bool FreeFormats
        {
            get { return Convert.ToBoolean(config.getValue("Settings", "FreeFormats", false)); }
            set { config.setValue("Settings", "FreeFormats", value.ToString(), false); }
        }
        public bool ExtractAudio
        {
            get { return Convert.ToBoolean(config.getValue("Settings", "ExtractAudio", false)); }
            set { config.setValue("Settings", "ExtractAudio", value.ToString(), false); }
        }
        public bool KeepVideo
        {
            get { return Convert.ToBoolean(config.getValue("Settings", "KeepVideo", false)); }
            set { config.setValue("Settings", "KeepVideo", value.ToString(), false); }
        }
        public bool IgnoreConfig
        {
            get { return Convert.ToBoolean(config.getValue("Settings", "IgnoreConfig", false)); }
            set { config.setValue("Settings", "IgnoreConfig", value.ToString(), false); }
        }
        public bool EmbedThumbnail
        {
            get { return Convert.ToBoolean(config.getValue("Settings", "EmbedThumbnail", false)); }
            set { config.setValue("Settings", "EmbedThumbnail", value.ToString(), false); }
        }
        public bool EmbedMetadata
        {
            get { return Convert.ToBoolean(config.getValue("Settings", "EmbedMetadata", false)); }
            set { config.setValue("Settings", "EmbedMetadata", value.ToString(), false); }
        }

        public void Save()
        {
            config.Save();
        }
        public Settings()
        {
            try
            {
                config = new CfgFile(cfgFile);
            }
            catch
            {
                //erstellle standart config
                config = new CfgFile();
                config.FileName = cfgFile;

                string d = System.IO.Directory.GetCurrentDirectory();
                if (!d.EndsWith("\\"))
                    d += "\\";
                Directory = d;
                NameTemplate = @"%(upload_date)s_%(title)s_%(uploader_id)s-%(id)s.%(ext)s";
                Video = 0;
                Audio = 0;
                Container = 0;
                UseNametemplate = false;
                IgnoreErrors = false;
                NoPlaylist = false;
                NoCacheDir = false;
                SkipVideo = false;
                FreeFormats = false;
                ExtractAudio = false;
                KeepVideo = false;
                IgnoreConfig = false;
                EmbedThumbnail = false;
                EmbedMetadata = false;
                config.Save();
            }
        }
    }   
}