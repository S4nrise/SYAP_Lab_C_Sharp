using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYAP_Lab_C_Sharp.Classes
{
    [Serializable]
    public class Students : IEnumerable<Student>
    {
        private List<Student> StudentList;

        public Students()
        {
            StudentList = new List<Student>();
        }

        public int Count
        {
            get { return StudentList.Count; }
        }

        public void Add(Student student)
        {
            StudentList.Add(student);
        }

        public void RemoveAt(int index)
        {
            StudentList.RemoveAt(index);
        }

        public void Clear()
        {
            StudentList.Clear();
        }

        public IEnumerator<Student> GetEnumerator()
        {
            foreach (var e in StudentList)
                yield return e;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public Student this[int index]
        {
            get { return StudentList[index]; }
            set { StudentList[index] = value; }
        }
    }
}
