using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public int Func1()
        {
            return 3;
        }

        public void Func2()
        {
            Console.WriteLine($"Calling {this.GetType()}.Func2");
        }

        public double Func3()
        {
            return (new Random()).NextDouble();
        }

        public bool Func4()
        {
            return true;
        }
    }
}
