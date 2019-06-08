using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019._05._25
{
    public interface ITransactionable
    {
        void SubtractFromAccount(decimal sum);

        void AddToAccount(decimal sum);
    }
}
