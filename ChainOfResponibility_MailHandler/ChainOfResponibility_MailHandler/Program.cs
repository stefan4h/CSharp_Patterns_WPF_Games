using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponibility_MailHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            Mail mailSpam = new Mail("spam");
            Mail mailNew = new Mail("new");
            AMailHandler spamMailHandler = new Reciever_SpamMail();

            spamMailHandler.Handle_Mail(mailSpam);
            spamMailHandler.Handle_Mail(mailNew);
        }
    }
}
