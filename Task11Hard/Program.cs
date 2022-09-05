// Задача 11 HARD - необязательная: Напишите программу, которая принимает на вход 
// целое число любой разрядности число и удаляет вторую цифру слева направо этого
// числа.
void numbers(int num)
{
    int temp=num;
    int coun=0;
    int coun1=0;
    while (temp > 0)
            {
                temp = temp / 10;
                coun++;
            }
    if (coun < 3)
            {
                Console.WriteLine(num);
            }
    else
    {
       // Console.WriteLine($"Разрядность числа {coun}");
        Console.Write((int)(num / Math.Pow(10,coun-1)));
        temp=((int)(num%Math.Pow(10,coun-2)));
        //Console.Write(temp);
        coun1 = coun-2;
        while (coun1 > 0)
        {
           Console.Write((int)(temp/ Math.Pow(10,coun1-1)));
           temp = (int)(temp % Math.Pow(10,coun1-1));
           coun1--;
        }          
    }
   Console.WriteLine(); 
}
Console.Write ("Введите число ");
int num=Convert.ToInt32 (Console.ReadLine());
numbers(num);
