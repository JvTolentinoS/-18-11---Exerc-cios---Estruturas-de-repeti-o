using System;

namespace _4___Sequencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sequência Fibonacci");
            int n1=0, n2=1, n3, i, numero;
            numero = 15;

            Console.WriteLine(n1);
            Console.WriteLine(n2);

            for(i=2; i<numero;++i)
            {
               n3=n1+n2;
               Console.WriteLine(n3);
               n1=n2;
               n2=n3;
            }
        }
    }
}
//créditos: https://www.javatpoint.com/fibonacci-series-in-csharp