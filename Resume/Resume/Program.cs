using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicFuctions; // all the basic function are defined in tis namespace..


namespace Resume
{



    class Program
    {

       
       

        //this method will taje the information of user..
        public static void takeUserInfo()
        {

            //creating a dictionary to store the user information....
            dynamic userinfo = new Dictionary<dynamic, dynamic>();
            

          

            


        }
        static void Main(string[] args)
        {

            char userChoice;


            //Show the Welcome Window
            Console.Clear();
            BasicFn.Welcome();
            //now show the ption to the user 
            Console.Clear();
            BasicFn.showOption();

         
            try
            {
            TakeAgain:
                Console.SetCursorPosition(40, 18);
                userChoice =  Char.Parse(Console.ReadLine());

                if (userChoice == '1')
                {

                }else if(userChoice == '2')
                {
                    
                }else if(userChoice == '3')
                {
                    Console.Clear();
                    BasicFn.ExitFun();

                }else
                {
                    Console.WriteLine("\a");
                    //in case if user dont enter the expected input;
                    goto TakeAgain;
                }

            }
            catch
            {

            }


            Program.takeUserInfo();
            Console.ReadLine();

        }
    }
}
