using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Q2
{
    class Class1
    {
        static void Main()
        {
            Bird b = new Bird("Eagle", double.Parse("200"));
            b.fly();
            b.fly(int.Parse("300"));//9
        }
    }
}
