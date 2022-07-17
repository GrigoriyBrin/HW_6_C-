// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
namespace GeekBrains
{
    class Task_1
    {
        public static void Main(string[] args)
        {
              try
            {
                Console.WriteLine("Введите 4 вещественных числа через пробел: ");
                string? sourceArray = Console.ReadLine();
                string[] numbersArray = sourceArray.Split(' ');

                double b1 = Convert.ToDouble(numbersArray[0].ToString());
                double k1 = Convert.ToDouble(numbersArray[1].ToString());
                double b2 = Convert.ToDouble(numbersArray[2].ToString());
                double k2 = Convert.ToDouble(numbersArray[3].ToString());
                Console.Write($"b1 = {b1}; k1 = {k1}; b2 = {b2}; k2 = {k2}");   

                Console.WriteLine();

                SolutionEquation(b1, k1, b2, k2);
            }
            catch
            {
                Console.WriteLine("Введите числа согласно инструкции, иначе программа не запустится!");
            }
        }

        public static void SolutionEquation(double valueB1, double valueK1, double valueB2, double valueK2)
        {
            double x = (valueB1 - valueB2) / (valueK2 - valueK1);
            double y = valueK2 * ((valueB1 - valueB2) / (valueK2 - valueK1)) + valueB2;
            bool validCross = y - y != valueK1 * x - valueK2 * x + valueB1 - valueB2;
            bool validIdentity = valueB1 == valueB2 && valueK1 == valueK2;

            if (validIdentity)
            {
                Console.WriteLine("Прямые совпадают, уравнение имеет бесконечное множество решений");
            }
            else if (validCross)
            {
                Console.WriteLine("Прямые не пересекаются, уравнение не имеет решения");
            }

            else
            {
                Console.WriteLine($"Точки пересечения: ({x}), ({y})");
            }
        }
    }
}

