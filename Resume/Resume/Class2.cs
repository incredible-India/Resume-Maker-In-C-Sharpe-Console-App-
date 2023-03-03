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


    public static void CreateDirectoryAndHTMLFile()
    {
        bool CheckDirAndFiles = CheckingIntialDirAndFiles();

        if(CheckDirAndFiles)
        {
            Console.WriteLine("Hello World");
            Console.ReadLine();
        }else
        {
            Console.WriteLine("Some Important File or Folder has been deleted.. ");
            Console.ReadLine();
            BasicFuctions.BasicFn.ExitFun();
        }
    }
}