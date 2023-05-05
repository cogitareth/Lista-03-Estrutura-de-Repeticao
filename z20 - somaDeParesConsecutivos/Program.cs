using System;

class Program
{
    static void Main(string[] args)
    {
        int x, soma;

        while (true)
        {
            x = int.Parse(Console.ReadLine());
            if (x == 0) break;
            soma = 0;
            for (int i = 0; i < 5; i++)
            {
                if (x % 2 != 0) x++; // se x for ímpar, somar 1 para torná-lo par
                soma += x;
                x += 2;
            }
            Console.WriteLine(soma);
        }
    }
}
