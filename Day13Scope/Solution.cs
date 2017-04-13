using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Task
//Complete the Difference class by writing the following:

//A class constructor that takes an array of integers as a parameter and saves it to the elements instance variable.
//A computeDifference method that finds the maximum absolute difference between any 2 numbers in  array
//and stores it in the maximum Difference instance variable.
//Input Format

//You are not responsible for reading any input from stdin.
//    The locked Solution class in your editor reads in  lines of input; the first line contains,
//    and the second line describes the array.
namespace Day13Scope
{
    class Solution
    {
        static void Main(string[] args)
        {

            Convert.ToInt32(Console.ReadLine());

            int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Difference d = new Difference(a);
            d.Print();

            //d.computeDifference();

            //Console.Write(d.maximumDifference);
        }
    }
    class Difference
    {
        private int[] elements;
        public int maximumDifference;

        public Difference(int[] num)
        {
            this.elements = num;
            this.maximumDifference = computeDifference();

        }

        public void Print()
        {
            foreach(var v in elements)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine("Maximum Difference is :" + maximumDifference);
            Console.ReadLine();
        }

        public int computeDifference()
        {
            int result = 0;
            maximumDifference = 0;
            //iterate through array
            for (int i = 0; i < elements.Length; i++)
            {
                for (int j = 0; j < elements.Length; j++)
                {
                    result = elements[j] - elements[i];
                    if(result > maximumDifference)
                    {
                        maximumDifference = result;
                    }
                }
                
            }

            return maximumDifference;

        }
    }
}
