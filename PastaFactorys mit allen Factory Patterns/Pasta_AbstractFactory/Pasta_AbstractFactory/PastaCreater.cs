using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasta_AbstractFactory
{
    class PastaCreater
    {
        IPastaFactory pf;

        public PastaCreater(IPastaFactory pff)
        {
            pf = pff;
        }

        public void MakePasta()
        {
            INoodles noodles = pf.GetNoodles();
            ISauce sauce = pf.GetSauce();

            noodles.ShowName();
            sauce.ShowName();
        }
    }
}
