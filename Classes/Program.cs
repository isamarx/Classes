using Classes.src;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pessoas");

            Pessoa Samara = new Pessoa("Samara", 19, "Rua Colibri");
            Console.WriteLine("Eu sou a " + Samara.Nome + ". Tenho " + Samara.Idade + " anos e moro na " + Samara.Endereço);
            Samara.falar();

            Pessoa Joao = new Pessoa("Joao", 14, "Rua Charles");
            Console.WriteLine("Eu sou o " + Joao.Nome + ". Tenho " + Joao.Idade + " anos e meu endereço fica na " + Joao.Endereço);
            Joao.falar();

            Pessoa Valentina = new Pessoa("Valentina", 12, "Rua Charles");
            Console.WriteLine("Eu sou a " + Valentina.Nome + ". Tenho " + Valentina.Idade + " anos e meu endereço é " + Valentina.Endereço);
            Valentina.falar();

            Pessoa Lucas = new Pessoa("Lucas", 7, "Travessa Curio");
            Console.WriteLine("Eu sou o " + Lucas.Nome + ". Tenho " + Lucas.Idade + " anos e moro na " + Lucas.Endereço);

        }
    }
}
