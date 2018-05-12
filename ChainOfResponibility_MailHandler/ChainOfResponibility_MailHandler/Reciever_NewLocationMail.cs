using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponibility_MailHandler
{
    class Reciever_NewLocationMail : AMailHandler
    {
        public Reciever_NewLocationMail():base(){}
        public Reciever_NewLocationMail(AMailHandler higherAuthority):base()
        {
            HigherAuthority = higherAuthority;
        }
        public override void Handle_Mail(Mail mail)
        {
            if (mail.Type == Mail_type.NEW_LOC_MAIL)
            {
                Console.WriteLine($"Die Mail vom Typ {mail.Type.ToString()} wird mit dem New-Location-Mail-Reciever an das Bussines Developement Team weitergeleitet");
                Mail_history.Add(mail);
            }
            else
                HigherAuthority.Handle_Mail(mail);
        }
    }
}
