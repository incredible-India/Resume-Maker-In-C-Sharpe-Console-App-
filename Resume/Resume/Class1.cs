﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInformation
{
    class User
    {
        private string fname;
        private string mname;
        private string lname;
        private string address;
        private string phone;
        private string college;
        private string skills;
        private string email;


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

    }
}
