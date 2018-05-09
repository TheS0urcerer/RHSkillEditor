
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

        private bool skillTreeEdited { get; set; } = false;
        private bool skillEdited { get; set; } = false;

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
            stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Near;
            stringFormat.LineAlignment = StringAlignment.Center;
        }


        private void lbJobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            JobName job = (JobName)lbJobs.SelectedItem;
            btnEditTree.Visible = true;
            btnSaveSkills.Visible = false;
            gbxSkills.Text = $"Skills for {job.GetDescription()}";
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
                if (skillEdited || skillTreeEdited)
                    btnSaveSkills.Visible = true;
            }
            else
            {
                gbxSkills.Visible = btnEditTree.Visible = true;
                if (skillEdited || skillTreeEdited)
                    btnSaveSkills.Visible = true;
            }
        }

        private void btnChDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fb = new FolderBrowserDialog();
            fb.SelectedPath = Properties.Settings.Default.workingDir;
            if (fb.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.workingDir = fb.SelectedPath;
                Properties.Settings.Default.TargetDir = Path.Combine(fb.SelectedPath, "Edited");
                Properties.Settings.Default.Save();
                loadFiles(Properties.Settings.Default.workingDir);
            }
        }

        private void loadFiles(string workingDir)
        {
            wipe();
            if (!File.Exists(Path.Combine(workingDir, Global.SKILL_INFO_NAME)))
                return;
            txtSource.Text = workingDir;
            txtEdited.Text = Properties.Settings.Default.TargetDir;
            Directory.CreateDirectory(txtEdited.Text);

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

        private void wipe()
        {
            // Simple method to clear out stuff that was previously loaded
            skillFile?.wipe();
            skillTreeFile?.wipe();
            skillLevelFile?.wipe();
            Global.LevelDict.Clear();
            Global.SkillDict.Clear();
            txtSource.Text = txtEdited.Text = null;
            lbxSkills.Items.Clear();
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
            skillEdited = btnSaveSkills.Visible = true;
        }

        private void lbxSkills_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEdit.Enabled = btnEdit.Visible = true;

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
        private StringFormat stringFormat;
        private void lbxSkills_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index == -1)
                return;
            // Draw the background.
            e.DrawBackground();
            Skill skill = (Skill)lbxSkills.Items[e.Index];

            //if (e.Bounds.Location.X < 5)
            //    return; // ignore if trying to write text to the hard left of the view
            Rectangle btnRect = new Rectangle(e.Bounds.Location.X, e.Bounds.Location.Y, 30, 30);
            if (skill.icon != null)
                e.Graphics.DrawImage(skill.icon, btnRect.X, btnRect.Y, 30, 30);
            Rectangle rect = new Rectangle();
            rect.X = e.Bounds.X + 32;
            rect.Y = e.Bounds.Y+9;
            rect.Width = e.Bounds.Width - 32;
            rect.Height = e.Bounds.Height;
            string txt = skill.korName;
            //e.Graphics.DrawString(skill.korName, this.Font, new SolidBrush(this.ForeColor), rect, stringFormat);
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                // Selected. Draw with the system highlight color.
                e.Graphics.DrawString(txt, this.Font, SystemBrushes.HighlightText,rect);
            }
            else
            {
                // Not selected. Draw with ListBox's foreground color.
                using (SolidBrush br = new SolidBrush(e.ForeColor))
                {
                    e.Graphics.DrawString(txt, this.Font, br, rect);
                }
            }
            e.DrawFocusRectangle();
        }

        private void btnSaveSkills_Click(object sender, EventArgs e)
        {
            string msg = "";
            if (skillEdited)
            {
                skillFile.save();
                skillLevelFile.save();
                msg += "Skills, Skill Levels ";
            }
            if (skillEdited && skillTreeEdited)
                msg += " and "; 
            if (skillTreeEdited)
            {
                skillTreeFile.save();
                msg += "Skill Tree";
            }
            msg += " saved.";    

            skillTreeEdited = skillEdited = false;
            btnSaveSkills.Visible = false;
            MessageBox.Show(msg,"Bin Files Saved");
        }

        private void btnEditTree_Click(object sender, EventArgs e)
        {
            if (lbJobs.SelectedIndex != -1)
            {
                SkillTreeEditor editor = new SkillTreeEditor(skillFile, skillTreeFile, (JobName)lbJobs.SelectedItem);
                if (editor.ShowDialog() == DialogResult.OK)
                {
                    skillTreeEdited = editor.skillTreeEdited;
                    skillEdited = editor.skillEdited;
                    if (skillEdited || skillTreeEdited)
                        btnSaveSkills.Visible = true;
                }
                    
                // something changed so allow save
            }
        }

        private void lbxSkills_DoubleClick(object sender, EventArgs e)
        {
            ListBox listbox = sender as ListBox;
            Skill info = listbox.SelectedItem as Skill;
            if (info == null)
                return;
            SkillEditor editor = new SkillEditor(info);
            if (editor.ShowDialog() == DialogResult.Cancel)
            {
                editor.Dispose();
                return;
            }
            editor.Dispose();
            info.save();
            skillEdited = btnEdit.Visible = true;
        }
    }
}
