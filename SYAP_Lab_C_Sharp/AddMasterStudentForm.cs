using SYAP_Lab_C_Sharp.Classes;
using System;
using System.Windows.Forms;

namespace SYAP_Lab_C_Sharp
{
    public partial class AddStudentMasterForm : Form
    {
        public readonly Master master;
        public AddStudentMasterForm(Modes Mode,Master master=null)
        {
            InitializeComponent();
            if (Mode == Modes.Edit)
            {
                AddButton.Text = "Изменить";
                Text = "Изменить магистра";
                this.master = master;
                FNameTextBox.Text = master.FName;
                SNameTextBox.Text = master.SName;
                SYearTextBox.Text = master.Age.ToString();
                FacultyTextBox.Text = master.Faculty;
                ThemeWorkTextBox.Text = master.ThemeWork;
                NumberTextBox.Text = master.Number.ToString();
            }
            else
            {
                AddButton.Text = "Добавить";
                Text = "Добавить магистра";
                this.master = new Master();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (FNameTextBox.Text == "")
            {
                MessageBox.Show("Введите имя магистра");
                return;
            }
            if (SNameTextBox.Text == "")
            {
                MessageBox.Show("Введите фамилию магистра");
                return;
            }
            if (FacultyTextBox.Text == "")
            {
                MessageBox.Show("Введите факультет магистра");
                return;
            }
            if (SYearTextBox.Text == "" || !int.TryParse(SYearTextBox.Text, out int age))
            {
                MessageBox.Show("Введите корректно возраст магистра");
                return;
            }
            if (ThemeWorkTextBox.Text == "")
            {
                MessageBox.Show("Введите тему работы магистра");
                return;
            }
            if (NumberTextBox.Text == "" || !int.TryParse(NumberTextBox.Text, out int num))
            {
                MessageBox.Show("Введите корректно номер магистра");
                return;
            }
            master.FName = FNameTextBox.Text;
            master.SName = SNameTextBox.Text;
            master.Age = age;
            master.Faculty = FacultyTextBox.Text;
            master.ThemeWork = ThemeWorkTextBox.Text;
            master.Number = num;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
