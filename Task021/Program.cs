// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
double lengthBetween (int x1, int y1, int z1, int x2, int y2, int z2)
{
    double res;
    res = Math.Sqrt ((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
    return res;
}
try 
            {
            Console.WriteLine("Введите координаты первой точки");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            int z1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты второй точки");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            int z2 = Convert.ToInt32(Console.ReadLine());

            double rez = lengthBetween (x1, y1, z1, x2, y2, z2);
            Console.WriteLine ($"A ({x1},{y1},{z1}); B ({x2},{y2},{z2})  ->  {Math.Round(rez, 2)}");
            }
        catch
            {
                Console.WriteLine("Ошибка ввода данных!");
            }
