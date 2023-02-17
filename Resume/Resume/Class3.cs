using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFuctions
{
    class BasicFn
    {
        //this method will show the welcome window to the user First..
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

        //this method will show the menu for the user information for the first time 
        public static void showOption()
        {

            
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(40, 12);
            Console.Write("1 :  Create New Resume");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(40, 14);
            Console.Write("2 :  See Previous Resume");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(40, 16);
            Console.Write("3 :  Exist");


           

            

        }


        //exit function...

        public static void ExitFun()
        {
            Console.SetCursorPosition(40, 12);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Thanku For Visiting Us...");
            
        }


    }
}
