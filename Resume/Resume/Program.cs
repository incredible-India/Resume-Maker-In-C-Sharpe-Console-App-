using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicFuctions; // all the basic function are defined in tis namespace..
using Datavalidator;// this namspace contain the collection of validators..


namespace Resume
{



    class Program
    {

       
       

        //this method will taje the information of user..
        public static void takeUserInfo()
        {

            //creating a dictionary to store the user information....
            dynamic userinfo = new Dictionary<string, string>();
            string temp;
            string returnTypeOfValidator;
            
            string [] userOPT = {"First Name","Middle Name","Last Name","Address","Phone","Skills","College"};
       
            Console.ReadLine();
            for (int i = 0; i < userOPT.Length; i++)
			{
                enterAgain:
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.SetCursorPosition(40, 12);  
                Console.Write($"{i+1} : Enter Your {userOPT[i]}");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.SetCursorPosition(40, 14);
                temp = Console.ReadLine();
                returnTypeOfValidator= CheckTheUserInfoValidation.CheckData(data:temp,ilength:3);
                
                if (returnTypeOfValidator == "ok")
                {
                    userinfo.Add(userOPT[i],temp);
                    continue;
                }else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.SetCursorPosition(40, 15);
                    Console.Write($"Error : {returnTypeOfValidator}");
                    Console.SetCursorPosition(40,16);
                    
                    Console.Write("Press Any Key to Enter Again");
                    Console.ReadLine();
                    goto enterAgain;
                    
                }


			}
               
            


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
            TakeAgain: 
                Console.SetCursorPosition(40, 18);
                userChoice =  Char.Parse(Console.ReadLine());
         
            try
            {
            

                if (userChoice == '1')
                {

                    Program.takeUserInfo();


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


            
            Console.ReadLine();

        }
    }
}
