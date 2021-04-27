using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplicationInterface
{
    interface InterfaceActionAccount <T>
    {
        void Open();
        void Close();
        void Put(decimal amount);
        void Withdrow(decimal amount);

    }
}
