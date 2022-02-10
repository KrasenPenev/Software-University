using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<int> st = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();
                if (command.Length>1)
                {
                    var comandArr = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                    int pushingNumber =int.Parse(comandArr[1]);

                    st.Push(pushingNumber);
                }
                else
                {
                    int cuurentNumComand = int.Parse(command);
                    if (st.Count==0)
                    {
                        continue;
                    }

                    if (cuurentNumComand==2)
                    {
                        if (st.Count == 0)
                        {
                            continue;
                        }
                        st.Pop();
                    }
                    else if (cuurentNumComand==3)
                    {
                      
                        int maxValue = int.MinValue;

                        if (st.Count == 0)
                        {
                            continue;
                        }
                        else
                        {
                            foreach (var elemnt in st)
                            {
                                if (maxValue < elemnt)
                                {
                                    maxValue = elemnt;
                                }
                            }
                            Console.WriteLine(maxValue);
                        }
                    }
                    else if (cuurentNumComand==4)
                    {
                        int minElemnt = int.MaxValue;

                        if (st.Count == 0)
                        {
                            continue;
                        }
                        else
                        {
                            foreach (var element in st)
                            {
                                if (minElemnt > element)
                                {
                                    minElemnt = element;
                                }
                            }
                            Console.WriteLine(minElemnt);
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(", ",st));
           
        }
    }
}
