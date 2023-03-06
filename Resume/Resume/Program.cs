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
   
        //editing process

       public static void StartEditing(Dictionary<string, string> userinfo,User user)
        {


                  
                 string returnTypeOfValidator ;
                int count=0;
                int option;
                string EditedData;
               Console.Clear();
                //if user want to edit his information..
                foreach (KeyValuePair<string,string> entry in userinfo)
                 {
                    
                     Console.WriteLine($"Press {++count} To Edit {entry.Key}->{entry.Value}");
                    

                    
                }
                enterdata:
                option = int.Parse(Console.ReadLine());

                    if(option>=1 && option <=8)
                    {
                    if(option == 1)
                    {
                        enterAgain1:
                        Console.Clear();
                        Console.WriteLine("Enter the New Value For : " + "First Name");
                        EditedData = Console.ReadLine();
                        returnTypeOfValidator= CheckTheUserInfoValidation.CheckData(data:EditedData,ilength:3);
                        if(returnTypeOfValidator == "ok")
                        {
                           
                            userinfo["First Name"] = EditedData;
                            user.setSpecificUserInfo(index:1,Value:EditedData);
                        
                            user.showUserConfirmation();
                            
                            ConfirmInfoEdition(userinfo,user);
                            
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.SetCursorPosition(40, 15);
                    Console.Write($"Error : {returnTypeOfValidator}");
                    Console.SetCursorPosition(40,16);
                    
                    Console.Write("Press Any Key to Enter Again");
                    Console.ReadLine();
                    goto enterAgain1;
                        }


                    } else if(option == 2)
                    {
                        enterAgain2:
                        Console.Clear();
                        Console.WriteLine("Enter the New Value For : " + "Middle Name");
                        EditedData = Console.ReadLine();
                        returnTypeOfValidator= CheckTheUserInfoValidation.CheckData(data:EditedData,ilength:3);
                        if(returnTypeOfValidator == "ok")
                        {
                           userinfo["Last Name"] = EditedData;
                            user.setSpecificUserInfo(index:2,Value:EditedData);
                        
                            user.showUserConfirmation();
                            
                            ConfirmInfoEdition(userinfo,user);
                        }
                        else
                        {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.SetCursorPosition(40, 15);
                    Console.Write($"Error : {returnTypeOfValidator}");
                    Console.SetCursorPosition(40,16);
                    
                    Console.Write("Press Any Key to Enter Again");
                    Console.ReadLine();
                    goto enterAgain2;
                        }

                    }else if(option == 3)
                    {
                        enterAgain3:
                        Console.Clear();
                        Console.WriteLine("Enter the New Value For : " + "Last Name");
                        EditedData = Console.ReadLine();
                        returnTypeOfValidator= CheckTheUserInfoValidation.CheckData(data:EditedData,ilength:3);
                        if(returnTypeOfValidator == "ok")
                        {
                        userinfo["Middle Name"] = EditedData;
                            user.setSpecificUserInfo(index:3,Value:EditedData);
                        
                            user.showUserConfirmation();
                            
                            ConfirmInfoEdition(userinfo,user);

                        }
                        else
                        {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.SetCursorPosition(40, 15);
                    Console.Write($"Error : {returnTypeOfValidator}");
                    Console.SetCursorPosition(40,16);
                    
                    Console.Write("Press Any Key to Enter Again");
                    Console.ReadLine();
                    goto enterAgain3;
                        }
                    }

                    else if(option == 4)
                    {
                        enterAgain4:
                        Console.Clear();
                        Console.WriteLine("Enter the New Value For : " + "Email");
                        EditedData = Console.ReadLine();
                        returnTypeOfValidator= CheckTheUserInfoValidation.CheckData(data:EditedData,ilength:3);
                        if(returnTypeOfValidator == "ok")
                        {
                              userinfo["Email"] = EditedData;
                            user.setSpecificUserInfo(index:4,Value:EditedData);
                        
                            user.showUserConfirmation();
                            
                            ConfirmInfoEdition(userinfo,user);

                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.SetCursorPosition(40, 15);
                    Console.Write($"Error : {returnTypeOfValidator}");
                    Console.SetCursorPosition(40,16);
                    
                    Console.Write("Press Any Key to Enter Again");
                    Console.ReadLine();
                    goto enterAgain4;
                        }
                    }
                    else if (option == 5)
                    {
                        enterAgain5:
                        Console.Clear();
                        Console.WriteLine("Enter the New Value For : " + "Address");
                        EditedData = Console.ReadLine();
                        returnTypeOfValidator= CheckTheUserInfoValidation.CheckData(data:EditedData,ilength:3);
                        if(returnTypeOfValidator == "ok")
                        {
                        userinfo["Address"] = EditedData;
                            user.setSpecificUserInfo(index:5,Value:EditedData);
                        
                            user.showUserConfirmation();
                            
                            ConfirmInfoEdition(userinfo,user);

                        }
                        else
                        {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.SetCursorPosition(40, 15);
                    Console.Write($"Error : {returnTypeOfValidator}");
                    Console.SetCursorPosition(40,16);
                    
                    Console.Write("Press Any Key to Enter Again");
                    Console.ReadLine();
                    goto enterAgain5;
                        }
                    }else if(option == 6)
                    {
                        enterAgain6:
                        Console.Clear();
                        Console.WriteLine("Enter the New Value For : " + "Phone");
                        EditedData = Console.ReadLine();
                        returnTypeOfValidator= CheckTheUserInfoValidation.CheckData(data:EditedData,ilength:3);
                        if(returnTypeOfValidator == "ok")
                        {
                            userinfo["Phone"] = EditedData;
                            user.setSpecificUserInfo(index:6,Value:EditedData);
                        
                            user.showUserConfirmation();
                            
                            ConfirmInfoEdition(userinfo,user);

                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.SetCursorPosition(40, 15);
                    Console.Write($"Error : {returnTypeOfValidator}");
                    Console.SetCursorPosition(40,16);
                    
                    Console.Write("Press Any Key to Enter Again");
                    Console.ReadLine();
                    goto enterAgain6;
                        }
                    }

                    else if(option == 7)
                    {
                        enterAgain7:
                        Console.Clear();
                        Console.WriteLine("Enter the New Value For : " + "Skills");
                        EditedData = Console.ReadLine();
                        returnTypeOfValidator= CheckTheUserInfoValidation.CheckData(data:EditedData,ilength:3);
                        if(returnTypeOfValidator == "ok")
                        {   userinfo["Skills"] = EditedData;
                            user.setSpecificUserInfo(index:7,Value:EditedData);
                        
                            user.showUserConfirmation();
                            
                            ConfirmInfoEdition(userinfo,user);

                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.SetCursorPosition(40, 15);
                    Console.Write($"Error : {returnTypeOfValidator}");
                    Console.SetCursorPosition(40,16);
                    
                    Console.Write("Press Any Key to Enter Again");
                    Console.ReadLine();
                    goto enterAgain7;
                        }
                    }

                    else if(option == 8)
                    {
                        enterAgain8:
                        Console.Clear();
                        Console.WriteLine("Enter the New Value For : " + "College");
                        EditedData = Console.ReadLine();
                        returnTypeOfValidator= CheckTheUserInfoValidation.CheckData(data:EditedData,ilength:3);
                        if(returnTypeOfValidator == "ok")
                        {
                            userinfo["College"] = EditedData;
                            user.setSpecificUserInfo(index:8,Value:EditedData);
                        
                            user.showUserConfirmation();
                            
                            ConfirmInfoEdition(userinfo,user);

                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.SetCursorPosition(40, 15);
                    Console.Write($"Error : {returnTypeOfValidator}");
                    Console.SetCursorPosition(40,16);
                    
                    Console.Write("Press Any Key to Enter Again");
                    Console.ReadLine();
                    goto enterAgain8;
                        }
                    }

                    }else
                    {
                        Console.WriteLine("invalid Choice.. \nEnter Again..\t");
                        goto enterdata;
                    }
        }
        //this method will ask the user to edit his information or Show the Resume as Web page
       public static void ConfirmInfoEdition(Dictionary<string, string> userinfo,User user)
        {
            //User user = new User();
            char isEdit;
           dataAgain:
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("1: Edit Information");
            Console.WriteLine("2: Show My Resume");
            
            isEdit =  Char.Parse(Console.ReadLine());

            if (isEdit == '1')
            {

                //this function will start editing 
                
                StartEditing(userinfo,user);


            }else if(isEdit == '2')
            {
                FileHandling.CreateDirectoryAndHTMLFile();
            }
            else
            {
                Console.WriteLine("Invalid choice ");
                goto dataAgain;
            }
        }
       

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
            

            Program.ConfirmInfoEdition(userinfo,user);
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
                    bool toProceed= FileHandling.CheckingIntialDirAndFiles();
                    //it will check weather the file and folder exist or not
                    if(toProceed)
                    {
                        Program.takeUserInfo();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Some File/Folder Are Deleted We cannot proceed");
                        Console.ReadLine();
                        BasicFn.ExitFun();
                    }  
                    
                    


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
