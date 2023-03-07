using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Datavalidator
{
    class CheckTheUserInfoValidation
    {
        //this method will check the userinformation and raise the Error if not found accordingly..
        public static String  CheckData(string data,int ilength)
        {

          
                if(ilength < data.Length)
                {
                    return "ok";
                }
                else
                {
                    return $"The Data Length Should be {ilength}";
                }
                
            


        }

    }
}



class FileHandling
{
    //here we will check the important file and direcotries to write the html file 
    public static bool CheckingIntialDirAndFiles()
    {
       // DirectoryInfo df = new DirectoryInfo();
     
        //first we will check the main directory for resume html exsist or not
        bool isExist = Directory.Exists(@"./../../../../UserResume");

        
        

        if(isExist)
        {
            //now we will check for the html file for the core

            bool isFile =  File.Exists(@"./../../../../UserResume/index.html");

            if (isFile)
                return true;
            else 
                return false;

        }else
        {
            return false;
        }
   
    

     
    }


    public static void CreateDirectoryAndHTMLFile(UserInformation.User user)
    {
        bool CheckDirAndFiles = CheckingIntialDirAndFiles();


       

        
        if(CheckDirAndFiles)
        {
            //making an temp folder to put the user.html file
            DirectoryInfo df  = new DirectoryInfo(@"./../../../../Temp");
            
            if(Directory.Exists(@"./../../../../Temp"))
                {
                
                Directory.Delete(@"./../../../../Temp",true);
            
            }
                df.Create();
       
            //now create the html file..

            if(File.Exists(@"./../../../../Temp/user.html"))
            {
               File.Delete(@"./../../../../Temp/user.html");
            }

            
             //reading and writing the data from existing file source

            String[] sr1 = File.ReadAllLines(@"./../../../../UserResume/src1.txt");
            String[] sr2 = File.ReadAllLines(@"./../../../../UserResume/src2.txt");

            //create fresh new file 
            FileStream fs = new FileStream(@"./../../../../Temp/user.html",FileMode.Append,FileAccess.Write);
            using(StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
            {
                foreach(String lines in sr1)
                
                sw.WriteLine(lines);

                

            sw.WriteLine(@"<title>Edited One</title></head>");
          
          
            foreach(String line in sr2)
                sw.WriteLine(line);
            //fname
            sw.WriteLine($"<h1 class=\"text-center text-light\">{user.fname} {user.mname} {user.lname}</h1></div></div>");
            //address
            sw.WriteLine($" <div class=\"container mt-2\"><div class=\"container  alert bg-dark text-center\"><h3 class=\"text-center text-light\"> <span class=\"text-danger\">Address</span> : {user.address}</h3> </div></div>");
            //phone number
            sw.WriteLine($" <div class=\"container mt-2\"><div class=\"container  alert bg-dark text-center\"><h3 class=\"text-center text-light\"><a href=\"tel:+{user.phone}\" class=\"text-danger\">{user.phone}<i class=\"fas fa-phone\"></i> </a></h3></div></div>");

            //email
            sw.WriteLine($" <div class=\"container mt-2\"> <div class=\"container  alert bg-dark text-center\"> <a name=\"contact\"></a> <h3 class=\"text-center text-light\"><a href=\"mailto:{user.email}\" class=\"text-danger\"><i class=\"fas fa-mail\"></i>{user.email}</a></h3> </div></div>");

            //college and skill and end of the file

            sw.WriteLine($"<div class=\"container mt-2\"> <div class=\"container  alert bg-dark text-center\"> <h3 class=\"text-center text-light\"><span class=\"text-danger\">College : </span>{user.college}</h3> </div>  </div>    <div class=\"container mt-2\">   <div class=\"container  alert bg-dark text-center\"><a name=\"skills\"></a>  <h3 class=\"text-center text-light\"><span class=\"text-danger\">Skills : </span>{user.skills}</h3>  </div> </div><script src=\"https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/js/bootstrap.bundle.min.js\" integrity=\"sha384-w76AqPfDkMBDXo30jS1Sgez6pr3x5MlQ1ZAGC+nuZB+EYdgRZgiwxhTBTkF7CXvN\" crossorigin=\"anonymous\"></script>  </body></html>");

            
                    
                    }

            //copy Svg File from User Resume to Original resume
            File.Copy(@"./../../../../UserResume/1456160-ffffff.svg",@"./../../../../Temp/1456160-ffffff.svg");
            fs.Close();
           
            System.Diagnostics.Process.Start("cmd.exe","/K   cd.. /../../../../../Temp  &  user.html");

            
           
                
            
           
        }else
        {
            Console.Clear();
            Console.WriteLine("Some Important File or Folder has been deleted.. ");
            Console.ReadLine();
            BasicFuctions.BasicFn.ExitFun();
        }
    }
}