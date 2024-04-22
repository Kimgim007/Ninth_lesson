using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninth_lesson.Exceptions
{
    public class WrongPasswordException:Exception
    {
       //Тут Ex для Пароля
        public WrongPasswordException() { }
        public WrongPasswordException(string message) : base(message) { }
        public override string ToString()
        {
            return "Пароль не соответствует требованиям";
        }
    }
}
