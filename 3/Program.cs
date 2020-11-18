using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Informações pessoais

            Console.WriteLine("Bem Vindo, Insira seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Insira sua Idade:");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira seu salário:");
            int salario = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira seu Estado Civil:");
            Console.WriteLine("");
            Console.WriteLine("1 - Solteiro(a)");
            Console.WriteLine("2 - Casado(a)");
            Console.WriteLine("3 - Viuvo(a)");
            Console.WriteLine("4 - Divorciado(a)");
            Console.WriteLine("-------------------------------------------------------");
            int estadoCivil = int.Parse(Console.ReadLine());

            Console.WriteLine("-------------------------------------------------------");
            while(idade > 150 || salario < 0 || estadoCivil > 4){
                Console.WriteLine("Informações inválidas, porfavor insira novamente.");

                Console.WriteLine("Bem Vindo, Insira seu nome: ");
                nome = Console.ReadLine();

                Console.WriteLine("Insira sua Idade:");
                idade = int.Parse(Console.ReadLine());

                Console.WriteLine("Insira seu salário:");
                salario = int.Parse(Console.ReadLine());

                Console.WriteLine("Insira seu Estado Civil:");
                Console.WriteLine("");
                Console.WriteLine("1 - Solteiro(a)");
                Console.WriteLine("2 - Casado(a)");
                Console.WriteLine("3 - Viuvo(a)");
                Console.WriteLine("4 - Divorciado(a)");
                estadoCivil = int.Parse(Console.ReadLine());
            }
            
            if(idade < 150 || salario > 0 || estadoCivil < 4 && estadoCivil > 1){
        
                Console.WriteLine("Informações validadas com sucesso!");
            }
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Nome: "+nome);
            Console.WriteLine("Idade: "+idade+" anos");
            Console.WriteLine("Salário: R$ "+salario);
            switch(estadoCivil)
                {
                case 1:
                Console.WriteLine("Estado civil: Solteiro(a)");
                break;

                case 2:
                Console.WriteLine("Estado civil: Casado(a)");
                break;

                case 3:
                Console.WriteLine("Estado civil: Viuvo(a)");
                break;

                case 4:
                Console.WriteLine("Estado civil: Divorciado(a)");
                break;
                }
        }
    }
}
