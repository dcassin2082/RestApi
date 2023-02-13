using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal interface ICreditCard
    {
        string GetCardType();
        int GetCreditLimit();
        int GetAnnualCharge();
    }
    internal class MoneyBack : ICreditCard
    {
        public string GetCardType()
        {
            return "MoneyBack";
        }
        public int GetCreditLimit()
        {
            return 15000;
        }
        public int GetAnnualCharge()
        {
            return 500;
        }
    }

    internal class Titanium : ICreditCard
    {
        public string GetCardType()
        {
            return "Titanium Edge";
        }
        public int GetCreditLimit()
        {
            return 25000;
        }
        public int GetAnnualCharge()
        {
            return 1500;
        }
    }

    internal class Platinum : ICreditCard
    {
        public string GetCardType()
        {
            return "Platinum Plus";
        }
        public int GetCreditLimit()
        {
            return 35000;
        }
        public int GetAnnualCharge()
        {
            return 2000;
        }
    }

    internal abstract class CreditCardFactory
    {
        protected internal abstract ICreditCard MakeProduct();

        //public ICreditCard CreateProduct()
        //{
        //    return MakeProduct();
        //}

        //    public static ICreditCard GetCreditCard(string cardType)
        //    {
        //        ICreditCard cardDetails = null;

        //        if (cardType == "MoneyBack")
        //        {
        //            cardDetails = new MoneyBack();
        //        }
        //        else if (cardType == "Titanium")
        //        {
        //            cardDetails = new Titanium();
        //        }
        //        else if (cardType == "Platinum")
        //        {
        //            cardDetails = new Platinum();
        //        }
        //        return cardDetails;
        //    }
    }
    internal class PlatinumFactory : CreditCardFactory
    {
        protected internal override ICreditCard MakeProduct()
        {
            return new Platinum();
        }
    }

    internal class TitaniumFactory : CreditCardFactory
    {
        protected internal override ICreditCard MakeProduct()
        {
            return new Titanium();
        }
    }


    internal class MoneyBackFactory : CreditCardFactory
    {
        protected internal override ICreditCard MakeProduct()
        {
            return new MoneyBack();
        }
    }

    internal abstract class MyAbstractClass
    {
        protected internal abstract IMyClasses DoSomething();

        protected void DoThisShit()
        {
            DoSomething();
        }
    }

    internal class ClassA : MyAbstractClass, IMyClasses
    {
        protected internal override IMyClasses DoSomething()
        {
            return new ClassA();
        }
    }

    internal interface IMyClasses
    {
    }
}
