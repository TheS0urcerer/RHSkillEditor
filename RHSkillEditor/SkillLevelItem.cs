
using RohanFile;
using System.Runtime.InteropServices;

namespace RHSkillEditor
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public struct SkillLevelItemStruct
    {
        public byte learnLevel;
        public ushort castingMana;
        public ushort castingTime;
        public ushort skillAniTime;
        public ushort manaPerSec;
        public uint durationTime;
        public uint coolingTime;
        [MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.U4, SizeConst = 5)]
        public uint[] param;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string effectDescription;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string description;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string explainFileName;

    }

    public class SkillLevelItem : IBinItem<SkillLevelItemStruct>
    {
        public bool dirty { set; get; } = false;
        private SkillLevelItemStruct data; 
        public SkillLevelItemStruct Data { set {data = value;} get { return data; } }
        public byte learnLevel { set; get; }
        public ushort castingMana { set; get; }
        public ushort castingTime{ set; get; }
        public ushort skillAniTime { set; get; }
        public ushort manaPerSec { set; get; }
        public uint durationTime { set; get; }
        public uint coolingTime { set; get; }
        public uint[] param { set; get; }
        public string effectDescription { set; get; }
        public string description { set; get; }
        public string explainFileName { set; get; }
        public SkillLevelItem(SkillLevelItemStruct data, bool fake = false)
        {
            this.data = data;
            dirty = true;   // force restore
            restore();
        }

        public SkillLevelItemStruct toStruct()
        {
            data = new SkillLevelItemStruct(); // remake the boxed SkillLevelItemStruct with a new one
            data.learnLevel = learnLevel;
            data.castingMana = castingMana;
            data.castingTime = castingTime;
            data.skillAniTime = skillAniTime;
            data.manaPerSec = manaPerSec;
            data.durationTime = durationTime;
            data.coolingTime = coolingTime;
            data.param = param;
            data.effectDescription = effectDescription;
            data.description = description;
            data.explainFileName = explainFileName;
            return data;        
        }

        // fill the class properties with data from the SkillLevelItem structure
        public void restore()
        {
            if (!dirty)                 // never modified?
                return;                 // nothing to do.    
            learnLevel = data.learnLevel;
            castingMana = data.castingMana;
            castingTime = data.castingTime;
            skillAniTime = data.skillAniTime;
            manaPerSec = data.manaPerSec;
            durationTime = data.durationTime;
            coolingTime = data.coolingTime;
            param = data.param;
            effectDescription = data.effectDescription;
            description = data.description;
            explainFileName = data.explainFileName;
        }

        public void save()
        {
            Data = toStruct();
        }
    }
}
