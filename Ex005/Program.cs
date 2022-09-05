try 
{
    Console.Write("Введите трехзначное целое положительное число : ");
    int number = Convert.ToInt32(Console.ReadLine());
        if (number < 1000 ) 
            if (number > 99) Console.WriteLine (number % 10); // остаток от деления числа на 10 и будет последней цифрой
            else Console.WriteLine ("Вы ввели не трехзначное число");  
        else Console.WriteLine ("Вы ввели число более чем с тремя знаками");    
}
catch 
{
    Console.WriteLine ("Вы ввели не трехзначное целое число, повторите попытку");
}
