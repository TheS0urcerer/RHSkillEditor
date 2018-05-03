using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RHSkillEditor
{
    public partial class SkillSelector : Form
    {
        Race race;
        List<Skill> skills;
        public SkillSelector()
        {
            InitializeComponent();
        }
        public SkillSelector(Race aRace, List<Skill> skills) : this()
        {
            this.race = aRace;
            this.skills = skills;
            skillList.DataSource = skills;
        }


    }
}
