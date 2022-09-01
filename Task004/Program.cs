Console.Write ("Введите целое число ");
try
    {   
    int x=Convert.ToInt32 (Console.ReadLine());
    Console.Write ("Введите еще одно целое число ");
    int y=Convert.ToInt32 (Console.ReadLine());
    Console.Write ("Bведите третье целое число ");
    int z=Convert.ToInt32 (Console.ReadLine());
    int max=x;
    if (y>max)
        {
            max=y;
        }
    if (z>max) 
        {
            max=z;
        }
    Console.WriteLine("Максимальное из этих чисел "+max);
    }
catch 
    {            
        Console.WriteLine("Что-то пошло не так!");
    }