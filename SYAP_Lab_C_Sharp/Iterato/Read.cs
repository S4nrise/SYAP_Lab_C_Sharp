using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SYAP_Lab_C_Sharp.Classes;

namespace SYAP_Lab_C_Sharp.Iterator
{
    class Read : InterfaceIterator
    {
        // Коллекция со студентами
        protected Students studentList;
        protected int studentCurrNum = 0;

        // Конструктор
        public Read(Students studentList)
        {
            this.studentList = studentList;
        }

        // Переход к следующему студенту
        public Student GetNext()
        {
            studentCurrNum++;
            return TakeCurrentStudent();
        }

        // Переход к предыдущий студенту
        public Student GetPrev()
        {
            studentCurrNum--;
            return TakeCurrentStudent();
        }

        // Проверка, есть ли дальше студенты
        public bool IfHasNext()
        {
            if (studentCurrNum < studentList.Count() - 1)
                return true;
            return false;
        }

        // Проверка, есть ли студенты до
        public bool IfHasPrev()
        {
            if (studentCurrNum >= 1)
                return true;
            throw new Exception("Обращение к предыдущему студенту невозможно!");
        }

        // Берем текущего студента, бросаем исключение, если пытаемся обраться к несуществующему
        public Student TakeCurrentStudent()
        {
            return studentList[studentCurrNum];
        }

        // Меняем информацию о выбранном студенте
        public void ChangeCurrentStudent(Student stud)
        {
            Student currentStud = TakeCurrentStudent();
            currentStud.FName = stud.FName;
            currentStud.SName = stud.SName;
            currentStud.Faculty = stud.Faculty;
            if (stud.GetType().ToString() == "CSharpStudents.Master")
                ((Master)currentStud).ThemeWork = ((Master)stud).ThemeWork;
        }

        // Удаляем выбранного студента
        public Student DeleteCurrentStudent()
        {
            // Удаляем из коллекции
            studentList.RemoveAt(studentCurrNum);

            // Если есть кто-то до, возвращаем его
            if (IfHasPrev())
                return GetPrev();
            else
                // Иначе берем текущего
                if (studentList.Count() > 0)
                return TakeCurrentStudent();
            // Иначе никого не осталось и уходим
            else return null;
        }

        public void Reset()
        {
            studentCurrNum = 0;
        }
    }
}
