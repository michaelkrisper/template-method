using System;

namespace template_method
{
    static class Program
    {
        static void Main(string[] args)
        {
            new ConcreteClass1().TemplateMethod();
            new ConcreteClass2().TemplateMethod();
            new ChildPropertyTemplate().PrintName();
            new ChildPropertyTemplate2().PrintName();

            Console.ReadKey();
        }
    }

    abstract class AbstractClass
    {
        public void TemplateMethod()
        {
            Console.WriteLine("Abstract Class calls following methods:");
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

    class ConcreteClass2 : AbstractClass
    {
        protected override void PrimitiveOperation1() => Console.WriteLine("ConcreteClass2.PrimitiveOperation1");
        protected override void PrimitiveOperation2() => Console.WriteLine("ConcreteClass2.PrimitiveOperation2");
    }
    
    abstract class BasicPropertyTemplate
    {
        protected abstract string Name { get;}
        public void PrintName() => Console.WriteLine($"Parent called {Name}");
    }
    
    class ChildPropertyTemplate : BasicPropertyTemplate
    {
        protected override string Name => "ChildProperty1";
    }

    class ChildPropertyTemplate2 : BasicPropertyTemplate
    {
        protected override string Name => "ChildProperty2";
    }
}
