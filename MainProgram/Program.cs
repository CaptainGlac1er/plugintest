using System;
using System.IO;
using System.Reflection;
using TestExtPlugin;

//https://docs.microsoft.com/en-us/dotnet/framework/app-domains/how-to-load-assemblies-into-an-application-domain
namespace plugin_practice
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] plugins = Directory.GetFiles("./ExtPlugins");
            foreach (var pluginFile in plugins)
            {
                Console.WriteLine(pluginFile);
                FileInfo file = new FileInfo(pluginFile);
                Assembly a = Assembly.LoadFile(file.FullName);
                Type plugin = a.GetType();
                
                Console.WriteLine(plugin.FullName);
                TestClass test = (TestClass)a.CreateInstance("Plugins.FirstExternalPlugin");
                test.Execute("From main program");

            }
            Console.WriteLine("Hello World!");
        }
    }
}
