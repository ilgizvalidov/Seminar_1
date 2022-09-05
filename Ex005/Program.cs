try 
{
    Console.Write("Введите трехзначное целое положительное число : ");
    int number = Convert.ToInt32(Console.ReadLine());
        if (number < 1000 ) 
            if (number > 99) Console.WriteLine (number / 100); // получаем первую цифру от трехзначного числа
            else Console.WriteLine ("Вы ввели не трехзначное число");  
        else Console.WriteLine ("Вы ввели число более чем с тремя знаками");    
}
catch 
{
    Console.WriteLine ("Вы ввели не трехзначное целое число, повторите попытку");
}
