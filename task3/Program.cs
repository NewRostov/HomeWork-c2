// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

internal class Program
{
    private static void Main(string[] args)
    {
        string[] week = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
        Console.WriteLine("Введите цифру, обозначающую день недели");
        int n = Convert.ToInt32(Console.ReadLine());
        int i = n - 1;
        if (n > 0 && n <= 5) { Console.WriteLine(week[i] + " не выходной день!"); }
        if (n >= 6 && n <= 7) { Console.WriteLine(week[i] + " выходной день!"); }
        if (n <= 0 || n > 7) { Console.WriteLine("Введите цифру, обозначающую день недели от 1 до 7"); }
    }
}