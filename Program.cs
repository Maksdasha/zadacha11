using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zadacha11
{

    class Program
    {
        static void Main(string[] args)
        {
            double radius_in, radius_out, square;
            string temp;
            bool trying;

            //Цикл повторяется до тех пор, пока пользователь вводит некорректные данные.
            do
            {
                try //Пробуем считать данные
                {
                    trying = true;
                    Console.Write("Введите площадь кольца: ");
                    temp = Console.ReadLine();
                    temp = temp.Replace('.', ',');
                    square = Convert.ToDouble(temp);
                }
                catch (Exception e) //Если не получается, значит данные некорректны. Повторяем цикл.
                {
                    trying = false;
                    Console.WriteLine("Введено неккоректное значение. Попробуйте еще раз.");
                    square = 0;
                }
            } while (!trying);

            do
            {
                try
                {
                    trying = true;
                    Console.Write("Введите внешний радиус кольца: ");
                    temp = Console.ReadLine();
                    temp = temp.Replace('.', ',');
                    radius_out = Convert.ToDouble(temp);
                }
                catch (Exception e)
                {
                    trying = false;
                    Console.WriteLine("Введено неккоректное значение. Попробуйте еще раз.");
                    radius_out = 0;
                }
            } while (!trying);


            //Проверяем, что внутренний радиус меньше внешнего, исходя из заданных значений.
            if (Math.Pow(radius_out, 2) - square / Math.PI < 0)
            {
                Console.WriteLine("Входные данные не соответствуют реальным.");
            }
            else
            {
                //Находим внутренний радиус.
                radius_in = Math.Sqrt(Math.Pow(radius_out, 2) - square / Math.PI);
                Console.Write("Внутренний радиус кольца равен: " + radius_in);
            }

            Console.ReadKey();
        }
    }
}
