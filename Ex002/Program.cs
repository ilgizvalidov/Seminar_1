try 
    {
    Console.WriteLine("Введите первое чило: ");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе чило: ");
    int number2 = Convert.ToInt32(Console.ReadLine());
    if (number1 == number2*number2) Console.WriteLine ("Число " + number1 + " является квадратом числа " + number2 );
    else if (number2 == number1 * number1) Console.WriteLine ("Число " + number2 + " является квадратом числа " + number1);
            else Console.WriteLine ("числа не являются квадратами друг друга");
    }
catch
{
    Console.WriteLine ("Вы ввели не числа");
}
