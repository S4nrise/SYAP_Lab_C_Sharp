namespace SYAP_Lab_C_Sharp
{
    partial class mainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
			this.FileMainFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.OpenMainFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SaveMainFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SaveAsMainFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.CloseMainFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.PreviousViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.NextViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.StudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AddStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.BachelorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.DeleateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.EditStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.StudentListView = new System.Windows.Forms.ListView();
			this.SearchBar = new System.Windows.Forms.TextBox();
			this.NextStudentButton = new System.Windows.Forms.Button();
			this.PreviousStudentButton = new System.Windows.Forms.Button();
			this.SearchGroupBox = new System.Windows.Forms.GroupBox();
			this.SelectSearchFieldComboBox = new System.Windows.Forms.ComboBox();
			this.StidentListLabel = new System.Windows.Forms.Label();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.mainMenuStrip.SuspendLayout();
			this.SearchGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainMenuStrip
			// 
			this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMainFormToolStripMenuItem,
            this.ViewToolStripMenuItem,
            this.StudentToolStripMenuItem});
			this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.mainMenuStrip.Name = "mainMenuStrip";
			this.mainMenuStrip.Size = new System.Drawing.Size(452, 24);
			this.mainMenuStrip.TabIndex = 0;
			this.mainMenuStrip.Text = "menuStrip1";
			// 
			// FileMainFormToolStripMenuItem
			// 
			this.FileMainFormToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenMainFormToolStripMenuItem,
            this.SaveMainFormToolStripMenuItem,
            this.SaveAsMainFormToolStripMenuItem,
            this.CloseMainFormToolStripMenuItem});
			this.FileMainFormToolStripMenuItem.Name = "FileMainFormToolStripMenuItem";
			this.FileMainFormToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.FileMainFormToolStripMenuItem.Text = "Файл";
			// 
			// OpenMainFormToolStripMenuItem
			// 
			this.OpenMainFormToolStripMenuItem.Name = "OpenMainFormToolStripMenuItem";
			this.OpenMainFormToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
			this.OpenMainFormToolStripMenuItem.Text = "Открыть";
			this.OpenMainFormToolStripMenuItem.Click += new System.EventHandler(this.OpenMainFormToolStripMenuItem_Click);
			// 
			// SaveMainFormToolStripMenuItem
			// 
			this.SaveMainFormToolStripMenuItem.Name = "SaveMainFormToolStripMenuItem";
			this.SaveMainFormToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
			this.SaveMainFormToolStripMenuItem.Text = "Сохранить";
			this.SaveMainFormToolStripMenuItem.Click += new System.EventHandler(this.SaveMainFormToolStripMenuItem_Click);
			// 
			// SaveAsMainFormToolStripMenuItem
			// 
			this.SaveAsMainFormToolStripMenuItem.Name = "SaveAsMainFormToolStripMenuItem";
			this.SaveAsMainFormToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
			this.SaveAsMainFormToolStripMenuItem.Text = "Сохранить как...";
			this.SaveAsMainFormToolStripMenuItem.Click += new System.EventHandler(this.SaveAsMainFormToolStripMenuItem_Click);
			// 
			// CloseMainFormToolStripMenuItem
			// 
			this.CloseMainFormToolStripMenuItem.Name = "CloseMainFormToolStripMenuItem";
			this.CloseMainFormToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
			this.CloseMainFormToolStripMenuItem.Text = "Закрыть";
			this.CloseMainFormToolStripMenuItem.Click += new System.EventHandler(this.CloseMainFormToolStripMenuItem_Click);
			// 
			// ViewToolStripMenuItem
			// 
			this.ViewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PreviousViewToolStripMenuItem,
            this.NextViewToolStripMenuItem});
			this.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem";
			this.ViewToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
			this.ViewToolStripMenuItem.Text = "Просмотр";
			// 
			// PreviousViewToolStripMenuItem
			// 
			this.PreviousViewToolStripMenuItem.Name = "PreviousViewToolStripMenuItem";
			this.PreviousViewToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
			this.PreviousViewToolStripMenuItem.Text = "Предыдущий";
			this.PreviousViewToolStripMenuItem.Click += new System.EventHandler(this.PreviousViewToolStripMenuItem_Click);
			// 
			// NextViewToolStripMenuItem
			// 
			this.NextViewToolStripMenuItem.Name = "NextViewToolStripMenuItem";
			this.NextViewToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
			this.NextViewToolStripMenuItem.Text = "Следующий";
			this.NextViewToolStripMenuItem.Click += new System.EventHandler(this.NextViewToolStripMenuItem_Click);
			// 
			// StudentToolStripMenuItem
			// 
			this.StudentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddStudentToolStripMenuItem,
            this.DeleateToolStripMenuItem,
            this.EditStudentToolStripMenuItem});
			this.StudentToolStripMenuItem.Name = "StudentToolStripMenuItem";
			this.StudentToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
			this.StudentToolStripMenuItem.Text = "Студенты";
			// 
			// AddStudentToolStripMenuItem
			// 
			this.AddStudentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BachelorToolStripMenuItem,
            this.MasterToolStripMenuItem});
			this.AddStudentToolStripMenuItem.Name = "AddStudentToolStripMenuItem";
			this.AddStudentToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
			this.AddStudentToolStripMenuItem.Text = "Добавить";
			// 
			// BachelorToolStripMenuItem
			// 
			this.BachelorToolStripMenuItem.Name = "BachelorToolStripMenuItem";
			this.BachelorToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
			this.BachelorToolStripMenuItem.Text = "Бакалавр";
			this.BachelorToolStripMenuItem.Click += new System.EventHandler(this.BachelorToolStripMenuItem_Click);
			// 
			// MasterToolStripMenuItem
			// 
			this.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem";
			this.MasterToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
			this.MasterToolStripMenuItem.Text = "Магистр";
			this.MasterToolStripMenuItem.Click += new System.EventHandler(this.MasterToolStripMenuItem_Click);
			// 
			// DeleateToolStripMenuItem
			// 
			this.DeleateToolStripMenuItem.Name = "DeleateToolStripMenuItem";
			this.DeleateToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
			this.DeleateToolStripMenuItem.Text = "Удалить";
			this.DeleateToolStripMenuItem.Click += new System.EventHandler(this.DeleateToolStripMenuItem_Click);
			// 
			// EditStudentToolStripMenuItem
			// 
			this.EditStudentToolStripMenuItem.Name = "EditStudentToolStripMenuItem";
			this.EditStudentToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
			this.EditStudentToolStripMenuItem.Text = "Редактировать";
			this.EditStudentToolStripMenuItem.Click += new System.EventHandler(this.EditStudentToolStripMenuItem_Click);
			// 
			// StudentListView
			// 
			this.StudentListView.FullRowSelect = true;
			this.StudentListView.HideSelection = false;
			this.StudentListView.Location = new System.Drawing.Point(18, 167);
			this.StudentListView.Name = "StudentListView";
			this.StudentListView.Size = new System.Drawing.Size(419, 163);
			this.StudentListView.TabIndex = 3;
			this.StudentListView.UseCompatibleStateImageBehavior = false;
			this.StudentListView.View = System.Windows.Forms.View.Details;
			this.StudentListView.SelectedIndexChanged += new System.EventHandler(this.StudentListView_SelectedIndexChanged);
			// 
			// SearchBar
			// 
			this.SearchBar.Enabled = false;
			this.SearchBar.ForeColor = System.Drawing.SystemColors.InactiveCaption;
			this.SearchBar.Location = new System.Drawing.Point(6, 41);
			this.SearchBar.Name = "SearchBar";
			this.SearchBar.Size = new System.Drawing.Size(196, 20);
			this.SearchBar.TabIndex = 4;
			this.SearchBar.Text = "Поиск";
			this.SearchBar.TextChanged += new System.EventHandler(this.SearchBar_TextChanged);
			// 
			// NextStudentButton
			// 
			this.NextStudentButton.Enabled = false;
			this.NextStudentButton.Location = new System.Drawing.Point(112, 67);
			this.NextStudentButton.Name = "NextStudentButton";
			this.NextStudentButton.Size = new System.Drawing.Size(90, 23);
			this.NextStudentButton.TabIndex = 5;
			this.NextStudentButton.Text = "Следующий";
			this.NextStudentButton.UseVisualStyleBackColor = true;
			this.NextStudentButton.Click += new System.EventHandler(this.NextStudentButton_Click);
			// 
			// PreviousStudentButton
			// 
			this.PreviousStudentButton.Enabled = false;
			this.PreviousStudentButton.Location = new System.Drawing.Point(6, 67);
			this.PreviousStudentButton.Name = "PreviousStudentButton";
			this.PreviousStudentButton.Size = new System.Drawing.Size(90, 23);
			this.PreviousStudentButton.TabIndex = 6;
			this.PreviousStudentButton.Text = "Предыдущий";
			this.PreviousStudentButton.UseVisualStyleBackColor = true;
			this.PreviousStudentButton.Click += new System.EventHandler(this.PreviousStudentButton_Click);
			// 
			// SearchGroupBox
			// 
			this.SearchGroupBox.Controls.Add(this.SelectSearchFieldComboBox);
			this.SearchGroupBox.Controls.Add(this.SearchBar);
			this.SearchGroupBox.Controls.Add(this.PreviousStudentButton);
			this.SearchGroupBox.Controls.Add(this.NextStudentButton);
			this.SearchGroupBox.Location = new System.Drawing.Point(112, 27);
			this.SearchGroupBox.Name = "SearchGroupBox";
			this.SearchGroupBox.Size = new System.Drawing.Size(213, 103);
			this.SearchGroupBox.TabIndex = 7;
			this.SearchGroupBox.TabStop = false;
			this.SearchGroupBox.Text = "Поиск";
			// 
			// SelectSearchFieldComboBox
			// 
			this.SelectSearchFieldComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.SelectSearchFieldComboBox.FormattingEnabled = true;
			this.SelectSearchFieldComboBox.Items.AddRange(new object[] {
            "Имя",
            "Фамилия",
            "Факультет"});
			this.SelectSearchFieldComboBox.Location = new System.Drawing.Point(6, 14);
			this.SelectSearchFieldComboBox.Name = "SelectSearchFieldComboBox";
			this.SelectSearchFieldComboBox.Size = new System.Drawing.Size(196, 21);
			this.SelectSearchFieldComboBox.TabIndex = 7;
			this.SelectSearchFieldComboBox.SelectedIndexChanged += new System.EventHandler(this.SelectSearchFieldComboBox_SelectedIndexChanged);
			// 
			// StidentListLabel
			// 
			this.StidentListLabel.AutoSize = true;
			this.StidentListLabel.Location = new System.Drawing.Point(18, 148);
			this.StidentListLabel.Name = "StidentListLabel";
			this.StidentListLabel.Size = new System.Drawing.Size(55, 13);
			this.StidentListLabel.TabIndex = 9;
			this.StidentListLabel.Text = "Студенты";
			// 
			// mainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(452, 379);
			this.Controls.Add(this.StidentListLabel);
			this.Controls.Add(this.SearchGroupBox);
			this.Controls.Add(this.StudentListView);
			this.Controls.Add(this.mainMenuStrip);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MainMenuStrip = this.mainMenuStrip;
			this.MaximizeBox = false;
			this.Name = "mainForm";
			this.Text = "Студенты";
			this.mainMenuStrip.ResumeLayout(false);
			this.mainMenuStrip.PerformLayout();
			this.SearchGroupBox.ResumeLayout(false);
			this.SearchGroupBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileMainFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenMainFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveMainFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseMainFormToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ListView StudentListView;
        private System.Windows.Forms.ToolStripMenuItem ViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PreviousViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NextViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StudentToolStripMenuItem;
        private System.Windows.Forms.TextBox SearchBar;
        private System.Windows.Forms.Button NextStudentButton;
        private System.Windows.Forms.Button PreviousStudentButton;
        private System.Windows.Forms.GroupBox SearchGroupBox;
        private System.Windows.Forms.ToolStripMenuItem AddStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditStudentToolStripMenuItem;
        private System.Windows.Forms.Label StidentListLabel;
        private System.Windows.Forms.ToolStripMenuItem SaveAsMainFormToolStripMenuItem;
        private System.Windows.Forms.ComboBox SelectSearchFieldComboBox;
        private System.Windows.Forms.ToolStripMenuItem BachelorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MasterToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

