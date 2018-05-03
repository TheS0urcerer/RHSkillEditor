namespace RHSkillEditor
{
    partial class SkillTreeEditor
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
            Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo treeNodeAdvStyleInfo1 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRace = new System.Windows.Forms.Label();
            this.txtJob = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.jobTree = new System.Windows.Forms.TreeView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ctxMenus = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editSelectedSkillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeSelectedSkillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editSkillTreeItemValuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expandingIcon1 = new Aga.Controls.Tree.NodeControls.ExpandingIcon();
            this.nodeTextBox1 = new Aga.Controls.Tree.NodeControls.NodeTextBox();
            this.jobTree2 = new Syncfusion.Windows.Forms.Tools.TreeViewAdv();
            this.ctxMenus.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Skills for Race:";
            // 
            // txtRace
            // 
            this.txtRace.AutoSize = true;
            this.txtRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRace.ForeColor = System.Drawing.Color.Blue;
            this.txtRace.Location = new System.Drawing.Point(125, 21);
            this.txtRace.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtRace.Name = "txtRace";
            this.txtRace.Size = new System.Drawing.Size(52, 20);
            this.txtRace.TabIndex = 1;
            this.txtRace.Text = "Race";
            // 
            // txtJob
            // 
            this.txtJob.AutoSize = true;
            this.txtJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJob.ForeColor = System.Drawing.Color.Blue;
            this.txtJob.Location = new System.Drawing.Point(345, 22);
            this.txtJob.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(39, 20);
            this.txtJob.TabIndex = 4;
            this.txtJob.Text = "Job";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Skills for Job:";
            // 
            // jobTree
            // 
            this.jobTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.jobTree.Location = new System.Drawing.Point(20, 47);
            this.jobTree.Margin = new System.Windows.Forms.Padding(4);
            this.jobTree.Name = "jobTree";
            this.jobTree.Size = new System.Drawing.Size(240, 574);
            this.jobTree.TabIndex = 5;
            this.jobTree.DrawNode += new System.Windows.Forms.DrawTreeNodeEventHandler(this.jobTree_DrawNode);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnCancel.FlatAppearance.BorderSize = 2;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(489, 635);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 30);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(385, 635);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "Commit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ctxMenus
            // 
            this.ctxMenus.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxMenus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editSelectedSkillToolStripMenuItem,
            this.changeSelectedSkillToolStripMenuItem,
            this.editSkillTreeItemValuesToolStripMenuItem});
            this.ctxMenus.Name = "ctxMenus";
            this.ctxMenus.Size = new System.Drawing.Size(244, 76);
            // 
            // editSelectedSkillToolStripMenuItem
            // 
            this.editSelectedSkillToolStripMenuItem.Name = "editSelectedSkillToolStripMenuItem";
            this.editSelectedSkillToolStripMenuItem.Size = new System.Drawing.Size(243, 24);
            this.editSelectedSkillToolStripMenuItem.Text = "Edit Selected Skill";
            this.editSelectedSkillToolStripMenuItem.Click += new System.EventHandler(this.editSelectedSkillToolStripMenuItem_Click);
            // 
            // changeSelectedSkillToolStripMenuItem
            // 
            this.changeSelectedSkillToolStripMenuItem.Name = "changeSelectedSkillToolStripMenuItem";
            this.changeSelectedSkillToolStripMenuItem.Size = new System.Drawing.Size(243, 24);
            this.changeSelectedSkillToolStripMenuItem.Text = "Change Selected Skill";
            this.changeSelectedSkillToolStripMenuItem.Click += new System.EventHandler(this.changeSelectedSkillToolStripMenuItem_Click);
            // 
            // editSkillTreeItemValuesToolStripMenuItem
            // 
            this.editSkillTreeItemValuesToolStripMenuItem.Name = "editSkillTreeItemValuesToolStripMenuItem";
            this.editSkillTreeItemValuesToolStripMenuItem.Size = new System.Drawing.Size(243, 24);
            this.editSkillTreeItemValuesToolStripMenuItem.Text = "Edit SkillTree Item Values";
            this.editSkillTreeItemValuesToolStripMenuItem.Click += new System.EventHandler(this.editSkillTreeItemValuesToolStripMenuItem_Click);
            // 
            // expandingIcon1
            // 
            this.expandingIcon1.LeftMargin = 0;
            this.expandingIcon1.ParentColumn = null;
            // 
            // nodeTextBox1
            // 
            this.nodeTextBox1.IncrementalSearchEnabled = true;
            this.nodeTextBox1.LeftMargin = 3;
            this.nodeTextBox1.ParentColumn = null;
            // 
            // jobTree2
            // 
            treeNodeAdvStyleInfo1.EnsureDefaultOptionedChild = true;
            this.jobTree2.BaseStylePairs.AddRange(new Syncfusion.Windows.Forms.Tools.StyleNamePair[] {
            new Syncfusion.Windows.Forms.Tools.StyleNamePair("Standard", treeNodeAdvStyleInfo1)});
            this.jobTree2.BeforeTouchSize = new System.Drawing.Size(312, 368);
            // 
            // 
            // 
            this.jobTree2.HelpTextControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.jobTree2.HelpTextControl.Location = new System.Drawing.Point(0, 0);
            this.jobTree2.HelpTextControl.Name = "helpText";
            this.jobTree2.HelpTextControl.Size = new System.Drawing.Size(63, 19);
            this.jobTree2.HelpTextControl.TabIndex = 0;
            this.jobTree2.HelpTextControl.Text = "help text";
            this.jobTree2.InactiveSelectedNodeForeColor = System.Drawing.SystemColors.ControlText;
            this.jobTree2.Location = new System.Drawing.Point(273, 47);
            this.jobTree2.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.jobTree2.Name = "jobTree2";
            this.jobTree2.SelectedNodeForeColor = System.Drawing.SystemColors.HighlightText;
            this.jobTree2.Size = new System.Drawing.Size(312, 368);
            this.jobTree2.TabIndex = 8;
            this.jobTree2.Text = "treeViewAdv1";
            // 
            // 
            // 
            this.jobTree2.ToolTipControl.BackColor = System.Drawing.SystemColors.Info;
            this.jobTree2.ToolTipControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.jobTree2.ToolTipControl.Location = new System.Drawing.Point(0, 0);
            this.jobTree2.ToolTipControl.Name = "toolTip";
            this.jobTree2.ToolTipControl.Size = new System.Drawing.Size(53, 19);
            this.jobTree2.ToolTipControl.TabIndex = 1;
            this.jobTree2.ToolTipControl.Text = "toolTip";
            // 
            // SkillTreeEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 677);
            this.ContextMenuStrip = this.ctxMenus;
            this.Controls.Add(this.jobTree2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.jobTree);
            this.Controls.Add(this.txtJob);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRace);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SkillTreeEditor";
            this.Text = "SkillTreeEditor";
            this.ctxMenus.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtRace;
        private System.Windows.Forms.Label txtJob;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TreeView jobTree;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip ctxMenus;
        private System.Windows.Forms.ToolStripMenuItem editSelectedSkillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeSelectedSkillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editSkillTreeItemValuesToolStripMenuItem;
        private Aga.Controls.Tree.NodeControls.ExpandingIcon expandingIcon1;
        private Aga.Controls.Tree.NodeControls.NodeTextBox nodeTextBox1;
        private Syncfusion.Windows.Forms.Tools.TreeViewAdv jobTree2;
    }
}