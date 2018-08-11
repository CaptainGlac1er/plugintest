using System;

namespace TestExtPlugin{
    public class TestClass
    {
        public TestClass(){
            Console.WriteLine("Testing");
        }
        public virtual void Execute(string value)
        {
            Console.WriteLine("Main Program says hi");
        }
    }
}