/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/


Double k1;
Double k2;
Double b1;
Double b2;
        
    while (true) // проверка введенного значения
        {
            Console.Write("Введите число k1: ");
            if (Double.TryParse(Console.ReadLine(), out k1))
                {
                    break;
                }
            Console.WriteLine("Это не число. Введите число");
                }

                while (true) // проверка введенного значения
                {
                    Console.Write("Введите число b1: ");
                    if (Double.TryParse(Console.ReadLine(), out b1))
                    {
                        break;
                    }
                    Console.WriteLine("Это не число. Введите число");
                }

                while (true) // проверка введенного значения
                {
                    Console.Write("Введите число k2: ");
                    if (Double.TryParse(Console.ReadLine(), out k2))
                    {
                        break;
                    }
                    Console.WriteLine("Это не число. Введите число");
                }

                while (true) // проверка введенного значения
                {
                    Console.Write("Введите число b2: ");
                    if (Double.TryParse(Console.ReadLine(), out b2))
                    {
                        break;
                    }
                    Console.WriteLine("Это не число. Введите число");
                }


                if (k1 == k2) { Console.WriteLine("k1=k2! Линии параллельны и не пересекаются."); }
                else { Console.WriteLine("Точка пересечения линий с координатами [x,y]: [{0},{1}]", Math.Round(1/k2*(b1-k1*b2/k2)/(1-k1/k2)-b2/k2,1), Math.Round((b1-k1*b2/k2)/(1-k1/k2),1));}
                

              
        