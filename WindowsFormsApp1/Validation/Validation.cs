using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Validation
{
    public static class Validation
    {
        public static bool NameValidation(string name)
        {            
            if ((string.IsNullOrEmpty(name) 
                || name.Length < 2) && !((name.Length == 2  || name.Length == 3) && name.EndsWith(".")))
            {
                return false;
            }
            
            return NameEnteringValidation(name);
        }

        public static bool NameEnteringValidation(string name)
        {            
            for (int i = 0; i < name.Length; i++)
            {
                if (name.Length <= 3 
                    && name.Length > 1
                    && i == name.Length - 1
                    && name[i].Equals('.'))
                {
                    return true;
                }
                if (!(char.IsLetter(name, i) 
                    || name[i].Equals('-') 
                    || name[i].Equals('`')))
                {
                    return false;
                }
            }

            return true;
        }

        public static bool BookNameValidation(string name)
        {
            if ((string.IsNullOrEmpty(name)
                || name.Length < 4))
            {
                return false;
            }

            return BookNameEnteringValidation(name);
        }

        public static bool BookNameEnteringValidation(string name)
        {
            for (int i = 0; i < name.Length; i++)
            {
                if (!(char.IsLetter(name, i)
                    || name[i].Equals('-')
                    || name[i].Equals('`')
                    || name[i].Equals(' ')
                    || name[i].Equals('.')
                    || name[i].Equals(',')))
                {
                    return false;
                }
            }

            return true;
        }

        public static bool SurnameValidation(string name)
        {
            if (string.IsNullOrEmpty(name)
                || name.Length < 2)
            {
                return false;
            }

            return SurnameEnteringValidation(name);
        }

        public static bool SurnameEnteringValidation(string name)
        {
            for (int i = 0; i < name.Length; i++)
            {
                if (!(char.IsLetter(name, i)
                    || name[i].Equals('-')
                    || name[i].Equals('`')))
                {
                    return false;
                }
            }

            return true;
        }

        public static bool PatronymicValidation(string name)
        {
            if (string.IsNullOrEmpty(name)
                || name.Length < 3)
            {
                return false;
            }

            return PatronymicEnteringValidation(name);
        }

        public static bool PatronymicEnteringValidation(string name)
        {
            for (int i = 0; i < name.Length; i++)
            {
                if (!(char.IsLetter(name, i)
                    || name[i].Equals('-')
                    || name[i].Equals('`')
                    || name[i].Equals(' ')))
                {
                    return false;
                }
            }

            return true;
        }

        public static bool LanguageValidation(string name)
        {
            if (string.IsNullOrEmpty(name)
                || name.Length < 5)
            {
                return false;
            }

            return LanguageEnteringValidation(name);
        }

        public static bool LanguageEnteringValidation(string name)
        {
            for (int i = 0; i < name.Length; i++)
            {
                if (!(char.IsLetter(name, i)))
                {
                    return false;
                }
            }

            return true;
        }

        public static bool EmailValidation(string email)
        {            
            if (string.IsNullOrEmpty(email))
            {
                return false;
            }

            var dogPartsStr = email.Split('@');
            if (dogPartsStr.Length != 2)
                return false;

            var dotPartsStr = dogPartsStr[1].Split('.');
            if (dotPartsStr.Length != 2)
                return false;

            if (dogPartsStr[0].Length < 5 
                || dogPartsStr[1].Length < 6 
                || dotPartsStr[0].Length < 3 
                || dotPartsStr[1].Length < 2 
                || dotPartsStr[1].Length > 7)
                return false;

            return EmailEnteringValidation(email);
        }

        public static bool EmailEnteringValidation(string email)
        {
            for (int i = 0; i < email.Length; i++)
            {
                if (!(char.IsLetter(email, i)
                    || email[i].Equals('.')
                    || email[i].Equals('@')))
                {
                    return false;
                }
            }

            return true;
        }

        public static bool TelNumberValidation(string telNumber)
        {           
            if (string.IsNullOrEmpty(telNumber) || telNumber.Length != 13 || !telNumber.StartsWith("+380"))
            {
                return false;
            }

            return TelNumberEnteringValidation(telNumber);
        }

        public static bool TelNumberEnteringValidation(string telNumber)
        {
            for (int i = 1; i < telNumber.Length; i++)
            {
                if (!char.IsDigit(telNumber, i))
                    return false;
            }

            return true;
        }
    }
}
