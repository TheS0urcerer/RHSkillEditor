using System;
using System.Drawing;
using System.Windows.Forms;

namespace RHSkillEditor
{
    public partial class SkillLevelEditor : Form
    {
        private Skill skill { get; set; }
        public bool dirty { get; set; }
        private int currLevel { get; set; } = 1;

        public SkillLevelEditor()
        {
            InitializeComponent();
        }
        public SkillLevelEditor(Skill skill) : this()
        {
            this.skill = skill;
            nsLevelSelector.Value  = currLevel = 1;
            currLevel = 1;
            populate();            // populate with 1st level selected
        }

        private void populate()
        {
            SkillLevelItem item = skill.skillLevel.skillLevel[currLevel - 1];
            
            dirty = false;
            ibCastingMana.IntegerValue = item.castingMana;
            ibCastTime.IntegerValue = item.castingTime;
            ibCooldown.IntegerValue = item.coolingTime;
            txtDescr.Text = item.description;
            ibDuration.IntegerValue = item.durationTime;
            txtEffectDescr.Text = item.effectDescription;
            txtExplainFile.Text = item.explainFileName;
            ibLearnLevel.IntegerValue = item.learnLevel;
            ibManaPerSec.IntegerValue = item.manaPerSec;
            ibParam1.IntegerValue = item.param[0];
            ibParam2.IntegerValue = item.param[1];
            ibParam3.IntegerValue = item.param[2];
            ibParam4.IntegerValue = item.param[3];
            ibParam5.IntegerValue = item.param[4];

            ibAniTime.IntegerValue = item.skillAniTime;
            skillLevelAvailable(item);
        }

        private bool skillLevelAvailable(SkillLevelItem item)
        {
            bool available = true;
            // look at each of the current SkillItemLevel is available
            available = !( item.learnLevel == 0 && item.castingMana == 0 && item.castingTime == 0 &&
                item.coolingTime == 0 && item.manaPerSec == 0 && item.skillAniTime == 0 && item.param[0] == 0);

            if (available)
            {
                txtLvlAvailable.Text = "Skill Level Available";
                txtLvlAvailable.ForeColor = Color.ForestGreen;
            }
            else
            {
                txtLvlAvailable.Text = "Skill Level NOT Available";
                txtLvlAvailable.ForeColor = Color.Red;
            }

            return available;
        }

        

        private void nsLevelSelector_ValueChanged(object sender, EventArgs e)
        {
            saveEdits();
            currLevel = (int)nsLevelSelector.Value;
            populate();
        }

        private void saveEdits()
        {
            if (!dirty)
                return;
            SkillLevelItem item = skill.skillLevel.skillLevel[currLevel-1];
            dirty = false;
            item.dirty = true;
            item.castingMana = (ushort)ibCastingMana.IntegerValue;
            item.castingTime = (ushort)ibCastTime.IntegerValue;
            item.coolingTime = (ushort)ibCooldown.IntegerValue;
            item.description = txtDescr.Text;
            item.durationTime = (ushort)ibDuration.IntegerValue;
            item.effectDescription = txtEffectDescr.Text;
            item.explainFileName = txtExplainFile.Text;
            item.learnLevel = (byte)ibLearnLevel.IntegerValue;
            item.manaPerSec = (ushort)ibManaPerSec.IntegerValue;
            item.param[0] = (uint)ibParam1.IntegerValue;
            item.param[1] = (uint)ibParam2.IntegerValue;
            item.param[2] = (uint)ibParam3.IntegerValue;
            item.param[3] = (uint)ibParam4.IntegerValue;
            item.param[4] = (uint)ibParam5.IntegerValue;
            item.skillAniTime = (ushort)ibAniTime.IntegerValue;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // stash the current levels if changed 
            saveEdits();
            DialogResult = DialogResult.OK;
            Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // restore all skillLevel values from their structs
            DialogResult = DialogResult.Cancel;
            Dispose();
        }

        private void edit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!skillLevelAvailable(skill.skillLevel.skillLevel[currLevel - 1]))
                return;         // ignore changes to unavailable skill levels
            if (!dirty)
                dirty = true;
        }
    }
}
