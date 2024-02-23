using System;

namespace HW_3
{
    internal class LineArray : Parent_Array, ILineArray
    {
        private int[] array;
        public LineArray()
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
            for(int i = 0; i < this.array.Length; i++)
            {
               if(Math.Abs(this.array[i]) > Math.Abs(max))
               {
                    max = this.array[i];
               }
            }
            return max;
        }
        public override void UserInput()
        {
            Console.WriteLine("Сколько элементов вы хотите?");
            int count = int.Parse(Console.ReadLine());

            this.array = new int[count];

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Введите элемент с индексом {i}: ");
                this.array[i] = int.Parse(Console.ReadLine());
            }
        }

        public override void RandomInput()
        {
            Random random = new Random();

            Console.WriteLine("Сколько элементов вы хотите?");
            int count = int.Parse(Console.ReadLine());

            this.array = new int[count];

            for (int i = 0; i < count; i++)
            {
                this.array[i] = random.Next(1, 501);
            }
        }

        public override void Display()
        {
            Console.Write("[");
            for(int i = 0; i < this.array.Length; i++)
            {
                string spaces = new string(' ', GetMax().ToString().Length - this.array[i].ToString().Length);
                Console.Write($"{spaces}{this.array[i]}");
            }
            Console.WriteLine(" ]");
        }

        public override float GetAverage()
        {
            float sum = 0;

            for(int i = 0; i < this.array.Length; i++)
            {
                sum += this.array[i];
            }
            return sum / this.array.Length;
        }

        public void DeleteElementsUpper100()
        {
            int[] result = {};
            
            for(int i = 0; i < this.array.Length;i++)
            {
                if(this.array[i] <= 100 && this.array[i] >= -100)
                {
                    Array.Resize( ref result, result.Length + 1);
                    result[result.Length - 1] = this.array[i];
                }
            }
            this.array = result;
        }

        public void DeleteDublicates()
        {
            int[] result = { };

            for (int i = 0; i < this.array.Length; i++)
            {
                if (!result.Contains(this.array[i]))
                {
                    Array.Resize(ref result, result.Length + 1);
                    result[result.Length - 1] = this.array[i];
                }
            }
            this.array = result;
        }
    }
}
