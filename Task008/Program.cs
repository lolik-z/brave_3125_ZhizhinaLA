Console.Write ("Введите целое положительное число больше единицы ");
try
    {   
    int x=Convert.ToInt32 (Console.ReadLine());
    int i = 2;
    
    if (x<2)
        {
            Console.WriteLine("Вы ввели неподходящее число");
        }
        else
        {
            Console.WriteLine("Чётные числа от 1 до "+x+": ");
            while (i<=x)
                {
                Console.Write (+i+", ");
                i=i+2;
                }
        }
    }
catch 
    {            
        Console.WriteLine("Что-то пошло не так!");
    }