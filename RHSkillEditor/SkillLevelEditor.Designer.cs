namespace RHSkillEditor
{
    partial class SkillLevelEditor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ibParam5 = new EnhancedControls.IntegerBox();
            this.ibParam4 = new EnhancedControls.IntegerBox();
            this.ibParam3 = new EnhancedControls.IntegerBox();
            this.ibParam2 = new EnhancedControls.IntegerBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.nsLevelSelector = new System.Windows.Forms.NumericUpDown();
            this.ibCastingMana = new EnhancedControls.IntegerBox();
            this.ibManaPerSec = new EnhancedControls.IntegerBox();
            this.ibCastTime = new EnhancedControls.IntegerBox();
            this.ibAniTime = new EnhancedControls.IntegerBox();
            this.ibDuration = new EnhancedControls.IntegerBox();
            this.ibCooldown = new EnhancedControls.IntegerBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ibLearnLevel = new EnhancedControls.IntegerBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtDescr = new System.Windows.Forms.TextBox();
            this.txtEffectDescr = new System.Windows.Forms.TextBox();
            this.txtExplainFile = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.txtLvlAvailable = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ibParam1 = new EnhancedControls.IntegerBox();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nsLevelSelector)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(68, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Learn Level:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(68, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Casting Mana:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(55, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Casting Time (ms):";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(24, 43);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Skill Animation Time (ms):";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(5, 72);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Skill Duration Time (ms):";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(5, 100);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Skill Cooldown Time (ms):";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(37, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Mana Use per Second:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(22, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(621, 88);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Skill Specific Parameters";
            this.toolTip1.SetToolTip(this.groupBox1, "These parameters are skill-specific.\r\nDo not edit them unless you know what you a" +
        "re doing.");
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.ibParam1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ibParam5, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.ibParam4, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.ibParam3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ibParam2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label9, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label10, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label11, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label12, 4, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 23);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(609, 59);
            this.tableLayoutPanel1.TabIndex = 0;
            this.toolTip1.SetToolTip(this.tableLayoutPanel1, "These parameters are skill-specific.\r\nDo not edit them unless you know what you a" +
        "re doing.");
            // 
            // ibParam5
            // 
            this.ibParam5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibParam5.IntegerValue = ((long)(0));
            this.ibParam5.Location = new System.Drawing.Point(495, 32);
            this.ibParam5.MaxValue = ((long)(9223372036854775807));
            this.ibParam5.MinValue = ((long)(0));
            this.ibParam5.Name = "ibParam5";
            this.ibParam5.Signed = false;
            this.ibParam5.Size = new System.Drawing.Size(111, 19);
            this.ibParam5.TabIndex = 18;
            this.ibParam5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edit_KeyPress);
            // 
            // ibParam4
            // 
            this.ibParam4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibParam4.IntegerValue = ((long)(0));
            this.ibParam4.Location = new System.Drawing.Point(370, 32);
            this.ibParam4.MaxValue = ((long)(9223372036854775807));
            this.ibParam4.MinValue = ((long)(0));
            this.ibParam4.Name = "ibParam4";
            this.ibParam4.Signed = false;
            this.ibParam4.Size = new System.Drawing.Size(111, 19);
            this.ibParam4.TabIndex = 17;
            this.ibParam4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edit_KeyPress);
            // 
            // ibParam3
            // 
            this.ibParam3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibParam3.IntegerValue = ((long)(0));
            this.ibParam3.Location = new System.Drawing.Point(249, 32);
            this.ibParam3.MaxValue = ((long)(9223372036854775807));
            this.ibParam3.MinValue = ((long)(0));
            this.ibParam3.Name = "ibParam3";
            this.ibParam3.Signed = false;
            this.ibParam3.Size = new System.Drawing.Size(111, 19);
            this.ibParam3.TabIndex = 16;
            this.ibParam3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edit_KeyPress);
            // 
            // ibParam2
            // 
            this.ibParam2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibParam2.IntegerValue = ((long)(0));
            this.ibParam2.Location = new System.Drawing.Point(128, 32);
            this.ibParam2.MaxValue = ((long)(9223372036854775807));
            this.ibParam2.MinValue = ((long)(0));
            this.ibParam2.Name = "ibParam2";
            this.ibParam2.Signed = false;
            this.ibParam2.Size = new System.Drawing.Size(111, 19);
            this.ibParam2.TabIndex = 15;
            this.ibParam2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edit_KeyPress);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 29);
            this.label8.TabIndex = 1;
            this.label8.Text = "0";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(124, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 29);
            this.label9.TabIndex = 2;
            this.label9.Text = "1";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(245, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 29);
            this.label10.TabIndex = 3;
            this.label10.Text = "2";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Location = new System.Drawing.Point(366, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 29);
            this.label11.TabIndex = 4;
            this.label11.Text = "3";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            // 
            // nsLevelSelector
            // 
            this.nsLevelSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nsLevelSelector.Location = new System.Drawing.Point(171, 12);
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
            this.nsLevelSelector.TabIndex = 27;
            this.nsLevelSelector.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.nsLevelSelector, "Select Level to edit here");
            this.nsLevelSelector.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nsLevelSelector.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nsLevelSelector.ValueChanged += new System.EventHandler(this.nsLevelSelector_ValueChanged);
            // 
            // ibCastingMana
            // 
            this.ibCastingMana.IntegerValue = ((long)(0));
            this.ibCastingMana.Location = new System.Drawing.Point(210, 104);
            this.ibCastingMana.MaxValue = ((long)(9223372036854775807));
            this.ibCastingMana.MinValue = ((long)(0));
            this.ibCastingMana.Name = "ibCastingMana";
            this.ibCastingMana.Signed = false;
            this.ibCastingMana.Size = new System.Drawing.Size(62, 22);
            this.ibCastingMana.TabIndex = 9;
            this.ibCastingMana.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edit_KeyPress);
            // 
            // ibManaPerSec
            // 
            this.ibManaPerSec.IntegerValue = ((long)(0));
            this.ibManaPerSec.Location = new System.Drawing.Point(210, 132);
            this.ibManaPerSec.MaxValue = ((long)(9223372036854775807));
            this.ibManaPerSec.MinValue = ((long)(0));
            this.ibManaPerSec.Name = "ibManaPerSec";
            this.ibManaPerSec.Signed = false;
            this.ibManaPerSec.Size = new System.Drawing.Size(62, 22);
            this.ibManaPerSec.TabIndex = 10;
            this.ibManaPerSec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edit_KeyPress);
            // 
            // ibCastTime
            // 
            this.ibCastTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibCastTime.IntegerValue = ((long)(0));
            this.ibCastTime.Location = new System.Drawing.Point(204, 21);
            this.ibCastTime.MaxValue = ((long)(9223372036854775807));
            this.ibCastTime.MinValue = ((long)(0));
            this.ibCastTime.Name = "ibCastTime";
            this.ibCastTime.Signed = false;
            this.ibCastTime.Size = new System.Drawing.Size(81, 22);
            this.ibCastTime.TabIndex = 11;
            this.ibCastTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edit_KeyPress);
            // 
            // ibAniTime
            // 
            this.ibAniTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibAniTime.IntegerValue = ((long)(0));
            this.ibAniTime.Location = new System.Drawing.Point(204, 47);
            this.ibAniTime.MaxValue = ((long)(9223372036854775807));
            this.ibAniTime.MinValue = ((long)(0));
            this.ibAniTime.Name = "ibAniTime";
            this.ibAniTime.Signed = false;
            this.ibAniTime.Size = new System.Drawing.Size(81, 22);
            this.ibAniTime.TabIndex = 12;
            this.ibAniTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edit_KeyPress);
            // 
            // ibDuration
            // 
            this.ibDuration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibDuration.IntegerValue = ((long)(0));
            this.ibDuration.Location = new System.Drawing.Point(204, 73);
            this.ibDuration.MaxValue = ((long)(9223372036854775807));
            this.ibDuration.MinValue = ((long)(0));
            this.ibDuration.Name = "ibDuration";
            this.ibDuration.Signed = false;
            this.ibDuration.Size = new System.Drawing.Size(81, 22);
            this.ibDuration.TabIndex = 13;
            this.ibDuration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edit_KeyPress);
            // 
            // ibCooldown
            // 
            this.ibCooldown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibCooldown.IntegerValue = ((long)(0));
            this.ibCooldown.Location = new System.Drawing.Point(204, 100);
            this.ibCooldown.MaxValue = ((long)(9223372036854775807));
            this.ibCooldown.MinValue = ((long)(0));
            this.ibCooldown.Name = "ibCooldown";
            this.ibCooldown.Signed = false;
            this.ibCooldown.Size = new System.Drawing.Size(81, 22);
            this.ibCooldown.TabIndex = 14;
            this.ibCooldown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edit_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.ibCooldown);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.ibDuration);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.ibAniTime);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.ibCastTime);
            this.groupBox2.Location = new System.Drawing.Point(349, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 134);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Timings";
            // 
            // ibLearnLevel
            // 
            this.ibLearnLevel.IntegerValue = ((long)(1));
            this.ibLearnLevel.Location = new System.Drawing.Point(210, 74);
            this.ibLearnLevel.MaxValue = ((long)(125));
            this.ibLearnLevel.MinValue = ((long)(1));
            this.ibLearnLevel.Name = "ibLearnLevel";
            this.ibLearnLevel.Signed = false;
            this.ibLearnLevel.Size = new System.Drawing.Size(25, 22);
            this.ibLearnLevel.TabIndex = 16;
            this.ibLearnLevel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edit_KeyPress);
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(22, 337);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(142, 23);
            this.label14.TabIndex = 19;
            this.label14.Text = "Effect Description:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(22, 289);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(142, 23);
            this.label15.TabIndex = 20;
            this.label15.Text = "Level Description:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(17, 385);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(131, 23);
            this.label16.TabIndex = 21;
            this.label16.Text = "Explain Filename:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtDescr
            // 
            this.txtDescr.Location = new System.Drawing.Point(17, 315);
            this.txtDescr.MaxLength = 128;
            this.txtDescr.Name = "txtDescr";
            this.txtDescr.Size = new System.Drawing.Size(631, 22);
            this.txtDescr.TabIndex = 22;
            this.txtDescr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edit_KeyPress);
            // 
            // txtEffectDescr
            // 
            this.txtEffectDescr.Location = new System.Drawing.Point(18, 363);
            this.txtEffectDescr.MaxLength = 128;
            this.txtEffectDescr.Name = "txtEffectDescr";
            this.txtEffectDescr.Size = new System.Drawing.Size(631, 22);
            this.txtEffectDescr.TabIndex = 23;
            this.txtEffectDescr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edit_KeyPress);
            // 
            // txtExplainFile
            // 
            this.txtExplainFile.Location = new System.Drawing.Point(17, 411);
            this.txtExplainFile.MaxLength = 128;
            this.txtExplainFile.Name = "txtExplainFile";
            this.txtExplainFile.Size = new System.Drawing.Size(631, 22);
            this.txtExplainFile.TabIndex = 24;
            this.txtExplainFile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edit_KeyPress);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnCancel.FlatAppearance.BorderSize = 2;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(560, 451);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 30);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnOK.FlatAppearance.BorderSize = 2;
            this.btnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Location = new System.Drawing.Point(456, 451);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(89, 30);
            this.btnOK.TabIndex = 25;
            this.btnOK.Text = "Commit";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(19, 14);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(146, 23);
            this.label17.TabIndex = 28;
            this.label17.Text = "Select Skill Level:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLvlAvailable
            // 
            this.txtLvlAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLvlAvailable.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtLvlAvailable.Location = new System.Drawing.Point(229, 14);
            this.txtLvlAvailable.Name = "txtLvlAvailable";
            this.txtLvlAvailable.Size = new System.Drawing.Size(405, 23);
            this.txtLvlAvailable.TabIndex = 29;
            this.txtLvlAvailable.Text = "Skill Level Available";
            this.txtLvlAvailable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(487, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 29);
            this.label12.TabIndex = 19;
            this.label12.Text = "4";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ibParam1
            // 
            this.ibParam1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibParam1.IntegerValue = ((long)(0));
            this.ibParam1.Location = new System.Drawing.Point(7, 32);
            this.ibParam1.MaxValue = ((long)(9223372036854775807));
            this.ibParam1.MinValue = ((long)(0));
            this.ibParam1.Name = "ibParam1";
            this.ibParam1.Signed = false;
            this.ibParam1.Size = new System.Drawing.Size(111, 19);
            this.ibParam1.TabIndex = 20;
            // 
            // SkillLevelEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 493);
            this.Controls.Add(this.txtLvlAvailable);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.nsLevelSelector);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtExplainFile);
            this.Controls.Add(this.txtEffectDescr);
            this.Controls.Add(this.txtDescr);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.ibLearnLevel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ibManaPerSec);
            this.Controls.Add(this.ibCastingMana);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SkillLevelEditor";
            this.Text = "SkillLevelEditor";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nsLevelSelector)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolTip toolTip1;
        private EnhancedControls.IntegerBox ibParam5;
        private EnhancedControls.IntegerBox ibParam4;
        private EnhancedControls.IntegerBox ibParam3;
        private EnhancedControls.IntegerBox ibParam2;
        private EnhancedControls.IntegerBox ibCastingMana;
        private EnhancedControls.IntegerBox ibManaPerSec;
        private EnhancedControls.IntegerBox ibCastTime;
        private EnhancedControls.IntegerBox ibAniTime;
        private EnhancedControls.IntegerBox ibDuration;
        private EnhancedControls.IntegerBox ibCooldown;
        private System.Windows.Forms.GroupBox groupBox2;
        private EnhancedControls.IntegerBox ibLearnLevel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtDescr;
        private System.Windows.Forms.TextBox txtEffectDescr;
        private System.Windows.Forms.TextBox txtExplainFile;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.NumericUpDown nsLevelSelector;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label txtLvlAvailable;
        private EnhancedControls.IntegerBox ibParam1;
        private System.Windows.Forms.Label label12;
    }
}