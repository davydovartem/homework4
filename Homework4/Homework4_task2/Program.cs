using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 2. Сложение матриц
            Console.WriteLine("Введите количество строк матриц:");
            if (!int.TryParse(Console.ReadLine(), out int rows) && rows > 0)
            {
                Console.WriteLine("Введите положительное целое число!");
            }
            else
            {
                Console.WriteLine("Введите количество столбцов матриц:");
                if (int.TryParse(Console.ReadLine(), out int cols) && cols > 0)
                {
                    Random random = new Random();
                    //Определим максимальное значение элементов матриц
                    int maxElementValue = 9;
                    int[,] M1 = new int[rows, cols];
                    int[,] M2 = new int[rows, cols];
                    int[,] A = new int[rows, cols];
                    //Для красивого отображения
                    int matrixMax1 = int.MinValue;
                    int matrixMax2 = int.MinValue;
                    int matrixMax3 = int.MinValue;
                    int matrixMaxWidth1, matrixMaxWidth2, matrixMaxWidth3;
                    //Заполняем
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            M1[i, j] = random.Next(maxElementValue + 1);
                            M2[i, j] = random.Next(maxElementValue + 1);
                            //запоминаем максимальные
                            if (M1[i, j] > matrixMax1)
                            {
                                matrixMax1 = M1[i, j];
                            }
                            if (M2[i, j] > matrixMax2)
                            {
                                matrixMax2 = M2[i, j];
                            }
                            A[i, j] = M1[i, j] + M2[i, j];
                            if (A[i, j] > matrixMax3)
                            {
                                matrixMax3 = A[i, j];
                            }
                        }
                    }
                    matrixMaxWidth1 = matrixMax1.ToString().Length;
                    matrixMaxWidth2 = matrixMax2.ToString().Length;
                    matrixMaxWidth3 = matrixMax3.ToString().Length;
                    //будем рисовать M1 + M2 = A
                    int widthM1 = matrixMaxWidth1 * cols + cols;
                    int widthM2 = matrixMaxWidth2 * cols + cols;
                    //первый столбец матрицы M1 - 0
                    int positionOfM1 = 0;
                    //первый столбец матрицы M2, 3 - 1 ' пробел+пробел(от " + ") - пробел(от первого пробела в цикле)
                    int positionOfM2 = positionOfM1 + widthM1 + 3 - 1;
                    int positionOfA = positionOfM2 + widthM2 + 3 - 1;
                    //Выводим M1
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            Console.Write(" " + M1[i, j].ToString().PadLeft(matrixMaxWidth1));

                        }
                        Console.Write("\n");
                    }
                    //cursTop - текущее положение курсора по вертикали
                    int cursTop = Console.CursorTop;
                    //смещаем курсор на "середину" матрицы и выводим +
                    Console.SetCursorPosition(positionOfM2 - 2, cursTop - (rows / 2) - 1);
                    Console.Write(" + ");
                    //Выводим M2
                    //положение по вертикали зависит от четности количества строк
                    cursTop = (rows % 2) == 0 ? Console.CursorTop - (rows / 2) + 1 : Console.CursorTop - (rows / 2);
                    Console.SetCursorPosition(positionOfM2, cursTop);
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            Console.Write(" " + M2[i, j].ToString().PadLeft(matrixMaxWidth2));

                        }
                        Console.SetCursorPosition(positionOfM2, cursTop + i + 1);
                    }
                    //выводим =
                    cursTop = Console.CursorTop;
                    Console.SetCursorPosition(positionOfA - 2, cursTop - (rows / 2) - 1);
                    Console.Write(" = ");
                    //Выводим A
                    //положение по вертикали зависит от четности количества строк
                    cursTop = (rows % 2) == 0 ? Console.CursorTop - (rows / 2) + 1 : Console.CursorTop - (rows / 2);
                    Console.SetCursorPosition(positionOfA, cursTop);
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            Console.Write(" " + A[i, j].ToString().PadLeft(matrixMaxWidth3));

                        }
                        Console.SetCursorPosition(positionOfA, cursTop + i + 1);
                    }

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
