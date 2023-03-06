using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInformation
{
    class User
    {
        public string  fname;
        public string mname;
        public string lname;
        public string address;
        public string phone;
        public string college;
        public string skills;
        public string email;


        private  void initiliseValueToTheUser(string fname,string mname,string lname,string address,string phone,
                                                string college,string skills,string email)
        {
            this.fname = fname;
            this.mname = mname;
            this.lname = lname;
            this.address = address;
            this.phone = phone;
            this.college = college;
            this.skills = skills;
            this.email = email;

        }



        public  void SetUserinformation(string fname, string mname, string lname, string address, string phone,
                                                string college, string skills, string email)
        {
            //this function will call the private method which will add the userinformation given by the user
            this.initiliseValueToTheUser(fname,mname
                ,lname,address,phone,college,skills,email);
        }

        public void showUserConfirmation()
        {
           Console.Clear();
            Console.WriteLine("First Name :" +  this.fname);
            Console.WriteLine("Middle Name :" +  this.mname);
            Console.WriteLine("Last Name :" +  this.lname);
            Console.WriteLine("Email :" +  this.email);
            Console.WriteLine("Phone :" +  this.phone);
            Console.WriteLine("Address:" + this.address );
            Console.WriteLine("Skills:" + this.skills );
            Console.WriteLine("College:" + this.college );

            
        }

        public void setSpecificUserInfo(int index,string Value)
        {

          

           if(index == 1)
            {
                
                this.fname = Value;
                
                
            }else if (index == 2)
            {
                this.mname = Value;
            }else if(index == 3)
            {
                this.lname =  Value;
            }else if(index == 4)
            {
                this.email = Value;
            }else if(index== 5)
            {
                this.address = Value;
            }else if(index == 6)
            {
                this.phone = Value;
            }else if(index == 7)
            {
                this.skills = Value;
            }else if(index == 8)
            {
                this.college = Value;
            }


        }

    }
}
