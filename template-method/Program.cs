using System;

namespace template_method
{
    class Program
    {
        static void Main(string[] args)
        {
            new Child1().Operation();
            new Child2().Operation();
            new ChildPropertyTemplate().PrintName();
            Console.ReadKey();
        }
    }

    abstract class Base
    {
        public void Operation()
        {
            Action1();
            Action2();
        }

        protected abstract void Action1();
        protected abstract void Action2();
    }

    class Child1 : Base
    {
        protected override void Action1() => Console.WriteLine("Child1.Action1");
        protected override void Action2() => Console.WriteLine("Child1.Action2");
    }

    internal class Child2 : Base
    {
        protected override void Action1() => Console.WriteLine("Child2.Action1");
        protected override void Action2() => Console.WriteLine("Child2.Action2");
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
