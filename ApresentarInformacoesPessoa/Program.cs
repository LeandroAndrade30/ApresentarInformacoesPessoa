using System;

namespace ApresentarInformacoesPessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o nome da pessoa");
            string nome = Console.ReadLine();
            Console.WriteLine("Informe a idade  da pessoa");
            int  idade = int.Parse( Console.ReadLine());
            Console.WriteLine("Informe a altura  da pessoa");
            double altura = double.Parse(Console.ReadLine());
            Pessoa p = new Pessoa(nome,idade,altura);
            p.Apresentar();
        }
    }
}
