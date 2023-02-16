using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInformation
{
    class User
    {
        private String fname;
        private String mname;
        private String lname;
        private String address;
        private String phone;
        private String college;
        private String skills;
        private String email;


        private  void initiliseValueToTheUser(String fname,String mname,String lname,String address,String phone,
                                                String college,String skills,String email)
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



        public  void SetUserinformation(String fname, String mname, String lname, String address, String phone,
                                                String college, String skills, String email)
        {
            //this function will call the private method which will add the userinformation given by the user
            this.initiliseValueToTheUser(fname,mname
                ,lname,address,phone,college,skills,email);
        }

    }
}
