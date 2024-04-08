using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ");
            MyClass myClassOb = new MyClass();
            myClassOb.Show();
            IMyInterfaceA interA = myClassOb;
            interA.Show();
            IMyInterfaceB interB = myClassOb;
            interB.Show();
            Console.ReadKey();

        }
    }
}
