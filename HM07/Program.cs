// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Введите число от 1 до 7: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day >= 1 && day <= 7)
{
    if (day == 6 || day == 7)
    {
        Console.WriteLine("Выходной день");
    } 
    else
    {
        Console.WriteLine("Рабочий день");
    }
}
else
{
    Console.WriteLine("Вы вышли из диапазона от 1 до 7");
}
