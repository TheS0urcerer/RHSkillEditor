using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RHSkillEditor
{
    public class OrphanSkill
    {
        internal Race race { get; set; }
        internal Skill skill;

        public OrphanSkill(Race race, SkillIdx skillidx)
        {
            this.race = race;
            try
            {
                skill = Global.SkillDict[skillidx];
            }
            catch (Exception e)
            {
                // not a valid orphan skill
                race = Race.NULLRACE;
                skill = null;
            }
        }

        public override string ToString()
        {
            if (skill != null)
                return skill.ToString();
            return "NO SKILL";
        }
    }
}
