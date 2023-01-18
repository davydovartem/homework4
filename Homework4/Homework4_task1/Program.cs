using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1. Случайная матрица
            Console.WriteLine("Введите количество строк матрицы:");
            if (!int.TryParse(Console.ReadLine(), out int rows) && rows > 0)
            {
                Console.WriteLine("Введите положительное целое число!");
            }
            else
            {
                Console.WriteLine("Введите количество столбцов матрицы:");
                if (int.TryParse(Console.ReadLine(), out int cols) && cols > 0)
                {
                    Random random = new Random();
                    //Определим максимальное значение элементов матрицы
                    int maxElementValue = 10000;
                    int[,] M = new int[rows, cols];
                    int matrixSum = 0;
                    //Для красивого отображения
                    int matrixMax = int.MinValue;
                    int matrixMaxWidth;
                    //Заполняем
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            M[i, j] = random.Next(maxElementValue + 1);
                            //запоминаем максимальный
                            if (M[i, j] > matrixMax)
                            {
                                matrixMax = M[i, j];
                            }
                            //считаем сумму
                            matrixSum += M[i, j];
                        }
                    }
                    //Выводим
                    matrixMaxWidth = matrixMax.ToString().Length;
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            Console.Write(" " + M[i, j].ToString().PadLeft(matrixMaxWidth));

                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine($"Сумма элементов: {matrixSum}\nМаксимальный элемент: {matrixMax}");
                }
                else
                {
                    Console.WriteLine("Введите положительное целое число!");
                    Environment.Exit(0);
                }
            }

            Console.ReadKey();
        }
    }
}
