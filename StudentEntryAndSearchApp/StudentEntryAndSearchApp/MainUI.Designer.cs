namespace StudentEntryAndSearchApp
{
    partial class MainUI
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
            this.studentEntryButton = new System.Windows.Forms.Button();
            this.studentSearchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studentEntryButton
            // 
            this.studentEntryButton.Location = new System.Drawing.Point(43, 49);
            this.studentEntryButton.Name = "studentEntryButton";
            this.studentEntryButton.Size = new System.Drawing.Size(129, 92);
            this.studentEntryButton.TabIndex = 0;
            this.studentEntryButton.Text = "Student Entry";
            this.studentEntryButton.UseVisualStyleBackColor = true;
            this.studentEntryButton.Click += new System.EventHandler(this.studentEntryButton_Click);
            // 
            // studentSearchButton
            // 
            this.studentSearchButton.Location = new System.Drawing.Point(250, 49);
            this.studentSearchButton.Name = "studentSearchButton";
            this.studentSearchButton.Size = new System.Drawing.Size(116, 92);
            this.studentSearchButton.TabIndex = 1;
            this.studentSearchButton.Text = "Student Search";
            this.studentSearchButton.UseVisualStyleBackColor = true;
            this.studentSearchButton.Click += new System.EventHandler(this.studentSearchButton_Click);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 281);
            this.Controls.Add(this.studentSearchButton);
            this.Controls.Add(this.studentEntryButton);
            this.Name = "MainUI";
            this.Text = "StartUp";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button studentEntryButton;
        private System.Windows.Forms.Button studentSearchButton;
    }
}

