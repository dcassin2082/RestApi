using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factories
{
    internal interface IFactory 
    {
    }
    internal abstract class Factory 
    {
        protected internal abstract Factory CreateFactory(string factoryType);
        public string FactoryName { get; set; }
    }
    internal class AnimalFactory : Factory, IFactory
    {
        public string GetFactoryType(string name)
        {
            throw new NotImplementedException();
        }

        protected internal override Factory CreateFactory(string factoryType)
        {
            return new AnimalFactory
            {
                FactoryName = factoryType,
            };
        }
    }
    internal class VegetableFactory : Factory, IFactory
    {
        protected internal override Factory CreateFactory(string factoryType)
        {
            return new VegetableFactory();
        }
    }
    internal class MineralFactory : Factory, IFactory
    {
        protected internal override Factory CreateFactory(string factoryType)
        {
            return new MineralFactory();
        }
    }
}
