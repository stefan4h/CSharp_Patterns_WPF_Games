using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponibility_MailHandler
{
    abstract class AMailHandler
    {
        public AMailHandler HigherAuthority { get; protected set; }

        public List<Mail> Mail_history { get; protected set; }

        public AMailHandler()
        {
            Mail_history = new List<Mail>();
        }

        public abstract void Handle_Mail(Mail mail);
    }
}
