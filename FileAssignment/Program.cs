using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            Console.WriteLine("Welcome User. Please Input your name: ");
            user.FirstName = Console.ReadLine();
            Console.WriteLine("Input your Surname: ");
            user.LastName = Console.ReadLine();
            Console.WriteLine($"Dear {user.FirstName} {user.LastName}, please select '1,2 or 3'" +
                $"(Note: 1 is to create a directory, 2 is to delete a directory, " +
                $"3 is to get a count of the total number of files in a directory");
            user.UserOPtion = Console.ReadLine();

            string path = @"C:\Users\Fred Chuks\Documents\C sharp\Solomon Young Academy\New Directory";

            if (user.UserOPtion == "1")
            {
                Console.WriteLine("You have opted to create a new directory");
                if (Directory.Exists(path)) 
                { Console.WriteLine("Already Exists"); }
                else
                {
                    Directory.CreateDirectory(path);
                }
            }
            else if(user.UserOPtion == "2")
            {
                Console.WriteLine("You have opted to delete a directory");
                if (Directory.Exists(path)) 
                { Directory.Delete(path); }
                else
                {
                    Console.WriteLine("Directory doesn't exist");
                }
            }
            else if (user.UserOPtion == "3")
            {
                Console.WriteLine("You have opted to get a count of the total number of files in a directory");
                if (Directory.Exists(path))
                {
                    Directory.GetFileSystemEntries(path);

                }
            }
            else
            {
                Console.WriteLine("You have entered an invalid input");
            }
            

            Console.ReadLine();
        }
    }
}
