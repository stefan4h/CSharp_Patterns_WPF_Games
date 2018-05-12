using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponibility_MailHandler
{
    class Reciever_ComplainMail : AMailHandler
    {
        public Reciever_ComplainMail():base()
        {
            HigherAuthority = new Reciever_NewLocationMail();
        }
        public Reciever_ComplainMail(AMailHandler higherAuthority):base()
        {
            HigherAuthority = higherAuthority;
        }

        public override void Handle_Mail(Mail mail)
        {
            if (mail.Type == Mail_type.COMPLAIN_MAIL)
            {
                Console.WriteLine($"Die Mail vom Typ {mail.Type.ToString()} wird mit dem Complain-Mail-Reciever an das Legal Department weitergeleitet");
                Mail_history.Add(mail);
            }
            else
                HigherAuthority.Handle_Mail(mail);
        }
    }
}
