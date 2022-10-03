using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IChatSystem whatapp=new WhatsApp();
            whatapp.SendMessage();
            whatapp.RecieveMessage();

            IChatSystem telegram = new Telegram();
            telegram.SendMessage();
            telegram.RecieveMessage();
        }

    }
}
