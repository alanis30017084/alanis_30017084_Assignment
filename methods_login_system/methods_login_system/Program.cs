using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods_login_system
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("<<< Create new login >>>\n\nPlease enter a username at least 8 characters long: ");
            string username = Console.ReadLine();
            int checkuser = 2;

            if (ValidateUsername(username, checkuser) == 1)
            {
                Console.Write("You have entered a valid username.\nPlease enter a password at least 8 characters long: ");
                string password = Console.ReadLine();
                
            }
            if (ValidateUsername(username, checkuser) == 0)
            {
                Console.WriteLine("This username is less than 8 characters. Please try again.");
            }
            else
            {
                Console.WriteLine("Sorry, that input is invalid. Please try again.");
            }
            Console.ReadLine();
        }

        static int ValidateUsername(string username, int checkuser)
        {
            if (username.Length >= 8)
            {
                 checkuser = 1;
            }
            if (username.Length < 8)
            {
                 checkuser = 0;
            }
            return checkuser;
        }

        
    }
}
