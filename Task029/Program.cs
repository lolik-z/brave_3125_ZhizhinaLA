// Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран. 
// N - вводится с клавиатуры. Элементы тоже вводятся с клавиатуры.
// 5
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 3
// 6, 1, 33 -> [6, 1, 33]
int[] ArrayN(int N)
{
    int[] array = new int[N];
    Console.WriteLine("Введите значения элементов массива ");
    for (int i = 0; i < N; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
try
{
    Console.Write("Введите целое число ");
    int a = Convert.ToInt32(Console.ReadLine());
    int[] array = ArrayN(a);
    Console.Write("Задан массив [");
    for (int i = 0; i < a - 1; i++) Console.Write(array[i] + ", ");
    Console.Write(array[a - 1] + "]");
}
catch (System.Exception)
{
    Console.WriteLine("Ошибка ввода!");
}