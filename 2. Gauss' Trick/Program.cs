using System;
using System.Linq;
using System.Collections.Generic;

namespace _2._Gauss__Trick
{
    class Program
    {1 2 3 4 51 2 3 4 5
        static void Main(string[] args)
        {//12345
            
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int originalLenght = numbers.Count;
            for (int i = 0; i < numbers.Count/2; i++)
            {//    1             1           5
                numbers[i] = numbers[i] + numbers[numbers.Count - 1];
                numbers.RemoveAt(numbers.Count - 1);
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
