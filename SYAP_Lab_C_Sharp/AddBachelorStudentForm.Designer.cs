namespace SYAP_Lab_C_Sharp
{
    partial class AddStudentBachelorForm
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
            this.FNameTextBox = new System.Windows.Forms.TextBox();
            this.SNameTextBox = new System.Windows.Forms.TextBox();
            this.FacultyTextBox = new System.Windows.Forms.TextBox();
            this.SYearTextBox = new System.Windows.Forms.TextBox();
            this.FNameLabel = new System.Windows.Forms.Label();
            this.SNameLabel = new System.Windows.Forms.Label();
            this.SYearLabel = new System.Windows.Forms.Label();
            this.FacultyLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.RatingLabel = new System.Windows.Forms.Label();
            this.RatingTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FNameTextBox
            // 
            this.FNameTextBox.Location = new System.Drawing.Point(133, 12);
            this.FNameTextBox.Name = "FNameTextBox";
            this.FNameTextBox.Size = new System.Drawing.Size(160, 20);
            this.FNameTextBox.TabIndex = 0;
            // 
            // SNameTextBox
            // 
            this.SNameTextBox.Location = new System.Drawing.Point(133, 38);
            this.SNameTextBox.Name = "SNameTextBox";
            this.SNameTextBox.Size = new System.Drawing.Size(160, 20);
            this.SNameTextBox.TabIndex = 1;
            // 
            // FacultyTextBox
            // 
            this.FacultyTextBox.Location = new System.Drawing.Point(133, 90);
            this.FacultyTextBox.Name = "FacultyTextBox";
            this.FacultyTextBox.Size = new System.Drawing.Size(160, 20);
            this.FacultyTextBox.TabIndex = 2;
            // 
            // SYearTextBox
            // 
            this.SYearTextBox.Location = new System.Drawing.Point(133, 64);
            this.SYearTextBox.Name = "SYearTextBox";
            this.SYearTextBox.Size = new System.Drawing.Size(160, 20);
            this.SYearTextBox.TabIndex = 3;
            // 
            // FNameLabel
            // 
            this.FNameLabel.AutoSize = true;
            this.FNameLabel.Location = new System.Drawing.Point(50, 18);
            this.FNameLabel.Name = "FNameLabel";
            this.FNameLabel.Size = new System.Drawing.Size(29, 13);
            this.FNameLabel.TabIndex = 4;
            this.FNameLabel.Text = "Имя";
            // 
            // SNameLabel
            // 
            this.SNameLabel.AutoSize = true;
            this.SNameLabel.Location = new System.Drawing.Point(50, 41);
            this.SNameLabel.Name = "SNameLabel";
            this.SNameLabel.Size = new System.Drawing.Size(56, 13);
            this.SNameLabel.TabIndex = 5;
            this.SNameLabel.Text = "Фамилия";
            // 
            // SYearLabel
            // 
            this.SYearLabel.AutoSize = true;
            this.SYearLabel.Location = new System.Drawing.Point(50, 67);
            this.SYearLabel.Name = "SYearLabel";
            this.SYearLabel.Size = new System.Drawing.Size(31, 13);
            this.SYearLabel.TabIndex = 6;
            this.SYearLabel.Text = "Курс";
            // 
            // FacultyLabel
            // 
            this.FacultyLabel.AutoSize = true;
            this.FacultyLabel.Location = new System.Drawing.Point(50, 93);
            this.FacultyLabel.Name = "FacultyLabel";
            this.FacultyLabel.Size = new System.Drawing.Size(63, 13);
            this.FacultyLabel.TabIndex = 7;
            this.FacultyLabel.Text = "Факультет";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(133, 143);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RatingLabel
            // 
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.Location = new System.Drawing.Point(50, 120);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(48, 13);
            this.RatingLabel.TabIndex = 9;
            this.RatingLabel.Text = "Рейтинг";
            // 
            // RatingTextBox
            // 
            this.RatingTextBox.Location = new System.Drawing.Point(133, 117);
            this.RatingTextBox.Name = "RatingTextBox";
            this.RatingTextBox.Size = new System.Drawing.Size(160, 20);
            this.RatingTextBox.TabIndex = 10;
            // 
            // AddStudentBachelorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 186);
            this.Controls.Add(this.RatingTextBox);
            this.Controls.Add(this.RatingLabel);
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
            this.Name = "AddStudentBachelorForm";
            this.Text = "Добавить бакалавра";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FNameTextBox;
        private System.Windows.Forms.TextBox SNameTextBox;
        private System.Windows.Forms.TextBox FacultyTextBox;
        private System.Windows.Forms.TextBox SYearTextBox;
        private System.Windows.Forms.Label FNameLabel;
        private System.Windows.Forms.Label SNameLabel;
        private System.Windows.Forms.Label SYearLabel;
        private System.Windows.Forms.Label FacultyLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label RatingLabel;
        private System.Windows.Forms.TextBox RatingTextBox;
    }
}