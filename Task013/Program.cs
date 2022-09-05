// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
void numbers(int num)
{
    int temp=num;
    int coun=0;
    int coun1=0;
    while (temp > 0)
            {
                temp = temp / 10;
                coun++;
            }
    if (coun < 3)
            {
                Console.WriteLine("Третьей цифры нет");
            }
    else
    {
       // Console.WriteLine($"Разрядность числа {coun}");
        temp=num;
        while (coun1 < coun-3)
        {
            temp = temp / 10;
            coun1++;
        }
            Console.WriteLine($"Третья цифра введенного числа {temp%10}");
    }
}

Console.Write ("Введите число ");
int num=Convert.ToInt32 (Console.ReadLine());

numbers(num);