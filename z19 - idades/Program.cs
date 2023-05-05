using System;

class Program
{
    static void Main(string[] args)
    {
        int idade, somaIdades = 0, contIndividuos = 0;

        while (true)
        {
            idade = int.Parse(Console.ReadLine());
            if (idade < 0) break;

            somaIdades += idade;
            contIndividuos++;
        }

        double mediaIdades = (double)somaIdades / contIndividuos;
        Console.WriteLine(mediaIdades.ToString("F2"));
    }
}
