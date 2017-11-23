using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasta_AbstractFactory
{
    interface IPastaFactory
    {
        INoodles GetNoodles();
        ISauce GetSauce();
    }
    public class SpaghettiBolognese : IPastaFactory
    {
        public INoodles GetNoodles()
        {
            return new Spaghetti();
        }

        public ISauce GetSauce()
        {
            return new Bolognese();
        }
    }
    public class PenneBolognese : IPastaFactory
    {
        public INoodles GetNoodles()
        {
            return new Penne();
        }

        public ISauce GetSauce()
        {
            return new Bolognese();
        }
    }
    public class SpaghettiAlTonno : IPastaFactory
    {
        public INoodles GetNoodles()
        {
            return new Spaghetti();
        }

        public ISauce GetSauce()
        {
            return new AlTonno();
        }
    }
    public class PenneAlTonno : IPastaFactory
    {
        public INoodles GetNoodles()
        {
            return new Spaghetti();
        }

        public ISauce GetSauce()
        {
            return new AlTonno();
        }
    }
    public class FusilliCarbonara : IPastaFactory
    {
        public INoodles GetNoodles()
        {
            return new Fusilli();
        }

        public ISauce GetSauce()
        {
            return new Carbonara();
        }
    }
    public class FusilliBolognese : IPastaFactory
    {
        public INoodles GetNoodles()
        {
            return new Fusilli();
        }

        public ISauce GetSauce()
        {
            return new Bolognese();
        }
    }
}
