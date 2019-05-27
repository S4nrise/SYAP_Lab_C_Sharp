using System;
using System.Windows.Forms;

namespace SYAP_Lab_C_Sharp
{
    public enum Modes
    {
        Add,
        Edit
    }
    public partial class AddStudentBachelorForm : Form
    {
        public AddStudentBachelorForm(Modes mode)    //Add - добавить, Edit - редактировать
        {
            InitializeComponent();
            if (mode == Modes.Edit)
            {
                AddButton.Text = "Изменить";
                Text = "Изменить бакалавра";

                FNameTextBox.Text = FName;
                SNameTextBox.Text = SName;
                SYearTextBox.Text = Age.ToString();
                FacultyTextBox.Text = Faculty;
                RatingTextBox.Text = Rating.ToString();
            }
            else
            {
                AddButton.Text = "Добавить";
                Text = "Добавить бакалавра";
            }
        }

        public static string FName;
        public static string SName;
        public static int Age;
        public static string Faculty;
        public static int Rating;

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (FNameTextBox.Text == "")
            {
                MessageBox.Show("Введите имя бакалавра");
                return;
            }
            if (SNameTextBox.Text == "")
            {
                MessageBox.Show("Введите фамилию бакалавра");
                return;
            }
            if (FacultyTextBox.Text == "")
            {
                MessageBox.Show("Введите факультет бакалавра");
                return;
            }
            if (SYearTextBox.Text == "")
            {
                MessageBox.Show("Введите возраст бакалавра");
                return;
            }
            if (RatingTextBox.Text == "")
            {
                MessageBox.Show("Введите рейтинг бакалавра");
                return;
            }
            FName = FNameTextBox.Text;
            SName = SNameTextBox.Text;
            Age = int.Parse(SYearTextBox.Text);
            Faculty = FacultyTextBox.Text;
            Rating = int.Parse(RatingTextBox.Text);

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
