using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3
{
    public abstract class Parent_Array : IArray
    {
        public abstract float GetAverage();
        public abstract void Display();
        public abstract void UserInput();
        public abstract void RandomInput();

    }
}
