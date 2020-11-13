using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int anoNascimento;
            int ano;
            int idade;
            int idadeSemana;
            
            Console.WriteLine("Qual seu ano de nascimento?");
            anoNascimento = int.Parse(Console.ReadLine());
            Console.WriteLine("Em que ano estamos?");
            ano = int.Parse(Console.ReadLine());

            idade = ano-anoNascimento;

            Console.WriteLine("Sua idade é: "+idade);

            idadeSemana = idade*52;

            Console.WriteLine("Sua idade em semanas é: "+idadeSemana);

        }
    }
}
