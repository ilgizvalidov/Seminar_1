Console.Write("Введите целое число: ");
    try
        {
        int number = Convert.ToInt32 (Console.ReadLine () );
        int result = number * number;
        Console.WriteLine ("Квадратцелого числа " + number + " равен " + result);
        if (number > 0 )
            Console.WriteLine ("Число положительное");
            
        else if (number < 0) Console.WriteLine ("Число отрицательное");
            else Console.WriteLine ("Вы ввели ноль"); 
// Выведу все числа от 0 до number
            int i = 0;
            while (i <= number) 
                {
                    Console.Write(i + ", ");
                    i++;            
                }

        }

    catch
        {
            Console.WriteLine ("надо было вводить именно целое число");
        }
 