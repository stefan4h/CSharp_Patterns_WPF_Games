using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponibility_MailHandler
{
    enum Mail_type {SPAM_MAIL,FAN_MAIL,COMPLAIN_MAIL,NEW_LOC_MAIL}

    class Mail
    {
        public Mail_type Type { get; private set; }

        public Mail(string type)
        {
            if (type.ToLower().Contains("fan"))
                Type = Mail_type.FAN_MAIL;
            else if (type.ToLower().Contains("complain"))
                Type = Mail_type.COMPLAIN_MAIL;
            else if (type.ToLower().Contains("new_loc") || type.ToLower().Contains("new") || type.ToLower().Contains("loc"))
                Type = Mail_type.NEW_LOC_MAIL;
            else
                Type = Mail_type.SPAM_MAIL;
        }
        public Mail()
        {
            Type = Mail_type.SPAM_MAIL;
        }
        public Mail(Mail_type type)
        {
            Type = type;
        }
    }
}
