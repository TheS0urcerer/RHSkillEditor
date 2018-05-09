using EnvDTE;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace RohanFile
{
    public class BinFile<T,C>
    {
        public string name { get; set; }
        public string outName { get; set; }

        public ArrayList content { get; set; } = new ArrayList();
        public BinFile(string fileName)
        {
            name = fileName ?? throw new ArgumentNullException(nameof(fileName));
            load();
        }
        public void load()
        {
            List<T> tContent = BinIO.getContent<T>(name); // throwaway list for file 
            foreach (T item in tContent)
            {
                C cItem = wrap(item);
                content.Add(cItem);
            }
                
        }
        public void save()
        {
            List<T> tContent = new List<T>();           // throwaway list
            foreach (IBinItem<T> item in content)
               tContent.Add(item.Data);
            outName = Path.Combine(RHSkillEditor.Properties.Settings.Default.TargetDir, 
                Path.GetFileName(name));
            Directory.CreateDirectory(RHSkillEditor.Properties.Settings.Default.TargetDir);
            BinIO.save(outName, tContent);
        }
        private C wrap(T t) =>
            (C)Activator.CreateInstance(typeof(C), new object[] { t, false });

        internal void wipe()
        {
            content?.Clear();
            name = outName = null;
        }
    }
}
