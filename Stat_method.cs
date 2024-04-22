using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninth_lesson.Exceptions;

namespace Ninth_lesson
{
    //Тут класс со статическим методом 
    public class Stat_method
    {
        public static void Method(string login, string password, string confirmPassword)
        {
            try
            {
                if (login.Length > 20 || login.Contains(" ") == true)
                {
                    throw new WrongLoginException();
                }
                if (password.Length > 20 || password.Contains(" ") == true || password.Any(char.IsDigit) != true || password != confirmPassword)
                {
                    throw new WrongPasswordException();
                }
            }
            catch (WrongLoginException ex)
            {
                Console.WriteLine($"{ex} ");
            }
            catch (WrongPasswordException ex)
            {
                Console.WriteLine($"{ex} ");
            }


        }
    }
}
