using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5._1
{
    class Program
    {
        static void Main(string[] args)      //метод нахождения среднего арифметического массива
        {

            Console.WriteLine("Введите семь чисел массива массива");
            int a1 = Convert.ToInt32(Console.ReadLine());
            int a2 = Convert.ToInt32(Console.ReadLine());
            int a3 = Convert.ToInt32(Console.ReadLine());
            int a4 = Convert.ToInt32(Console.ReadLine());
            int a5 = Convert.ToInt32(Console.ReadLine());
            int a6 = Convert.ToInt32(Console.ReadLine());
            int a7 = Convert.ToInt32(Console.ReadLine());


            int[] m = new int[7] { a1, a2, a3, a4, a5, a6, a7 };

            double summa = 0;

            for (int i = 0; i < 7; i++)
            {
                summa += m[i];
            }

            Console.Write("Среднее арифметическое значение равно={0:f2} ", summa / 7);

            Console.ReadKey();



        }
    }
}
