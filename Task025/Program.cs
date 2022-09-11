// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
int AToThePowerOfN (int a, int b)
{
    int res = 1; //Math.Pow(a,n);
    for (int i = 0; i < b; i++) res = res*a;
    return res;
}
try 
    {
        Console.WriteLine("Введите первое натуральное число ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе натуральное число ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine ($"{a}, {b} -> {AToThePowerOfN(a, b)}");
    }
catch
    {
        Console.WriteLine("Ошибка ввода данных!");
    }