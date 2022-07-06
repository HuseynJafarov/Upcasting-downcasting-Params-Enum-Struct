using System;
using System.Collections.Generic;
using System.Text;

namespace Enum_Struct_Upcasting_Downcasting.Models
{
    public abstract class Animal
    {
      public virtual void Test()
        {
            Console.WriteLine("Animal test");
        }


        public abstract void Eat();



    }
}
