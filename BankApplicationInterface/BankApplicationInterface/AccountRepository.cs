using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplicationInterface
{
    public class AccountRepository <T> : InterfaceActionAccount <T>
    {
         List<AccountSettins> Customers { get; set; }

        public void Close()
        {
            
        }

        public void Open()
        {
            
        }

        public void Put(decimal amount)
        {
            
        }

        public void Withdrow(decimal amount)
        {
           
        }
    }
}
