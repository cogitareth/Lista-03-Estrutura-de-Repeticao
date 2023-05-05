using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int senha = 2002;
        int tentativa;

        do
        {
            tentativa = int.Parse(Console.ReadLine());

            if (tentativa != senha)
            {
                Console.WriteLine("Senha Invalida");
            }

        } while (tentativa != senha);

        Console.WriteLine("Acesso Permitido");
    }
}
