using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// абстрактный класс
    /// </summary>
    abstract class AClass
    {
        /// <summary>
        /// обычный метод Mwthod1
        /// </summary>
        public void Method1() => Console.WriteLine("Обычный метод Method1 из абстрактный класс AClass");
        /// <summary>
        /// виртульный метод Method2
        /// </summary>
        public virtual void Method2() => Console.WriteLine("Виртуальный метод Method2 из абстрактного класса AClass");
        /// <summary>
        /// абстрактный метод Method3
        /// </summary>
        public abstract void Method3();
        /// <summary>
        /// абстрактный метод Method4
        /// </summary>
        public abstract void Method4();
    }
}
