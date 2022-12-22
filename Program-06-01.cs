/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/


Int64 m;
Int64 CurrentNumber;
Int64 Counter=0;
{
    while (true) // проверка введенного значения
        {
            Console.Write("Введите количество чисел: ");
                if (Int64.TryParse(Console.ReadLine(), out m))
                    {
                        break;
                    }
                    Console.WriteLine("Это не число. Введите число.");
        }

                               
    for (int i=1; i<=m; i++)
        {
            while (true) // Просто проверка введенного значения
                    {
                        Console.Write("Введите {0} число: ",i);
                        if (Int64.TryParse(Console.ReadLine(), out CurrentNumber))
                        {
                            break;
                        }
                        Console.WriteLine("Это не число. Введите число.");
                    }
                    if (CurrentNumber > 0) { Counter++; }
        }
                
        Console.WriteLine("Количество положительных чисел = {0}", Counter);

}
 