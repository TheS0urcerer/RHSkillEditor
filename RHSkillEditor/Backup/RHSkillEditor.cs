
using RohanFile;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.ComponentModel;

namespace RHSkillEditor
{
    public partial class RHSkillEditor : Form
    {

        public static BinFile<SkillStruct, Skill> skillFile { get; set; }
        public static BinFile<SkillLevelStruct, SkillLevel> skillLevelFile { get; set; }
        public static BinFile<SkillTreeStruct, SkillTreeItem> skillTreeFile { get; set; }

        public RHSkillEditor()
        {
            InitializeComponent();
            Properties.Settings.Default.ImagesTargetDir =
                Path.Combine(Application.StartupPath, "Images");
            Properties.Settings.Default.Save();
            Directory.CreateDirectory(Properties.Settings.Default.ImagesTargetDir);
            if (!Properties.Settings.Default.workingDir.Equals("."))
            {
                loadFiles(Properties.Settings.Default.workingDir);
                Properties.Settings.Default.TargetDir = Properties.Settings.Default.workingDir + "\\Edited";
                Directory.CreateDirectory(Properties.Settings.Default.TargetDir);
            }
            Properties.Settings.Default.Save();
        }


        private void lbJobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            JobName job = (JobName)lbJobs.SelectedItem;
            btnEditTree.Visible = true; 
            gbxSkills.Text = $"Skills for {job.ToString()}";
            List<Skill> infos = new List<Skill>();
            lbxSkills.Items.Clear();
            foreach (SkillTreeItem skillTree in skillTreeFile.content)
            {
                if (skillTree.job == job)  //   if the Job is the one we selected
                {
                    // look up the associated skill in the skillinfo list
                    if (Global.SkillDict.TryGetValue(skillTree.skillIdx, out Skill skill))
                        if (!lbxSkills.Items.Contains(skill))       // add the skill only once!
                            lbxSkills.Items.Add(skill);
                }
            }
            if (lbxSkills.Items.Count == 0)
            {
                gbxSkills.Visible = btnEdit.Visible = btnEditTree.Visible = false; 
            }
            else
                gbxSkills.Visible = btnEditTree.Visible = true;
        }

        private void btnChDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fb = new FolderBrowserDialog();
            fb.SelectedPath = Properties.Settings.Default.workingDir;
            if (fb.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.workingDir = fb.SelectedPath;
                Properties.Settings.Default.Save();
                loadFiles(Properties.Settings.Default.workingDir);
            }
        }

        private void loadFiles(string workingDir)
        {
            if (!File.Exists(Path.Combine(workingDir, Global.SKILL_INFO_NAME)))
                return;
            txtSource.Text = workingDir;
            String editDir = txtEdited.Text = Path.Combine(workingDir, "Edited");
            
            Directory.CreateDirectory(editDir);

            // start filling stuff in
            skillFile = new BinFile<SkillStruct, Skill>(Path.Combine(workingDir, Global.SKILL_INFO_NAME));
            skillLevelFile = new BinFile<SkillLevelStruct, SkillLevel>(Path.Combine(workingDir, Global.SKILL_LVL_NAME));
            // load the skill lookup dictinary
            foreach (SkillLevel level in skillLevelFile.content)
            {
                if (!Global.LevelDict.TryAdd(level.skillIdx, level))
                    Console.WriteLine($"Failed to add {level.skillIdx.ToString()} to LevelDict");
            }
            foreach (Skill item in skillFile.content)
            {
                if (!Global.SkillDict.TryAdd(item.skillIdx, item))
                    Console.WriteLine($"Failed to add {item.skillIdx.ToString()} to SkillDict");

                if (Global.LevelDict.TryGetValue(item.skillIdx, out SkillLevel level))
                    item.skillLevel = level;        // guildmaster skills may not have this
            }
            skillTreeFile = new BinFile<SkillTreeStruct, SkillTreeItem>(Path.Combine(workingDir, Global.SKILL_TREE_NAME));
            // Link the skills to its levels


            // load the jobs listbox
            foreach (JobName job in Enum.GetValues(typeof(JobName)))
                lbJobs.Items.Add(job);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Skill info = (Skill)lbxSkills.SelectedItem;
            if (info == null)
                return;
            SkillEditor editor = new SkillEditor(info);
            if (editor.ShowDialog() == DialogResult.Cancel)
            {
                editor.Dispose();
                return;
            }
        }

        private void lbxSkills_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEdit.Enabled = btnEdit.Visible = true;
            btnSaveSkills.Enabled = btnSaveSkills.Visible = true;
        }

        private void importImagesToolStripMenuItem_Click(object sender, EventArgs e) =>
            (new ImageImporter()).ShowDialog();

        private void readmeToolStripMenuItem_Click(object sender, EventArgs e) =>
            (new Readme()).ShowDialog();
        

        private void lbJobs_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index == -1)
                return;
            JobName item = (JobName)lbJobs.Items[e.Index];
            e.DrawBackground();
            string description = item.GetDescription();
            e.Graphics.DrawString(description, e.Font, Brushes.Black, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }

        private void lbxSkills_DrawItem(object sender, DrawItemEventArgs e)
        {

        }

        private void btnSaveSkills_Click(object sender, EventArgs e)
        {
            skillFile.save();
            skillLevelFile.save();
            skillTreeFile.save();

        }

        private void btnEditTree_Click(object sender, EventArgs e)
        {
            if (lbJobs.SelectedIndex != -1)
            {
                SkillTreeEditor editor = new SkillTreeEditor(skillFile, skillTreeFile, (JobName)lbJobs.SelectedItem);
                editor.ShowDialog();

            }
        }
    }
}
