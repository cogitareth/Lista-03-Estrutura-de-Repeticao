using System;

class programa
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        for(int i = 0; i < N; i++)
        {
            int x = int.Parse(Console.ReadLine());

            if (x > 0)
            {
                if (x % 2 == 0)
                {
                    Console.WriteLine("EVEN POSITIVE");
                }
                else
                {
                    Console.WriteLine("ODD POSITIVE");
                }
            }

            else if (x < 0)
            {
                if (x % 2 == 0)
                {
                    Console.WriteLine("EVEN NEGATIVE");
                }
                else
                {
                    Console.WriteLine("ODD NEGATIVE");
                }
            } 
            
            else
            {
                Console.WriteLine("NULL");
            }
        }
    }
}
