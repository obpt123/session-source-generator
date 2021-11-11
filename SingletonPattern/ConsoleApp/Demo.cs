using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SingletonPattern;
namespace ConsoleApp
{
    [Singleton]
    partial class Demo
    {
        public void SayHello(string name)
        {

            Console.WriteLine($"Hello,{name}.");
        }
    }
}
