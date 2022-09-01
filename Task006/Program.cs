Console.Write ("Введите целое число ");
try
    {   
    int x=Convert.ToInt32 (Console.ReadLine());
    if (x%2==0)
        {
            Console.WriteLine("Вы ввели четное число");
        }
    else Console.WriteLine("Вы ввели нечетное число");
    }
catch 
    {            
        Console.WriteLine("Что-то пошло не так!");
    }
