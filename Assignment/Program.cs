using System;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[4];
            Random random = new Random();

            for (int i=0; i<4; i++)
            {
                array[i] = random.Next();
            }
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(array[i]);
            }

                         
        }
    }
}
