using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialLesson
{
    internal class User : IAccount
    {
        private string FullName { get; set; }
        private string Email { get; set; }
        public string Password { get; set; }

        public User(string fullName, string email, string password)
        {
            FullName = fullName;
            Email = email;
            Password = password;
        }

        public bool PasswordChecker(string password)
        {
            bool res = false;
            bool res1 = false;
            bool res2 = false;
            bool res3 = false;

            if (password.Length >= 8)
                res = true;
            else
                return false;


            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= 'A' && password[i] <= 'Z')
                {
                    res1 = true;
                    break;
                }
                else
                    res1 = false;
            }

            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= 'a' && password[i] <= 'z')
                {
                    res2 = true;
                    break;
                }
                else
                    res2 = false;
            }

            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= '0' && password[i] <= '9')
                {
                    res3 = true;
                    break;
                }
                else
                    res3 = false;
            }

            return (res && res1 && res2 && res3);
        }

        public void ShowInfo()
        {
            Console.WriteLine($"FullName = {FullName}, Email = {Email}");
        }
    }
}
