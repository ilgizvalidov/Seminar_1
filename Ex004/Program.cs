try 
{
Console.Write ("Введите целое число : ");
int number = Convert.ToInt32 (Console.ReadLine());
 
    if (number > 0 )
    {
        int i = (0 - number);
        while (i <= number)
            {
             Console.Write (i + ", ");
             i++;
            }
    }
    else 
    {
       Console.WriteLine (" Вы ввели отрицательное число");
    
    }
}

catch

{
    Console.Write ("Вы ввели не число");
}
