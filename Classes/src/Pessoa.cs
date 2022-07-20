using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.src
{
     class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Endereço { get; set; }

        public Pessoa(string nome, int idade, string endereço)

        {
            Nome = nome;    
            Idade = idade;
            Endereço = endereço;

        }

        public void falar()
        {
            Console.WriteLine("Eu sei falar");
        }
    }
}
