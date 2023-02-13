using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal interface IAnimal
    {
        string Speak();
    }
    internal class Cat : IAnimal
    {
        public string Speak()
        {
            return "Meow";
        }
    }
    internal class Lion : IAnimal
    {
        public string Speak()
        {
            return "Roar";
        }
    }
    internal class Dog : IAnimal
    {
        public string Speak()
        {
            return "Bark";
        }
    }
    internal class Octupus : IAnimal
    {
        public string Speak()
        {
            return "Squawk";
        }
    }
    internal class Shark : IAnimal
    {
        public string Speak()
        {
            return "Squawk";
        }
    }
    internal abstract class AnimalFactory
    {
        public abstract IAnimal GetAnimal(string animalType);

        public static AnimalFactory CreateAnimalFactory(string FactoryType)
        {
            if (FactoryType.Equals("Sea"))
                return new SeaAnimalFactory();
            else
                return new LandAnimalFactory();
        }
    }
    internal class LandAnimalFactory : AnimalFactory
    {
        public override IAnimal GetAnimal(string AnimalType)
        {
            if (AnimalType.Equals("Dogl"))
            {
                return new Dog();
            }
            else if (AnimalType.Equals("Cat"))
            {
                return new Cat();
            }
            else if (AnimalType.Equals("Lion"))
            {
                return new Lion();
            }
            else
                return null;
        }
    }
    internal class SeaAnimalFactory : AnimalFactory
    {
        public override IAnimal GetAnimal(string AnimalType)
        {
            if (AnimalType.Equals("Shark"))
            {
                return new Shark();
            }
            else if (AnimalType.Equals("Octopus"))
            {
                return new Octupus();
            }
            else
                return null;
        }
    }
}
