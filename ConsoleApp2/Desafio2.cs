using System;

namespace ConsoleApp2
{
    internal class Desafio2
    {
        static void Main(string[] args)
        {
            double nota, media;
            int qtNotas = 0;
            double soma = 0;
            double novoCalculo = 1;
            while (novoCalculo == 1)
            {
                nota = Convert.ToDouble(Console.ReadLine()); ;
                if (nota < 0 || nota > 10)
                {
                    Console.WriteLine("nota invalida");
                }
                else
                {
                    soma += nota;
                    qtNotas++;
                    if (qtNotas == 2)
                    {
                        media = soma / qtNotas;
                        Console.Write("media = ");
                        Console.WriteLine(media.ToString("N2"));
                        soma = 0;
                        qtNotas = 0;
                        novoCalculo = 0;
                        while (!(novoCalculo == 1 || novoCalculo == 2))
                        {
                            Console.WriteLine("novo calculo (1-sim 2-nao)");
                            novoCalculo = double.Parse(Console.ReadLine());
                        }
                    }
                }
            }
        }
    }
}
