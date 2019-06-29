namespace SYAP_Lab_C_Sharp
{
    partial class AddStudentMasterForm
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
            this.ThemeWorkTextBox = new System.Windows.Forms.TextBox();
            this.ThemeWorkLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.FacultyLabel = new System.Windows.Forms.Label();
            this.SYearLabel = new System.Windows.Forms.Label();
            this.SNameLabel = new System.Windows.Forms.Label();
            this.FNameLabel = new System.Windows.Forms.Label();
            this.SYearTextBox = new System.Windows.Forms.TextBox();
            this.FacultyTextBox = new System.Windows.Forms.TextBox();
            this.SNameTextBox = new System.Windows.Forms.TextBox();
            this.FNameTextBox = new System.Windows.Forms.TextBox();
            this.NumberLabel = new System.Windows.Forms.Label();
            this.NumberTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ThemeWorkTextBox
            // 
            this.ThemeWorkTextBox.Location = new System.Drawing.Point(125, 117);
            this.ThemeWorkTextBox.Name = "ThemeWorkTextBox";
            this.ThemeWorkTextBox.Size = new System.Drawing.Size(160, 20);
            this.ThemeWorkTextBox.TabIndex = 4;
            // 
            // ThemeWorkLabel
            // 
            this.ThemeWorkLabel.AutoSize = true;
            this.ThemeWorkLabel.Location = new System.Drawing.Point(42, 120);
            this.ThemeWorkLabel.Name = "ThemeWorkLabel";
            this.ThemeWorkLabel.Size = new System.Drawing.Size(74, 13);
            this.ThemeWorkLabel.TabIndex = 20;
            this.ThemeWorkLabel.Text = "Тема работы";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(125, 186);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // FacultyLabel
            // 
            this.FacultyLabel.AutoSize = true;
            this.FacultyLabel.Location = new System.Drawing.Point(42, 93);
            this.FacultyLabel.Name = "FacultyLabel";
            this.FacultyLabel.Size = new System.Drawing.Size(63, 13);
            this.FacultyLabel.TabIndex = 18;
            this.FacultyLabel.Text = "Факультет";
            // 
            // SYearLabel
            // 
            this.SYearLabel.AutoSize = true;
            this.SYearLabel.Location = new System.Drawing.Point(42, 67);
            this.SYearLabel.Name = "SYearLabel";
            this.SYearLabel.Size = new System.Drawing.Size(31, 13);
            this.SYearLabel.TabIndex = 17;
            this.SYearLabel.Text = "Курс";
            // 
            // SNameLabel
            // 
            this.SNameLabel.AutoSize = true;
            this.SNameLabel.Location = new System.Drawing.Point(42, 41);
            this.SNameLabel.Name = "SNameLabel";
            this.SNameLabel.Size = new System.Drawing.Size(56, 13);
            this.SNameLabel.TabIndex = 16;
            this.SNameLabel.Text = "Фамилия";
            // 
            // FNameLabel
            // 
            this.FNameLabel.AutoSize = true;
            this.FNameLabel.Location = new System.Drawing.Point(42, 18);
            this.FNameLabel.Name = "FNameLabel";
            this.FNameLabel.Size = new System.Drawing.Size(29, 13);
            this.FNameLabel.TabIndex = 15;
            this.FNameLabel.Text = "Имя";
            // 
            // SYearTextBox
            // 
            this.SYearTextBox.Location = new System.Drawing.Point(125, 64);
            this.SYearTextBox.Name = "SYearTextBox";
            this.SYearTextBox.Size = new System.Drawing.Size(160, 20);
            this.SYearTextBox.TabIndex = 2;
            // 
            // FacultyTextBox
            // 
            this.FacultyTextBox.Location = new System.Drawing.Point(125, 90);
            this.FacultyTextBox.Name = "FacultyTextBox";
            this.FacultyTextBox.Size = new System.Drawing.Size(160, 20);
            this.FacultyTextBox.TabIndex = 3;
            // 
            // SNameTextBox
            // 
            this.SNameTextBox.Location = new System.Drawing.Point(125, 38);
            this.SNameTextBox.Name = "SNameTextBox";
            this.SNameTextBox.Size = new System.Drawing.Size(160, 20);
            this.SNameTextBox.TabIndex = 1;
            // 
            // FNameTextBox
            // 
            this.FNameTextBox.Location = new System.Drawing.Point(125, 12);
            this.FNameTextBox.Name = "FNameTextBox";
            this.FNameTextBox.Size = new System.Drawing.Size(160, 20);
            this.FNameTextBox.TabIndex = 0;
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Location = new System.Drawing.Point(42, 147);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(41, 13);
            this.NumberLabel.TabIndex = 22;
            this.NumberLabel.Text = "Номер";
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.Location = new System.Drawing.Point(125, 144);
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.Size = new System.Drawing.Size(160, 20);
            this.NumberTextBox.TabIndex = 5;
            // 
            // AddStudentMasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 232);
            this.Controls.Add(this.NumberTextBox);
            this.Controls.Add(this.NumberLabel);
            this.Controls.Add(this.ThemeWorkTextBox);
            this.Controls.Add(this.ThemeWorkLabel);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.FacultyLabel);
            this.Controls.Add(this.SYearLabel);
            this.Controls.Add(this.SNameLabel);
            this.Controls.Add(this.FNameLabel);
            this.Controls.Add(this.SYearTextBox);
            this.Controls.Add(this.FacultyTextBox);
            this.Controls.Add(this.SNameTextBox);
            this.Controls.Add(this.FNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddStudentMasterForm";
            this.Text = "Добавить магистра";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ThemeWorkTextBox;
        private System.Windows.Forms.Label ThemeWorkLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label FacultyLabel;
        private System.Windows.Forms.Label SYearLabel;
        private System.Windows.Forms.Label SNameLabel;
        private System.Windows.Forms.Label FNameLabel;
        private System.Windows.Forms.TextBox SYearTextBox;
        private System.Windows.Forms.TextBox FacultyTextBox;
        private System.Windows.Forms.TextBox SNameTextBox;
        private System.Windows.Forms.TextBox FNameTextBox;
        private System.Windows.Forms.Label NumberLabel;
        private System.Windows.Forms.TextBox NumberTextBox;
    }
}