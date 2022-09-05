// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
void numbers(int num)
{
    int result=0;
    if ((num<100) ^ (num>=1000))
        {
            Console.WriteLine("Вы ввели неподходящее число");
        }
        else Console.WriteLine($"Вторая цифра введенного числа {num%100/10}");
}

Console.Write ("Введите трёхзначное число ");
int num=int.Parse(Console.ReadLine());

numbers(num);