using System;

class Program
{
    static void Main()
    {
        string[] userInputArray = ReadArrayFromConsole();

        PrintFilteredArray(userInputArray);
    }

    static string[] ReadArrayFromConsole()
    {
        Console.WriteLine("Введите строки для формирования массива (для завершения введите 0):");

        string[] inputArray = new string[0];
        string input;

        do
        {
            Array.Resize(ref inputArray, inputArray.Length + 1);
            input = Console.ReadLine();

            inputArray[inputArray.Length - 1] = input;
        } while (input != "0");

        return inputArray;
    }