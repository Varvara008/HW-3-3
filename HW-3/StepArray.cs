using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HW_3
{
    internal class StepArray : Parent_Array, IStepArray
    {
        private int[][] array;

        public StepArray()
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
            for (int i = 0; i < this.array.Length; i++)
            {
                for (int j = 0; j < this.array[i].Length; j++)
                {
                    if (Math.Abs(this.array[i][j]) > Math.Abs(max))
                    {
                        max = this.array[i][j];
                    }
                }
            }
            return max;
        }
        public override void UserInput()
        {
            Console.WriteLine("Сколько рядов вы хотите?");
            int rows = int.Parse(Console.ReadLine());

            this.array = new int[rows][];

            int[] columns = new int[rows];

            for (int i = 0; i < rows; i++)
            {
                this.array[i] = new int[columns[i]];
            }
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine($"Сколько элементов вы хотите в ряду с индексом {i} ?");
                columns[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns[i]; j++)
                {
                    Console.WriteLine($"Введите элемент с индексами {i}, {j}: ");
                    this.array[i][j] = int.Parse(Console.ReadLine());
                }

            }
        }

        public override void RandomInput()
        {
            Random random = new Random();

            Console.WriteLine("Сколько рядов вы хотите?");
            int rows = int.Parse(Console.ReadLine());

            this.array = new int[rows][];

            int[] columns = new int[rows];

            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine($"Сколько элементов вы хотите в ряду с индексом {i} ?");
                columns[i] = int.Parse(Console.ReadLine());
                this.array[i] = new int[columns[i]];
            }


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns[i]; j++)
                {
                    this.array[i][j] = random.Next(1, 501);
                }

            }
        }

        public override void Display()
        {
            for (int i = 0; i < this.array.Length; i++)
            {
                for (int j = 0; j < this.array[i].Length; j++)
                {
                    string spaces = new string(' ', GetMax().ToString().Length - this.array[i][j].ToString().Length + 1);
                    Console.Write($"{spaces}{this.array[i][j]}");
                }
                Console.WriteLine();
            }

        }

        public override float GetAverage()
        {
            float sum = 0;
            int count = 0;

            for (int i = 0; i < this.array.Length; i++)
            {
                for (int j = 0; j < this.array[i].Length; j++)
                {
                    sum += this.array[i][j];
                    count++;
                }

            }
            return sum / count;

        }

        public float[] GetAverageInRows()
        {
            float[] averages = new float[this.array.Length];

            for (int i = 0; i < this.array.Length; i++)
            {
                float sum = 0;
                int count = 0;
                for (int j = 0; j < this.array[i].Length; j++)
                {
                    sum += this.array[i][j];
                    count++;
                    averages[i] = sum/ count;
                }

            }
            return averages;
        }

        public void ChangeEvenNumbers()
        {
            for (int i = 0; i < this.array.Length; i++)
            {
                for (int j = 0; j < this.array[i].Length; j++)
                {
                    if(this.array[i][j] % 2 == 0)
                    {
                        this.array[i][j] = i * j;
                    }
                }
                
            }
        }
    }
}
