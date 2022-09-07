// Задача 23 Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
string TableKub (int x)
{
    int i = 2;
    string result = string.Empty;
    if (x<0)
        {
            result ="Вы ввели неподходящее число";
        }
        else
        {
            result = x+" -> 1";
            while (i<=x)
                {
                result = result+", "+Math. Pow(i,3);
                i++;
                }
        }
    return result;
}
Console.Write ("Введите целое положительное число ");
try
    {   
    int x=Convert.ToInt32 (Console.ReadLine());
    Console.WriteLine(TableKub(x));
    }
catch 
    {            
        Console.WriteLine("Что-то пошло не так!");
    }




