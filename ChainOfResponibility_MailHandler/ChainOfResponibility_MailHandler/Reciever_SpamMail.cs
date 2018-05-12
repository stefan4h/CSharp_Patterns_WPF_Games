using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponibility_MailHandler
{
    class Reciever_SpamMail : AMailHandler
    {
        public Reciever_SpamMail():base()
        {
            HigherAuthority = new Reciever_FanMail();
        }
        public Reciever_SpamMail(AMailHandler higherAuthority):base()
        {
            HigherAuthority = higherAuthority;
        }

        public override void Handle_Mail(Mail mail)
        {
            if (mail.Type == Mail_type.SPAM_MAIL || !(mail.Type == Mail_type.NEW_LOC_MAIL || mail.Type == Mail_type.FAN_MAIL || mail.Type == Mail_type.COMPLAIN_MAIL))
            {
                Console.WriteLine($"Die Mail vom Typ {mail.Type.ToString()} wird mit dem Spam-Mail-Reciever gelöscht");
                Mail_history.Add(mail);
            }
            else
                HigherAuthority.Handle_Mail(mail);
        }
    }
}
