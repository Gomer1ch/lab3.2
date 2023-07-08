using System;

namespace Лаба_3_задание_1
{
    class Program
    {
        static void Main(string[] args)
        {
                int n, ind1 = -1, ind2 = -1;
                double sum = 0;
                Console.Write("Введите размер массива n=");
                n = Convert.ToInt16(Console.ReadLine());
                double[] mas = new double[n];
                Console.WriteLine("Введите элементы массива");
                for (int i = 0; i < n; i++)
                {
                    mas[i] = Convert.ToDouble(Console.ReadLine());
                }
                for (int i = 0; i < n; i++) //Получение индексов 2х отрицательных чисел
                {
                    if (mas[i] < 0 & ind1 == -1) ind1 = i;
                    if (ind1 >= 0 & i > ind1 & mas[i] < 0 & ind2==-1) { ind2 = i; break; }
                }
                for (int i = ind1+1; i < ind2; i++) // Сумма элементов массива между двумя отрицательными числами
                {
                    sum = sum + mas[i];
                }
                double min = Int32.MaxValue; int indmin = 0; // Нахождение номера минимального элемента массива 
                for (int i=0; i<n; i++)
                {
                    if (mas[i] < min) min = mas[i];
                    if (min == mas[i]) indmin = i+1;
                }
                Console.WriteLine("Номер минимального элемента равен " + indmin);
                Console.WriteLine("Сумма элементов от " + mas[ind2] + " до " + mas[ind1] + " равна " + sum);
                Console.WriteLine("Пересортированный массив:");
                int j = 0; double boof; //Пересортировка массива для вывода сначала чисел по модулю не превышающих 1, а потом остальных 
                for(int i=0; i<n; i++)
                {
                    if (Math.Abs(mas[i]) <= 1)
                    {
                        boof = mas[j];
                        mas[j] = mas[i];
                        mas[i] = boof;
                        j++;
                    }
                }
            foreach (double i in mas) { Console.WriteLine($"{i}"); }
            Console.ReadKey();
        }
    }
}
