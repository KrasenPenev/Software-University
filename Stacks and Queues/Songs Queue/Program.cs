using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Songs_Queue_1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputArr = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            Queue<string> que = new Queue<string>(inputArr);

            string comand = "";

            while (que.Count()!=0)
            {
                comand = Console.ReadLine();
                if (comand=="Play")
                {
                    que.Dequeue();
                }
                else if (comand.Contains("Add"))
                {
                    string[] comandArr = comand.Split("Add", StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string song = comandArr[0].Trim();
                    if (que.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                        continue;
                    }

                    que.Enqueue(song);
                }
                else if (comand=="Show")
                {
                    Console.WriteLine(string.Join(", ",que));
                }
            }
            if (que.Count==0)
            {
                Console.WriteLine("No more songs!");
            }
        }
    }
}
