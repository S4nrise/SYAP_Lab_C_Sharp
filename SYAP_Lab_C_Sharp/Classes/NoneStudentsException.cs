using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SYAP_Lab_C_Sharp.Classes
{
    class NoneStudentsException : Exception
    {
        public NoneStudentsException()
        {
        }

        public NoneStudentsException(string message) : base(message)
        {
        }

        public NoneStudentsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NoneStudentsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
