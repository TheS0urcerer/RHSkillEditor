using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

namespace RohanFile
{
    public static class BinIO
    {
        public static List<T> getContent<T>(string fileName)
        {
            List<T> content = new List<T>();
            using (var reader = new BinaryReader(new FileStream(fileName, FileMode.Open)))
            {
                try
                {
                    byte[] buffer;
                    while (true)
                    {
                        buffer = reader.ReadBytes(Marshal.SizeOf<T>());
                        if (buffer.Length < Marshal.SizeOf<T>())
                            break;
                        T struc = ToStructure<T>(buffer);
                        content.Add(struc);
                    }
                }
                catch (Exception)
                {
                    //. quietly exit on file problem
                }
            }   // done
            return content;
        }
        public static bool save<T>(string fileName, List<T> content)
        {
            bool result;
            using (var writer = new System.IO.BinaryWriter(new FileStream(fileName, FileMode.Create)))
            {
                try
                {
                    foreach (T item in content)
                    {
                        byte[] buffer = ToByteArray(item);
                        writer.Write(buffer);
                    }
                    result = true;
                }
                catch (Exception)
                {
                    //. quietly exit on file problem
                    result = false;
                }
            }   // done
            return result;
        }

        private static T ToStructure<T>(byte[] data)
        {
            unsafe
            {
                fixed (byte* p = &data[0])
                {
                    return (T)Marshal.PtrToStructure(new IntPtr(p), typeof(T));
                }
            };
        }
        private static byte[] ToByteArray(object obj)
        {
            int len = Marshal.SizeOf(obj);
            byte[] arr = new byte[len];
            IntPtr ptr = Marshal.AllocHGlobal(len);
            Marshal.StructureToPtr(obj, ptr, true);
            Marshal.Copy(ptr, arr, 0, len);
            Marshal.FreeHGlobal(ptr);
            return arr;
        }
    }

}
