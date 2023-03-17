using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9.Task2
{
    internal class InvalidSorterCodeException : Exception
    {
        public InvalidSorterCodeException(string value) : base($"{value} - недопустимое значение.")
        {
        }
    }
}
