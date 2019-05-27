using System;
namespace SYAP_Lab_C_Sharp.Classes
{
    [Serializable]
    public class Bachelor:Student
    {
        public int Rating { get; set; }
        public Bachelor() { }
        public Bachelor(string fName, string sName, int age, string faculty, int rating):base(fName,sName,age,faculty)
        {
            Rating = rating;
        }
    }
}
