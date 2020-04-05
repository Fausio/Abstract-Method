using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Method.Model
{
    abstract class A
    {
        public void Show()
        {
            Console.WriteLine("This is show of A");
        }

        public abstract void Display();
    }
}
