using System;
using System.Collections.Generic;
// https://www.codewars.com/kata/52597aa56021e91c93000cb0/train/csharp

namespace TasksFromCodewars.Tasks
{
    internal class MovingZerosToTheEnd
    {
        static int size;
        public static void Start()
        {
            Console.WriteLine("Введите размерность массива");
            GetTheSize();
            Console.WriteLine("Введите элементы массива:");
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = GetTheNumber();
            }
            Console.WriteLine("Приступили к перемещению нулей в конец массива. \nПолученный массив:");
            MoveZeroes(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("  " + arr[i]);
            }
            Console.ReadKey();
        }
        public static int[] MoveZeroes(int[] arr)
        {
            List<int> temp = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    temp.Add(arr[i]);
                }
            }
            for (int i = 0; i < temp.Count; i++)
            {
                arr[i] = temp[i];
            }
            for (int i = temp.Count; i < arr.Length; i++)
            {
                arr[i] = 0;
            }
            return arr;
        }
        public static int GetTheNumber()
        {
            int numbTemp = 0;
            try
            {
                numbTemp = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Данные введены не корректно, повторите ввод");
                GetTheNumber();
            }

            return numbTemp;
        }
        public static int GetTheSize()
        {
            try
            {
                size = Convert.ToInt32(Console.ReadLine());
            }
            catch { GetTheSize(); }
            return size;
        }
    }
}
