using System;

namespace AP204_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 10;

            //for (int i = num; i <= 0; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //while (num<20)
            //{
            //    Console.WriteLine(num);
            //    num++;
            //}
            //for (; ; )
            //{
            //    Console.WriteLine("loading...");
            //}


            //int selection;
            //do
            //{
            //    Console.WriteLine("1. Create");
            //    Console.WriteLine("2. Update");
            //    Console.WriteLine("3. Delete");
            //    Console.WriteLine("4. Detail");
            //    Console.WriteLine("0. Exit");

            //    selection = Convert.ToInt32(Console.ReadLine());

            //} while (selection!=0);


            //int[] array = new int[15];

            //for (int i = 0; i < array.Length; i++)
            //{
            //if (i < 5)
            //{
            //    array[i] = i * 5;
            //}
            //else
            //{
            //    array[i] = i;
            //}
            //Console.WriteLine(array[i]);
            //}

            //for (int i = 0; i < array.Length; i++)
            //{
            //}

            //foreach (int number in array)
            //{
            //    Console.WriteLine(number);
            //}

            //int[] arr = new int[] { 5, 20, 33, 41, 89, 104 };


            //for (int i = 0; i < arr.Length; i++)
            //{


            //    if (arr[i] == 41)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(arr[i]);

            //}
            //Console.WriteLine("After loop");


            //string name = "Malik";

            //for (int i = 0; i < name.Length; i++)
            //{
            //    Console.Write(name[i]);
            //}

            //Console.WriteLine(name[4]);

            //foreach (char letter in name)
            //{
            //    Console.WriteLine(letter);
            //}


            string word = Console.ReadLine();

            bool result = false;

            //for (int i = 0; i < word.Length; i++)
            //{
            //    if (word[i] == 'a')
            //    {
            //        Console.WriteLine("a var");
            //        result = true;
            //        break;
            //    }

            //}
            //if (result == false)
            //{
            //    Console.WriteLine("yoxdur");
            //}


            foreach (char letter in word)
            {
                if(letter == 'a')
                {
                    Console.WriteLine("a var");
                    result = true;
                    break;
                }
            }
            if (result == false)
            {
                Console.WriteLine("yoxdur");
            }
        }
    }
}
