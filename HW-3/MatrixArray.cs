using System;

namespace HW_3
{
    internal class MatrixArray : Parent_Array, IMatrixArray
    {
        private int[,] array;
        public MatrixArray()
        {

            Console.WriteLine("Вы хотите заполнить массив самостоятельно?");
            Console.WriteLine("1 - Да, 2 - Нет");
            int fill = int.Parse(Console.ReadLine());

            if (fill == 1)
            {
                UserInput();
            }
            else
            {
                RandomInput();
            }
        }
        private int GetMax()
        {
            int max = 0;
            for (int i = 0; i < this.array.GetLength(0); i++)
            {
                for(int j = 0; j < this.array.GetLength(1); j++)
                {
                    if (Math.Abs(this.array[i, j]) > Math.Abs(max))
                    {
                        max = this.array[i, j];
                    }
                }
            }
            return max;
        }
        public override void UserInput()
        {
            Console.WriteLine("Сколько рядов вы хотите?");
            int rows = int.Parse(Console.ReadLine());

            Console.WriteLine("Сколько столбцов вы хотите?");
            int columns = int.Parse(Console.ReadLine());

            this.array = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
               for(int j = 0; j < columns; j++)
               {
                    Console.WriteLine($"Введите элемент с индексами {i}, {j}: ");
                    this.array[i, j] = int.Parse(Console.ReadLine());
               }

            }
        }

        public override void RandomInput()
        {
            Random random = new Random();

            Console.WriteLine("Сколько рядов вы хотите?");
            int rows = int.Parse(Console.ReadLine());

            Console.WriteLine("Сколько столбцов вы хотите?");
            int columns = int.Parse(Console.ReadLine());

            this.array = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    this.array[i, j] = random.Next(1, 501);
                }

            }
        }

        public override void Display()
        {
            for (int i = 0; i < this.array.GetLength(0); i++)
            {
                for (int j = 0; j < this.array.GetLength(1); j++)
                {
                    string spaces = new string(' ', GetMax().ToString().Length - this.array[i, j].ToString().Length + 1);
                    Console.Write($"{spaces}{this.array[i, j]}");
                }
                Console.WriteLine();
            }

        }
        
        public override float GetAverage()
        {
            float sum = 0;

            for (int i = 0; i < this.array.GetLength(0); i++)
            {
                for (int j = 0; j < this.array.GetLength(1); j++)
                {
                    sum += this.array[i, j];
                }

            }
            return sum / (this.array.GetLength(0) * this.array.GetLength(1));

        }

        public void DisplayReversedEvenRows()
        {
            Display();

            for (int i = 0; i < this.array.GetLength(0); i++)
            {
                if(i % 2 == 0)
                {
                    for (int j = this.array.GetLength(1) - 1; j >= 0; j--)
                    {
                        string spaces = new string(' ', GetMax().ToString().Length - this.array[i, j].ToString().Length + 1);
                        Console.Write($"{spaces}{this.array[i, j]}");
                    }
                }
                else
                {
                    for (int j = 0; j < this.array.GetLength(1); j++)
                    {
                        string spaces = new string(' ', GetMax().ToString().Length - this.array[i, j].ToString().Length + 1);
                        Console.Write($"{spaces}{this.array[i, j]}");
                    }
                }

                Console.WriteLine();

            }
        }
    }
}
