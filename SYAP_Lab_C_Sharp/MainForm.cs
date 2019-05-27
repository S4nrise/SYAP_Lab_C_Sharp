using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SYAP_Lab_C_Sharp.Classes;
using System.IO;
using System.Xml.Serialization;

namespace SYAP_Lab_C_Sharp
{    
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            StudentListViewSet();
            students = new Students();
        }


        //Студенты в коллекции 
        //Счетчик в коллекцию (или патрен)
        //Попытаться разделить на б/л и интерфейс
        //Ex возник в б/л 
        //Отловить в интерфейсе
        Students students;
        int curStud = -1;

        //Кнопка Открыть
        private void OpenMainFormToolStripMenuItem_Click(object sender, EventArgs e)       
        {
            openFileDialog.Filter = "Файлы xml (*.xml) | *.xml";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var fStream = new FileStream(openFileDialog.FileName, FileMode.Open,FileAccess.Read);
                var xmls = new XmlSerializer(typeof(List<Student>));
                students.StudentList = (List<Student>)xmls.Deserialize(fStream); 
                listView.Items.Add(openFileDialog.SafeFileName.Substring(0, openFileDialog.SafeFileName.Length - 4));
                UpdateStudentListView();
                fStream.Close();
            } 
        }

        //Кнопка Сохранить как...
        private void SaveAsMainFormToolStripMenuItem_Click(object sender, EventArgs e)      
        {
            saveFileDialog.Filter = "Файлы xml (*.xml) | *.xml";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var fileName = saveFileDialog.FileName;
                var fSream = new FileStream(fileName, FileMode.Create);
                var xmls = new XmlSerializer(typeof(List<Student>));
                xmls.Serialize(fSream, students.StudentList);  
                fSream.Close();
            }
        }

        //Кнопка Бакалавр
        private void BachelorToolStripMenuItem_Click(object sender, EventArgs e)        
        {
            var AddStudent = new AddStudentBachelorForm(Modes.Add);     //Вызываем окошко добавления студента
            if (AddStudent.ShowDialog() == DialogResult.OK)
                students.Add(AddStudent.bachelor);
            UpdateStudentListView();
        }

        //Кнопка Магистр
        private void MasterToolStripMenuItem_Click(object sender, EventArgs e)  
        {
            var AddStudent = new AddStudentMasterForm(Modes.Add);       //Вызываем окошко добавления студента
            if (AddStudent.ShowDialog() == DialogResult.OK)
                students.Add(AddStudent.master);
            UpdateStudentListView();
        }

        //Обновление листа
        private void UpdateStudentListView()
        {
            StudentListView.Clear();
            foreach (Student stud in students)
            {                
                var studtemp = stud is Bachelor ? "Бакалавр" : "Магистр";
                var LVI = new ListViewItem(new[]
                {
                    stud.FName,
                    stud.SName,
                    stud.Age.ToString(),
                    stud.Faculty,
                    studtemp
                });
                StudentListView.Items.Add(LVI);
            }
            StudentListViewSet();
        }

        //Чтоб название колонок было полным.
        void StudentListViewSet()       
        {
            StudentListView.Columns.Add("Имя");
            StudentListView.Columns.Add("Фамилия");
            StudentListView.Columns.Add("Курс");
            StudentListView.Columns.Add("Факультет");
            StudentListView.Columns.Add("Степень");
            StudentListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            StudentListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        //Удаление студента
        private void DeleateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            students.RemoveAt(StudentListView.FocusedItem.Index);
            StudentListView.FocusedItem.Remove();
        }

        private void EditStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Редактирование
            if (StudentListView.FocusedItem is null)
            {
                MessageBox.Show("Выберете студента для редактирования");
                return;
            }

            var temp = students[StudentListView.FocusedItem.Index];

            if (temp is Bachelor)
            {
                var EditStudent = new AddStudentBachelorForm(Modes.Edit,(Bachelor)temp);     //Вызываем редатирование студента
                if (EditStudent.ShowDialog() == DialogResult.OK) UpdateStudentListView();                
            }
            else if (temp is Master)
            {
                var EditStudent = new AddStudentMasterForm(Modes.Edit,(Master)temp);
                if (EditStudent.ShowDialog() == DialogResult.OK) UpdateStudentListView();               
            }
        }

        //Следующий студент
        private void NextStudentButton_Click(object sender, EventArgs e)
        {
            if (curStud == -1 || curStud == students.Count - 1) return;
            ListViewSelect(curStud, false);
            ListViewSelect(curStud + 1, true);
        }

        //Предыдущий студент
        private void PreviousStudentButton_Click(object sender, EventArgs e)
        {
            if (curStud < 1) return;
            ListViewSelect(curStud, false);
            ListViewSelect(curStud - 1, true);
        }

        //Подсветка студентов
        void ListViewSelect(int index, bool val)
        {
            StudentListView.Items[index].Focused = val;
            StudentListView.Items[index].Selected = val;
        }

        //Кнопка закрыть лист
        private void CloseMainFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            students.Clear();
            listView.Clear();
            UpdateStudentListView();
        }

        //Синхронизировать выбранного студента с curStud
        private void StudentListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StudentListView.FocusedItem != null)
                curStud = StudentListView.FocusedItem.Index;
        }
    }
}
