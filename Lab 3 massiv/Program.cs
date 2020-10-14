using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_massiv
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");
            int elementsCount = Convert.ToInt32(Console.ReadLine());
            int[] myArray = new int [elementsCount];
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"Введите элемент массива под индексом {i}: ");
                myArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Вывод массива: ");
            for(int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
            Console.WriteLine("GitHub");
            Console.ReadLine();
        }
    }
}
