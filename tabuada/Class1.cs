using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuada
{
    class Class1
    {
        public void Tabuada1()
        {
            int num, num2;
            num = 1;

            while (num <= 10)
            {
                num2 = 1;
                while (num2 <= 10)
                {
                    Console.WriteLine("{0} x {1} = {2}", num, num2, num * num2);
                    num2++;
                }
                Console.WriteLine("");
                num++;
            }
        }
        public void Exercicio2()
        {

        }
        public void Exercicio3()
        {
            int num, soma;
            for (num = 0; num <= 1000; num += 100)
            {
                Console.WriteLine(num);

            }
        }
    }
}
