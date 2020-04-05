using System;
using System.Collections.Generic;
using System.Text;
using Abstract_Method.Model.abstract_class;

namespace Abstract_Method.Model
{
    class B : A
    {
        public override void Display()
        {
            Console.WriteLine("This Is display Of B");
        }
    }
}
