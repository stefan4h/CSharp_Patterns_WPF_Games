using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponibility_MailHandler
{
    class Reciever_FanMail : AMailHandler
    {
        public Reciever_FanMail():base()
        {
            HigherAuthority = new Reciever_ComplainMail();
        }
        public Reciever_FanMail(AMailHandler higherAuthority):base()
        {
            HigherAuthority = higherAuthority;
        }

        public override void Handle_Mail(Mail mail)
        {
            if (mail.Type == Mail_type.FAN_MAIL)
            {
                Console.WriteLine($"Die Mail vom Typ {mail.Type.ToString()} wird mit dem Fan-Mail-Reciever an den CEO weitergeleitet");
                Mail_history.Add(mail);
            }
            else
                HigherAuthority.Handle_Mail(mail);
        }
    }
}
