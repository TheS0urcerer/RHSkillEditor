using RohanFile;
using System.Collections.Generic;
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms.VisualStyles;

namespace RHSkillEditor
{
    public partial class SkillTreeEditor : Form
    {
        private List<Skill> raceSkills = new List<Skill>();
        private Race race { get; set; }
        private JobName job { get; set; }

        private Rectangle buttonRect = new Rectangle(80, 2, 34, 34);
        private StringFormat stringFormat;


        public SkillTreeEditor()
        {
            InitializeComponent();
        }
        public SkillTreeEditor(BinFile<SkillStruct, Skill> skillBin, BinFile<SkillTreeStruct, SkillTreeItem> skillTreeBin, JobName job) : this()
        {
            this.job = job;


            // determine race from JobName
            switch (job)
            {
                case JobName.HUMAN_KNIGHT:
                case JobName.HUMAN_GUARDIAN:
                case JobName.HUMAN_DEFENDER:
                    loadRaceSkills(JobName.HUMAN_KNIGHT, JobName.HUMAN_GUARDIAN, JobName.HUMAN_DEFENDER);
                    race = Race.HUMAN; break;
                case JobName.ELF_HEALER:
                case JobName.ELF_PRIEST:
                case JobName.ELF_TEMPLAR:
                    loadRaceSkills(JobName.ELF_HEALER, JobName.ELF_PRIEST, JobName.ELF_TEMPLAR);
                    race = Race.ELF; break;
                case JobName.HALFELF_ARCHER:
                case JobName.HALFELF_RANGER:
                case JobName.HALFELF_SCOUT:
                    loadRaceSkills(JobName.HALFELF_ARCHER, JobName.HALFELF_RANGER, JobName.HALFELF_SCOUT);
                    race = Race.HALFELF; break;
                case JobName.DHAN_ASSASSIN:
                case JobName.DHAN_AVENGER:
                case JobName.DHAN_PREDATOR:
                    loadRaceSkills(JobName.DHAN_ASSASSIN, JobName.DHAN_AVENGER, JobName.DHAN_PREDATOR);
                    race = Race.DHAN; break;
                case JobName.GIANT_WARRIOR:
                case JobName.GIANT_BERSERKER:
                case JobName.GIANT_SAVAGE:
                    loadRaceSkills(JobName.GIANT_WARRIOR, JobName.GIANT_BERSERKER, JobName.GIANT_SAVAGE);
                    race = Race.GIANT; break;
                case JobName.DARKELF_MAGE:
                case JobName.DARKELF_WARLOCK:
                case JobName.DARKELF_WIZARD:
                    loadRaceSkills(JobName.DARKELF_MAGE, JobName.DARKELF_WARLOCK, JobName.DARKELF_WIZARD);
                    race = Race.DARKELF; break;
                case JobName.TRINITY_MER:
                case JobName.TRINITY_RUMIR:
                case JobName.TRINITY_NOIR:
                   loadRaceSkills(JobName.TRINITY_MER, JobName.TRINITY_RUMIR, JobName.TRINITY_NOIR);
                    race = Race.TRINITY; break;
                case JobName.DEKAN_DRAGON_FIGHTER:
                case JobName.DEKAN_DRAGON_KNIGHT:
                case JobName.DEKAN_DRAGON_SAGE:
                    loadRaceSkills(JobName.DEKAN_DRAGON_FIGHTER, JobName.DEKAN_DRAGON_KNIGHT, JobName.DEKAN_DRAGON_SAGE);
                    race = Race.DEKAN; break;
                case JobName.GUILD_MASTER:
                    loadRaceSkills(JobName.GUILD_MASTER, JobName.GUILD_MASTER, JobName.GUILD_MASTER);
                    race = Race.GM; break;
            }
            txtJob.Text = job.GetDescription();
            txtRace.Text = race.GetDescription();
            jobTree.DrawMode = TreeViewDrawMode.OwnerDrawText;
        
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Near;
            stringFormat.LineAlignment = StringAlignment.Center;

            populate();
        }

        private void loadRaceSkills(JobName j1, JobName j2, JobName j3)
        {
            SkillTree st = new SkillTree(j1, false);
            foreach (SkillTreeNode stn in st.jobItems)
            {
                if (!raceSkills.Contains(stn.treeItem.skill))
                    raceSkills.Add(stn.treeItem.skill);
            }
            if (j1 == j2)
                return;
            st = new SkillTree(j2, false);
            foreach (SkillTreeNode stn in st.jobItems)
            {
                if (!raceSkills.Contains(stn.treeItem.skill))
                    raceSkills.Add(stn.treeItem.skill);
            }
            st = new SkillTree(j3, false);
            foreach (SkillTreeNode stn in st.jobItems)
            {
                if (!raceSkills.Contains(stn.treeItem.skill))
                    raceSkills.Add(stn.treeItem.skill);
            }
        }

        private void populate()
        {
            // CustomNodeNode = new TreeNode(job.GetDescription());
            SkillTree skillTree = new SkillTree(job,true);
            CustomNode[] roots = skillTree.buildTrees();
            jobTree.Nodes.AddRange(roots);
        }

        private void editSelectedSkillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode node = jobTree.SelectedNode;
            SkillTreeItem sti = ((SkillTreeNode)node.Tag).treeItem;
            Skill skill = sti.skill;

            SkillEditor skillEditor = new SkillEditor(skill);
            if (skillEditor.ShowDialog() == DialogResult.Cancel)
                return;
        }

        private void changeSelectedSkillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode node = jobTree.SelectedNode;
            SkillTreeItem sti = ((SkillTreeNode)node.Tag).treeItem;
            SkillSelector selector = new SkillSelector(race, raceSkills);
            if (selector.ShowDialog() == DialogResult.OK)
            {
                //Skill newSkill = selector.
                sti.skill = selector.selectedSkill;
                sti.save();
                jobTree.Refresh();
            }
                
            else
                sti.revert();

        }

        private void editSkillTreeItemValuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode node = jobTree.SelectedNode;
            SkillTreeItem sti = ((SkillTreeNode)node.Tag).treeItem;
            SkillTreeItemEditor editor = new SkillTreeItemEditor(sti, race, raceSkills);
            if (editor.ShowDialog() == DialogResult.OK)
                sti.save();
            else
                sti.revert();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Dispose();
        }

        private void jobTree_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            SkillTreeNode stn = (SkillTreeNode)e.Node.Tag;
            if (e.Bounds.Location.X <5)
                return; // ignore if trying to write text to the hard left of the view

            e.Graphics.DrawString(stn.treeItem.skill.korName, this.Font, new SolidBrush(this.ForeColor), e.Bounds, stringFormat);
            Rectangle btnRect = new Rectangle(e.Node.Bounds.Location.X + e.Node.Bounds.Size.Width + 5, e.Node.Bounds.Location.Y, buttonRect.Width, buttonRect.Height);
            if (stn.treeItem.skill.icon != null)
                e.Graphics.DrawImage(stn.treeItem.skill.icon, btnRect.X, btnRect.Y, 30, 30);
        }

        private void jobTree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode node = jobTree.SelectedNode;
            SkillTreeItem sti = ((SkillTreeNode)node.Tag).treeItem;
            Skill skill = sti.skill;

            SkillEditor skillEditor = new SkillEditor(skill);
            if (skillEditor.ShowDialog() == DialogResult.Cancel)
                return;
        }
    }

    public class CustomNode : TreeNode
    {
        public SkillTreeNode node { get; set; }
        public CustomNode(SkillTreeNode stn)
        {
            node = stn;
            Text = stn.treeItem.skill.korName;
        }
    }
}
