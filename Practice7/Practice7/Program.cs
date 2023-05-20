using System;

namespace Practice7
{
    class programm
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" -Здравствйуте, скажите, как к вам можно обращаться?"); //Приветствие
            Console.ForegroundColor = ConsoleColor.Magenta;
            string name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" -Приятно познакомиться, " + name + "!");
            Console.WriteLine("  Данная программа поможет вам вычислить следующее: min^2 * ((x + y + z) / 2), x * y * z) + 1"); //Пример
            Console.WriteLine();
            Console.WriteLine("Пункт 1 - Вычисление min^2 * ((x + y + z) / 2), x * y * z) + 1)");
            Console.WriteLine("Пункт 2 - Выход из программы");
            int mpoint = Convert.ToInt32(Console.ReadLine());
            switch (mpoint)
            {
                case 1:
                {
                    Console.WriteLine(" ___________________________");
                    Console.Write(" *Введите значение переменной x: ");  //Значение первой переменной
                    double x = Convert.ToDouble(Console.ReadLine());
                    Console.Write(" *Введите значение переменной y: ");  //Значение второй переменной
                    double y = Convert.ToDouble(Console.ReadLine());
                    Console.Write(" *Введите значение переменной z: ");  //Значение третьей переменной
                    double z = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(" ___________________________");
                    if (((x + y + z / 2) < (x * y * z)))
                    {
                        Console.WriteLine($"Так как выражение (x + y + z / 2)  меньше чем ( x * y * z ), то результат:\n (x + y + z / 2) ^ 2 + 1 = ({x} + {y} + {z})/ 2) ^ 2 + 1 = {Math.Pow(((x + y + z) / 2), 2) + 1}  ");
                    }
                    else
                    {
                        Console.WriteLine($"Так как выражение ( x * y * z ) меньше или равно (x + y + z / 2), то результат:\n ( x * y * z ) ^ 2 + 1 =({x} * {y} * {z}) ^ 2 + 1 = {Math.Pow((x * y * z), 2) + 1}  ");
                    }
                    Console.WriteLine("Результат использования условной операции");
                    Console.WriteLine(x + y + z / 2.0 < x * y * z ? $"Так как выражение (x + y + z / 2) < (x * y * z) со значениями {x}, {y},{z}; то результат: min ^ 2 * ((x + y + z) / 2) + 1 = min ^ 2 * (({x} + {y} + {z})/ 2) + 1) = {Math.Pow((x+y+z) / 2.0, 2) + 1}": $"Так как выражение (x * y * z) <= ((x + y + z) / 2) со значениями {x}, {y}, {z}; то результат: min ^ 2 * (x * y * z) + 1 = min ^ 2({x} * {y} * {z} + 1 = {Math.Pow(x * y * z, 2) + 1}") ;
                    Console.ReadLine();
                    break;
                }
                case 2:
                {
                     Console.Clear();
                     Console.ForegroundColor = ConsoleColor.Magenta;
                     Console.WriteLine("(Выход из программы)");
                     Console.ResetColor();
                     return;
                     Console.WriteLine();
                     break;

                }
            }   
        }

    }

}