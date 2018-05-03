namespace RHSkillEditor
{
    partial class Readme
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
            this.readmeBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // readmeBox
            // 
            this.readmeBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.readmeBox.Location = new System.Drawing.Point(0, 0);
            this.readmeBox.Name = "readmeBox";
            this.readmeBox.Size = new System.Drawing.Size(800, 450);
            this.readmeBox.TabIndex = 0;
            this.readmeBox.Text = "";
            // 
            // Readme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.readmeBox);
            this.Name = "Readme";
            this.Text = "Readme";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox readmeBox;
    }
}