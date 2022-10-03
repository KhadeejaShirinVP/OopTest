using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopTest
{
    interface IChatSystem
    {
        void SendMessage();
        void RecieveMessage();
    }
    class WhatsApp : IChatSystem
    {
        public void SendMessage()
        {
            Console.WriteLine("sending message via whatsApp");
        }
        public void RecieveMessage()
        {
            Console.WriteLine("recieving message via whatsApp");
        }
    }
    class Telegram : IChatSystem
    {
        public void SendMessage()
        {
            Console.WriteLine("sending message via telegram");
        }
        public void RecieveMessage()
        {
            Console.WriteLine("recieving message via telegram");
        }
        
    }
   
    
}
