using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RHSkillEditor
{
    public partial class SkillSelector : Form
    {
        public Skill selectedSkill { get; set; }

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

            stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Near;
            stringFormat.LineAlignment = StringAlignment.Center;
        }

        private void skillList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedSkill = (Skill)skillList.SelectedItem;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            selectedSkill = null;
            DialogResult = DialogResult.Cancel;
            Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Dispose();
        }
        private Rectangle buttonRect = new Rectangle(80, 2, 34, 34);
        private StringFormat stringFormat;
        private void skillList_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index == -1)
                return;
            // Draw the background.
            e.DrawBackground();
            Skill skill = (Skill)skillList.Items[e.Index];

            //if (e.Bounds.Location.X < 5)
            //    return; // ignore if trying to write text to the hard left of the view
            Rectangle btnRect = new Rectangle(e.Bounds.Location.X, e.Bounds.Location.Y, 30, 30);
            if (skill.icon != null)
                e.Graphics.DrawImage(skill.icon, btnRect.X, btnRect.Y, 30, 30);
            Rectangle rect = new Rectangle();
            rect.X = e.Bounds.X + 32;
            rect.Y = e.Bounds.Y + 9;
            rect.Width = e.Bounds.Width - 32;
            rect.Height = e.Bounds.Height;
            string txt = skill.korName;
            //e.Graphics.DrawString(skill.korName, this.Font, new SolidBrush(this.ForeColor), rect, stringFormat);
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                // Selected. Draw with the system highlight color.
                e.Graphics.DrawString(txt, this.Font, SystemBrushes.HighlightText, rect);
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
    }
}
