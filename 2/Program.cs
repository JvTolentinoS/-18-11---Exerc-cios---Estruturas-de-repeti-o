using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Insira seu nome de usuário"); //NOME
            string nome = Console.ReadLine();

            Console.WriteLine("Insira sua senha"); //SENHA
            string senha = Console.ReadLine();

            while(nome == senha)
            {
                Console.WriteLine("Seu nome/senha não deve ser igual a seu nome/senha, insira novamente: ");

                Console.WriteLine("Insira seu nome de usuário"); //NOME
                string nome2 = Console.ReadLine();

                Console.WriteLine("Insira sua senha"); //SENHA
                string senha2 = Console.ReadLine();

            }
        }
    }
}
