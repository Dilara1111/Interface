using System;

namespace Task_12._11._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
    interface IAcccount
    {
        public string PasswordChecker(string password);
        public bool ShowInfo
        {

        }

    }
    class User : IAcccount
    {
        public string Fullame { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        
    }
}
