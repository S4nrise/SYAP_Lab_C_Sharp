using SYAP_Lab_C_Sharp.Classes;
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
        public readonly Bachelor bachelor;
        public AddStudentBachelorForm(Modes mode,Bachelor bachelor=null)    //Add - добавить, Edit - редактировать
        {
            InitializeComponent();
            if (mode == Modes.Edit)
            {
                AddButton.Text = "Изменить";
                Text = "Изменить бакалавра";
                this.bachelor = bachelor;
                FNameTextBox.Text = bachelor.FName;
                SNameTextBox.Text = bachelor.SName;
                SYearTextBox.Text = bachelor.Age.ToString();
                FacultyTextBox.Text = bachelor.Faculty;
                RatingTextBox.Text = bachelor.Rating.ToString();
            }
            else
            {
                AddButton.Text = "Добавить";
                Text = "Добавить бакалавра";
                this.bachelor = new Bachelor();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
			int age, rat;
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
            if (SYearTextBox.Text == "" || !int.TryParse(SYearTextBox.Text, out age))
            {
                MessageBox.Show("Введите корректно курс бакалавра");
                return;
            }
            if (FacultyTextBox.Text == "")
            {
                MessageBox.Show("Введите факультет бакалавра");
                return;
            }
            if (RatingTextBox.Text == "" || !int.TryParse(RatingTextBox.Text, out rat))
            {
                MessageBox.Show("Введите корректно рейтинг бакалавра");
                return;
            }
            bachelor.FName = FNameTextBox.Text;
            bachelor.SName = SNameTextBox.Text;
            bachelor.Age = age;
            bachelor.Faculty = FacultyTextBox.Text;
            bachelor.Rating = rat;
            
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
