/*Name: Alanis Correa Kriener
 Assignment*/
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
            // Welcome message & declaring variables which will be used as a loop condition (if the username/password is valid or not).
            Console.Write("Rotorua Thermal Holiday park - Welcome to the staff login page.\n<<< Create new login >>>\n");
            int checkUser = 2;
            int checkPass = 2;
            
            // First loop will repeat a prompt asking for a username as long as the ValidateUsername method returns a value not equal to 1.
            do
            {
                Console.Write("\nPlease enter a username at least 8 characters long: ");
                string username = Console.ReadLine();

                if (ValidateUsername(username, checkUser) == 1)
                {
                    Console.Write("You have entered a valid username.");
                    // Second loop will repeat an 'enter password' prompt as long as ValidatePass returns a value not equal to 1.
                    do {
                    Console.Write("\n\nPlease enter a password at least 8 characters long: ");
                    string pass = Console.ReadLine();
                    Console.Write("Please enter this password again: ");
                    string pass2 = Console.ReadLine();

                    if (ValidatePass(pass, pass2, checkPass) == 1)
                    {
                            // If the username & password are both valid, the loop conditions are both set to 1 to exit both loops.
                        Console.WriteLine($"\nUsername and Password have been accepted and set.\n\nYour details are as follows...\nUsername: {username}\nPassword: {pass}");
                            checkUser = 1;
                            checkPass = 1;
                        }
                    else if (ValidatePass(pass, pass2, checkPass) == 0)
                    {
                        Console.WriteLine("\nInvalid password.\nPlease check it is more than 8 characters and both entries match.");
                    }
                    } while (checkPass != 1);
                }

                else if (ValidateUsername(username, checkUser) == 0)
                {
                    Console.WriteLine("Your username is invalid. Please check it is more than 8 characters.");
                }
                
            } while (checkUser != 1);
            Console.ReadLine();
        }

        // Method to return a '1' if the length of the username is 8 or more characters.
        static int ValidateUsername(string username, int checkUser)
        {
            if (username.Length >= 8)
            {
                 checkUser = 1;
            }
            if (username.Length < 8)
            {
                 checkUser = 0;
            }
            return checkUser;
        }


        // Method to return a '1' only if both passwords match AND have a length of 8 or more characters.
        static int ValidatePass(string pass, string pass2, int checkPass)
        {
            if (pass == pass2 && pass.Length >= 8)
            {
                checkPass = 1;
            }
            else
            {
                checkPass = 0;
            }
            return checkPass;
        }
                
    }
}
