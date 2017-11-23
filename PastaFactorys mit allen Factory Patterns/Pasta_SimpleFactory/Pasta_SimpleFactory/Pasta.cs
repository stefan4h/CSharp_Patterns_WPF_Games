using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasta_SimpleFactory
{
    abstract class Pasta
    {
        protected string noodles;
        protected string sauce;
        public abstract void SetNoodles();
        public abstract void SetSauce();
        public abstract string GetNoodles();
        public abstract string GetSauce();
    }
    class SpaghettiBolognese : Pasta
    {
        public SpaghettiBolognese()
        {
            SetNoodles();
            SetSauce();
        }
        public override void SetNoodles()
        {
            noodles = "Spaghetti";
        }
        public override void SetSauce()
        {
            sauce = "Bolognese";
        }
        public override string GetNoodles()
        {
            return noodles;
        }
        public override string GetSauce()
        {
            return sauce;
        }

    }
    class SpaghettiCarbonara : Pasta
    {
        public SpaghettiCarbonara()
        {
            SetNoodles();
            SetSauce();
        }
        public override void SetNoodles()
        {
            noodles = "Spaghetti";
        }
        public override void SetSauce()
        {
            sauce = "Carbonara";
        }
        public override string GetNoodles()
        {
            return noodles;
        }
        public override string GetSauce()
        {
            return sauce;
        }

    }
    class PenneCarbonara : Pasta
    {
        public PenneCarbonara()
        {
            SetNoodles();
            SetSauce();
        }
        public override void SetNoodles()
        {
            noodles = "Penne";
        }
        public override void SetSauce()
        {
            sauce = "Carbonara";
        }
        public override string GetNoodles()
        {
            return noodles;
        }
        public override string GetSauce()
        {
            return sauce;
        }

    }
}
