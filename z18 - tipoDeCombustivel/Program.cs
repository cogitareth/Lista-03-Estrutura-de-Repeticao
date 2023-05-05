using System;

class Program
{
    static void Main(string[] args)
    {
        int alcool = 0, gasolina = 0, diesel = 0;
        int tipo = 0;

        do
        {
            tipo = int.Parse(Console.ReadLine());
            switch (tipo)
            {
                case 1:
                    alcool++;
                    break;
                case 2:
                    gasolina++;
                    break;
                case 3:
                    diesel++;
                    break;
                case 4:
                    break;
                default:
                    continue;
            }
        } while (tipo != 4);

        Console.WriteLine("MUITO OBRIGADO");
        Console.WriteLine("Alcool: " + alcool);
        Console.WriteLine("Gasolina: " + gasolina);
        Console.WriteLine("Diesel: " + diesel);
    }
}
