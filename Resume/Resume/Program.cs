using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Resume
{



    class Program
    {

        //Welcome Window
        public static void Welcome()
        {
            Console.SetCursorPosition(40, 12);
            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write("Welcome To The Resume Maker App.. ");
            Console.SetCursorPosition(40, 14);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Press Any Key To Continue..");

            Console.ReadLine();
        }

        //this method will taje the information of user..
        public static void takeUserInfo()
        {

            //creating a dictionary to store the user information....
            dynamic userinfo = new Dictionary<dynamic, dynamic>();

            Welcome();

          

            


        }
        static void Main(string[] args)
        {
            Program.takeUserInfo();
            Console.ReadLine();

        }
    }
}
