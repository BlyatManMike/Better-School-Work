using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Klasser;
using System.IO;

namespace Tre_Cases_2._0
{
    public class Password : PasswordClass
    {
        public void PassCheck()
        {
            Console.Clear();
            var PassClear = new PasswordClass();
            string UserLogIn = @"C:\Users\mikchr\Desktop\projects\UserLogIn.txt";
            string Username, Password;
            string[] LogInInfo;
            bool PassLoop = false, PassCheck = false;

            if (!File.Exists(UserLogIn))
            {
                Console.Write("Indtast nyt brugernavn: ");
                Username = Console.ReadLine();

                do
                {
                    Console.Clear();
                    Console.WriteLine("Ny adgangskode kræves\nAdgangskoden skal indeholder mindst 12 tegn, skal\ninderholde både store og små bogstaver,\nskal indeholde mindst 1 speciel symbol og må\nikke have et tal som første eller sidste tegn.");
                    Console.Write("Indtast ny adgangskode: ");
                    Password = Console.ReadLine();

                    PassCheck = PassClear.PCLength(Password);

                    if (PassCheck == true)
                    {
                        PassLoop = true;
                    }

                    PassCheck = PassClear.PCUpperLower(Password);

                    if (PassCheck == true)
                    {
                        PassLoop = true;
                    }

                    PassCheck = PassClear.PCSymbol(Password);

                    if (PassCheck == true)
                    {
                        PassLoop = true;
                    }

                    PassCheck = PassClear.PCNumberEnd(Password);

                    if (PassCheck == true)
                    {
                        PassLoop = true;
                    }

                    PassCheck = PassClear.PCSpace(Password);

                    if (PassCheck == true)
                    {
                        PassLoop = true;
                    }

                    PassCheck = PassClear.PCUserEquate(Password, Username);

                    if (PassCheck == true)
                    {
                        PassLoop = true;
                    }

                    if (PassCheck == false)
                    {
                        Console.WriteLine("Adgangskode er ikke godkendt, prøv igen.");
                        PassLoop = false;
                    }

                } while (PassLoop == false);

                LogInInfo = new string[0].Append(Username).ToArray();
                LogInInfo = LogInInfo.Append(Password).ToArray();
                File.Delete(UserLogIn);
                File.AppendAllLines(UserLogIn, LogInInfo);
                Console.Clear();
            }
            else
            {   
                LogInInfo = File.ReadAllLines(UserLogIn);
                do
                {
                    Console.Clear();
                    Console.Write("Indtast Brugernavn: ");
                    Username = Console.ReadLine();

                    Console.Write("Indtast Adgangskode: ");
                    Password = Console.ReadLine();

                    if (Username != LogInInfo[0] || Password != LogInInfo[1])
                    {
                        Console.Clear();
                        Console.WriteLine("Brugernavn eller Adgangskode er forkert, prøv igen.");
                        Console.ReadKey();
                        PassLoop = true;
                    }
                    else
                    {
                        PassLoop = false;
                    }
                } while (PassLoop == true);
            }
        }
        public void PassChange()
        {
            Console.Clear();
            var PassClear = new PasswordClass();
            string UserLogIn = @"C:\Users\mikchr\Desktop\projects\UserLogIn.txt";
            string Username = "", Password = "";
            string[] LogInInfo = File.ReadAllLines(UserLogIn);
            bool PassLoop = false, PassCheck = false;

            do
            {
                Console.Clear();
                Console.WriteLine("Opret ny adgangskode\n\nAdgangskoden skal:\nIndeholde mindst 12 tegn\nIndeholde både store og små bogstaver\nSkal indeholde mindst 1 speciel symbol\nMå ikke være det samme som brugernavn\nMå ikke have et tal som første eller sidste tegn.");
                Console.WriteLine("Ny adgangskode må ikke være identisk til forrige adgangskode.\n");
                Console.Write("Indtast ny adgangskode: ");
                Password = Console.ReadLine();

                PassCheck = PassClear.PCLength(Password);

                if (PassCheck == true)
                {
                    PassLoop = true;
                }

                PassCheck = PassClear.PCUpperLower(Password);

                if (PassCheck == true)
                {
                    PassLoop = true;
                }

                PassCheck = PassClear.PCSymbol(Password);

                if (PassCheck == true)
                {
                    PassLoop = true;
                }

                PassCheck = PassClear.PCNumberEnd(Password);

                if (PassCheck == true)
                {
                    PassLoop = true;
                }

                PassCheck = PassClear.PCSpace(Password);

                if (PassCheck == true)
                {
                    PassLoop = true;
                }

                PassCheck = PassClear.PCUserEquate(Password, Username);

                if (PassCheck == true)
                {
                    PassLoop = true;
                }

                if (PassCheck == false || Password == LogInInfo[1])
                {
                    Console.Clear();
                    Console.WriteLine("Adgangskode er ikke godkendt, prøv igen.");
                    Console.ReadKey();
                    PassLoop = false;
                }
            }while (PassLoop == false);

            LogInInfo = new string[0].Append(Username).ToArray();
            LogInInfo = LogInInfo.Append(Password).ToArray();
            File.Delete(UserLogIn);
            File.AppendAllLines(UserLogIn, LogInInfo);
            Console.Clear();
        }
    }
}
