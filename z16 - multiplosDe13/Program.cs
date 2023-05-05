using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int x, y, soma = 0;

        x = int.Parse(Console.ReadLine());
        y = int.Parse(Console.ReadLine());

        if (x > y)
        {
            int aux = x;
            x = y;
            y = aux;
        }

        for (int i = x; i <= y; i++)
        {
            if (i % 13 != 0)
            {
                soma += i;
            }
        }

        Console.WriteLine(soma);
    }
}
