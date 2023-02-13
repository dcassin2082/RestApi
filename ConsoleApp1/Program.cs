using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Generally we will get the Card Type from UI.
            //Here we are hardcoded the card type
            string cardType = "Platinum";
            ICreditCard cardDetails = new PlatinumFactory().MakeProduct();
            DisplayCardDetails(cardDetails);

            cardDetails = new MoneyBackFactory().MakeProduct();
            DisplayCardDetails(cardDetails);

            cardDetails = new TitaniumFactory().MakeProduct();
            DisplayCardDetails(cardDetails);

            //Console.WriteLine();
            //Console.WriteLine();
            //AbstractFactoryStuff();
            //Console.WriteLine();
            //Concrete();
            string cs = @"server=localhost;initial catalog=test;integrated security=true;trustservercertificate=true;";

            using (SqlConnection cn = DataManager.GetConnection())
            {
                DataManager.Connection.ConnectionString = cs;
                using (SqlCommand cmd = new SqlCommand("select * from contact", cn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine("GO FUCK YOURSELEF" + reader.GetString(0));
                        }
                    }
                }
            }
        }
        private static void Concrete()
        {
            Dog dog = new Dog();
            Console.WriteLine(dog.Speak() + " ...............................................");

            AnimalFactory factory = AnimalFactory.CreateAnimalFactory("Land");
            IAnimal animal = factory.GetAnimal("Dog");
            Console.WriteLine(animal?.Speak());

        }
        private static void AbstractFactoryStuff()
        {
            string speakSound = null;
            // Create the Sea Factory object by passing the factory type as Sea
            AnimalFactory animalFactory = AnimalFactory.CreateAnimalFactory("Sea");
            Console.WriteLine("Animal Factory type : " + animalFactory.GetType().Name);
            Console.WriteLine();
            // Get Octopus Animal object by passing the animal type as Octopus
            IAnimal animal = animalFactory.GetAnimal("Octopus");
            Console.WriteLine("Animal Type : " + animal.GetType().Name);
            speakSound = animal.Speak();
            Console.WriteLine(animal.GetType().Name + " Speak : " + speakSound);
            Console.WriteLine();
            Console.WriteLine("--------------------------");
            // Create Land Factory object by passing the factory type as Land
            animalFactory = AnimalFactory.CreateAnimalFactory("Land");
            Console.WriteLine("Animal Factory type : " + animalFactory.GetType().Name);
            Console.WriteLine();
            // Get Lion Animal object by passing the animal type as Lion
            animal = animalFactory.GetAnimal("Lion");
            Console.WriteLine("Animal Type : " + animal.GetType().Name);
            speakSound = animal.Speak();
            Console.WriteLine(animal.GetType().Name + " Speak : " + speakSound);
            Console.WriteLine();
            // Get Cat Animal object by passing the animal type as Cat
            animal = animalFactory.GetAnimal("Cat");
            Console.WriteLine("Animal Type : " + animal.GetType().Name);
            speakSound = animal.Speak();
            Console.WriteLine(animal.GetType().Name + " Speak : " + speakSound);
        }
        private static void DisplayCardDetails(ICreditCard cardDetails)
        {
            if (cardDetails != null)
            {
                Console.WriteLine("CardType : " + cardDetails.GetCardType());
                Console.WriteLine("CreditLimit : " + cardDetails.GetCreditLimit());
                Console.WriteLine("AnnualCharge :" + cardDetails.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }
        }
    }
}
