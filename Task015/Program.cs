// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
void numbers(int a)
{
    if (a == 1 ^ a == 2 ^ a == 3 ^ a == 4 ^ a == 5 )
    {
        Console.WriteLine("Нет (номеру соответствует будний день)");
    }
    else if (a == 6 ^ a == 7)
    {
        Console.WriteLine("Да (номеру соответствует выходной)");
    }
    else
    {
        Console.WriteLine("Дня недели с таким номером нет");
    }
}    
Console.Write ("Введите номер дня недели ");
int a = Convert.ToInt32 (Console.ReadLine());

numbers(a);