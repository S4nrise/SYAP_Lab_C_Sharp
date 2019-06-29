using SYAP_Lab_C_Sharp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYAP_Lab_C_Sharp.Iterator
{
    interface InterfaceIterator
    {
        Student GetNext();
        Student GetPrev();

        bool IfHasNext();
        bool IfHasPrev();

        Student TakeCurrentStudent();

        void Reset();
    }
}
