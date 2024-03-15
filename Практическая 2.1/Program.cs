// 1 задание

/*
using System;
public class Program
{
    public static void Main()
    {
        // Инициализация строк J и S
        string J = "lsa";
        string S = "llddssaac";
        // Вызов метода CountJewelsInStones для подсчета драгоценностей
        int count = CountJewelsInStones(J, S);
        Console.WriteLine("Количество драгоценностей: " + count);
    }
    public static int CountJewelsInStones(string J, string S)
    {
        int count = 0;

        foreach (char stone in S)
        {
            if (J.Contains(stone))
            {
                ++count;
            }
        }
        return count;
    }
}
*/

// Задание 2


/*
using System;
using System.Collections.Generic;
public class Program
{
    public static void Main()
    {
        int[] candidates1 = { 2, 5, 2, 1, 2 };
        int target1 = 5;
        var result1 = CombinationSum(candidates1, target1);
        PrintResult(result1);
        int[] candidates2 = { 10, 1, 2, 7, 6, 1, 5 };
        int target2 = 8;
        var result2 = CombinationSum(candidates2, target2);
        PrintResult(result2);
    }
    public static IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        IList<IList<int>> result = new List<IList<int>>();
        Array.Sort(candidates);
        Backtrack(result, new List<int>(), candidates, target, 0);
        return result;
    }
    public static void Backtrack(IList<IList<int>> result, List<int> tempList, int[] candidates, int remaining, int start)
    {
        if (remaining < 0)
        {
            return;
        }
        else if (remaining == 0)
        {
            result.Add(new List<int>(tempList));
        }
        else
        {
            
            for (int i = start; i < candidates.Length; i++)
            {
                if (i > start && candidates[i] == candidates[i - 1])
                {
                    continue;
                }
                tempList.Add(candidates[i]);
                Backtrack(result, tempList, candidates, remaining - candidates[i], i + 1);
                tempList.RemoveAt(tempList.Count - 1);
            }
        }
    }
    public static void PrintResult(IList<IList<int>> result)
    {
        Console.WriteLine("[");
        foreach (var combination in result)
        {
            Console.Write("[");
            
            for (int i = 0; i < combination.Count; i++)
            {
                Console.Write(combination[i]);
                if (i != combination.Count - 1)
                {
                    Console.Write(",");
                }
            }
            Console.WriteLine("],");
        }
        Console.WriteLine("]");
    }
}
*/

//Задание 3

/*
using System;
using System.Collections.Generic;
public class Program
{
    public static void Main()
    {
        int[] nums1 = { 1, 2, 3, 4 };
        bool result1 = ContainsDuplicate(nums1);
        Console.WriteLine(result1);
        int[] nums2 = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
        bool result2 = ContainsDuplicate(nums2);
        Console.WriteLine(result2);
        int[] nums3 = { 1, 2, 3, 1 };
        bool result3 = ContainsDuplicate(nums3);
        Console.WriteLine(result3);
    }
    public static bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> set = new HashSet<int>();

        foreach (int num in nums)
        {
            if (set.Contains(num))
            {
                return true;
            }
            else
            {
                set.Add(num);
            }
        }
        return false;
    }
}
*/