using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons
{
    class GrandParent
    {
        public string GrandParentField = "GrandParentField";
        public string GrandParentProp { get; set; } = "GrandParentProp";

        public string GrandParentFieldOverride = "GrandParentFieldOverride";
        public string GrandParentPropOverride { get; set; } = "GrandParentPropOverride";

        public GrandParent()
        {
            Console.WriteLine("GrandParent");
        }
    }

    class Son : GrandParent
    {
        public string GrandParentFieldOverride = "SonFieldOverride";
        public string GrandParentPropOverride { get; set; } = "SonPropOverride";

        public Son()
        {
            Console.WriteLine("Son");
        }

    }

    class GrandSon : Son
    {
        public GrandSon()
        {
            Console.WriteLine("GrandSon");
            Console.WriteLine(GrandParentField); // все паблик поля наследуються
            Console.WriteLine(GrandParentProp); // все паблик свойства наследуються
            Console.WriteLine(GrandParentFieldOverride); // при присвоении одноименным свойствам в класах наследниках значение 'переопределяеться'
            Console.WriteLine(GrandParentPropOverride);
        }
    }
}
