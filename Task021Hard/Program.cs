// Задача 21 - HARD необязательная
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними 
// в N-мерном пространстве. Сначала задается N с клавиатуры, потом задаются координаты точек.
double lengthBetweenN (int N)
{
    int[] array1 = new int[N];
    int[] array2 = new int[N];
    int i = 0;
    double res = 0;
    int temp = 0;
    if (N==0)
    {  res = 0; }
    else
        {
            Console.WriteLine("Введите координаты первой точки");
            while (i<N)
                {
                    array1[i] = Convert.ToInt32(Console.ReadLine());
                    i++;
                }
            i = 0;
            Console.WriteLine("Введите координаты второй точки");
            while (i<N)
                {
                    array2[i] = Convert.ToInt32(Console.ReadLine());
                    i++;
                }   
            i = 0;
            while (i<N)
                {
                    temp = temp+(array2[i]-array1[i])*(array2[i]-array1[i]);
                    i++;
                }
            res = Math.Sqrt (temp);
        }
    return res;
}
try 
    {
        Console.WriteLine("Введите размерность пространства ");
        int N = Convert.ToInt32(Console.ReadLine());
        double rez = lengthBetweenN(N);
        Console.WriteLine ($"Расстояние между точками  {Math.Round(rez, 2)}");
    }
catch
    {
        Console.WriteLine("Ошибка ввода данных!");
    }
