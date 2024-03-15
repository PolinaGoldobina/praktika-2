/*

//Задание 1

using System;
class Student
{
    public string Surname { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string GroupNumber { get; set; }
    public int[] Grades { get; set; }

    public void Input()
    {
        Console.WriteLine("Введите фамилию");
        Surname = Console.ReadLine();
        Console.WriteLine("Введите дату рождения (дд.мм.гггг)");
        string DateOfBirthInput = Console.ReadLine();
        DateOfBirth = DateTime.ParseExact(DateOfBirthInput, "dd.MM.yyyy", null);
        Console.WriteLine("Введите номер группы");
        GroupNumber = Console.ReadLine();
        Grades = new int[5] { 4, 4, 3, 5, 3 };
    }
    public void ChangeSurname()
    {
        Console.WriteLine("Введите новую фамилию");
        Surname = Console.ReadLine();
    }
    public void ChangeDateOfBirth()
    {
        Console.WriteLine("Введите новую дату рождения (дд.мм.гггг)");
        string DateOfBirthInput = Console.ReadLine();
        DateOfBirth = DateTime.ParseExact(DateOfBirthInput, "dd.MM.yyyy", null);
    }
    public void ChangeGroupNumber()
    {
        Console.WriteLine("Введите новый номер группы");
        GroupNumber = Console.ReadLine();
    }
    public void PrintStudentInfo()
    {
        Console.WriteLine($"Фамилия студента: {Surname}");
        Console.WriteLine($"Дата рождения студента: {DateOfBirth:dd.MM.yyyy}");
        Console.WriteLine($"Номер группы: {GroupNumber}");
        Console.WriteLine("Успеваемость студента:");
        foreach (int grade in Grades)
        {
            Console.Write($"{grade} ");
        }
    }
    public static void Main(string[] args)
    {
        Student student = new Student();
        student.Input();
        Console.WriteLine("Если вы хотите изменить фамилию, введите 1");
        Console.WriteLine("Если вы хотите изменить дату рождения, введите 2");
        Console.WriteLine("Если вы хотите изменить номер группы, введите 3");
        int choose = Convert.ToInt32(Console.ReadLine());

        if (choose == 1)
        {
            student.ChangeSurname();
        }
        else if (choose == 2)
        {
            student.ChangeDateOfBirth();
        }
        else if (choose == 3)
        {
            student.ChangeGroupNumber();
        }
        Console.WriteLine();
        student.PrintStudentInfo();
    }
}
*/

/*

//Задание 2

using System;
class Train
{
    public string Destination { get; set; }
    public int TrainNumber { get; set; }
    public DateTime DepartureTime { get; set; }
    public Train(string destination, int trainNumber, DateTime departureTime)
    {
        Destination = destination;
        TrainNumber = trainNumber;
        DepartureTime = departureTime;
    }
    public void PrintTrainInfo()
    {
        Console.WriteLine("Поезд №" + TrainNumber);
        Console.WriteLine("Направление: " + Destination);
        Console.WriteLine("Время отправления: " + DepartureTime.ToString("HH:mm"));
    }
}
class Program
{
    static void Main(string[] args)
    {
        Train[] trains = new Train[]
        {
            new Train("Москва", 1, new DateTime(2024, 12, 10, 8, 30, 0)),
            new Train("Санкт-Петербург", 2, new DateTime(2024, 12, 11, 17, 0, 0)),
            new Train("Владивосток", 3, new DateTime(2024, 12, 12, 19, 20, 0))
        };
        Console.Write("Введите номер поезда: ");
        int trainNumber = int.Parse(Console.ReadLine());
        Train selectedTrain = null;
        foreach (Train train in trains)
        {
            if (train.TrainNumber == trainNumber)
            {
                selectedTrain = train;
                break;
            }
        }

        if (selectedTrain != null)
        {
            Console.WriteLine();
            selectedTrain.PrintTrainInfo();
        }
        else
        {
            Console.WriteLine("Поезд с номером " + trainNumber + " не найден");
        }
    }
}
*/

/*

//Задание 3
using System;
class Numbers
{
    private int number1;
    private int number2;
    public int Number1
    {
        get { return number1; }
        set { number1 = value; }
    }
    public int Number2
    {
        get { return number2; }
        set { number2 = value; }
    }
    public void PrintNumbers()
    {
        Console.WriteLine("Число 1: " + number1);
        Console.WriteLine("Число 2: " + number2);
    }
    public void ChangeNumbers()
    {
        Console.WriteLine("Введите новое значение для числа 1:");
        number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите новое значение для числа 2:");
        number2 = Convert.ToInt32(Console.ReadLine());
    }
    public int CalculateSum()
    {
        return number1 + number2;
    }
    public int FindMax()
    {
        return Math.Max(number1, number2);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Numbers numbers = new Numbers();
        numbers.ChangeNumbers();
        Console.WriteLine();
        numbers.PrintNumbers();
        int sum = numbers.CalculateSum();
        Console.WriteLine("Сумма чисел: " + sum);
        int max = numbers.FindMax();
        Console.WriteLine("Наибольшее значение: " + max);
    }
}

*/

/*
//Задание 4
using System;
class Counter
{
    private int value;
    public int Value
    {
        get { return value; }
        set { this.value = value; }
    }
    public Counter()
    {
        value = 0; 
    }
    public Counter(int initialValue)
    {
        value = initialValue; 
    }
    public void Increment()
    {
        value++;
    }
    public void Decrement()
    {
        value--;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Counter counter = new Counter();
        Console.WriteLine("Введите начальное значение счетчика:");
        counter.Value = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите количество операций увеличения:");
        int incrementCount = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите количество операций уменьшения:");
        int decrementCount = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Текущее состояние счетчика: " + counter.Value);

        for (int i = 0; i < incrementCount; i++)
        {
            counter.Increment();
        }

        for (int i = 0; i < decrementCount; i++)
        {
            counter.Decrement();
        }
        Console.WriteLine("Итоговое состояние счетчика: " + counter.Value);
    }
}

*/

/*
// 5 задание

using System;
class Person
{
    private string name;
    private int age;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public int Age
    {
        get { return age; }
        set { age = value; }
    }
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
        Console.WriteLine("Объект создан. Имя: " + name + ", Возраст: " + age);
    }
    public Person()
    {
        name = "";
        age = 0;
        Console.WriteLine("Объект создан по умолчанию. Имя: " + name + ", Возраст: " + age);
    }
    ~Person()
    {
        Console.WriteLine("Объект удален. Имя: " + name + ", Возраст: " + age);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Person person1 = new Person("Max", 27);
        Person person2 = new Person();
        Console.WriteLine("Введите новое имя:");
        person1.Name = Console.ReadLine();
        Console.WriteLine("Введите новый возраст:");
        person1.Age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Информация о созданных объектах:");
        Console.WriteLine("Person1: Имя - " + person1.Name + ", Возраст - " + person1.Age);
        Console.WriteLine("Person2: Имя - " + person2.Name + ", Возраст - " + person2.Age);
    }
}
*/

