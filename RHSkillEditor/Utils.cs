using System;
using System.IO;
using System.Windows.Forms;

namespace RHSkillEditor
{
    public static class Utils
    {
        public static string[] Directories(string path)
        {
            string[] dirs = null;
            string dirsOnly = Path.GetDirectoryName(path);
            if (dirsOnly != String.Empty)
            {
                dirs = dirsOnly?.Split(new char[] { '\\' });
            }
            return dirs;
        }

        public static string GetOutputDir()
        {

            FolderBrowserDialog dlg = new FolderBrowserDialog();
            string prevdir = Properties.Settings.Default.workingDir;
            if (!prevdir.Equals("null"))
                dlg.SelectedPath = prevdir;
            DialogResult result = dlg.ShowDialog();
            if (result == DialogResult.Cancel)
                return null;
            Properties.Settings.Default.workingDir = dlg.SelectedPath;
            Properties.Settings.Default.Save();
            return dlg.SelectedPath;
        }
        public static string GetInputDir()
        {

            FolderBrowserDialog dlg = new FolderBrowserDialog();
            string prevdir = Properties.Settings.Default.SourceDir;
            if (!prevdir.Equals("null"))
                dlg.SelectedPath = prevdir;
            DialogResult result = dlg.ShowDialog();
            if (result == DialogResult.Cancel)
                return null;
            Properties.Settings.Default.SourceDir = dlg.SelectedPath;
            Properties.Settings.Default.Save();
            return dlg.SelectedPath;
        }
        public static byte[] AdjustOutput(byte[] buff, out int offset)
        {
            offset = 0;

            GfxType gfxtype = GetGfxType(buff, out offset);

            if (buff.Length < 4)
                return buff;
            switch (gfxtype)
            {
                case GfxType.TGA:
                    offset = 3;     // start of file follows "GEO" magic header
                    break;
                case GfxType.DDS:
                    //replace "GEO " magic value with "DDS "
                    buff[0] = (byte)'D';
                    buff[1] = (byte)'D';
                    buff[2] = (byte)'S';
                    break;
            }
            return buff;
        }
        /*
         * translate source buffer from GFX format to TGA or DDS as needed
         */
        public static byte[] GetImageData(byte[] source)
        {
            int offset = 0;
            source = AdjustOutput(source, out offset);
            if (offset == 0)
                return source;

            byte[] output = new byte[source.Length - 4];    // in case things don't go well
            Buffer.BlockCopy(source, 3, output, 0, output.Length);
            return output;
        }

        /*
         * translate the buffer from TGA or DDS format to GFX format
         */
        public static byte[] GetGfxData(byte[] source)
        {
            byte[] output = new byte[0];        // in case things don't go well
            int offset = 0;
            if (source[0] != 'D' && source[1] != 'D' && source[2] != 'S')
                offset = 4;

            output = new byte[source.Length + offset];
            source.CopyTo(output, offset);
            output[0] = (byte)'G';
            output[1] = (byte)'E';
            output[2] = (byte)'O';
            if (offset == 4)
                output[3] = (byte)0x00;
            else
                output[3] = (byte)' ';
            return output;
        }

        /*
         * Figure out the type of image in a .gfx file
         * handles only .tgs and .dds type images
         */
        public static GfxType GetGfxType(byte[] buff, out int offset)
        {
            offset = 0;

            // if file content is nothing but a "GEO" header, nothing to do.
            if (buff.Length < 4)
                return GfxType.UNKNOWN;  // unknown .gfx Type

            if (buff[0] == 'G' && buff[1] == 'E' && buff[2] == 'O')
            {
                if (buff[3] == 0x00)
                {
                    // this is a .tga (Targa) file
                    offset = 3;     // start of file follows "GEO" magic header
                    return GfxType.TGA;
                }
                if (buff[3] == ' ' && buff[4] == 124)
                {
                    return GfxType.DDS;
                }
            }
            return GfxType.UNKNOWN;
        }

        public static void WriteFile(string target, byte[] buffer, int offset)
        {
            string dirs = Path.GetDirectoryName(target);

            BinaryWriter bw = null;
            try
            {
                Directory.CreateDirectory(dirs);

                FileStream fs = new FileStream(target, FileMode.Create);
                bw = new BinaryWriter(fs);
                bw.Write(buffer, offset, (buffer.Length - offset));

                bw.Flush();
            }
            catch (IOException)
            { }
            finally
            {
                if (bw != null)
                    bw.Close();
            }
        }
    }
}
