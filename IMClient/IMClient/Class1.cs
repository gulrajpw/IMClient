using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalVariables
{
    public class Global 
    {


        public static String UserName;

        public static void SetUserName(String entry)
        {
            UserName = entry;
        }

        public static String ShowUserName()
        {
            return UserName;
        }
    }

}
