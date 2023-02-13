using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factories
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            CreditCard card = new TitaniumCard().CreateCard();
            DisplayResults(card);
            Console.WriteLine();
            card = new PlatinumCard().CreateCard();
            DisplayResults(card);
            for(int i = 1; i < 10; i++)
            {
                var singleton = Singleton.GetInstance();
            }
            MyFactory a = new A().CreateObject("A");
            a.Name = "Shit ass cocksucker";

        }
       
        private static void DisplayResults(CreditCard card)
        {
            Console.WriteLine(card.CardType);
            Console.WriteLine(card.CreditLimit);
        }

      
    }

   
    internal sealed class Singleton
    {
        private static readonly object _instanceLock = new object();
        private static Singleton _instance = null;
        private int _counter = 0;

        private Singleton()
        {
            _counter++;
            Console.WriteLine($"Instance count: {_counter}");
        }

        public static Singleton GetInstance()
        {
            if(_instance == null )
            {
                lock (_instanceLock)
                {
                    _instance = new Singleton();
                }
            }
            return _instance;
        }
    }
    
}
