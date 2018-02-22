using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEW_Facade_GameSettings.Exceptions
{
    class DoesNotMatchRestrictionsException:Exception
    {
        public DoesNotMatchRestrictionsException(string message):base(message){}
        public DoesNotMatchRestrictionsException() : base() { }
    }
}
