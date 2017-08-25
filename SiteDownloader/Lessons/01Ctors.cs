using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons
{
    class _01Ctors
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Name { get; set; }
        public _01Ctors()
        {
            Console.WriteLine("Default ctor");
        }

        public _01Ctors(int x, int y)
            : this()
        {
            Console.WriteLine("User ctor");
        }

        public _01Ctors(string name)
            : this(10, 20)
        {
            Console.WriteLine();
        }

    }
}
