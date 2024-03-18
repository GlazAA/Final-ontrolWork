using System;

class Program
{
    static void Main()
    {
        string[] inputArray = new string[100]; 
        int count = 0;

        Console.WriteLine("Введите строки для формирования массива (для завершения введите 0):");

        string input = Console.ReadLine();
        while (input != "0")
        {
            inputArray[count] = input;
            count++;

            input = Console.ReadLine();
        }



        string[] resultArray = new string[count];
        int resultCount = 0;

        for (int i = 0; i < count; i++)
        {
            string inputString = inputArray[i];
            string resultString = "";

            foreach (char c in inputString)
            {
                if (char.IsLetterOrDigit(c))
                {
                    if (resultString.Length < 3)
                    {
                        resultString += c;
                    }
                }
            }

            if (resultString == "")
            {
                resultArray[resultCount] = "символы и цифры не найдены";
            }
            else
            {
                resultArray[resultCount] = resultString;
            }

            resultCount++;
        }

        Console.WriteLine("Результат:");

        for (int i = 0; i < resultCount; i++)
        {
            Console.WriteLine(resultArray[i]);
        }
    }
}
