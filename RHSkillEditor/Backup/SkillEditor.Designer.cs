using EnhancedControls;

namespace RHSkillEditor
{
    partial class SkillEditor
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSkill = new System.Windows.Forms.TextBox();
            this.chkEnabled = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEName = new System.Windows.Forms.TextBox();
            this.txtKName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.cbxSubtype = new System.Windows.Forms.ComboBox();
            this.cbxTarget = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDescr = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIconFile = new System.Windows.Forms.TextBox();
            this.txtSIconFile = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPIconFile = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEIconFile = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEffectDescr = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSEIconFile = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtAddPoint = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtTimeFlag = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtLIconFile = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.itxtRange = new EnhancedControls.IntegerBox();
            this.itxtAddPointProb1 = new EnhancedControls.IntegerBox();
            this.itxtAddPointProb2 = new EnhancedControls.IntegerBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtExplainFile = new System.Windows.Forms.TextBox();
            this.txtLEffectDescr = new System.Windows.Forms.TextBox();
            this.txtLevelDescr = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.ibLearnLevel = new EnhancedControls.IntegerBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.ibCooldown = new EnhancedControls.IntegerBox();
            this.label22 = new System.Windows.Forms.Label();
            this.ibDuration = new EnhancedControls.IntegerBox();
            this.label23 = new System.Windows.Forms.Label();
            this.ibAniTime = new EnhancedControls.IntegerBox();
            this.label24 = new System.Windows.Forms.Label();
            this.ibCastTime = new EnhancedControls.IntegerBox();
            this.ibManaPerSec = new EnhancedControls.IntegerBox();
            this.ibCastingMana = new EnhancedControls.IntegerBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ibParam0 = new EnhancedControls.IntegerBox();
            this.ibParam4 = new EnhancedControls.IntegerBox();
            this.ibParam3 = new EnhancedControls.IntegerBox();
            this.ibParam2 = new EnhancedControls.IntegerBox();
            this.ibParam1 = new EnhancedControls.IntegerBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.txtLvlAvailable = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.nsLevelSelector = new System.Windows.Forms.NumericUpDown();
            this.pbSkill = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nsLevelSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSkill)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(765, 658);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Commit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnCancel.FlatAppearance.BorderSize = 2;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(869, 658);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 30);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(54, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Skill: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSkill
            // 
            this.txtSkill.Location = new System.Drawing.Point(161, 25);
            this.txtSkill.Name = "txtSkill";
            this.txtSkill.ReadOnly = true;
            this.txtSkill.Size = new System.Drawing.Size(315, 22);
            this.txtSkill.TabIndex = 3;
            // 
            // chkEnabled
            // 
            this.chkEnabled.AutoSize = true;
            this.chkEnabled.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkEnabled.Location = new System.Drawing.Point(588, 25);
            this.chkEnabled.Name = "chkEnabled";
            this.chkEnabled.Size = new System.Drawing.Size(82, 21);
            this.chkEnabled.TabIndex = 4;
            this.chkEnabled.Text = "Enabled";
            this.chkEnabled.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(54, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "English Name: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(521, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Korean Name: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEName
            // 
            this.txtEName.Location = new System.Drawing.Point(161, 86);
            this.txtEName.Name = "txtEName";
            this.txtEName.Size = new System.Drawing.Size(315, 22);
            this.txtEName.TabIndex = 7;
            // 
            // txtKName
            // 
            this.txtKName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKName.Location = new System.Drawing.Point(626, 88);
            this.txtKName.Name = "txtKName";
            this.txtKName.Size = new System.Drawing.Size(321, 22);
            this.txtKName.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(54, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Skill Type: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(522, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Subtype: ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(54, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Target: ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxType
            // 
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(161, 114);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(235, 24);
            this.cbxType.TabIndex = 12;
            // 
            // cbxSubtype
            // 
            this.cbxSubtype.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxSubtype.FormattingEnabled = true;
            this.cbxSubtype.Location = new System.Drawing.Point(626, 114);
            this.cbxSubtype.Name = "cbxSubtype";
            this.cbxSubtype.Size = new System.Drawing.Size(241, 24);
            this.cbxSubtype.TabIndex = 13;
            // 
            // cbxTarget
            // 
            this.cbxTarget.FormattingEnabled = true;
            this.cbxTarget.Location = new System.Drawing.Point(161, 144);
            this.cbxTarget.Name = "cbxTarget";
            this.cbxTarget.Size = new System.Drawing.Size(235, 24);
            this.cbxTarget.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(524, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "Range: ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(54, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 23);
            this.label8.TabIndex = 17;
            this.label8.Text = "Description: ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDescr
            // 
            this.txtDescr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescr.Location = new System.Drawing.Point(161, 174);
            this.txtDescr.Name = "txtDescr";
            this.txtDescr.Size = new System.Drawing.Size(786, 22);
            this.txtDescr.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(23, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 23);
            this.label9.TabIndex = 19;
            this.label9.Text = "Icon File: ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtIconFile
            // 
            this.txtIconFile.Location = new System.Drawing.Point(161, 230);
            this.txtIconFile.Name = "txtIconFile";
            this.txtIconFile.Size = new System.Drawing.Size(241, 22);
            this.txtIconFile.TabIndex = 20;
            // 
            // txtSIconFile
            // 
            this.txtSIconFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSIconFile.Location = new System.Drawing.Point(625, 231);
            this.txtSIconFile.Name = "txtSIconFile";
            this.txtSIconFile.Size = new System.Drawing.Size(247, 22);
            this.txtSIconFile.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(494, 230);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 23);
            this.label10.TabIndex = 21;
            this.label10.Text = "Small Icon File: ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPIconFile
            // 
            this.txtPIconFile.Location = new System.Drawing.Point(161, 258);
            this.txtPIconFile.Name = "txtPIconFile";
            this.txtPIconFile.Size = new System.Drawing.Size(241, 22);
            this.txtPIconFile.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(54, 257);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 23);
            this.label11.TabIndex = 23;
            this.label11.Text = "Icon Push File: ";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEIconFile
            // 
            this.txtEIconFile.Location = new System.Drawing.Point(161, 291);
            this.txtEIconFile.Name = "txtEIconFile";
            this.txtEIconFile.Size = new System.Drawing.Size(241, 22);
            this.txtEIconFile.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(30, 291);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 23);
            this.label12.TabIndex = 25;
            this.label12.Text = "Effect Icon File: ";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEffectDescr
            // 
            this.txtEffectDescr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEffectDescr.Location = new System.Drawing.Point(161, 202);
            this.txtEffectDescr.Name = "txtEffectDescr";
            this.txtEffectDescr.Size = new System.Drawing.Size(786, 22);
            this.txtEffectDescr.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(4, 201);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(151, 23);
            this.label13.TabIndex = 27;
            this.label13.Text = "Effect Description: ";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSEIconFile
            // 
            this.txtSEIconFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSEIconFile.Location = new System.Drawing.Point(626, 291);
            this.txtSEIconFile.Name = "txtSEIconFile";
            this.txtSEIconFile.Size = new System.Drawing.Size(247, 22);
            this.txtSEIconFile.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(460, 291);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(160, 23);
            this.label14.TabIndex = 29;
            this.label14.Text = "Small effect Icon File: ";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAddPoint
            // 
            this.txtAddPoint.Location = new System.Drawing.Point(161, 319);
            this.txtAddPoint.Name = "txtAddPoint";
            this.txtAddPoint.Size = new System.Drawing.Size(25, 22);
            this.txtAddPoint.TabIndex = 32;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(26, 319);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(129, 23);
            this.label15.TabIndex = 31;
            this.label15.Text = "Add Point: ";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(194, 319);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(160, 23);
            this.label16.TabIndex = 33;
            this.label16.Text = "Add point probability 1: ";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(194, 347);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(160, 23);
            this.label17.TabIndex = 35;
            this.label17.Text = "Add point probability 2: ";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTimeFlag
            // 
            this.txtTimeFlag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimeFlag.Location = new System.Drawing.Point(626, 319);
            this.txtTimeFlag.Name = "txtTimeFlag";
            this.txtTimeFlag.Size = new System.Drawing.Size(247, 22);
            this.txtTimeFlag.TabIndex = 38;
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(524, 319);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(96, 23);
            this.label18.TabIndex = 37;
            this.label18.Text = "Time Flag: ";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLIconFile
            // 
            this.txtLIconFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLIconFile.Location = new System.Drawing.Point(625, 259);
            this.txtLIconFile.Name = "txtLIconFile";
            this.txtLIconFile.Size = new System.Drawing.Size(247, 22);
            this.txtLIconFile.TabIndex = 41;
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(494, 258);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(125, 23);
            this.label19.TabIndex = 40;
            this.label19.Text = "Large Icon File: ";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // itxtRange
            // 
            this.itxtRange.IntegerValue = ((long)(1));
            this.itxtRange.Location = new System.Drawing.Point(626, 143);
            this.itxtRange.MaxValue = ((long)(5000));
            this.itxtRange.MinValue = ((long)(0));
            this.itxtRange.Name = "itxtRange";
            this.itxtRange.Signed = false;
            this.itxtRange.Size = new System.Drawing.Size(44, 22);
            this.itxtRange.TabIndex = 42;
            // 
            // itxtAddPointProb1
            // 
            this.itxtAddPointProb1.IntegerValue = ((long)(1));
            this.itxtAddPointProb1.Location = new System.Drawing.Point(360, 320);
            this.itxtAddPointProb1.MaxValue = ((long)(999999));
            this.itxtAddPointProb1.MinValue = ((long)(0));
            this.itxtAddPointProb1.Name = "itxtAddPointProb1";
            this.itxtAddPointProb1.Signed = false;
            this.itxtAddPointProb1.Size = new System.Drawing.Size(65, 22);
            this.itxtAddPointProb1.TabIndex = 43;
            // 
            // itxtAddPointProb2
            // 
            this.itxtAddPointProb2.IntegerValue = ((long)(1));
            this.itxtAddPointProb2.Location = new System.Drawing.Point(360, 348);
            this.itxtAddPointProb2.MaxValue = ((long)(999999));
            this.itxtAddPointProb2.MinValue = ((long)(0));
            this.itxtAddPointProb2.Name = "itxtAddPointProb2";
            this.itxtAddPointProb2.Signed = false;
            this.itxtAddPointProb2.Size = new System.Drawing.Size(65, 22);
            this.itxtAddPointProb2.TabIndex = 44;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtExplainFile);
            this.groupBox1.Controls.Add(this.txtLEffectDescr);
            this.groupBox1.Controls.Add(this.txtLevelDescr);
            this.groupBox1.Controls.Add(this.label32);
            this.groupBox1.Controls.Add(this.label33);
            this.groupBox1.Controls.Add(this.label34);
            this.groupBox1.Controls.Add(this.ibLearnLevel);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.ibManaPerSec);
            this.groupBox1.Controls.Add(this.ibCastingMana);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label29);
            this.groupBox1.Controls.Add(this.label30);
            this.groupBox1.Controls.Add(this.label31);
            this.groupBox1.Controls.Add(this.txtLvlAvailable);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.nsLevelSelector);
            this.groupBox1.Location = new System.Drawing.Point(41, 385);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(917, 253);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Skill Levels";
            // 
            // txtExplainFile
            // 
            this.txtExplainFile.Location = new System.Drawing.Point(149, 218);
            this.txtExplainFile.MaxLength = 128;
            this.txtExplainFile.Name = "txtExplainFile";
            this.txtExplainFile.Size = new System.Drawing.Size(762, 22);
            this.txtExplainFile.TabIndex = 63;
            // 
            // txtLEffectDescr
            // 
            this.txtLEffectDescr.Location = new System.Drawing.Point(149, 190);
            this.txtLEffectDescr.MaxLength = 128;
            this.txtLEffectDescr.Name = "txtLEffectDescr";
            this.txtLEffectDescr.Size = new System.Drawing.Size(762, 22);
            this.txtLEffectDescr.TabIndex = 62;
            // 
            // txtLevelDescr
            // 
            this.txtLevelDescr.Location = new System.Drawing.Point(149, 162);
            this.txtLevelDescr.MaxLength = 128;
            this.txtLevelDescr.Name = "txtLevelDescr";
            this.txtLevelDescr.Size = new System.Drawing.Size(762, 22);
            this.txtLevelDescr.TabIndex = 61;
            // 
            // label32
            // 
            this.label32.Location = new System.Drawing.Point(12, 218);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(131, 23);
            this.label32.TabIndex = 60;
            this.label32.Text = "Explain Filename:";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label33
            // 
            this.label33.Location = new System.Drawing.Point(10, 159);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(136, 23);
            this.label33.TabIndex = 59;
            this.label33.Text = "Level Description:";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label34
            // 
            this.label34.Location = new System.Drawing.Point(15, 190);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(131, 23);
            this.label34.TabIndex = 58;
            this.label34.Text = "Effect Description:";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ibLearnLevel
            // 
            this.ibLearnLevel.IntegerValue = ((long)(1));
            this.ibLearnLevel.Location = new System.Drawing.Point(143, 59);
            this.ibLearnLevel.MaxValue = ((long)(125));
            this.ibLearnLevel.MinValue = ((long)(1));
            this.ibLearnLevel.Name = "ibLearnLevel";
            this.ibLearnLevel.Signed = false;
            this.ibLearnLevel.Size = new System.Drawing.Size(25, 22);
            this.ibLearnLevel.TabIndex = 57;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.ibCooldown);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.ibDuration);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.ibAniTime);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.ibCastTime);
            this.groupBox2.Location = new System.Drawing.Point(655, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 134);
            this.groupBox2.TabIndex = 56;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Timings";
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(6, 18);
            this.label21.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(177, 23);
            this.label21.TabIndex = 2;
            this.label21.Text = "Casting Time (ms):";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ibCooldown
            // 
            this.ibCooldown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibCooldown.IntegerValue = ((long)(0));
            this.ibCooldown.Location = new System.Drawing.Point(183, 97);
            this.ibCooldown.MaxValue = ((long)(9223372036854775807));
            this.ibCooldown.MinValue = ((long)(0));
            this.ibCooldown.Name = "ibCooldown";
            this.ibCooldown.Signed = false;
            this.ibCooldown.Size = new System.Drawing.Size(68, 22);
            this.ibCooldown.TabIndex = 14;
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(6, 43);
            this.label22.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(177, 23);
            this.label22.TabIndex = 3;
            this.label22.Text = "Skill Animation Time (ms):";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ibDuration
            // 
            this.ibDuration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibDuration.IntegerValue = ((long)(0));
            this.ibDuration.Location = new System.Drawing.Point(183, 70);
            this.ibDuration.MaxValue = ((long)(9223372036854775807));
            this.ibDuration.MinValue = ((long)(0));
            this.ibDuration.Name = "ibDuration";
            this.ibDuration.Signed = false;
            this.ibDuration.Size = new System.Drawing.Size(68, 22);
            this.ibDuration.TabIndex = 13;
            // 
            // label23
            // 
            this.label23.Location = new System.Drawing.Point(6, 72);
            this.label23.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(177, 23);
            this.label23.TabIndex = 4;
            this.label23.Text = "Skill Duration Time (ms):";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ibAniTime
            // 
            this.ibAniTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibAniTime.IntegerValue = ((long)(0));
            this.ibAniTime.Location = new System.Drawing.Point(183, 44);
            this.ibAniTime.MaxValue = ((long)(9223372036854775807));
            this.ibAniTime.MinValue = ((long)(0));
            this.ibAniTime.Name = "ibAniTime";
            this.ibAniTime.Signed = false;
            this.ibAniTime.Size = new System.Drawing.Size(68, 22);
            this.ibAniTime.TabIndex = 12;
            // 
            // label24
            // 
            this.label24.Location = new System.Drawing.Point(6, 100);
            this.label24.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(177, 23);
            this.label24.TabIndex = 5;
            this.label24.Text = "Skill Cooldown Time (ms):";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ibCastTime
            // 
            this.ibCastTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibCastTime.IntegerValue = ((long)(0));
            this.ibCastTime.Location = new System.Drawing.Point(183, 18);
            this.ibCastTime.MaxValue = ((long)(9223372036854775807));
            this.ibCastTime.MinValue = ((long)(0));
            this.ibCastTime.Name = "ibCastTime";
            this.ibCastTime.Signed = false;
            this.ibCastTime.Size = new System.Drawing.Size(68, 22);
            this.ibCastTime.TabIndex = 11;
            // 
            // ibManaPerSec
            // 
            this.ibManaPerSec.IntegerValue = ((long)(0));
            this.ibManaPerSec.Location = new System.Drawing.Point(143, 113);
            this.ibManaPerSec.MaxValue = ((long)(9223372036854775807));
            this.ibManaPerSec.MinValue = ((long)(0));
            this.ibManaPerSec.Name = "ibManaPerSec";
            this.ibManaPerSec.Signed = false;
            this.ibManaPerSec.Size = new System.Drawing.Size(62, 22);
            this.ibManaPerSec.TabIndex = 55;
            // 
            // ibCastingMana
            // 
            this.ibCastingMana.IntegerValue = ((long)(0));
            this.ibCastingMana.Location = new System.Drawing.Point(143, 85);
            this.ibCastingMana.MaxValue = ((long)(9223372036854775807));
            this.ibCastingMana.MinValue = ((long)(0));
            this.ibCastingMana.Name = "ibCastingMana";
            this.ibCastingMana.Signed = false;
            this.ibCastingMana.Size = new System.Drawing.Size(62, 22);
            this.ibCastingMana.TabIndex = 54;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel1);
            this.groupBox3.Location = new System.Drawing.Point(215, 54);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(434, 101);
            this.groupBox3.TabIndex = 53;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Skill Specific Parameters";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.ibParam0, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ibParam4, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.ibParam3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.ibParam2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ibParam1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label25, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label26, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label27, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label28, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label35, 4, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 21);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(422, 69);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ibParam0
            // 
            this.ibParam0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibParam0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ibParam0.IntegerValue = ((long)(0));
            this.ibParam0.Location = new System.Drawing.Point(3, 37);
            this.ibParam0.MaxValue = ((long)(9223372036854775807));
            this.ibParam0.MinValue = ((long)(0));
            this.ibParam0.Name = "ibParam0";
            this.ibParam0.Signed = false;
            this.ibParam0.Size = new System.Drawing.Size(78, 23);
            this.ibParam0.TabIndex = 20;
            // 
            // ibParam4
            // 
            this.ibParam4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibParam4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ibParam4.IntegerValue = ((long)(0));
            this.ibParam4.Location = new System.Drawing.Point(339, 37);
            this.ibParam4.MaxValue = ((long)(9223372036854775807));
            this.ibParam4.MinValue = ((long)(0));
            this.ibParam4.Name = "ibParam4";
            this.ibParam4.Signed = false;
            this.ibParam4.Size = new System.Drawing.Size(80, 23);
            this.ibParam4.TabIndex = 18;
            // 
            // ibParam3
            // 
            this.ibParam3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibParam3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ibParam3.IntegerValue = ((long)(0));
            this.ibParam3.Location = new System.Drawing.Point(255, 37);
            this.ibParam3.MaxValue = ((long)(9223372036854775807));
            this.ibParam3.MinValue = ((long)(0));
            this.ibParam3.Name = "ibParam3";
            this.ibParam3.Signed = false;
            this.ibParam3.Size = new System.Drawing.Size(78, 23);
            this.ibParam3.TabIndex = 17;
            // 
            // ibParam2
            // 
            this.ibParam2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibParam2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ibParam2.IntegerValue = ((long)(0));
            this.ibParam2.Location = new System.Drawing.Point(171, 37);
            this.ibParam2.MaxValue = ((long)(9223372036854775807));
            this.ibParam2.MinValue = ((long)(0));
            this.ibParam2.Name = "ibParam2";
            this.ibParam2.Signed = false;
            this.ibParam2.Size = new System.Drawing.Size(78, 23);
            this.ibParam2.TabIndex = 16;
            // 
            // ibParam1
            // 
            this.ibParam1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibParam1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ibParam1.IntegerValue = ((long)(0));
            this.ibParam1.Location = new System.Drawing.Point(87, 37);
            this.ibParam1.MaxValue = ((long)(9223372036854775807));
            this.ibParam1.MinValue = ((long)(0));
            this.ibParam1.Name = "ibParam1";
            this.ibParam1.Signed = false;
            this.ibParam1.Size = new System.Drawing.Size(78, 23);
            this.ibParam1.TabIndex = 15;
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label25.Location = new System.Drawing.Point(3, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(78, 34);
            this.label25.TabIndex = 1;
            this.label25.Text = "0";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label26
            // 
            this.label26.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label26.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label26.Location = new System.Drawing.Point(87, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(78, 34);
            this.label26.TabIndex = 2;
            this.label26.Text = "1";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label27
            // 
            this.label27.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label27.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label27.Location = new System.Drawing.Point(171, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(78, 34);
            this.label27.TabIndex = 3;
            this.label27.Text = "2";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label28
            // 
            this.label28.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label28.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label28.Location = new System.Drawing.Point(255, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(78, 34);
            this.label28.TabIndex = 4;
            this.label28.Text = "3";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label35
            // 
            this.label35.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label35.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label35.Location = new System.Drawing.Point(339, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(80, 34);
            this.label35.TabIndex = 19;
            this.label35.Text = "4";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label29
            // 
            this.label29.Location = new System.Drawing.Point(4, 113);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(143, 23);
            this.label29.TabIndex = 52;
            this.label29.Text = "Mana Use / Second:";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label30
            // 
            this.label30.Location = new System.Drawing.Point(1, 84);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(146, 23);
            this.label30.TabIndex = 51;
            this.label30.Text = "Casting Mana:";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label31
            // 
            this.label31.Location = new System.Drawing.Point(1, 56);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(146, 23);
            this.label31.TabIndex = 50;
            this.label31.Text = "Learn Level:";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLvlAvailable
            // 
            this.txtLvlAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLvlAvailable.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtLvlAvailable.Location = new System.Drawing.Point(211, 21);
            this.txtLvlAvailable.Name = "txtLvlAvailable";
            this.txtLvlAvailable.Size = new System.Drawing.Size(390, 23);
            this.txtLvlAvailable.TabIndex = 49;
            this.txtLvlAvailable.Text = "Skill Level Available";
            this.txtLvlAvailable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(10, 23);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(146, 23);
            this.label20.TabIndex = 48;
            this.label20.Text = "Select Skill Level:";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nsLevelSelector
            // 
            this.nsLevelSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nsLevelSelector.Location = new System.Drawing.Point(162, 21);
            this.nsLevelSelector.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.nsLevelSelector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nsLevelSelector.Name = "nsLevelSelector";
            this.nsLevelSelector.Size = new System.Drawing.Size(43, 27);
            this.nsLevelSelector.TabIndex = 47;
            this.nsLevelSelector.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nsLevelSelector.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nsLevelSelector.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nsLevelSelector.ValueChanged += new System.EventHandler(this.nsLevelSelector_ValueChanged);
            // 
            // pbSkill
            // 
            this.pbSkill.Location = new System.Drawing.Point(497, 12);
            this.pbSkill.Name = "pbSkill";
            this.pbSkill.Size = new System.Drawing.Size(51, 47);
            this.pbSkill.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbSkill.TabIndex = 47;
            this.pbSkill.TabStop = false;
            // 
            // SkillEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 700);
            this.Controls.Add(this.pbSkill);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.itxtAddPointProb2);
            this.Controls.Add(this.itxtAddPointProb1);
            this.Controls.Add(this.itxtRange);
            this.Controls.Add(this.txtLIconFile);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtTimeFlag);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtAddPoint);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtSEIconFile);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtEffectDescr);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtEIconFile);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtPIconFile);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtSIconFile);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtIconFile);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDescr);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbxTarget);
            this.Controls.Add(this.cbxSubtype);
            this.Controls.Add(this.cbxType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKName);
            this.Controls.Add(this.txtEName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkEnabled);
            this.Controls.Add(this.txtSkill);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.button1);
            this.Name = "SkillEditor";
            this.Text = "SkillEditor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nsLevelSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSkill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSkill;
        private System.Windows.Forms.CheckBox chkEnabled;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEName;
        private System.Windows.Forms.TextBox txtKName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.ComboBox cbxSubtype;
        private System.Windows.Forms.ComboBox cbxTarget;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDescr;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIconFile;
        private System.Windows.Forms.TextBox txtSIconFile;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPIconFile;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEIconFile;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtEffectDescr;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSEIconFile;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtAddPoint;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtTimeFlag;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtLIconFile;
        private System.Windows.Forms.Label label19;
        private IntegerBox itxtRange;
        private IntegerBox itxtAddPointProb1;
        private IntegerBox itxtAddPointProb2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label txtLvlAvailable;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.NumericUpDown nsLevelSelector;
        private IntegerBox ibLearnLevel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label21;
        private IntegerBox ibCooldown;
        private System.Windows.Forms.Label label22;
        private IntegerBox ibDuration;
        private System.Windows.Forms.Label label23;
        private IntegerBox ibAniTime;
        private System.Windows.Forms.Label label24;
        private IntegerBox ibCastTime;
        private IntegerBox ibManaPerSec;
        private IntegerBox ibCastingMana;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private IntegerBox ibParam4;
        private IntegerBox ibParam3;
        private IntegerBox ibParam2;
        private IntegerBox ibParam1;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox txtExplainFile;
        private System.Windows.Forms.TextBox txtLEffectDescr;
        private System.Windows.Forms.TextBox txtLevelDescr;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.PictureBox pbSkill;
        private IntegerBox ibParam0;
        private System.Windows.Forms.Label label35;
    }
}