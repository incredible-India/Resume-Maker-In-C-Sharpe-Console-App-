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
        public static String  CheckData(dynamic data,int length,String type)
        {

            if(data.GetType() == type)
            {
                if(data.Length == length)
                {
                    return "ok";
                }
                else
                {
                    return $"The Data Length Should be {length}";
                }
                
            }else
            {
                return $"Data Type Must Be {type}";
            }

            return "ok";

        }

    }
}
