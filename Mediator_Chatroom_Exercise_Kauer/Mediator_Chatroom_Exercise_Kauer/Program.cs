using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Chatroom_Exercise_Kauer
{
    class Program
    {
        static void Main(string[] args)
        {
            Person one = new Person("Kathi");
            Person two = new Person("yes");

            ConcreteChatroom c = new ConcreteChatroom();

            one.CreateChatroom(two, c);
            

            one.Send("juhu");
            Console.WriteLine(two.chat[0]);
        }
    }
}
