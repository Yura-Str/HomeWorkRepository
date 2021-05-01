using System;
using System.Collections.Generic;

namespace BankLibrary
{
    public class Bank<T> where T : Account
    {
        private const string KgkPassPhrase = "CleanUp";
        private readonly List<Account> _accounts = new();
        private readonly Dictionary <Locker, Locker> _accountsDict = new Dictionary<Locker, Locker>();

        public object Addaccount(string passWorld, string userName, object data)
        {
            Locker userInfo = new Locker(passWorld, userName);
            Locker userData = new Locker( data);
            _accountsDict.Add(userInfo, userData);
            return (Convert.ToString(_accountsDict.Keys));
        }

        public object GetLockerData(string passWorld, string userName)
        {
            string result;
            Locker userInfo = new Locker(passWorld, userName);
            return   Convert.ToString(_accountsDict[userInfo]);
         //   throw new ArgumentOutOfRangeException(
              //  $"you entered incorrect username or password");
        }

        public void VisitKgk(string passPhrase)
        {
            if (passPhrase.Equals(KgkPassPhrase))
            {
                foreach (var key in _accountsDict.Keys)
                {
                    _accountsDict[key] = null;
                }
            }
        }

        public void OpenAccount(OpenAccountParameters parameters)
        {
            CreateAccount(parameters.AccountCreated, () => parameters.Type == AccountType.Deposit
                ? new DepositAccount(parameters.Amount) as T
                : new OnDemandAccount(parameters.Amount) as T);
        }

        private void CreateAccount(AccountCreated accountCreated, Func<T> creator)
        {
            var account = creator();
            account.Open();
            account.Created += accountCreated;
            _accounts.Add(account);
        }
    }
}
