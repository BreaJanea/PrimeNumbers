using System;

namespace PrimeLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's Locate Some Primes!\n");
            Console.WriteLine("This application will find you any prime, in order, from first prime number on!");

            do
            {
                Console.Write("\nWhich prime number are you looking for? ");

                int input = int.Parse(Console.ReadLine());

                if (input < 2)
                {
                    return;
                }
                Console.WriteLine($"The number {input} prime is {PrimeNumbers.GetPrime(input)}");
            } while (UserContiue());
        }
        public static bool UserContiue()
        {
            char c;
            do
            {
                Console.Write("\nDo you want to find another prime number(y/n)? ");
                c = Console.ReadKey().KeyChar;
                if (c == 'n' || c == 'N')
                {
                    Console.WriteLine("\nSee ya!");
                    return false;
                }
            } while (c != 'y' && c != 'Y');
            return true;
        }
    }
}
