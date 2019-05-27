using System;
namespace SYAP_Lab_C_Sharp.Classes
{
    [Serializable]
    public class Master:Student
    {
        public string ThemeWork;
        public int Number;
        public Master() { }
        public Master(string fName, string sName, int age, string faculty, string themework, int number) : base(fName, sName, age, faculty)
        {
            ThemeWork = themework;
            Number = number;
        }
    }
}
