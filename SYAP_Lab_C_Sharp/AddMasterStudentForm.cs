using System;
using System.Windows.Forms;

namespace SYAP_Lab_C_Sharp
{
    public partial class AddStudentMasterForm : Form
    {
        public AddStudentMasterForm(Modes Mode)
        {
            InitializeComponent();
            if (Mode == Modes.Edit)
            {
                AddButton.Text = "Изменить";
                Text = "Изменить магистра";
                FNameTextBox.Text = FName;
                SNameTextBox.Text = SName;
                SYearTextBox.Text = Age.ToString();
                FacultyTextBox.Text = Faculty;
                ThemeWorkTextBox.Text = ThemeWork;
                NumberTextBox.Text = Number.ToString();
            }
            else
            {
                AddButton.Text = "Добавить";
                Text = "Добавить магистра";
            }
        }

        public static string FName;
        public static string SName;
        public static int Age;
        public static string Faculty;
        public static string ThemeWork;
        public static int Number;

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
            if (SYearTextBox.Text == "")
            {
                MessageBox.Show("Введите возраст магистра");
                return;
            }
            if (ThemeWorkTextBox.Text == "")
            {
                MessageBox.Show("Введите тему работы магистра");
                return;
            }
            if (NumberTextBox.Text == "")
            {
                MessageBox.Show("Введите номер магистра");
                return;
            }
            FName = FNameTextBox.Text;
            SName = SNameTextBox.Text;
            Age = int.Parse(SYearTextBox.Text);
            Faculty = FacultyTextBox.Text;
            ThemeWork = ThemeWorkTextBox.Text;
            Number = int.Parse(NumberTextBox.Text);

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
