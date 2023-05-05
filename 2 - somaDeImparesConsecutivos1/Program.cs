using System;

class programa
{
    static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        if (x > y)
        {
            int aux = x;
            x = y;
            y = aux;
        }

        int somaImpares = 0;
        for (int i = x + 1; i < y; i++)
        {
            if (i % 2 != 0)
            {
                somaImpares += i;
            }
        }

        Console.WriteLine(somaImpares);
    }
}