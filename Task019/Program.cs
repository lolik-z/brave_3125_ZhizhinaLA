// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
string Palindrome5 (int number)
{
    int temp=number;
    int coun=0;
    while (temp > 0)
            {
                temp = temp / 10;
                coun++;
            }
    string result = string.Empty;
    if ((coun == 5))
    {
        if ((number/10000==number%10)&((number%10000)/1000==(number/10)%10))
        {
            result = "да";
        }
        else result = "нет";
    } else result = "Разрядность числа "+coun;
    return result;
}
try 
    {
    Console.Write ("Введите пятизначное число, чтобы проверить, является ли оно палиндромом ");
    int a = Convert.ToInt32 (Console.ReadLine());
    Console.WriteLine(a+" -> "+Palindrome5(a));
    }
catch
    {
        Console.WriteLine("Ошибка ввода данных!");
    }