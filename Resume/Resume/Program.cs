using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicFuctions; // all the basic function are defined in this namespace..
using Datavalidator;// this namspace contain the collection of validators..
using UserInformation;//user class where all the user related information is stored..


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
            
            string [] userOPT = {"First Name","Middle Name","Last Name","Email","Address","Phone","Skills","College"};
       
            //taking the user information...
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

          

            //we have took the useronfo, Now we have to save this information in class of UserInformation define in class1 namespace
            //saving userinformation in UserInformation

            User user =  new User();//class of the user 
            //saving the user information..
            user.SetUserinformation(fname:userinfo["First Name"],
                mname:userinfo["Middle Name"],lname:userinfo["Last Name"],
                address:userinfo["Address"],
                phone:userinfo["Phone"],college:userinfo["College"],
                skills:userinfo["Skills"],email:userinfo["Email"]);
            
            //showing the entered data to the user for the confirmation;

            user.showUserConfirmation();

            
        /*    foreach (KeyValuePair<string,string> entry in userinfo)
        {
               

        Console.WriteLine($"{entry.Key}: {entry.Value}");
        }*/

           
               
            


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
