using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    internal class AgeException : Exception
    {
        public AgeException(string message) : base($"Age Exception: {message}")
        {

        }
    }
}
