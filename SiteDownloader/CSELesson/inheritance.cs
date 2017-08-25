using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSELesson
{
    class Inheritance
    {
    }

    class Parent
    {
        public string PublicParentField = "PublicParentField";
        protected string ProtectedParentField = "ProtectedParentField";
        public string PublicParentField1 = "PublicParentField1";
        protected string ProtectedParentField1 = "ProtectedParentField1";

        public void ShowFields()
        {
            Console.WriteLine(this.PublicParentField + Environment.NewLine + this.ProtectedParentField + Environment.NewLine + this.PublicParentField1 + Environment.NewLine + this.ProtectedParentField1 + Environment.NewLine);

        }
    }

    class Child : Parent
    {

        public string PublicParentField1 = "SubstitutionPublicParentField1";
        protected string ProtectedParentField1 = "SubstitutionProtectedParentField1";
        public Child()
        {
            PublicParentField = "OverridedPublicParentField";
            ProtectedParentField = "OverridedProtectedParentField";
        }
    }
}

