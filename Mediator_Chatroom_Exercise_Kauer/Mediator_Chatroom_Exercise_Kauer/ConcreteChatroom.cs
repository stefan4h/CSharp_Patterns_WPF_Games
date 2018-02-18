using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Chatroom_Exercise_Kauer
{
    class ConcreteChatroom : IChatroomSingle
    {
        Person person1;
        Person person2;

        public Person Person1
        {
            get
            {
                return person1;
            }

            set
            {
                person1 = value;
            }
        }

        public Person Person2
        {
            get
            {
                return person2;
            }

            set
            {
                person2 = value;
            }
        }

        public void Register(Person one, Person two)
        {
            person1 = one;
            person2 = two;
        }

        public void Send(string message, Person from)
        {
            if (from == person1)
                person2.Receive(message,from);
            else
                person1.Receive(message, from);
        }
    }
}
