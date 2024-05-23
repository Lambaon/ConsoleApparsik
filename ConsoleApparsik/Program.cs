using System;

namespace RandomNumbersGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Min");
            int min = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Max");
            int max = int.Parse(Console.ReadLine());

            if (min > max)
            {
                Console.WriteLine("Error");
                return;
            }
            Random random = new Random();
            
            int[] numbers = new int[40];
            
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(min, max + 1);
            }
            
            Array.Sort(numbers);

            string output = "";
            for (int i = 0; i < numbers.Length; i++)
            {

                output += numbers[i];
                if (i < numbers.Length - 1)
                {
                    output += ", ";
                }
            }
            
            Console.WriteLine("Numbers");
            Console.WriteLine(output);


        }
    }
}