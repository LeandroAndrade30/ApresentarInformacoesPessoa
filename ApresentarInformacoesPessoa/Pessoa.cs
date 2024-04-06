using System;
using System.Collections.Generic;
using System.Text;

namespace ApresentarInformacoesPessoa
{
    public class Pessoa
    {
        private string _nome;
        private int _idade;
        private double _altura;
        private string _endereco;

        public Pessoa(string nome, int idade, double altura)
        {
            _nome = nome;
            _idade = idade;
            _altura = altura;
        }


        public Pessoa (string nome, int idade, double altura, string endereco):this(nome,idade,altura)
        {
            _endereco = endereco;
        }

        public string Nome
        {
            get { return _nome; }
            set {  _nome = value; }
        }

        public int Idade
        {
            get { return _idade; }
            set { _idade = value; }
        }

        public double Altura
        {
            get { return _altura; }
            set { _altura = value; }
        }

        public string Endereco
        {
            get { return _endereco; }
            set { _endereco = value; }
        }




        public  void Apresentar()

        {
            Console.WriteLine($"O nome da pessoa é: {_nome}");
            Console.WriteLine($"A Idade da pessoa é: {_idade}");
            Console.WriteLine($"O Altura da pessoa é: {_altura}");
            Console.WriteLine($"O Altura da pessoa é: {_endereco}");

        }   
    }
}
