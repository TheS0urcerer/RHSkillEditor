using FreeImageAPI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace RHSkillEditor
{
    public partial class ImageImporter : Form
    {

        public ImageImporter()
        {
            InitializeComponent();
            Properties.Settings.Default.ImagesTargetDir =
                   Path.Combine(Application.StartupPath, "Images");
           
            Directory.CreateDirectory(Properties.Settings.Default.ImagesTargetDir);
            txtSourceDir.Text = Properties.Settings.Default.ImagesSourceDir;
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() != DialogResult.Cancel)
            {
                Properties.Settings.Default.ImagesSourceDir = dlg.SelectedPath;
                Properties.Settings.Default.Save();
                txtSourceDir.Text = dlg.SelectedPath;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!File.Exists(txtSourceDir.Text+@"\bitmaps.gel"))
            {
                MessageBox.Show("bitmaps.gem and bitmaps.gel was not found\n"+
                    "at the specified location.\nChoose a valid location!", 
                    "GEM/GEL not found", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            ImportWorker.RunWorkerAsync(null);
        }

        private void cleanup(string workingDir, bool full)
        {
            string[] dirs = Directory.GetDirectories(workingDir);
            foreach (string dir in dirs)
            {
                if (!dir.Contains("interface4") || full)
                    Directory.Delete(dir, true);
            }
        }

        private void convertImages(List<GELEntry> loaded, string targetDir)
        {
            foreach (GELEntry entry in loaded)
                convertFile(entry, targetDir);
        }
            

        private void convertFile(GELEntry entry, string targetDir)
        {
            // this elementhas graphical data
            byte[] data = entry.gemData;
            if (data == null || data.Length < 10)
                return;
            int offset;
            GfxType gfxType = Utils.GetGfxType(data, out offset);
            if (gfxType != GfxType.UNKNOWN)
            {
                string outfile = Path.Combine(targetDir, Path.GetFileNameWithoutExtension(entry.ge.filename) + ".jpg");
                byte[] imgbytes = Utils.GetImageData(data);
                // create an image out of the translated byte array 
                Stream byteStream = new MemoryStream(imgbytes);
                try
                {
                    if (gfxType == GfxType.TGA)
                    {
                        FreeImageBitmap fib = new FreeImageBitmap(byteStream, FREE_IMAGE_FORMAT.FIF_TARGA);
                        fib.Save(outfile, FREE_IMAGE_FORMAT.FIF_JPEG);
                    }

                }
                catch (Exception e)
                {
                    System.Console.WriteLine($"Failed to write {outfile}\n... Exception :{e.Message}");
                }
            }
        }


        private void ImportWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            string archiveName = "bitmaps.gel";
            string archivePath = Properties.Settings.Default.ImagesSourceDir;
            string fullName = Path.Combine(archivePath, archiveName);

            string gel = fullName;
            RHArchive archive = new RHArchive(fullName);
            ImportWorker.ReportProgress(1);
            archive.gelFile.load();
            ImportWorker.ReportProgress(40);    // fetch only relevant data from GEM
            List<GELEntry> loadedEntries = new List<GELEntry>();
            foreach(GELEntry entry in archive.gelFile.entries)
            {
                if (!entry.ge.filename.StartsWith(@"interface4\skillicon") && !entry.ge.filename.StartsWith(@"interface4\skill_icon"))
                    continue;
                if (!entry.ge.filename.EndsWith(@".gtx"))
                    continue;       // we only care about .gtx entries
                if (entry.ge.filename.EndsWith(@"_20.gtx"))
                    continue; //don't convert the *_20.gtx (small) files.
                archive.gelFile.loadGemEntry(archive.gemFile, entry);
                loadedEntries.Add(entry);       // keep track of entries loaded
            }
            ImportWorker.ReportProgress(80);    // output converted entries to the target directory
            convertImages(loadedEntries, Properties.Settings.Default.ImagesTargetDir);
            archive.gemFile.close();
            ImportWorker.ReportProgress(100);   
        }

        private void ImportWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            switch (e.ProgressPercentage)
            {
                case 1:
                    txtMessage.Text = $"Started image import.";
                    btnCancel.Enabled = btnOK.Visible = false;
                    Application.UseWaitCursor = true;
                    break;
                case 40:
                    txtMessage.Text = $"Extracting needed items from GEM file.";
                    break;
                case 80:
                    txtMessage.Text = $"Converting .gtx image data to .jpg and storing them in\n{Properties.Settings.Default.ImagesTargetDir}.";
                    break;
                case 100:
                    txtMessage.Text = $"Import completed.";
                    btnCancel.Enabled = true;
                    Application.UseWaitCursor = false;
                    break;
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Dispose();

        }
    }
}
