using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
