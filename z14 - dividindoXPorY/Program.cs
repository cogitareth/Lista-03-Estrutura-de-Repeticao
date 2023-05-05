using System;

class programa
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int x = int.Parse(valores[0]);
            int y = int.Parse(valores[1]);

            if (y == 0)
            {
                Console.WriteLine("divisao impossivel");
            }
            else
            {
                double resultado = (double) x / y;
                Console.WriteLine(resultado.ToString("F1"));
            }
        }
    }
}