using System;
using System.Text;
using System.Windows.Forms;

namespace youtube_dl_gui
{
    public partial class Form : System.Windows.Forms.Form
    {
        Settings settings;
        public Form()
        {
            InitializeComponent();
            settings = new Settings();
            LoadSettings();
        }

        private void lblDocumentation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/rg3/youtube-dl/blob/master/README.md#options");
        }

        private void LoadSettings()
        {
            try
            {
                tbDirectory.Text = settings.Directory;
                comboVideo.SelectedIndex = settings.Video;
                comboAudio.SelectedIndex = settings.Audio;
                comboFile.SelectedIndex = settings.Container;
                cbFilenameFormat.CheckState = (settings.UseNametemplate) ? CheckState.Checked : CheckState.Unchecked;
                tbFilenameFormat.Text = settings.NameTemplate;
                cbNoPlaylist.CheckState = (settings.NoPlaylist) ? CheckState.Checked : CheckState.Unchecked;
                cbPlaylistItems.CheckState = (settings.UsePlaylistItems) ? CheckState.Checked : CheckState.Unchecked;
                tbPlaylistItems.Text = settings.PlaylistItems;
                cbIngoreErrors.CheckState = (settings.IgnoreErrors) ? CheckState.Checked : CheckState.Unchecked;
                cbEmbedThumbnail.CheckState = (settings.EmbedThumbnail) ? CheckState.Checked : CheckState.Unchecked;
                cbNoCacheDir.CheckState = (settings.NoCacheDir) ? CheckState.Checked : CheckState.Unchecked;
                cbCloseOutput.CheckState = (settings.CloseOutputLog) ? CheckState.Checked : CheckState.Unchecked;

                //cbSkipVideo.CheckState = (settings.SkipVideo) ? CheckState.Checked : CheckState.Unchecked;
                //cbExtractAudio.CheckState = (settings.ExtractAudio) ? CheckState.Checked : CheckState.Unchecked;
                //cbKeepVideo.CheckState = (settings.KeepVideo) ? CheckState.Checked : CheckState.Unchecked;
                //cbIgnoreConfig.CheckState = (settings.IgnoreConfig) ? CheckState.Checked : CheckState.Unchecked;
                //cbEmbedMetadata.CheckState = (settings.EmbedMetadata) ? CheckState.Checked : CheckState.Unchecked;
            }
            catch
            {

            }
            
        }

        private string argsBuilder()
        {
            string temp = $"-o \"{tbDirectory.Text}";
            temp += ((CheckState.Checked == cbFilenameFormat.CheckState) ? $"{tbFilenameFormat.Text}\"" : "%(title)s-%(id)s.%(ext)s\"").Replace("%", "%%");
            if(CheckState.Checked == cbIngoreErrors.CheckState)
                temp += " -i";
            if(CheckState.Checked == cbNoPlaylist.CheckState)
                temp += " --no-playlist";
            if (CheckState.Checked == cbPlaylistItems.CheckState)
                temp += " --playlist-items \"" + tbPlaylistItems.Text + "\"";
            if (CheckState.Checked == cbEmbedThumbnail.CheckState)
                temp += " --embed-thumbnail";
            if (CheckState.Checked == cbNoCacheDir.CheckState)
                temp += " --no-cache-dir";
            
            //if (CheckState.Checked == cbSkipVideo.CheckState)
            //    temp += " --skip-download";
            //if (CheckState.Checked == cbFreeFormats.CheckState)
            //    temp += " --prefer-free-formats";
            //if (CheckState.Checked == cbExtractAudio.CheckState)
            //    temp += " --extract-audio";
            //if (CheckState.Checked == cbKeepVideo.CheckState)
            //    temp += " --keep-video";
            //if (CheckState.Checked == cbIgnoreConfig.CheckState)
            //    temp += " --ignore-config";
            //if (CheckState.Checked == cbEmbedMetadata.CheckState)
            //    temp += " --add-metadata";

            switch (comboVideo.SelectedIndex)
                {
                    case 0:
                        temp += " -f bestvideo[ext=mp4]+";
                        break;
                    case 1:
                        temp += " -f bestvideo[ext=mp4][height=1080]+";
                        break;
                    case 2:
                        temp += " -f bestvideo[ext=mp4][height=720]+";
                        break;
                    case 3:
                        temp += " -f bestvideo[ext=webm]+";
                        break;
                    case 4:
                        temp += " -f bestvideo[ext=webm][height=1080]+";
                        break;
                    case 5:
                        temp += " -f bestvideo[ext=webm][height=720]+";
                        break;
                    case 6:
                        temp += " -f ";
                        break;
                    default:                        
                        temp += " -f [format_id=" + comboVideo.Text + "]+";
                        break;
                }

            switch (comboAudio.SelectedIndex)
            {
                case 0:
                    temp += "bestaudio";
                    break;
                case 1:
                    temp += "bestaudio[ext=m4a]";
                    break;
                case 2:
                    temp += "bestaudio[acodec=opus]";
                    break;
                case 3:
                    temp += "bestaudio[acodec=vorbis]";
                    break;
                default:
                    temp += "[format_id=" + comboAudio.Text + "]+";
                    break;
            }

            if (comboFile.SelectedIndex < 5)
                temp += $" --merge-output-format {comboFile.Text}";
            else if (comboFile.SelectedIndex == 5)
                temp += $" --extract-audio --audio-format {comboFile.Text}";
            else
                temp += $" -x";

            temp += " "+ $"\"{tbURL.Text}\"";
            return temp;
        }

