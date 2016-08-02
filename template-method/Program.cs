using System;

namespace template_method
{
    class Program
    {
        static void Main(string[] args)
        {
            new ConcreteClass1().TemplateMethod();
            new ConcreteClass2().TemplateMethod();
            new ChildPropertyTemplate().PrintName();
            Console.ReadKey();
        }
    }

    abstract class AbstractClass
    {
        public void TemplateMethod()
        {
            PrimitiveOperation1();
            PrimitiveOperation2();
        }

        protected abstract void PrimitiveOperation1();
        protected abstract void PrimitiveOperation2();
    }

    class ConcreteClass1 : AbstractClass
    {
        protected override void PrimitiveOperation1() => Console.WriteLine("ConcreteClass1.PrimitiveOperation1");
        protected override void PrimitiveOperation2() => Console.WriteLine("ConcreteClass1.PrimitiveOperation2");
    }

    internal class ConcreteClass2 : AbstractClass
    {
        protected override void PrimitiveOperation1() => Console.WriteLine("ConcreteClass2.PrimitiveOperation1");
        protected override void PrimitiveOperation2() => Console.WriteLine("ConcreteClass2.PrimitiveOperation2");
    }
    
    internal abstract class BasicPropertyTemplate
    {
        protected abstract string Name { get;}
        public void PrintName() => Console.WriteLine($"Parent called {Name}");
    }
    
    internal class ChildPropertyTemplate : BasicPropertyTemplate
    {
        protected override string Name => "ChildProperty";
    }
}
