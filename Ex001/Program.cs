﻿Console.Write("Введите целое число: ");
int number = Convert.ToInt32 (Console.ReadLine () );
int result = number * number;
Console.WriteLine ("Квадратцелого числа " + number + " равен " + result);
if (number > 0 )
{
    Console.WriteLine ("Число положительное");
}
else if (number < 0) 
        {
            Console.WriteLine ("Число отрицательное");
        }
     else 
        {
            Console.WriteLine ("Вы ввели ноль");
        }