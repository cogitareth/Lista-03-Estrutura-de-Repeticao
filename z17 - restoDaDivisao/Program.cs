using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int x, y;

        x = int.Parse(Console.ReadLine());
        y = int.Parse(Console.ReadLine());

        if (x > y)
        {
            int aux = x;
            x = y;
            y = aux;
        }

        for (int i = x + 1; i < y; i++)
        {
            int resto = i % 5;

            if (resto == 2 || resto == 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
