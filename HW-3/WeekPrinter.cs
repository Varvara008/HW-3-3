using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3
{
    internal class WeekPrinter : IPrinter
    {
        public void Print()
        {
            string[] weekdays = {"ПН", "ВТ", "СР", "ЧТ", "ПТ", "СБ", "ВС"};
            
            for(int i = 0; i < weekdays.Length; i++)
            {
                Console.WriteLine($"{weekdays[i]} ");
            }
        }
    }
}
