using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortierungsalgorithmen
{
    class Program
    {
        private static int[] FillArray(int[] array)
        {
            int Min;
            int Max;
            Random RND = new Random();
            Min = 0;
            Max = 11;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = RND.Next(Min, Max);

            }
            return array;
        }
        private static void Variante1()
        {
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;

            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Index {i} : {array[i]}");
            }
            Console.ReadKey();
        }

        private static void Variante2()
        {
            int Min;
            int Max;
            Random RND = new Random();
            int[] array = new int[10];
            Min = 0;
            Max = 11;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = RND.Next(Min, Max);

            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Index {i} : {array[i]}");
            }
            Console.ReadKey();
        }


        private static bool CanConvert(string num)
        {
            try
            {
                Convert.ToInt32(num);
            }
            catch
            {
                return false;
            }
            return true;
        }

        private static int[] CreateArrayLength()
        {
            string Length;
            Length = "#";
            while (!CanConvert(Length))
            {
                Console.Write("Array Length: ");
                Length = Console.ReadLine();
            }
            int[] Array;
            Array = new int[Convert.ToInt32(Length)];
            return Array;
        }

        private static int[] CreateArrayLengthHard()
        {
            int Length = 5;
            int[] Array = new int[Length];

            return Array;
        }


        private static void Output(int[] Arr)
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                Console.WriteLine($"Index {i} : {Arr[i]}");
            }
            Console.WriteLine("\n--ende");
        }
        private static void Variante3()
        {
            int[] Array;
            Array = CreateArrayLengthHard();
            Array = FillArray(Array);
            Output(Array);
            Console.ReadLine();
        }

        private static void Variante4()
        {
            int[] Array;
            Array = CreateArrayLength();
            Array = FillArray(Array);
            Output(Array);
            Console.ReadLine();
        }

        // Output a part of a array based on 2 variables minimum index and maximum index.
        // As of now, its not possible to output multiple values that are not logically following each other in a array
        private static void OutputValues(int[] array, int value1, int value2)
        {
            if (value1 > array.Length || value2 > array.Length || value1 < 0 || value2 < 0) { return; }
            for (int i = value1; i < value2; i++)
            {
                Console.WriteLine($"Index {i} : {array[i]}");
            }
        }


        private static void Variante5()
        {
            int sliceMin;
            int sliceMax;
            sliceMin = 0; // manual input
            sliceMax = 2; // manual input
            int[] Array;
            Array = CreateArrayLength();
            Array = FillArray(Array);
            OutputValues(Array, sliceMin, sliceMax);
            Console.ReadLine();
        }

        private static int[] SwapValues(int[] array, int Value1, int Value2)
        {
            int TempValue = array[Value1];
            array[Value1] = array[Value2];
            array[Value2] = TempValue;
            return array;
        }
        private static void Variante6()
        {
            int[] array;
            array = CreateArrayLength();
            array = FillArray(array);
            Output(array);
            for (int i = 0; i < array.Length / 2; i++)
            {
                Console.WriteLine(array.Length - i - 1);
                array = SwapValues(array, i, array.Length - i - 1);
            }
            Output(array);
            Console.ReadLine();
        }

        private static void Variante7()
        {
            int[] array = CreateArrayLength();
            array = FillArray(array);
            Output(array);
            Array.Sort(array);
            Output(array);
            Console.ReadLine();

        }

        static void Main(string[] args)
        {
            Variante7();
        }
    }
}
