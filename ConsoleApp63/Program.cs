using System;

namespace forre
{
    class Program
    {
        static void Main(string[] args)
        {
            bool start = true;

            while (start != false)
            {
                Console.WriteLine("1. Addera tre tal");
                Console.WriteLine("2. Största talet av två tal");
                Console.WriteLine("3. Avsluta programmet");

                int menyval = int.Parse(Console.ReadLine());

                switch (menyval)
                {

                    case 1:
                        Console.WriteLine("Skriv ett tal");
                        int a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Skriv ett till tal");
                        int b = int.Parse(Console.ReadLine());
                        Console.WriteLine("Skriv ett till tal");
                        int c = int.Parse(Console.ReadLine());
                        Console.WriteLine(Addera(a, b, c));
                        break;

                    case 2:
                        Console.WriteLine("Skriv ett tal");
                        int ab = int.Parse(Console.ReadLine());
                        Console.WriteLine("Skriv ett till tal");
                        int ba = int.Parse(Console.ReadLine());
                        Console.WriteLine(Störst(ab, ba));
                        break;


                    case 3:
                        start = false;
                        break;

                }



            }

            static int Addera(int a, int b, int c)
            {
                return a + b + c;
            }

            static int Störst(int ab, int ba)
            {
                if (ab > ba)
                {
                    return ab;
                }

                else {
                    return ba;
                }

                   
            }
        }
    }
}