/*
//задание 1
using System;
class Worker
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public double Rate { get; set; }
    public int Days { get; set; }
    public double GetSalary()
    {
        return Rate * Days;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Worker worker = new Worker();
        Console.Write("Введите имя работника: ");
        worker.Name = Console.ReadLine();
        Console.Write("Введите фамилию работника: ");
        worker.Surname = Console.ReadLine();
        Console.Write("Введите ставку за день работы: ");
        worker.Rate = double.Parse(Console.ReadLine());
        Console.Write("Введите количество отработанных дней: ");
        worker.Days = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Информация о работнике:");
        Console.WriteLine("Имя: " + worker.Name);
        Console.WriteLine("Фамилия: " + worker.Surname);
        Console.WriteLine("Ставка за день работы: " + worker.Rate);
        Console.WriteLine("Количество отработанных дней: " + worker.Days);
        Console.WriteLine("Зарплата: " + worker.GetSalary());
    }
}
*/

/* 
//задание 2

using System;
class Worker
{
    private string name;
    private string surname;
    private double rate;
    private int days;
    public string GetName()
    {
        return name;
    }
    public void SetName(string value)
    {
        name = value;
    }
    public string GetSurname()
    {
        return surname;
    }
    public void SetSurname(string value)
    {
        surname = value;
    }
    public double GetRate()
    {
        return rate;
    }
    public void SetRate(double value)
    {
        rate = value;
    }
    public int GetDays()
    {
        return days;
    }
    public void SetDays(int value)
    {
        days = value;
    }
    public double GetSalary()
    {
        return rate * days;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Worker worker = new Worker();
        Console.Write("Введите имя работника: ");
        worker.SetName(Console.ReadLine());
        Console.Write("Введите фамилию работника: ");
        worker.SetSurname(Console.ReadLine());
        Console.Write("Введите ставку за день работы: ");
        worker.SetRate(double.Parse(Console.ReadLine()));
        Console.Write("Введите количество отработанных дней: ");
        worker.SetDays(int.Parse(Console.ReadLine()));
        Console.WriteLine();
        Console.WriteLine("Информация о работнике:");
        Console.WriteLine("Имя: " + worker.GetName());
        Console.WriteLine("Фамилия: " + worker.GetSurname());
        Console.WriteLine("Ставка за день работы: " + worker.GetRate());
        Console.WriteLine("Количество отработанных дней: " + worker.GetDays());
        Console.WriteLine("Зарплата: " + worker.GetSalary());
    }
}
*/

/*
//Задание 3

using System;
class Calculation
{
    private string calculationLine;
    public void SetCalculationLine(string line)
    {
        calculationLine = line;
    }
    public void SetLastSymbolCalculationLine(char symbol)
    {
        calculationLine += symbol;
    }
    public string GetCalculationLine()
    {
        return calculationLine;
    }
    public char GetLastSymbol()
    {
        if (!string.IsNullOrEmpty(calculationLine))
        {
            return calculationLine[calculationLine.Length - 1];
        }
        return '\0';
    }
    public void DeleteLastSymbol()
    {
        if (!string.IsNullOrEmpty(calculationLine))
        {
            calculationLine = calculationLine.Remove(calculationLine.Length - 1);
        }
    }
}
class Program
{
    static void Main()
    {
        Calculation calc = new Calculation();
        calc.SetCalculationLine(" A - B ");
        Console.WriteLine("Исходная строка: " + calc.GetCalculationLine());
        calc.SetLastSymbolCalculationLine('=');
        Console.WriteLine("Исходная строка после добавления символа: " + calc.GetCalculationLine());
        Console.WriteLine("Последний символ: " + calc.GetLastSymbol());
        calc.DeleteLastSymbol();
        Console.WriteLine("Строка с удаленным последним символом: " + calc.GetCalculationLine());
    }
}
*/
