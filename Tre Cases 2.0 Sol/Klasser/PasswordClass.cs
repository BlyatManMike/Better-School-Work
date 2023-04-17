using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasser
{
    public class PasswordClass
    {
        public bool PCLength(string password)
        {
            bool PassCheck = false;
            
            if (password.Length >= 12)
            {
                PassCheck = true;
            }
            
            return PassCheck;
        }
        public bool PCUpperLower(string password)
        {
            bool PassCheck = false;
            
            if (password != password.ToLower() || password != password.ToUpper())
            {
                PassCheck = true;
            }
            return PassCheck;
        }
        public bool PCSymbol(string password)
        {
            bool PassCheck = false;
            foreach (char LetterOrNumber in password)
            { 
                if (char.IsLetterOrDigit(LetterOrNumber))
                {
                    PassCheck = true;
                }
            }
            
            return PassCheck;
        }
        public bool PCNumberEnd(string password)
        {
            bool PassCheck = false;

            if (!char.IsDigit(password[0]) || !char.IsDigit(password.Last()))
            {
                PassCheck = true;
            }
            return PassCheck;
        }
        public bool PCSpace(string password)
        {
            bool PassCheck = false;
            
            if (!password.Contains(" "))
            {
                PassCheck = true;
            }
            return PassCheck;
        }
        public bool PCUserEquate(string password, string user)
        {
            bool PassCheck = false;
            
            if (password.ToLower() != user.ToLower())
            {
                PassCheck = true;
            }
          
            return PassCheck;
        }

    }
}
