using SYAP_Lab_C_Sharp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYAP_Lab_C_Sharp.Iterator
{
    class SearchThemeWork : Search
    {
        // Имя студента
        string diploma;

        // Конструктор без параметров
        public SearchThemeWork() { }

        // Конструктор с параметрами
        public SearchThemeWork(Students studentList, string diploma)
        {
            this.studentList = studentList;
            this.diploma = diploma;
        }

        // Взять первого студента
        public override Student GetFirst()
        {
            // Пока не дошли до конца
            while (studentList.Count() > countOfFirst)
            {
                // Если нашли элемент, подходящий по условию, выходим из цикла
                if (studentList[countOfFirst].GetType().ToString() == "SYAP_Lab_C_Sharp.Master")
                    if (((Master)studentList[countOfFirst]).ThemeWork == diploma)
                        break;
                countOfFirst++;
            }

            // Если полностью обошли коллекцию, возвращаем null
            if (studentList.Count() <= countOfFirst)
                return null;
            else
            {
                studentCurrNum = countOfFirst;
                return TakeCurrentStudent();
            }
        }

        // Взять следующего
        public override Student GetNext()
        {
            countUntilEnd = studentCurrNum;
            countUntilEnd++;

            // Пока не дошли до конца
            while (studentList.Count() > countUntilEnd)
            {
                // Если нашли элемент, подходящий по условию, выходим из цикла
                if (studentList[countUntilEnd].GetType().ToString() == "SYAP_Lab_C_Sharp.Master")
                    if (((Master)studentList[countUntilEnd]).ThemeWork == diploma)
                        break;
                countUntilEnd++;
            }

            // Если полностью обошли коллекцию, возвращаем null
            if (studentList.Count() <= countUntilEnd)
                return null;
            else
            {
                studentCurrNum = countUntilEnd++;
                return TakeCurrentStudent();
            }
        }

        public override Student GetPrev()
        {
            countBeforeStart = studentCurrNum;
            countBeforeStart--;

            // Пока не дошли до начала
            while (countBeforeStart >= 0)
            {
                // Если нашли элемент, подходящий по условию, выходим из цикла
                if (studentList[countBeforeStart].GetType().ToString() == "SYAP_Lab_C_Sharp.Master")
                    if (((Master)studentList[countBeforeStart]).ThemeWork == diploma)
                        break;
                countBeforeStart--;
            }

            // Если полностью обошли коллекцию, возвращаем null
            if (countBeforeStart < 0)
                return null;
            else
            {
                studentCurrNum = countBeforeStart--;
                return TakeCurrentStudent();
            }
        }
    }
}
