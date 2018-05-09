using EnhancedControls;

namespace RHSkillEditor
{
    partial class RHSkillEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbJobs = new System.Windows.Forms.ListBox();
            this.btnEditTree = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEdited = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxSkills = new System.Windows.Forms.GroupBox();
            this.btnSaveSkills = new System.Windows.Forms.Button();
            this.lbxSkills = new System.Windows.Forms.ListBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtSource = new System.Windows.Forms.TextBox();
            this.btnChDir = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.utilityFunctionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importImagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.gbxSkills.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.lbJobs);
            this.groupBox1.Controls.Add(this.btnEditTree);
            this.groupBox1.Location = new System.Drawing.Point(12, 122);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(252, 461);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Job";
            // 
            // lbJobs
            // 
            this.lbJobs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbJobs.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbJobs.FormattingEnabled = true;
            this.lbJobs.ItemHeight = 16;
            this.lbJobs.Location = new System.Drawing.Point(5, 21);
            this.lbJobs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbJobs.Name = "lbJobs";
            this.lbJobs.Size = new System.Drawing.Size(240, 372);
            this.lbJobs.TabIndex = 11;
            this.lbJobs.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbJobs_DrawItem);
            this.lbJobs.SelectedIndexChanged += new System.EventHandler(this.lbJobs_SelectedIndexChanged);
            // 
            // btnEditTree
            // 
            this.btnEditTree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditTree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEditTree.Image = global::RHSkillEditor.Properties.Resources.skillTree;
            this.btnEditTree.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditTree.Location = new System.Drawing.Point(90, 402);
            this.btnEditTree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditTree.Name = "btnEditTree";
            this.btnEditTree.Size = new System.Drawing.Size(154, 46);
            this.btnEditTree.TabIndex = 10;
            this.btnEditTree.Text = "Edit Skill Tree";
            this.btnEditTree.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnEditTree, "Edit the highlighted skill");
            this.btnEditTree.UseVisualStyleBackColor = true;
            this.btnEditTree.Visible = false;
            this.btnEditTree.Click += new System.EventHandler(this.btnEditTree_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Source BIN Directory :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEdited
            // 
            this.txtEdited.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEdited.Location = new System.Drawing.Point(171, 78);
            this.txtEdited.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEdited.Name = "txtEdited";
            this.txtEdited.ReadOnly = true;
            this.txtEdited.Size = new System.Drawing.Size(420, 22);
            this.txtEdited.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(9, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Edited BIN Directory :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbxSkills
            // 
            this.gbxSkills.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxSkills.Controls.Add(this.btnSaveSkills);
            this.gbxSkills.Controls.Add(this.lbxSkills);
            this.gbxSkills.Controls.Add(this.btnEdit);
            this.gbxSkills.Location = new System.Drawing.Point(269, 122);
            this.gbxSkills.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxSkills.Name = "gbxSkills";
            this.gbxSkills.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxSkills.Size = new System.Drawing.Size(320, 461);
            this.gbxSkills.TabIndex = 7;
            this.gbxSkills.TabStop = false;
            this.gbxSkills.Text = "Skills for %%";
            this.gbxSkills.Visible = false;
            // 
            // btnSaveSkills
            // 
            this.btnSaveSkills.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveSkills.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSaveSkills.Image = global::RHSkillEditor.Properties.Resources.save;
            this.btnSaveSkills.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveSkills.Location = new System.Drawing.Point(139, 402);
            this.btnSaveSkills.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveSkills.Name = "btnSaveSkills";
            this.btnSaveSkills.Size = new System.Drawing.Size(175, 46);
            this.btnSaveSkills.TabIndex = 11;
            this.btnSaveSkills.Text = "Save Edited Files";
            this.btnSaveSkills.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnSaveSkills, "Save all skills unconditionally");
            this.btnSaveSkills.UseVisualStyleBackColor = true;
            this.btnSaveSkills.Visible = false;
            this.btnSaveSkills.Click += new System.EventHandler(this.btnSaveSkills_Click);
            // 
            // lbxSkills
            // 
            this.lbxSkills.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxSkills.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbxSkills.FormattingEnabled = true;
            this.lbxSkills.ItemHeight = 32;
            this.lbxSkills.Location = new System.Drawing.Point(5, 21);
            this.lbxSkills.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbxSkills.Name = "lbxSkills";
            this.lbxSkills.Size = new System.Drawing.Size(309, 356);
            this.lbxSkills.TabIndex = 10;
            this.lbxSkills.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbxSkills_DrawItem);
            this.lbxSkills.SelectedIndexChanged += new System.EventHandler(this.lbxSkills_SelectedIndexChanged);
            this.lbxSkills.DoubleClick += new System.EventHandler(this.lbxSkills_DoubleClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEdit.Image = global::RHSkillEditor.Properties.Resources.edit;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(6, 402);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(119, 46);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Edit Skill";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnEdit, "Edit the highlighted skill");
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtSource
            // 
            this.txtSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSource.Location = new System.Drawing.Point(171, 48);
            this.txtSource.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSource.Name = "txtSource";
            this.txtSource.ReadOnly = true;
            this.txtSource.Size = new System.Drawing.Size(384, 22);
            this.txtSource.TabIndex = 10;
            // 
            // btnChDir
            // 
            this.btnChDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChDir.Location = new System.Drawing.Point(560, 44);
            this.btnChDir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChDir.Name = "btnChDir";
            this.btnChDir.Size = new System.Drawing.Size(31, 30);
            this.btnChDir.TabIndex = 11;
            this.btnChDir.Text = "...";
            this.btnChDir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChDir.UseVisualStyleBackColor = true;
            this.btnChDir.Click += new System.EventHandler(this.btnChDir_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.utilityFunctionsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(594, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // utilityFunctionsToolStripMenuItem
            // 
            this.utilityFunctionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importImagesToolStripMenuItem});
            this.utilityFunctionsToolStripMenuItem.Name = "utilityFunctionsToolStripMenuItem";
            this.utilityFunctionsToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.utilityFunctionsToolStripMenuItem.Text = "Utility Functions";
            // 
            // importImagesToolStripMenuItem
            // 
            this.importImagesToolStripMenuItem.Name = "importImagesToolStripMenuItem";
            this.importImagesToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.importImagesToolStripMenuItem.Text = "Import images...";
            this.importImagesToolStripMenuItem.Click += new System.EventHandler(this.importImagesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 24);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readmeToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // readmeToolStripMenuItem
            // 
            this.readmeToolStripMenuItem.Name = "readmeToolStripMenuItem";
            this.readmeToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.readmeToolStripMenuItem.Text = "Readme";
            this.readmeToolStripMenuItem.Click += new System.EventHandler(this.readmeToolStripMenuItem_Click);
            // 
            // RHSkillEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 584);
            this.Controls.Add(this.btnChDir);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.gbxSkills);
            this.Controls.Add(this.txtEdited);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RHSkillEditor";
            this.Text = "Rohan Skills Editor";
            this.groupBox1.ResumeLayout(false);
            this.gbxSkills.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEdited;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbxSkills;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Button btnChDir;
        private System.Windows.Forms.Button btnEditTree;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem utilityFunctionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importImagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readmeToolStripMenuItem;
        private System.Windows.Forms.ListBox lbxSkills;
        private System.Windows.Forms.Button btnSaveSkills;
        private System.Windows.Forms.ListBox lbJobs;
    }
}

