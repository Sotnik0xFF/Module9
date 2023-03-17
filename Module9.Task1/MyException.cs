using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9.Task1
{
    public class MyException : Exception
    {
        public MyException() : base("MyException default message.")
        {
        }

        public MyException(string message) : base(message)
        {
        }
    }
}
