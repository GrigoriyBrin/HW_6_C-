// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
namespace GeekBrains
{
    class Task_1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите произвольное количество вещественных чисел через пробел: ");
            
            string? m = Console.ReadLine();
            string[] numbersArray = m.Split(' ');
            
            Console.WriteLine();
            CountNumbers(numbersArray);
            
        }

        public static void CountNumbers(string[] numbers)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                double c = Convert.ToDouble(numbers[i].ToString());
                if (c > 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"Пользователь ввел {count} чисел больше 0");
        }  
    }
}
