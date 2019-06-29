using SYAP_Lab_C_Sharp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYAP_Lab_C_Sharp.Iterator
{
    class SearchFName : Search
    {
        // Имя студента
        string firstName;

        // Конструктор без параметров
        public SearchFName() { }

        // Конструктор с параметрами
        public SearchFName(Students studentList, string firstName)
        {
            this.studentList = studentList;
            this.firstName = firstName;
        }

        // Взять первого студента
        public override Student GetFirst()
        {
            // Пока не дошли до конца
            while (studentList.Count() > countOfFirst)
            {
                // Если нашли элемент, подходящий по условию, выходим из цикла
                if (studentList[countOfFirst].FName == firstName)
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
                if (studentList[countUntilEnd].FName == firstName)
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
                if (studentList[countBeforeStart].FName == firstName)
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
