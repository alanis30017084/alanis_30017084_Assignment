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
            Console.Write("<<< Create new login >>>\n");
            int checkuser = 2;
            int checkpass = 2;
            
            do
            {
                Console.Write("\nPlease enter a username at least 8 characters long: ");
                string username = Console.ReadLine();

                if (ValidateUsername(username, checkuser) == 1)
                {
                    Console.Write("You have entered a valid username.");
                    do {
                    Console.Write("\n\nPlease enter a password at least 8 characters long: ");
                    string pass = Console.ReadLine();
                    Console.Write("Please enter this password again: ");
                    string pass2 = Console.ReadLine();

                    if (ValidatePass(pass, pass2, checkpass) == 1)
                    {
                        Console.WriteLine($"\nUsername and Password have been accepted and set.\n\nYour details are as follows...\nUsername: {username}\nPassword: {pass}");
                            checkuser = 1;
                            checkpass = 1;
                        }
                    else if (ValidatePass(pass, pass2, checkpass) == 0)
                    {
                        Console.WriteLine("\nInvalid password.\nPlease check it is more than 8 characters and both entries match.");
                    }
                    } while (checkpass != 1);
                }

                else if (ValidateUsername(username, checkuser) == 0)
                {
                    Console.WriteLine("Your username is invalid. Please check it is more than 8 characters.");
                }
                
            } while (checkuser != 1);
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

        static int ValidatePass(string pass, string pass2, int checkpass)
        {
            if (pass == pass2 && pass.Length >= 8)
            {
                checkpass = 1;
            }
            else
            {
                checkpass = 0;
            }
            return checkpass;
        }
                
    }
}
