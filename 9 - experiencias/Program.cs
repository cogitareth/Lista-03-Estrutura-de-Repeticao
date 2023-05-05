using System;

class programa
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int quantiaCoelhos = 0, quantiaRatos = 0, quantiaSapos = 0, quantiaTotal = 0;


        for(int i = 0; i < N; i++)
        {
            string[] testes = Console.ReadLine().Split(' ');
            int quantia = int.Parse(testes[0]);
            string tipo = testes[1];

            if (tipo == "C")
            {
                quantiaCoelhos += quantia;
            }
            
            else if (tipo == "R")
            {
                quantiaRatos += quantia;
            }

            else
            {
                quantiaSapos += quantia;
            }

            quantiaTotal += quantia;
        }

        double percentualCoelhos = (double)quantiaCoelhos / quantiaTotal * 100;
        double percentualRatos = (double)quantiaRatos / quantiaTotal * 100;
        double percentualSapos = (double)quantiaSapos / quantiaTotal * 100;

        Console.WriteLine("Total: " + quantiaTotal + " cobaias");
        Console.WriteLine("Total de coelhos: " + quantiaCoelhos);
        Console.WriteLine("Total de ratos: " + quantiaRatos);
        Console.WriteLine("Total de sapos: " + quantiaSapos);
        Console.WriteLine("Percentual de coelhos: " + percentualCoelhos.ToString("F2") + " %");
        Console.WriteLine("Percentual de ratos: " + percentualRatos.ToString("F2") + " %");
        Console.WriteLine("Percentual de sapos: " + percentualSapos.ToString("F2") + " %");
    }
}