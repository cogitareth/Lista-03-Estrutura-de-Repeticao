using System;

class MainClass
{
    public static void Main(string[] args)
    {
        double nota1 = -1, nota2 = -1;

        while (true)
        {
            double nota = double.Parse(Console.ReadLine());

            if (nota < 0 || nota > 10)
            {
                Console.WriteLine("nota invalida");
            }
            else
            {
                if (nota1 == -1)
                {
                    nota1 = nota;
                }
                else
                {
                    nota2 = nota;
                    break;
                }
            }
        }

        double media = (nota1 + nota2) / 2;
        Console.WriteLine($"media = {media:F2}");
    }
}
