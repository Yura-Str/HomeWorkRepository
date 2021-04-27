using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplicationInterface
{
    class AccountSettins
    {
        private static int _counter = 0;
        public decimal _amount;
        private int _id;
        private int _days = 0;
        private StateAccount _state;
        private AccountType Type = AccountType.Deposit;
    }
}
