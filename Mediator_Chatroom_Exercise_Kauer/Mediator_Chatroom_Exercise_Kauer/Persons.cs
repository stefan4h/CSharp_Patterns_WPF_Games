using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Chatroom_Exercise_Kauer
{
    public class Person
    {
        public IChatroomSingle chatroom;
        public List<String> chat;

        public string name;
        public string Name
        {
            get { return name; }
        }

        public Person( string name)
        {
            chat = new List<string>();
            this.name = name;
        }

        public void CreateChatroom(Person person, IChatroomSingle chatroomS)
        {
            chatroom = chatroomS;
            chatroom.Register(this, person);
        }

        public void Send(string message)
        {
            chatroom.Send(message, this);
        }

        public void Receive(string message, Person from)
        {
            chat.Add(name + " got a message from " + from.name + ": " + message);
        }
    }
}
