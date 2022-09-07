// Задача 19 - HARD необязательная
// Напишите программу, которая принимает на вход целое число любой разрядности и проверяет, 
// является ли оно палиндромом.double lengthBetweenN (int N)
string PalindromeN (int number)
    {
        int temp=number;
        int coun=0;
        string result = "да";
        while (temp > 0)
                {
                    temp = temp / 10;
                    coun++;
                }
        int[] array = new int[coun];
        temp=number;
        int i = 0;
        while (i<coun)
                    {
                        array[i] = temp%10;
                        Console.WriteLine($"массив {array[i]}");
                        temp = temp / 10;
                        i++;
                    }
        i=0;
        while (i<coun/2)
        {
            if (array[i]!=array[coun-i-1])
            {
                result = "нет";
            }
            i++;
        }
        return result;
    }
try 
    {
    Console.Write ("Введите число, чтобы проверить, является ли оно палиндромом ");
    int a = Convert.ToInt32 (Console.ReadLine());
    Console.WriteLine(a+" -> "+PalindromeN(a));
    }
catch
    {
        Console.WriteLine("Ошибка ввода данных!");
    }
