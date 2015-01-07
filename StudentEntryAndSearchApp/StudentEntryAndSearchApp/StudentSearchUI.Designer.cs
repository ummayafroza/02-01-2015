namespace StudentEntryAndSearchApp
{
    partial class StudentSearchUI
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
            this.searchDeptIdButton = new System.Windows.Forms.Button();
            this.searchDeptIdTextBox = new System.Windows.Forms.TextBox();
            this.showAllListBox = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // searchDeptIdButton
            // 
            this.searchDeptIdButton.Location = new System.Drawing.Point(45, 60);
            this.searchDeptIdButton.Name = "searchDeptIdButton";
            this.searchDeptIdButton.Size = new System.Drawing.Size(75, 23);
            this.searchDeptIdButton.TabIndex = 0;
            this.searchDeptIdButton.Text = "Search";
            this.searchDeptIdButton.UseVisualStyleBackColor = true;
            this.searchDeptIdButton.Click += new System.EventHandler(this.searchDeptIdButton_Click);
            // 
            // searchDeptIdTextBox
            // 
            this.searchDeptIdTextBox.Location = new System.Drawing.Point(203, 62);
            this.searchDeptIdTextBox.Name = "searchDeptIdTextBox";
            this.searchDeptIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.searchDeptIdTextBox.TabIndex = 1;
            // 
            // showAllListBox
            // 
            this.showAllListBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.showAllListBox.GridLines = true;
            this.showAllListBox.Location = new System.Drawing.Point(39, 162);
            this.showAllListBox.Name = "showAllListBox";
            this.showAllListBox.Size = new System.Drawing.Size(417, 254);
            this.showAllListBox.TabIndex = 2;
            this.showAllListBox.UseCompatibleStateImageBehavior = false;
            this.showAllListBox.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Student Id";
            this.columnHeader1.Width = 114;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Student Name";
            this.columnHeader2.Width = 104;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Phone";
            this.columnHeader3.Width = 79;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Email";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Dept_Id";
            // 
            // StudentSearchUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 441);
            this.Controls.Add(this.showAllListBox);
            this.Controls.Add(this.searchDeptIdTextBox);
            this.Controls.Add(this.searchDeptIdButton);
            this.Name = "StudentSearchUI";
            this.Text = "Student Search UI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchDeptIdButton;
        private System.Windows.Forms.TextBox searchDeptIdTextBox;
        private System.Windows.Forms.ListView showAllListBox;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}