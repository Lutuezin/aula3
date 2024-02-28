using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1234567891; // 10^9
            uint b = 1234567899; // 10^10
            long c = 1234567891011121314; // 10^19
            ulong d = 12345678910111213141; // 10^20

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);

            float f = 1.27F; // especificar tipo no final
            double x = 1.23; // especificar tipo no final
            decimal = 1.42m; // especificar tipo no final - 28 digitos de precisão.

        }
    }
}
