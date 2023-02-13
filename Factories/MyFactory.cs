using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factories
{
    internal abstract class MyFactory
    {
        public string Name { get; set; }
        internal abstract MyFactory CreateObject(string factoryType);

    }

    internal class A : MyFactory
    {
        internal override MyFactory CreateObject(string factoryType)
        {
            return new A();
        }
    }
    internal class B : MyFactory
    {
        internal override MyFactory CreateObject(string factoryType)
        {
            return new B();
        }
    }
    internal class C : MyFactory
    {
        internal override MyFactory CreateObject(string factoryType)
        {
            return new C();
        }
    }
}
