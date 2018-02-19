using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                for (var i = 0; i < 10; i++)
                {

                    string UserInput = UserRespobse();
                    char[] charArr = UserInput.ToCharArray();
                    Array.Reverse(charArr);
                    string ResultofReverse = new string(charArr);

                    if (UserInput == ResultofReverse)
                    {
                        Console.WriteLine("Your word is a palindrome");
                    }
                    else
                    {
                        if (UserInput == "EXIT")
                        {
                            break;
                        }
                        else
                            Console.WriteLine("Try again or enter exit to exit");
                    }

                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }


        }

        public static string UserRespobse()
        {
            try
            {
                string _userinput;

                Console.WriteLine("Enter any word to check if it is a palindrome");
                _userinput = Console.ReadLine();
                _userinput = _userinput.ToUpper();
                _userinput = _userinput.TrimStart();
                _userinput = _userinput.TrimEnd();

                return _userinput;
            }
            catch (Exception)
            {
                throw;
            }

        }


    }
}
