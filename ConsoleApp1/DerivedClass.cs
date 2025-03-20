using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class DerivedClass : AClass
    {
        /// <summary>
    /// переопределеный метод с именем Method2
    /// </summary>
        public override void Method2()  
        {
            base.Method2();
            Console.WriteLine("Метод Method2 из класса AClass, реализованый в производном классе DerivedClass");
        }
        /// <summary>
        /// преопределеный метод с именем Method3
        /// </summary>
        public override void Method3()
        {
            Console.WriteLine("Метод Method3 из класса AClass реализованый в производном классе DerivedClass");
        }
        /// <summary>
        /// преопределеный метод с именем Method4
        /// </summary>
        public override void Method4()
        {
            Console.WriteLine("Метод Method4 из класса AClass реализованый в производном классе DerivedClass");
        }
    }
}
