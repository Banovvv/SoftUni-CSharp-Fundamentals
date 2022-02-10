using System;
using System.Linq;

namespace _11.ArrayManipulator
{
    internal class Program
    {
        static void Main()
        {
            int[] inputArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string rawInput;

            while ((rawInput = Console.ReadLine()) != "end")
            {
                string[] args = rawInput.Split();

                Arraymanipulator(inputArray, args);
            }
        }

        public static void Arraymanipulator(int[] inputArray, string[] args)
        {
            int[] functionArray = new int[inputArray.Length];
            Array.Copy(inputArray, functionArray, inputArray.Length);

            if (args[0] == "exchange")
            {
                for (int i = 1; i <= int.Parse(args[1]) + 1; i++)
                {
                    int firstElement = functionArray[0];

                    for (int j = 1; j < functionArray.Length; j++)
                    {
                        int currentElement = functionArray[j];
                        functionArray[j - 1] = currentElement;
                    }
                    functionArray[functionArray.Length - 1] = firstElement;
                }

                Console.WriteLine(string.Join(" ", functionArray));

            }
            else if (args[0] == "max")
            {
                if (args[1] == "even")
                {
                    int maxEvenIndex = 0;
                    int previousMaxNumber = -1;
                    for (int i = 0; i < inputArray.Length; i++)
                    {
                        if (inputArray[i] % 2 == 0)
                        {
                            if (inputArray[i] >= previousMaxNumber)
                            {
                                previousMaxNumber = inputArray[i];
                                maxEvenIndex = i;
                            }
                        }
                    }
                    if (previousMaxNumber == -1)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(maxEvenIndex);
                    }
                }
                else if (args[1] == "odd")
                {
                    int maxOddIndex = 0;
                    int previousMaxNumber = -1;
                    for (int i = 0; i < inputArray.Length; i++)
                    {
                        if (inputArray[i] % 2 != 0)
                        {
                            if (inputArray[i] >= previousMaxNumber)
                            {
                                previousMaxNumber = inputArray[i];
                                maxOddIndex = i;
                            }
                        }
                    }

                    if (previousMaxNumber == -1)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(maxOddIndex);
                    }
                }
            }
            else if (args[0] == "min")
            {
                if (args[1] == "even")
                {
                    int minEvenIndex = 0;
                    int previousMinNumber = 1001;
                    for (int i = 0; i < inputArray.Length; i++)
                    {
                        if (inputArray[i] % 2 == 0)
                        {
                            if (inputArray[i] <= previousMinNumber)
                            {
                                previousMinNumber = inputArray[i];
                                minEvenIndex = i;
                            }
                        }
                    }
                    if (previousMinNumber == 1001)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(minEvenIndex);
                    }
                }
                else if (args[1] == "odd")
                {
                    int minOddIndex = 0;
                    int previousMinNumber = 1001;
                    for (int i = 0; i < inputArray.Length; i++)
                    {
                        if (inputArray[i] % 2 != 0)
                        {
                            if (inputArray[i] <= previousMinNumber)
                            {
                                previousMinNumber = inputArray[i];
                                minOddIndex = i;
                            }
                        }
                    }
                    if (previousMinNumber == 1001)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(minOddIndex);
                    }
                }
            }
            else if (args[0] == "first")
            {
                int count = int.Parse(args[1]);
                int[] firstArray = new int[count];

                if (count > inputArray.Length)
                {
                    Console.WriteLine("Invalid count");
                }
                else
                {
                    if (args[2] == "even")
                    {
                        for (int i = 1; i <= count;)
                        {
                            for (int j = 0; j < inputArray.Length; j++)
                            {
                                if (inputArray[j] % 2 == 0)
                                {
                                    if (i > count)
                                    {
                                        break;
                                    }
                                    firstArray[i - 1] = inputArray[j];
                                    i++;
                                }
                            }
                        }
                        Console.Write("[");
                        for (int i = 0; i < firstArray.Length; i++)
                        {
                            if (firstArray[i] != 0 && i != firstArray.Length - 1)
                            {
                                Console.Write($"{firstArray[i]}, ");
                            }
                            else if (firstArray[i] != 0 && i == firstArray.Length - 1)
                            {
                                Console.Write($"{firstArray[i]}");
                            }
                        }
                        Console.Write("]");
                        Console.WriteLine();
                    }
                    else if (args[2] == "odd")
                    {
                        for (int i = 1; i < count;)
                        {
                            for (int j = 0; j < inputArray.Length; j++)
                            {
                                if (inputArray[j] % 2 != 0)
                                {
                                    if(i > count)
                                    {
                                        break;
                                    }
                                    firstArray[i - 1] = inputArray[j];
                                    i++;
                                }
                            }
                        }
                        Console.Write("[");
                        for (int i = 0; i < firstArray.Length; i++)
                        {
                            if (firstArray[i] != 0 && i != firstArray.Length - 1)
                            {
                                Console.Write($"{firstArray[i]}, ");
                            }
                            else if (firstArray[i] != 0 && i == firstArray.Length - 1)
                            {
                                Console.Write($"{firstArray[i]}");
                            }
                        }
                        Console.Write("]");
                        Console.WriteLine();
                    }
                }
            }
            else if (args[0] == "last")
            {
                int count = int.Parse(args[1]);
                int[] firstArray = new int[count];

                if (count > inputArray.Length)
                {
                    Console.WriteLine("Invalid count");
                }
                else
                {
                    if (args[2] == "even")
                    {
                        for (int i = 1; i <= count;)
                        {
                            for (int j = 0; j < inputArray.Length; j++)
                            {
                                if (inputArray[j] % 2 == 0)
                                {
                                    if (i > count)
                                    {
                                        break;
                                    }
                                    firstArray[i - 1] = inputArray[j];
                                    i++;
                                }
                            }
                        }
                        Console.Write("[");
                        for (int i = 0; i < firstArray.Length; i++)
                        {
                            if (firstArray[i] != 0 && i != firstArray.Length - 1)
                            {
                                Console.Write($"{firstArray[i]}, ");
                            }
                            else if (firstArray[i] != 0 && i == firstArray.Length - 1)
                            {
                                Console.Write($"{firstArray[i]}");
                            }
                        }
                        Console.Write("]");
                        Console.WriteLine();
                    }
                    else if (args[2] == "odd")
                    {
                        for (int i = 1; i <= count;)
                        {
                            for (int j = 0; j < inputArray.Length; j++)
                            {
                                if (inputArray[j] % 2 != 0)
                                {
                                    if (i > count)
                                    {
                                        break;
                                    }
                                    firstArray[i - 1] = inputArray[j];
                                    i++;
                                }
                            }
                        }
                        Console.Write("[");
                        for (int i = 0; i < firstArray.Length; i++)
                        {
                            if (firstArray[i] != 0 && i != firstArray.Length - 1)
                            {
                                Console.Write($"{firstArray[i]}, ");
                            }
                            else if (firstArray[i] != 0 && i == firstArray.Length - 1)
                            {
                                Console.Write($"{firstArray[i]}");
                            }
                        }
                        Console.Write("]");
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
