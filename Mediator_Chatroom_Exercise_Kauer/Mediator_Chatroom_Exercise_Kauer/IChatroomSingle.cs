using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Chatroom_Exercise_Kauer
{
    public interface IChatroomSingle
    {
        void Send(string message, Person from);
        void Register(Person one, Person two);
    }

}
