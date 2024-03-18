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

    static void PrintFilteredArray(string[] inputArray)
    {
        string[] filteredArray = new string[0];

        foreach (string str in inputArray)
        {
            if (str == "0")
                break;

            string filteredStr = GetFilteredString(str);
            if (!String.IsNullOrEmpty(filteredStr))
            {
                Array.Resize(ref filteredArray, filteredArray.Length + 1);
                filteredArray[filteredArray.Length - 1] = filteredStr;
            }
        }

        if (filteredArray.Length == 0)
        {
            Console.WriteLine("Символы и цифры не найдены");
        }
        else
        {
            Console.WriteLine("Отфильтрованный массив:");
            foreach (string str in filteredArray)
            {
                Console.WriteLine(str);
            }
        }
    }

    static string GetFilteredString(string str)
    {
        char[] filteredChars = new char[0];

        foreach (char c in str)
        {
            if (Char.IsDigit(c) || Char.IsLetter(c))
            {
                Array.Resize(ref filteredChars, filteredChars.Length + 1);
                filteredChars[filteredChars.Length - 1] = c;
            }

            if (filteredChars.Length >= 3)
                break;
        }

        return new string(filteredChars);
    }
}