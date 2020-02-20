using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    class RandomArray
    {
        List<int> list = new List<int>();
      
        Random random = new Random();

             public void AddElement()
        {
                for(int i=0; i<4; i++)
            {
                list.Add(random.Next());
                            
            }
        }
        public void PrintElement()
        {
            foreach (int number in list)
            {
                Console.WriteLine(number);
            }
        }


    }
}
