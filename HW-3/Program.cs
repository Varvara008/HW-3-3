using HW_3;
using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        IArray[] arrays = { new LineArray(), new MatrixArray(), new StepArray() };
        for(int i = 0; i < arrays.Length; i++)
        {
            Console.WriteLine(arrays[i].GetAverage());
            arrays[i].Display();
            WeekPrinter array = new WeekPrinter();
            array.Print();
           
        }
    }
}
