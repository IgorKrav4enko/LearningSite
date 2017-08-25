using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSELesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Parent parent = new Parent();
            parent.ShowFields();
            Child child = new Child();
            child.ShowFields();

        }
    }
}
