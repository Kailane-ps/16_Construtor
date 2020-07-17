using System;

namespace Construtor
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto Base = new Produto();
            Base.Nome = "base ruby rose feels";


            Console.ForegroundColor = ConsoleColor.Magenta;
            Produto corretivo = new Produto("Castanha 20");
            Console.WriteLine(corretivo.Descricao);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Blue;
            Produto Paleta = new Produto (123,234,"Paleta Mahav","32 cores");
            Console.WriteLine($"Numero do Produto {Paleta.Numero} o estoque: {Paleta.Estoque} Nome:{Paleta.Nome} com {Paleta.Descricao}");
            Console.ResetColor();

        }
    }
}
