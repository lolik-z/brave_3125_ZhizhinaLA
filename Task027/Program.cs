// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int SumN(int x)
{
    int result = 0;
    int temp=x;
    for (int i = 0; i < x; i++) 
    {
        result = result + temp%10;
        temp = temp / 10;
    }
    return result;
}
Console.Write("Введите целое положительное число ");
try
{
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Cумма цифр в числе {x} -> {SumN(x)}");
}
catch
{
    Console.WriteLine("Что-то пошло не так!");
}