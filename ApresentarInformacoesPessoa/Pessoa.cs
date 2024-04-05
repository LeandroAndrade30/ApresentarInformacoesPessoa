using System;
using System.Collections.Generic;
using System.Text;

namespace ApresentarInformacoesPessoa
{
    public  class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Altura { get; set; }

        public Pessoa(string nome, int idade, double altura)
        {
            Nome = nome;
            Idade = idade;
            Altura = altura;
        }

        public  void Apresentar()

        {
            Console.WriteLine($"O nome da pessoa é: {Nome}");
            Console.WriteLine($"A Idade da pessoa é: {Idade}");
            Console.WriteLine($"O Altura da pessoa é: {Altura}");
        }
    }
}
