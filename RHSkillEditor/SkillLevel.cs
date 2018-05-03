using RohanFile;
using System.Runtime.InteropServices;

namespace RHSkillEditor
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public struct SkillLevelStruct
    {
        [MarshalAs(UnmanagedType.U2)]
        public SkillIdx skillIdx;
        public ushort usPad;
        [MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.Struct, SizeConst = 7)]
        public SkillLevelItemStruct[] skillLevel;
        public byte bPad;
    }

    public class SkillLevel : IBinItem<SkillLevelStruct>
    {
        public SkillIdx skillIdx { get; set; }
        public ushort usPad { get; set; }
        public byte bPad { get; set; }
        public SkillLevelItem[] skillLevel { get; set; }
        public SkillLevel(SkillLevelStruct data, bool fake=false)
        {
            skillIdx = data.skillIdx;
            usPad = data.usPad;
            bPad = data.bPad;
            SkillLevelItem[] levels = new SkillLevelItem[7];
            for (int i = 0; i < 7; i++)
                levels[i] = new SkillLevelItem(data.skillLevel[i]);
            skillLevel = levels;
        }

        public SkillLevelStruct toStruct()
        {
            SkillLevelStruct data = new SkillLevelStruct();
            data.skillIdx = skillIdx;
            data.usPad = usPad;
            data.bPad = bPad;
            SkillLevelItemStruct[] sli = new SkillLevelItemStruct[7];

            for (int i = 0; i < 7; i++)
                sli[i] = skillLevel[i].toStruct();
            data.skillLevel = sli;
            return data;
        }
    }
}
