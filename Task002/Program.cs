Console.Write ("Введите целое число ");
try
    {   
    int x=Convert.ToInt32 (Console.ReadLine());
    Console.Write ("Введите еще одно целое число ");
    int y=Convert.ToInt32 (Console.ReadLine());
    if (x>y)
        {
        Console.WriteLine("Максимальное из двух чисел "+x+", а минимальное "+y);
        }
    else if (y>x) Console.WriteLine("Максимальное из двух чисел "+y+", а минимальное "+x);
    else Console.WriteLine("Вы ввели равные числа "+x+"="+y);
    }
catch 
    {
                    
        Console.WriteLine("Что-то пошло не так!");
    }