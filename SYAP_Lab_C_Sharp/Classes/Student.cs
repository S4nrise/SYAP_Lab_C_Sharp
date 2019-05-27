using System;
using System.Xml.Serialization;

namespace SYAP_Lab_C_Sharp.Classes
{
    [XmlInclude(typeof(Bachelor))]
    [XmlInclude(typeof(Master))]
    [Serializable]
    public abstract class Student
    {
        public string FName; //Обозначем поле Имя
        public string SName; //Обозначаем поле Фамилия
        public int Age;
        public string Faculty;

        public Student() { }    //Пустой конструктор для XML

        public Student(string fName, string sName, int age, string faculty)
        {
            FName = fName;
            SName = sName;
            Age = age;
            Faculty = faculty;
        }
    }
}
