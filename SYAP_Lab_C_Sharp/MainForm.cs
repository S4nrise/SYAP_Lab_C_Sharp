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
using SYAP_Lab_C_Sharp.Iterator;
using System.Runtime.Serialization.Formatters.Binary;

namespace SYAP_Lab_C_Sharp
{    
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            StudentListViewSet();
            students = new Students();
            SelectSearchFieldComboBox.SelectedIndex = 0;
        }
        
        private Students students;
        int curStud = -1;
        string fileName = string.Empty;

        //Кнопка Открыть
        private void OpenMainFormToolStripMenuItem_Click(object sender, EventArgs e)       
        {
            openFileDialog.Filter = "Файлы xml (*.xml) | *.xml";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog.FileName;
                var fStream = new FileStream(openFileDialog.FileName, FileMode.Open,FileAccess.Read);
                //var xmls = new XmlSerializer(typeof(List<Student>));
                var bnFormater = new BinaryFormatter();
                var temp = (Students)bnFormater.Deserialize(fStream);
                //var temp = (List<Student>)xmls.Deserialize(fStream);
                foreach (var st in temp)
                    students.Add(st);
                //listView.Items.Add(openFileDialog.SafeFileName.Substring(0, openFileDialog.SafeFileName.Length - 4));
                UpdateStudentListView();
                SearchBar.Enabled = true;
                fStream.Close();
            } 
        }

        //Кнопка сохранить
        private void SaveMainFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Если ничего нет, то вызвать сохранить как
            if (fileName == string.Empty)
            {
                SaveAsMainFormToolStripMenuItem_Click(sender, e);
                return;
            }

            if (MessageBox.Show("Вы хотите сохраниться?", "Сохранение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.DefaultExt = ".xml";
                saveFile.Filter = "Файлы xml (*.xml) | *.xml";

                var fSream = new FileStream(fileName, FileMode.Create);
                //var xmls = new XmlSerializer(typeof(List<Student>));
                //xmls.Serialize(fSream, students);
                var bnFormater = new BinaryFormatter();
                bnFormater.Serialize(fSream, students);
                fSream.Close();
            }
            else return;
        }

        //Кнопка Сохранить как...
        private void SaveAsMainFormToolStripMenuItem_Click(object sender, EventArgs e)      
        {
            saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Файлы xml (*.xml) | *.xml";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var fileName = saveFileDialog.FileName;
                var fSream = new FileStream(fileName, FileMode.Create);
                //var xmls = new XmlSerializer(typeof(List<Student>));
                //xmls.Serialize(fSream, students.StudentList);
                var bnFormater = new BinaryFormatter();
                bnFormater.Serialize(fSream, students);
                fSream.Close();
            }
        }

        //Кнопка закрыть лист
        private void CloseMainFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileName = string.Empty;
            SearchBar.Enabled = false;
            students.Clear();
            UpdateStudentListView();
        }

        //Кнопка Бакалавр
        private void BachelorToolStripMenuItem_Click(object sender, EventArgs e)        
        {
            var AddStudent = new AddStudentBachelorForm(Modes.Add);     //Вызываем окошко добавления студента
            if (AddStudent.ShowDialog() == DialogResult.OK)
            {
                students.Add(AddStudent.bachelor);
                SearchBar.Enabled = true;
            }
            UpdateStudentListView();
        }

        //Кнопка Магистр
        private void MasterToolStripMenuItem_Click(object sender, EventArgs e)  
        {
            var AddStudent = new AddStudentMasterForm(Modes.Add);       //Вызываем окошко добавления студента
            if (AddStudent.ShowDialog() == DialogResult.OK)
            {
                students.Add(AddStudent.master);
                SearchBar.Enabled = true;
            }
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
            if (StudentListView.Focused == false) { MessageBox.Show("Выберете студента"); return; }
            else if (SearchBar.Text == string.Empty)
            {
                students.RemoveAt(StudentListView.FocusedItem.Index);
            }
            //else finStud.RemoveAt(StudentListView.FocusedItem.Index);
            StudentListView.FocusedItem.Remove();
        }

        private void EditStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Редактирование
            if (StudentListView.FocusedItem == null)
            {
                MessageBox.Show("Выберете студента для редактирования");
                return;
            }
            Student temp;
            if (SearchBar.Text == string.Empty)
            {
             temp = students[StudentListView.FocusedItem.Index];
            }
            else temp = finStud[StudentListView.FocusedItem.Index];

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
            if (curStud == -1 || curStud == StudentListView.Items.Count - 1) return;
            else
            {
                ListViewSelect(curStud, false);
                ListViewSelect(curStud + 1, true);
                PreviousStudentButton.Enabled = curStud != 0;
                NextStudentButton.Enabled = curStud != StudentListView.Items.Count - 1;
            }          
        }

        int SearchPrev()
        {
            var finStud = search(0, curStud);
            if (finStud == -1)
                return -1;
            var temp = finStud;
            while (finStud != -1)
            {
                finStud = search(finStud + 1, curStud);
                if (finStud != -1)
                    temp = finStud;
            }
            return temp;
        }

        //Предыдущий студент
        private void PreviousStudentButton_Click(object sender, EventArgs e)
        {
            if (curStud < 1) return;
            else
            {
                ListViewSelect(curStud, false);
                ListViewSelect(curStud - 1, true);
                PreviousStudentButton.Enabled = curStud != 0;
                NextStudentButton.Enabled = curStud != StudentListView.Items.Count - 1;
            }            
        }

        //Подсветка студентов
        void ListViewSelect(int index, bool val)
        {
            StudentListView.Items[index].Focused = val;
            StudentListView.Items[index].Selected = val;
        }

        //Синхронизировать выбранного студента с curStud
        private void StudentListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StudentListView.FocusedItem != null)
                curStud = StudentListView.FocusedItem.Index;
        }

        delegate int SearchStud(int start, int lstLen);
        SearchStud search;

        void Upd(List<Student> finStud)
        {
            StudentListView.Clear();
            if (finStud.Count == 0)
                return;
            foreach (var st in finStud)
            {
                var studtemp = st is Bachelor ? "Бакалавр" : "Магистр";
                StudentListView.Items.Add(new ListViewItem(new[]
                {
                    st.FName,st.SName,st.Age.ToString(),st.Faculty, studtemp
                }));
            }
            //StudentListView.Items.Add(new ListViewItem(new[]
            //    {
            //        students[curStud].FName,
            //        students[curStud].SName,
            //        students[curStud].Age.ToString(),
            //        students[curStud].Faculty,
            //        studtemp
            //    }));
            StudentListViewSet();
        }

        int SBName(int start, int lstLen)
        {
            for (int i = start; i < lstLen; i++)
                if (students[i].FName.Contains(SearchBar.Text))
                    return i;
            return -1;
        }

        int SBSName(int start, int lstLen)
        {
            for (int i = start; i < lstLen; i++)
                if (students[i].SName.Contains(SearchBar.Text))
                    return i;
            return -1;
        }

        int SBFaculty(int start, int lstLen)
        {
            for (int i = start; i < lstLen; i++)
                if (students[i].Faculty.Contains(SearchBar.Text))
                    return i;
            return -1;
        }

        //Поле поиска
            List<Student> finStud=null;//= search(0, students.Count);
        private void SearchBar_TextChanged(object sender, EventArgs e)
        {
            DeleateToolStripMenuItem.Enabled = SearchBar.Text == string.Empty;
            ViewToolStripMenuItem.Enabled = SearchBar.Text == string.Empty;
			NextStudentButton.Enabled = false;
			curStud = -1;
            if (SelectSearchFieldComboBox.Text == "Имя")
                finStud = students.Where(a => a.FName == SearchBar.Text).ToList();
            if (SelectSearchFieldComboBox.Text == "Фамилия")
                finStud = students.Where(a => a.SName == SearchBar.Text).ToList();
            if (SelectSearchFieldComboBox.Text == "Факультет")
                finStud = students.Where(a => a.Faculty == SearchBar.Text).ToList();
            if (SelectSearchFieldComboBox.Text == "Курс")
                finStud = students.Where(a => a.Age == int.Parse(SearchBar.Text)).ToList();
            if (SearchBar.Text == "")
            {
                UpdateStudentListView();
                NextStudentButton.Enabled = PreviousStudentButton.Enabled = false;
            }
            else
            {
                Upd(finStud);
                NextStudentButton.Enabled = search(curStud + 1, students.Count) != -1 && StudentListView.Items.Count>1;
                PreviousStudentButton.Enabled = SearchPrev() != -1;
            }
        }

        private void SelectSearchFieldComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (SelectSearchFieldComboBox.Text)
            {
                case "Имя":
                    search = SBName;
                    break;
                case "Фамилия":
                    search = SBSName;
                    break;
                default:
                    search = SBFaculty;
                    break;
            }
            SearchBar.Text = "";
            SearchBar_TextChanged(sender, e);
        }

        private void NextViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (curStud == -1 || curStud == students.Count - 1) return;
            ListViewSelect(curStud, false);
            ListViewSelect(curStud + 1, true);
        }

        private void PreviousViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (curStud < 1) return;
            ListViewSelect(curStud, false);
            ListViewSelect(curStud - 1, true);
        }
    }
}
