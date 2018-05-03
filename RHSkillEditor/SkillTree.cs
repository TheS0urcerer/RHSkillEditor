
using RohanFile;
using System.Runtime.InteropServices;

namespace RHSkillEditor
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public struct SkillTreeStruct
    {
        public JobName job;
        public SkillIdx skillIdx;
        public SkillIdx parentSkillIdx;
        public byte point;
        public byte reqPoint;                                 
    }

    public class SkillTree : IBinItem<SkillTreeStruct>
    {
        public JobName job { get; set; }
        public SkillIdx skillIdx { get; set; }
        public SkillIdx parentSkillIdx { get; set; }
        public byte point { get; set; }
        public byte reqPoint { get; set; }
        public SkillTree(SkillTreeStruct data)
        {
            job = data.job;
            skillIdx = data.skillIdx;
            parentSkillIdx = data.parentSkillIdx;
            point = data.point;
            reqPoint = data.reqPoint;
        }

        public SkillTreeStruct toStruct()
        {
            SkillTreeStruct data = new SkillTreeStruct();
            data.job = job;
            data.skillIdx = skillIdx;
            data.parentSkillIdx = parentSkillIdx;
            data.point = point;
            data.reqPoint = reqPoint;
            return data;
        }
    }

}
