using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tinhtong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 5;
            // thêm biến d có giá trị là 6 
            int d = 6;
            int c = a + b +d;
            Console.WriteLine("tong 3 so {0} va {1} va {2} la: {3}",a,b,d, c);
            Console.ReadLine();

        }
    }
}
