using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A18.MediatorPattern
{
    class User
    {
        public string Name { get; set; }

        public User(string name)
        {
            Name = name;
        }
        
        public void SendMessage(string message)
        {
            ChatRoom.ShowMessage(this, message);
        }
    }
}
