using System;

class Programa
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        

        for (int i = 0; i < N; i++)
        {
            string[] lista = Console.ReadLine().Split(' ');
            double x1 = double.Parse(lista[0]);
            double x2 = double.Parse(lista[1]);
            double x3 = double.Parse(lista[2]);

            double media = (((x1 * 2) + (x2 * 3) + (x3 * 5)) / 10);

            Console.WriteLine(media.ToString("N1"));
        }
    }
}