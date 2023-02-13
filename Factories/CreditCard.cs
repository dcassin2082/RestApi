using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factories
{
    internal abstract class CreditCard
    {
        internal string CardType { get; set; }
        internal int CreditLimit { get; set; }
        internal abstract CreditCard CreateCard();
    }
    internal class PlatinumCard : CreditCard
    {
        internal override CreditCard CreateCard()
        {
            return new PlatinumCard
            {
                CardType = "Platinum",
                CreditLimit = 2000
            };
        }
    }
    internal class TitaniumCard : CreditCard
    {
        internal override CreditCard CreateCard()
        {
            return new TitaniumCard
            {
                CardType = "Titanium",
                CreditLimit = 5000
            };
        }
    }
}
