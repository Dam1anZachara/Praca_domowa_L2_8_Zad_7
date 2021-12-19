using System;

namespace L2_8_Zad_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program narysuje diament o krótszej przekątnej o długości wprowadzonej przez użytkownika");

            Console.Write("Wprowadź długość: ");
            Int32.TryParse(Console.ReadLine(), out int input);

            int counter1 = 1;

            for (int i = 0; i < input;)
            {
                for (int j = 1; j <= input / 2; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < counter1; k++)
                {
                    Console.Write("*");
                }

                for (int l = 1; l <= input / 2; l++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
                input -= 2;
                counter1 += 2;
            }

            input += 4;
            counter1 -= 4;

            for (int i = 0; i < counter1;)
            {
                for (int j = 1; j <= input / 2; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < counter1; k++)
                {
                    Console.Write("*");
                }

                for (int l = 1; l <= input / 2; l++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
                input += 2;
                counter1 -= 2;
            }
        }
    }
}
