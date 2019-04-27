using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class MyClass
    {
        private string change;

        public string GetStructureField()
        {
            return this.change;
        }

        public void SetClassField(string fieldValue)
        {
            this.change = fieldValue;
        }
    }
}
