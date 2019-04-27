using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public struct MyStructure
    {
        private string change;

        public string GetStructureField()
        {
            return this.change;
        }

        public void SetStructureField(string fieldValue)
        {
            this.change = fieldValue;
        }
    }
}
