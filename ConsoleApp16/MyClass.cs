using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class MyClass: IMyInterfaceA, IMyInterfaceB
    {
        public void Show()
        {
            Console.WriteLine("MyClass.Show() is conpleted ");
           
        }
        void IMyInterfaceA.Show()
        {
            Console.WriteLine(" ");
        }
        void IMyInterfaceB.Show()
        {
            Console.WriteLine(" ");
        }
    }
}
