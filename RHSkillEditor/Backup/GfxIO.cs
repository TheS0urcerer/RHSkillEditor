using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace RHSkillEditor
{
    public class RHArchive
    {
        private string fileName { get; set; }
        public GELFile gelFile;
        public GEMFile gemFile;

        public RHArchive(string source)
        {
            string path = $"{Path.GetDirectoryName(source)}\\{Path.GetFileNameWithoutExtension(source)}.gel";
            gelFile = new GELFile(path);
            path = $"{Path.GetDirectoryName(source)}\\{Path.GetFileNameWithoutExtension(source)}.gem";
            gemFile = new GEMFile(path);
        }


    }
    [StructLayout(LayoutKind.Sequential)]
    public struct _GELHeader
    {
        public Int32 gelSig;      // 0x01010101 gel magic number
        public Int32 ver;      // 0
        public Int32 count;
        public Int32 missFileSize;
        public Int32 checksum;
        public Int32 pad;
    };

    [StructLayout(LayoutKind.Sequential)]
    public struct _GEMHeader
    {
        public Int32 gemSig;      // 0x10101010 gem magic number
        public Int32 reserved;      //  zero
    };


    [StructLayout(LayoutKind.Sequential)]
    public struct _GELEntry
    {
        public Int32 gelID;
        public Int32 hash;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string filename;
        public Int32 gelOffset;         // position within GEM file
        public Int32 startOffset;
        public Int32 dataSize;          // number of bytes in GEM file
        public Int32 checksum;
    };

    public class GEMFile
    {
        string source;
        BinaryReader b;
        public bool Valid { get; set; }
        public GEMFile(String path)
        {
            source = path;
            openFile();
        }

        private void openFile()
        {
            try
            {
                b = new BinaryReader(File.Open(source, FileMode.Open, FileAccess.Read));
                Valid = true;
            }
            catch (IOException)
            {
                MessageBox.Show("Unable to open bitmaps.gem.\nClose and reopen RHSkillEditor before you try again");
                Valid = false;
            }
        }

        public byte[] getBlob(int pos, int required)
        {
            if (required == -1)
                return null;

            if (!Valid)
                return null;            // flag that the file is not valid
            int length = (int)b.BaseStream.Length;
            if (required > length)
                return new byte[0];     // flag that the file is not valid
            int count = 0;
            //Console.WriteLine(required);
            byte[] bytes = new byte[required];
            try
            {
                b.BaseStream.Seek(pos, SeekOrigin.Begin);
                count = b.Read(bytes, 0, required);
                if (count < required)           // premature EOF
                    return new byte[0];
                return bytes;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new byte[0];
            }
        }

        public void close()
        {
            b.Dispose();
        }
    }


    public class GELEntry
    {
        public _GELEntry ge;
        public byte[] gemData;
    }

    public class GELFile
    {
        public string fileName { get; set; }
        private _GELHeader header;
        internal GELEntry[] entries { get; set; }
        public GELFile(string name)
        {
            string path = Path.GetDirectoryName(name);
            string fname = Path.GetFileNameWithoutExtension(name) + ".gel";
            fileName = $"{path}\\{fname}";
            load();
        }


        internal void loadGemEntry(GEMFile gemFile, GELEntry entry) =>
            entry.gemData = gemFile.getBlob(entry.ge.startOffset, entry.ge.dataSize);

        internal void loadGemData(GEMFile gemFile)
        {
            for (int i = 0; i < entries.Length; i++)
                loadGemEntry(gemFile, entries[i]);
        }

        internal Boolean load()
        {
            using (BinaryReader reader = new BinaryReader(new FileStream(fileName, FileMode.Open, FileAccess.Read)))
            {
                try
                {
                    if (loadHeader(reader))
                        loadContent(reader);
                    reader.Dispose();
                }
                catch (IOException)
                {
                    return false;
                }
                finally
                {
                    reader.Dispose();
                }
            }
            return true;
        }

        internal Boolean loadHeader(BinaryReader reader)
        {
            int count = Marshal.SizeOf(typeof(_GELHeader));
            byte[] buffer = new byte[count];
            try
            {
                buffer = reader.ReadBytes(count);
                GCHandle handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
                header = (_GELHeader)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(_GELHeader));
                handle.Free();
            }
            catch (IOException)
            {
                return false;
            }
            return true;
        }

        void loadContent(BinaryReader reader)
        {
            //  Alloc content array to load
            entries = new GELEntry[header.count];

            int count = Marshal.SizeOf(typeof(_GELEntry));
            byte[] buffer = new byte[count];
            for (int i = 0; i < header.count; i++)
            {
                entries[i] = new GELEntry();
                buffer = reader.ReadBytes(count);
                GCHandle handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
                entries[i].ge = (_GELEntry)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(_GELEntry));
                handle.Free();
            }
        }
    }


    static class GfxIO
    {


    }
}
