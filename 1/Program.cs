using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Insira uma nota de 0 a 10.");
            nota = int.Parse(Console.ReadLine());
            
            while (nota > 10)
            {
                Console.WriteLine("Valor Inválido, insira novamente");
                nota = int.Parse(Console.ReadLine());
            }
            if (nota <= 10){
                Console.WriteLine("Nota validada.");
            }
        }
    }
}
