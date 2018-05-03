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
    public partial class SkillTreeItemEditor : Form
    {
        private SkillTreeItem sti;
        private Race race;
        private List<Skill> skills;
        public SkillTreeItemEditor()
        {
            InitializeComponent();
        }
        public SkillTreeItemEditor(SkillTreeItem sti, Race race, List<Skill>skills) : this()
        {
            this.sti = sti;
            this.race = race;
            this.skills = skills;
            txtSkill.Text = sti.skill.korName;
            if (sti.childSkill != null)
                txtChild.Text = sti.childSkill.korName;
            ibPoints.IntegerValue = sti.point;
            ibReqPoints.IntegerValue = sti.reqPoint;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sti.point = (byte)ibPoints.IntegerValue;
            sti.reqPoint = (byte)ibReqPoints.IntegerValue;
            DialogResult = DialogResult.OK;
            Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Dispose();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            SkillSelector ss = new SkillSelector(race, skills);
            ss.ShowDialog();
        }
    }
}
