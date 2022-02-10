using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {

            int kg = int.Parse(Console.ReadLine());

            Queue<int> que = new Queue<int>();

            string[] input = Console.ReadLine().Split(" ").ToArray(); ;
            int maxValue = int.MinValue;
            int sumOfOrders = 0;
            for (int i = 0; i < input.Length; i++)
            {
                int currentNum = int.Parse(input[i]);
                if (maxValue < currentNum)
                {
                    maxValue = currentNum;
                }
                sumOfOrders += currentNum;
                que.Enqueue(currentNum);
            }



            while (que.Count != 0)
            {

                //  kg -= que.Dequeue();
                int curentOrder = que.Peek();

                if (curentOrder<=kg)
                {
                    kg -= que.Dequeue();
                }
                else
                {
                    break;
                }
                //if (que.Count == 0 || kg <= que.Peek())
                //{
                //    break;
                //}
            }

            if (que.Count == 0)
            {
                Console.WriteLine(maxValue);
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine(maxValue);
                Console.WriteLine($"Orders left: {string.Join(" ", que)}");
            }




        }
    }
}
