using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //This is a simple program
            Console.WriteLine("The Tech Academy\nStudent Daily Report");
            Console.WriteLine();

            //Ask for Students Name
            Console.WriteLine("What is your name?");
            string studentName = Console.ReadLine();

            //Asks for student name
            Console.WriteLine("What Course are you on?");
            string courseName = Console.ReadLine();

            //Asks for page number
            Console.WriteLine("What step Number?");
            int stepNumber = Convert.ToInt32(Console.ReadLine());

            //asks if the student needs help
            Console.WriteLine("Do you need help with anything? Please answer \"True\" or \"False\".");
            bool needHelp = Convert.ToBoolean(Console.ReadLine());

            // Ask for positive experiences (string data type, open response)
            Console.Write("Were there any positive experiences you’d like to share? Please give specifics: ");
            string positiveExperiences = Console.ReadLine();

            // Ask for other feedback (string data type, open response)
            Console.Write("Is there any other feedback you’d like to provide? Please be specific: ");
            string feedback = Console.ReadLine();

            // Ask how many hours studied today (decimal data type for precision)
            Console.Write("How many hours did you study today? ");
            decimal studyHours = Convert.ToDecimal(Console.ReadLine());

            // Print the program closing message
            Console.WriteLine();
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
        }
    }
}
