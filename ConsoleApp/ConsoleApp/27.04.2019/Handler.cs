using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Handler
    {
        private void ClassTaker(MyClass myClass)
        {
            myClass.SetClassField("changed");
        }

        private void StructTaker(MyStructure myStruct)
        {
            myStruct.SetStructureField("changed");
        }

        public void Execute()
        {
            MyClass mclss = new MyClass();
            MyStructure mstrctr = new MyStructure();
            mclss.SetClassField("not changed");
            mstrctr.SetStructureField("not changed");

            this.ClassTaker(mclss);
            this.StructTaker(mstrctr);

            Console.WriteLine("Structute: " + mstrctr.GetStructureField());
            Console.WriteLine("Class: " + mclss.GetStructureField());
        }
    }
}
