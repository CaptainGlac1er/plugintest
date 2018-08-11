using System;
using TestExtPlugin;

namespace Plugins
{
    public class FirstExternalPlugin : TestClass
    {
        private string name = "FirstExternalPlugin";
        public FirstExternalPlugin()
        {
            Console.WriteLine($"External Plugin was made: {name}");
        }
        public override void Execute(string value)
        {
            Console.WriteLine($"External Plugin says: {value}");
        }
    }
}
