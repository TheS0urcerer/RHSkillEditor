using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace RHSkillEditor
{


    public partial class SkillEditor : Form
    {
        internal Skill skill { get; set; }
        internal bool dirty { get; set; }
        public SkillEditor()
        {

            InitializeComponent();
            initComboBoxes();

        }
        private void initComboBoxes()
        {
            cbxType.DataSource = Enum.GetValues(typeof(SkillType));
            cbxSubtype.DataSource = Enum.GetValues(typeof(SkillSubType));
            cbxTarget.DataSource = Enum.GetValues(typeof(SkillTarget));
        }
        public SkillEditor(Skill skill) : this()
        {
            this.skill = skill;
            populate();
         // populate with 1st level selected
        }


        private void populate()
        {
            if (skill.icon != null)
                pbSkill.Image = skill.icon;
            // text fields
            txtAddPoint.Text = skill.addPoint.ToString();
            itxtAddPointProb1.IntegerValue = skill.addPointProbability;
            itxtAddPointProb2.IntegerValue = skill.addPointProbability2;
            txtDescr.Text = skill.description;
            txtEffectDescr.Text = skill.affectDescription;
            txtEIconFile.Text = skill.iconAffectFileName;
            txtSEIconFile.Text = skill.iconSmallAffectFile;
            txtEName.Text = skill.engName;
            txtKName.Text = skill.korName;
            txtIconFile.Text = skill.iconFileName;
            txtPIconFile.Text = skill.iconPushFileName;
            txtSIconFile.Text = skill.iconSmallFileName;
            txtLIconFile.Text = skill.iconLargeFileName;
            itxtRange.IntegerValue = skill.range;
            txtSkill.Text = $"{skill.korName} ({skill.skillIdx.ToString()})" ;                  // read only - uses korean name rather than ENUM label
            //txtSkill.Text = skill.skillIdx.ToString();
            txtTimeFlag.Text = skill.timeFlag.ToString();
            // checkboxes
            chkEnabled.Checked = (skill.enable > 0);
            // comboboxes (enums)
            cbxType.SelectedItem = skill.type;
            cbxSubtype.SelectedItem = skill.subType;
            cbxTarget.SelectedItem = skill.target;
            //loadSkillLevels();

            nsLevelSelector.Value = currLevel = 1;
            currLevel = 1;
            skillLevelPopulate(currLevel);
        }

        private void collect()
        {
            // text fields
            skill.addPoint = (byte)Byte.Parse(txtAddPoint.Text);
            skill.addPointProbability = (int)itxtAddPointProb1.IntegerValue;
            skill.addPointProbability2 = (int)itxtAddPointProb2.IntegerValue;
            skill.description = txtDescr.Text;
            skill.affectDescription = txtEffectDescr.Text;
            skill.iconAffectFileName = txtEIconFile.Text;
            skill.iconSmallAffectFile = txtSEIconFile.Text;
            skill.engName = txtEName.Text;
            skill.korName = txtKName.Text;
            skill.iconFileName = txtIconFile.Text;
            skill.iconPushFileName = txtPIconFile.Text;
            skill.iconSmallFileName = txtSIconFile.Text;
            skill.iconLargeFileName = txtLIconFile.Text;
            skill.range = (int)itxtRange.IntegerValue;
            // enum comboboxes
            if (cbxType.SelectedIndex != -1)
                 skill.type = (SkillType)cbxType.SelectedItem;
            if (cbxSubtype.SelectedIndex != -1)
                skill.subType = (SkillSubType)cbxSubtype.SelectedItem;
            if (cbxTarget.SelectedIndex != -1)
                skill.target = (SkillTarget)cbxTarget.SelectedItem;
            skill.skillLevel.data = skill.skillLevel.toStruct();
        }


        //private void loadSkillLevels()
        //{
        //    List<SkillLevelItem> skillLevels = new List<SkillLevelItem>();
        //    skillLevels.AddRange(skill.skillLevel.skillLevel);
        //}


        private bool levelDirty { get; set; } = false;
        private int currLevel { get; set; } = 1;
        private void skillLevelPopulate(int level)
        {
            SkillLevelItem item = skill.skillLevel.skillLevel[level - 1];

            dirty = false;
            ibCastingMana.IntegerValue = item.castingMana;
            ibCastTime.IntegerValue = item.castingTime;
            ibCooldown.IntegerValue = item.coolingTime;
            txtLevelDescr.Text = item.description;
            ibDuration.IntegerValue = item.durationTime;
            txtLEffectDescr.Text = item.effectDescription;
            txtExplainFile.Text = item.explainFileName;
            ibLearnLevel.IntegerValue = item.learnLevel;
            ibManaPerSec.IntegerValue = item.manaPerSec;
            ibParam0.IntegerValue = item.param[0];
            ibParam1.IntegerValue = item.param[1];
            ibParam2.IntegerValue = item.param[2];
            ibParam3.IntegerValue = item.param[3];
            ibParam4.IntegerValue = item.param[4];
            ibAniTime.IntegerValue = item.skillAniTime;
            skillLevelAvailable(item);
        }

        private bool skillLevelAvailable(SkillLevelItem item)
        {
            bool available = true;
            // look at each of the current SkillItemLevel is available
            available = !(item.learnLevel == 0 && item.castingMana == 0 && item.castingTime == 0 &&
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
            saveLevelEdits(currLevel - 1);
            currLevel = (int)nsLevelSelector.Value;
            skillLevelPopulate(currLevel);
        }
        private void saveLevelEdits(int idx)
        {
            SkillLevelItem item = skill.skillLevel.skillLevel[idx];
            dirty = false;
            item.dirty = true;
            item.castingMana = (ushort)ibCastingMana.IntegerValue;
            item.castingTime = (ushort)ibCastTime.IntegerValue;
            item.coolingTime = (ushort)ibCooldown.IntegerValue;
            item.description = txtLevelDescr.Text;
            item.durationTime = (ushort)ibDuration.IntegerValue;
            item.effectDescription = txtLEffectDescr.Text;
            item.explainFileName = txtExplainFile.Text;
            item.learnLevel = (byte)ibLearnLevel.IntegerValue;
            item.manaPerSec = (ushort)ibManaPerSec.IntegerValue;
            item.param[0] = (uint)ibParam0.IntegerValue;
            item.param[1] = (uint)ibParam1.IntegerValue;
            item.param[2] = (uint)ibParam2.IntegerValue;
            item.param[3] = (uint)ibParam3.IntegerValue;
            item.param[4] = (uint)ibParam4.IntegerValue;
            item.skillAniTime = (ushort)ibAniTime.IntegerValue;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveLevelEdits(currLevel - 1);
            collect();
            skill.save();
            skill.data = skill.toStruct();
            for (int i=0; i<7; i++)
                skill.skillLevel.skillLevel[i].save();
            DialogResult = DialogResult.OK;
            Dispose();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            skill.revert();             // Back out skill changes
            for (int i = 0; i < 7; i++)  // back out skillLevel changes
                skill.skillLevel.skillLevel[i].restore();
            DialogResult = DialogResult.Cancel;
            Dispose();
        }
    }
}
