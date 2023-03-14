//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
//что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите целое число, не меньше трехзначного: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number < 99) Console.WriteLine("Вы ввели не трехзначное целое число - третьей цифры нет!");
        else if (number > 99)

        {
            while (number > 1000)
            {
                number = number / 10;
            }

            Console.WriteLine("Третья цифра равна: " + number % 10);
        }
    }
}