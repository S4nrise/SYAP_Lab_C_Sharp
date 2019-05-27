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
        }


        //Студенты в коллекции 
        //Счетчик в коллекцию (или патрен)
        //Попытаться разделить на б/л и интерфейс
        //Ex возник в б/л 
        //Отловить в интерфейсе
        List<Student> StudentList = new List<Student>();
        int curStud = -1;

        //Кнопка Открыть
        private void OpenMainFormToolStripMenuItem_Click(object sender, EventArgs e)       
        {
            openFileDialog.Filter = "Файлы xml (*.xml) | *.xml";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var fStream = new FileStream(openFileDialog.FileName, FileMode.Open,FileAccess.Read);
                var xmls = new XmlSerializer(typeof(List<Student>));
                StudentList = (List<Student>)xmls.Deserialize(fStream); 
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
                xmls.Serialize(fSream, StudentList);  
                fSream.Close();
            }
        }

        //Кнопка Бакалавр
        private void BachelorToolStripMenuItem_Click(object sender, EventArgs e)        
        {
            Form AddStudent = new AddStudentBachelorForm(Modes.Add);     //Вызываем окошко добавления студента
            if (AddStudent.ShowDialog() == DialogResult.OK)     
                StudentList.Add(new Bachelor(
                    AddStudentBachelorForm.FName,
                    AddStudentBachelorForm.SName,
                    AddStudentBachelorForm.Age,
                    AddStudentBachelorForm.Faculty,
                    AddStudentBachelorForm.Rating));
            UpdateStudentListView();
        }

        //Кнопка Магистр
        private void MasterToolStripMenuItem_Click(object sender, EventArgs e)  
        {
            Form AddStudent = new AddStudentMasterForm(Modes.Add);       //Вызываем окошко добавления студента
            if (AddStudent.ShowDialog() == DialogResult.OK)
                StudentList.Add(new Master(
                    AddStudentMasterForm.FName,
                    AddStudentMasterForm.SName,
                    AddStudentMasterForm.Age,
                    AddStudentMasterForm.Faculty,
                    AddStudentMasterForm.ThemeWork,
                    AddStudentMasterForm.Number));
            UpdateStudentListView();
        }

        //Обновление листа
        private void UpdateStudentListView()
        {
            StudentListView.Clear();
            foreach (Student stud in StudentList)
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
            StudentList.RemoveAt(StudentListView.FocusedItem.Index);
            StudentListView.FocusedItem.Remove();
        }

        private void EditStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Редактирование
            if (StudentListView.Focused==true) 
                {
                var temp = StudentList[StudentListView.FocusedItem.Index];
                
                if (temp is Bachelor)
                {
                    Bachelor sur = (Bachelor)temp;
                    AddStudentBachelorForm.FName = sur.FName;
                    AddStudentBachelorForm.SName = sur.SName;
                    AddStudentBachelorForm.Age = sur.Age;
                    AddStudentBachelorForm.Faculty = sur.Faculty;
                    AddStudentBachelorForm.Rating = sur.Rating;

                    Form EditStudent = new AddStudentBachelorForm(Modes.Edit);     //Вызываем редатирование студента
                    if (EditStudent.ShowDialog() == DialogResult.OK)
                    {
                        sur.FName = AddStudentBachelorForm.FName;
                        sur.SName = AddStudentBachelorForm.SName;
                        sur.Age = AddStudentBachelorForm.Age;
                        sur.Faculty = AddStudentBachelorForm.Faculty;
                        sur.Rating = AddStudentBachelorForm.Rating;
                        UpdateStudentListView();
                    }
                }
                else if (temp is Master)
                {
                    Master sur = (Master)temp;
                    AddStudentMasterForm.FName = sur.FName;
                    AddStudentMasterForm.SName = sur.SName;
                    AddStudentMasterForm.Age = sur.Age;
                    AddStudentMasterForm.Faculty = sur.Faculty;
                    AddStudentMasterForm.ThemeWork = sur.ThemeWork;
                    AddStudentMasterForm.Number = sur.Number;

                    Form EditStudent = new AddStudentMasterForm(Modes.Edit);
                    if (EditStudent.ShowDialog() == DialogResult.OK)
                    {
                        sur.FName = AddStudentMasterForm.FName;
                        sur.SName = AddStudentMasterForm.SName;
                        sur.Age = AddStudentMasterForm.Age;
                        sur.Faculty = AddStudentMasterForm.Faculty;
                        sur.ThemeWork = AddStudentMasterForm.ThemeWork;
                        sur.Number = AddStudentMasterForm.Number;
                        UpdateStudentListView();
                    }
                }
            }
            else MessageBox.Show ("Выберете студента для редактирования");
        }

        //Следующий студент
        private void NextStudentButton_Click(object sender, EventArgs e)
        {
            curStud++;
            if (curStud >= 0 && curStud < StudentList.Count)
            {
                StudentListView.Items[curStud].Focused = true;
                StudentListView.Select();
            }
            if (curStud > StudentList.Count) curStud--;
        }

        //Предыдущий студент
        private void PreviousStudentButton_Click(object sender, EventArgs e)
        {
            if (curStud < -1) return;
            curStud--;
            if (curStud < 0) curStud = 0;
            if (curStud >= 0 && curStud <= StudentList.Count)
            {
                StudentListView.Items[curStud].Focused = true;
                StudentListView.Select();
            }
        }

        //Кнопка закрыть лист
        private void CloseMainFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentList.Clear();
            listView.Clear();
            UpdateStudentListView();
        }

        //Синхронизировать выбранного студента с curStud
        private void StudentListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            curStud = StudentListView.FocusedItem.Index;
        }
    }
}
