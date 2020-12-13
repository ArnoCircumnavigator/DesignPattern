using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A18.MediatorPattern
{
    class ChatRoom
    {
        public static void ShowMessage(User user,string message)
        {
            Console.WriteLine(System.DateTime.Now.ToString("hh:mm:ss") + "["
                + user.Name + "] : " + message);
        }
    }
}
