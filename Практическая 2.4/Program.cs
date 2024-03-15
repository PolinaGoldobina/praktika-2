//Задание 1 
using System;
using System.Collections.Generic;

public class RomanToIntegerConverter
{
    public static int Convert(string romanNumber)
    {
        var romanValues = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        int result = 0;
        int prevValue = 0;

        for (int i = romanNumber.Length - 1; i >= 0; i--)
        {
            int currValue = romanValues[romanNumber[i]];

            if (currValue >= prevValue)
            {
                result += currValue;
            }
            else
            {
                result -= currValue;
            }

            prevValue = currValue;
        }
        return result;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите римское число:");
        string romanNumber = Console.ReadLine();
        int integerNumber = RomanToIntegerConverter.Convert(romanNumber);
        Console.WriteLine($"Ввод: {romanNumber}");
        Console.WriteLine($"Вывод: {integerNumber}");
    }
}