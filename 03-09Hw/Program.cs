using System;
using System.Collections.Generic;
namespace _03_09Hw
{
    /*Lab 1 : Cubic Array 10x10x1
Build a three dimensional array and populate it with numbers which are products of the input numbers. Make the size of the cube to be 10x10x10 and your numbers will run from 1 at (1,1,1) through 1000 at (10,10,10). Numbering starts at 1 here instead of 0.
Tip : use a loop within a loop within a loop to accomplish this!
Lab 2 : List
Create a one-dimensional list of integers called List01.
Iterate over the three dimensional array above, and for every number in the array, add it to the list.
Finally add up the total sum of all numbers in the list and output the result.
Lab 3 : Dictionary
Create a dictionary of 10 countries as the index, with the capital city as the data.
Iterate over the data and display it.
Return the completed dictionary to complete the test
Lab 4 : Queue
Count from 1 to 100 and add the cubes of each number to a queue.
Run dequeue 10 times and sum the output
Return this sum.
Lab 5 : Stack
Repeat this for a stack ie count from 1 to 100, add the cube of each number to the stack, then pop 10 items off the top of the stack and sum the output of those 10 numbers.
Return this sum
     * */
    class Program
    {

        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Hello World!");
            //p.Lab1And2();
            //p.Lab3();
            //p.Lab4();
            p.Lab5();
            Console.ReadLine();

        }

        void Lab1And2()
        {
            int[,,] array = new int[10, 10, 10];
            int total = 0, value = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int x = 0; x < array.GetLength(1); x++)
                {
                    for (int p = 0; p < array.GetLength(2); p++)
                    {
                        array[i, x, p] = (i + 1) * (x + 1) * (p + 1);
                        Console.WriteLine("This is the current array: " + array[i, x, p]);
                    }
                }
            }
            Console.WriteLine("Value of array [2,3,7] : " + array[2, 3, 7]);
            List<int> lister = new List<int>();
            foreach (int i in array)
            {
                lister.Add(i);
            }
            foreach(int i in lister)
            {
                value = value + i;
            }
            Console.WriteLine(value);

        }
        void Lab3()
        {
            Dictionary<string, string> countries = new Dictionary<string, string>()
            {
                {"London","England" },{"Tirana","Albania"},{"Algiers","Algeria"},{"Maputo","Mozambique"},{"Kabul","Afghanistan"},
                {"Brasilia","Brazil" },{"Pyongyang","North Korea"},{"Wellington","New Zealand"},{"Oslo","Norway"},{"Bucharest","Romania"}
            };
            foreach(KeyValuePair<string, string> capital in countries)
            {
                Console.WriteLine(capital.Value);
            }
            foreach (var capital in countries)
            {
                Console.WriteLine(capital.Key);
            }            
        }
        void Lab4()
        {
            double number = 0, result = 0;
            int works = 0;
            Queue<double> que = new Queue<double>();
            for (int i = 0; i < 100; i++)
            {
                number = Convert.ToDouble(i);
                result = Math.Ceiling(Math.Pow(number, (double) 3)); //Unsure if you required cube root or cubed
                //result = number * number * number;
                Console.WriteLine("Result for cube: " + result);
                que.Enqueue(result);
            }
            for (int i = 0; i <= 10; i++)
            {
                que.Dequeue();
            }
            foreach(int i in que)
            {
                works = works + i;
            }
            Console.WriteLine(works);
        }
        void Lab5()
        {
            double number = 0, result = 0, another = 0;
            int works = 0;
            Stack<double> que = new Stack<double>();
            for (int i = 0; i <= 100; i++)
            {
                number = Convert.ToDouble(i);
                result = Math.Ceiling(Math.Pow(number, (double) 3)); //Unsure if you required cube root or cubed
                //result = number * number * number;
                Console.WriteLine("Result for cube: " + result);
                que.Push(result);

            }
            for (int i = 0; i <= 10; i++)
            {
                another = another + que.Pop();
            }
            Console.WriteLine("The sum of the 10 popped off: " + another);
        }
    }
}
