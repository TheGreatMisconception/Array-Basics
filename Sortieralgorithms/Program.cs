using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Sortierungsalgorithmen
{
    class Program
    {
        // Fills an Array with random numbers
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

        // Return a array with hardcoded length 
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
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
            Console.Clear();
        }

        // Create and return a filled array with random numbers
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
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
            Console.Clear();
        }

        // Check if a given string can be converted to an Integer
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

        // Method to create an array based on user input
        private static int[] CreateArrayLength(string Variante)
        {

            // Nonsense
            string username;
            string hostname;
            username = Environment.UserName;
            hostname = System.Environment.GetEnvironmentVariable("COMPUTERNAME");

            string Length;
            Length = "#";
            while (!CanConvert(Length))
            {
                Console.Write($"{username}@{hostname}:~/{Variante}# ./{Variante} --start\nStarting {Variante}\n\nEnter Array Length:");
                Length = Console.ReadLine();
                Console.Clear();
            }
            int[] Array;
            Array = new int[Convert.ToInt32(Length)];
            return Array;
        }

        // Create a Array with hardcoded values
        private static int[] CreateArrayLengthHard()
        {
            int Length = 5;
            int[] Array = new int[Length];

            return Array;
        }

        // Output the Array
        private static void Output(int[] Arr, bool clear)
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                Console.WriteLine($"Index {i} : {Arr[i]}");
            }
            if (clear)
            {
                Console.WriteLine("\nPress any key to exit...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        // Create and Fill array based on hardcoded length
        private static void Variante3()
        {
            int[] Array;
            Array = CreateArrayLengthHard();
            Array = FillArray(Array);
            Output(Array, true);
            Console.Clear();
        }

        // User defined Array-length
        private static void Variante4()
        {
            int[] Array;
            Array = CreateArrayLength("Variante4");
            Array = FillArray(Array);
            Output(Array, true);
            Console.Clear();
        }

        // Output a part of an Array based on 2 variables: minimum index and maximum index.
        // As of now, it's not possible to output multiple values that are not logically behind each other
        private static void OutputValues(int[] array, int value1, int value2)
        {
            if (value1 > array.Length || value2 > array.Length || value1 < 0 || value2 < 0) { return; }
            for (int i = value1; i < value2; i++)
            {
                Console.WriteLine($"Index {i} : {array[i]}");
            }
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadLine();
            Console.Clear();
        }

        // Return only parts of an Array
        private static void Variante5()
        {
            int sliceMin;
            int sliceMax;
            sliceMin = 0; // hardcoded value
            sliceMax = 2; // hardcoded value
            int[] Array;
            Array = CreateArrayLength("Variante5");
            Array = FillArray(Array);
            OutputValues(Array, sliceMin, sliceMax);
        }

        // Swapping helper method
        private static int[] SwapValues(int[] array, int Value1, int Value2)
        {
            int TempValue = array[Value1];
            array[Value1] = array[Value2];
            array[Value2] = TempValue;
            return array;
        }

        // Swap Array
        private static void Variante6()
        {
            int[] array;
            array = CreateArrayLength("Variante6");
            array = FillArray(array);
            Console.WriteLine("Before: \n");
            Output(array, false);
            for (int i = 0; i < array.Length / 2; i++)
            {
                array = SwapValues(array, i, array.Length - i - 1);
            }
            Console.WriteLine("\n\nAfter: \n");
            Output(array, true);
            Console.Clear();
        }

        // Sorting using built-in sorting
        private static void Variante7()
        {
            int[] array = CreateArrayLength("Variante7");
            array = FillArray(array);
            Output(array, false);
            Array.Sort(array);
            Output(array, true);
            Console.Clear();

        }

        // BubbleSort implementation
        private static void Variante8()
        {
            int[] array = CreateArrayLength("Variante8");
            array = FillArray(array);
            for (int i = 0; i < array.Length; i++)
            {
                for (int y = 0; y < array.Length; y++)
                {
                    // <  - smaller to greater
                    // >  - greater to smaller
                    if (array[i] < array[y])
                    {
                        // Temp variable in order to swap values
                        int temp;
                        temp = array[y];
                        array[y] = array[i];
                        array[i] = temp;
                    }
                }
            }
            Output(array, true);
            Console.Clear();
        }

        // Selectionsort
        private static void Variante9()
        {
            int[] array = CreateArrayLength("Variante9");
            array = FillArray(array);
            int smallest;
            int temp;
            for (int i = 0; i < array.Length - 1; i++) {
                smallest = i;

                for (int y = i+1; y < array.Length; y++) {
                    if (array[y] < array[smallest]) {
                        smallest = y;
                    }
                }
                temp = array[smallest];
                array[smallest] = array[i];
                array[i] = temp;
            }
            Output(array, true);
        }

        // Add a counter
        private static void Variante10()
        {
            {
                int Counter;
                Counter = 0;
                int[] array = CreateArrayLength("Variante10");
                array = FillArray(array);
                for (int i = 0; i < array.Length; i++)
                {
                    for (int y = 0; y < array.Length; y++)
                    {
                        // <  - smaller to greater
                        // >  - greater to smaller
                        if (array[i] < array[y])
                        {
                            // Temp variable in order to swap values
                            int temp;
                            temp = array[y];
                            array[y] = array[i];
                            array[i] = temp;
                        }
                        Counter++;
                    }
                }
                Console.WriteLine($"Iterations: {Counter}\n");
                Output(array, true);
                Console.Clear();
            }
        }


        // Menu to select the different variants
        private static void Menu()
        {
            bool InMenu;
            // Nonsense
            string username;
            string hostname;
            string version, author, name, source;
            version = "0.2a";
            author = "The GreatMisconception";
            name = "Welcome to SortingFun 1000\n";
            source = "https://github.com/TheGreatMisconception/";
            username = Environment.UserName;
            hostname = System.Environment.GetEnvironmentVariable("COMPUTERNAME");
            // While True Loop variable
            InMenu = true;
            string[] commands = { "clear", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "exit", "quit", "help", "display" };
            string[] Variants = { "Basic Array with 10 Entrys", "Basic Array with 10 Random Entrys", "Basic Arrays with extra method and other length", "Array with user specifed length", "Return only parts of an array", "Swap complete array", "Sorted array with c# built-in algorithm", "Array thats being sorted with bubblesort", "WIP", "sorted array with iteration counter" };
            string welcomemessage = $"{name}Version: {version}\nAuthor: {author}\nSource: {source}\n\nSee \"help\" for more information\n";
            Console.WriteLine(welcomemessage);
            while (InMenu)
            {
                string cmd;

                Console.Write($"{username}@{hostname}: ~#");
                cmd = Console.ReadLine();
                switch (cmd)
                {
                    // clears Console
                    case "clear":
                        Console.Clear();
                        break;
                    // Exists programm
                    case "quit":
                        InMenu = false;
                        break;
                    // Exists programm
                    case "exit":
                        InMenu = false;
                        break;
                    // Prints all available commands to console
                    case "help":
                        Console.WriteLine("Available Commands: \n");
                        foreach (string command in commands) { Console.WriteLine(command); }
                        Console.WriteLine("\n");
                        break;
                    case "1":
                        Console.Clear();
                        Variante1();
                        break;
                    case "2":
                        Console.Clear();
                        Variante2();
                        break;
                    case "3":
                        Console.Clear();
                        Variante3();
                        break;
                    case "4":
                        Console.Clear();
                        Variante4();
                        break;
                    case "5":
                        Console.Clear();
                        Variante5();
                        break;
                    case "6":
                        Console.Clear();
                        Variante6();
                        break;
                    case "7":
                        Console.Clear();
                        Variante7();
                        break;
                    case "8":
                        Console.Clear();
                        Variante8();
                        break;
                    case "9":
                        Console.Clear();
                        Variante9();
                        break;

                    // Displays "About-Message"
                    case "about":
                        Console.WriteLine(welcomemessage);
                        break;
                    case "":
                        break;

                    // Lists all available variants
                    case "display":
                        Console.WriteLine("Available Variants and its description\n");
                        for (int Description = 0; Description < Variants.Length; Description++)
                        {
                            Console.WriteLine($"{Description} {Variants[Description]}");
                        }
                        Console.WriteLine("\n");
                        break;

                    // Fallback if no match
                    default:
                        Console.WriteLine($"{cmd}: Command not found");
                        break;

                }
            }

        }

        // Main Method
        static void Main(string[] args)
        {
            // Launch Main Menu
            Menu();
        }
    }
}