        private void btnDirectory_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == folderBrowserDialog.ShowDialog())
                tbDirectory.Text = folderBrowserDialog.SelectedPath+"\\";      
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            btnSaveSettings.Enabled = false;
            timer.Tag = btnSaveSettings;
            timer.Start();

            settings.Directory = tbDirectory.Text;
            settings.Video = comboVideo.SelectedIndex;
            settings.Audio = comboAudio.SelectedIndex;
            settings.Container = comboFile.SelectedIndex;
            settings.UseNametemplate = (CheckState.Checked == cbFilenameFormat.CheckState) ? true : false;
            settings.NameTemplate = tbFilenameFormat.Text;
            settings.NoPlaylist = (CheckState.Checked == cbNoPlaylist.CheckState) ? true : false;
            settings.UsePlaylistItems = (CheckState.Checked == cbPlaylistItems.CheckState) ? true : false;
            settings.PlaylistItems = tbPlaylistItems.Text;
            settings.IgnoreErrors = (CheckState.Checked == cbIngoreErrors.CheckState) ? true : false;
            settings.EmbedThumbnail = (CheckState.Checked == cbEmbedThumbnail.CheckState) ? true : false;
            settings.NoCacheDir = (CheckState.Checked == cbNoCacheDir.CheckState) ? true : false;
            settings.CloseOutputLog = (CheckState.Checked == cbCloseOutput.CheckState) ? true : false;
            
            //settings.SkipVideo = (CheckState.Checked == cbSkipVideo.CheckState) ? true : false;
            //settings.FreeFormats = (CheckState.Checked == cbFreeFormats.CheckState) ? true : false;
            //settings.ExtractAudio = (CheckState.Checked == cbExtractAudio.CheckState) ? true : false;
            //settings.KeepVideo = (CheckState.Checked == cbKeepVideo.CheckState) ? true : false;
            //settings.IgnoreConfig = (CheckState.Checked == cbIgnoreConfig.CheckState) ? true : false;
            //settings.EmbedMetadata = (CheckState.Checked == cbEmbedMetadata.CheckState) ? true : false;

            settings.Save();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            ((Button)timer.Tag).Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            timer.Tag = btnUpdate;
            timer.Start();

            string homeDirectory, filename;
            homeDirectory = System.IO.Directory.GetCurrentDirectory();
            if (!homeDirectory.EndsWith("\\"))
                homeDirectory += "\\";
            
            filename = homeDirectory + DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".bat";

            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(filename, false, Encoding.Default))
            {
                sw.WriteLine("wget --no-check-certificate https://ffmpeg.zeranoe.com/builds/win64/static/ffmpeg-latest-win64-static.7z");
                sw.WriteLine("7z e ffmpeg-latest-win64-static.7z *.exe -r -y");
                sw.WriteLine("DEL ffmpeg-latest-win64-static.7z");
                sw.WriteLine("wget --no-check-certificate https://yt-dl.org/downloads/latest/youtube-dl.exe");
                if (cbCloseOutput.CheckState == CheckState.Unchecked)
                {
                    sw.WriteLine("PAUSE");
                    sw.WriteLine("DEL \"" + filename + "\"");
                }
            }

            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo = new System.Diagnostics.ProcessStartInfo(filename);
            p.Start();
        }

        private void btnCheckFormats_Click(object sender, EventArgs e)
        {
            btnCheckFormats.Enabled = false;
            timer.Tag = btnCheckFormats;
            timer.Start();

            if (tbURL.Text == "")
                return;
            string homeDirectory, args, command, filename;
            homeDirectory = System.IO.Directory.GetCurrentDirectory();
            if (!homeDirectory.EndsWith("\\"))
                homeDirectory += "\\";
            args = "-F " + tbURL.Text;
            command = $"\"{homeDirectory}youtube-dl.exe\" {args}";
            filename = homeDirectory + DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".bat";

            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(filename, false, Encoding.Default))
            {
                sw.WriteLine(command);
                sw.WriteLine("PAUSE");
            }

            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo = new System.Diagnostics.ProcessStartInfo(filename);
            p.Start();

        }

        private void btnClearCache_Click(object sender, EventArgs e)
        {
            btnClearCache.Enabled = false;
            timer.Tag = btnClearCache;
            timer.Start();

            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo = new System.Diagnostics.ProcessStartInfo("youtube-dl.exe", "--rm-cache-dir");
            p.Start();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            timer.Tag = btnStart;
            timer.Start();

            if (tbURL.Text == "")
                return;
            string homeDirectory, args, command, filename;
            homeDirectory = System.IO.Directory.GetCurrentDirectory();
            if (!homeDirectory.EndsWith("\\"))
                homeDirectory += "\\";
            args = @argsBuilder();
            command = $"\"{homeDirectory}youtube-dl.exe\" {args}";
            filename = homeDirectory + DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".bat";

            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(filename, false, Encoding.Default))
            {
                sw.WriteLine(command);
                if (cbCloseOutput.CheckState == CheckState.Unchecked)
                {
                    sw.WriteLine("PAUSE");
                    sw.WriteLine("DEL \"" + filename + "\"");
                }
            }

            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo = new System.Diagnostics.ProcessStartInfo(filename);
            p.Start();
        }
    }
}