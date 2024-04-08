using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] strings)
        {
            Console.WriteLine("***Изучение интерфейсов.Пример-2***\n");
            MyClass myOb = new ChildClass();
            myOb.Show1();
            myOb.Show2();
            Console.ReadKey();


        }
    }
}
