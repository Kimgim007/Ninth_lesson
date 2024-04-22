using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninth_lesson.Exceptions
{
    public class WrongLoginException : Exception
    {
        //Тут Ex для Логина 
        public WrongLoginException() { }
        public WrongLoginException(string message) : base(message) { }
        public override string ToString()
        {
            return "Логин не соответствует требованиям";
        }
    }
}
