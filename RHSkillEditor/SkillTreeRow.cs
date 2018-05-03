using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RHSkillEditor
{
    public class SkillTreeRow
    {
        public Skill Skill { get; set; }
        private SkillTree skillTree;
        public byte Point { get { return skillTree.point; } set { skillTree.point = value; } }
        public byte ReqPoint { get { return skillTree.reqPoint; } set { skillTree.reqPoint = value; } }
        public Skill Child { get; set; }


    }
}
