using System;
using System.Collections.Generic;

namespace BankLibrary
{
    public class Bank<T> where T : Account
    {
        private const string KgkPassPhrase = "CleanUp";
        private readonly List<Account> _accounts = new();
        private readonly Dictionary<Locker, object> _accountsDict = new Dictionary<Locker, object>();

        public object Addaccount(string passWorld, string userName, object data)
        {
            Locker userInfo = new Locker(passWorld, userName);
            _accountsDict.Add(userInfo, data);
            return (Convert.ToString(_accountsDict.Keys));
        }

        public object GetLockerData(string passworld, string username)
        {
            foreach (KeyValuePair<Locker, object> locker in _accountsDict)
            {
                if (locker.Key.Matches(passworld, username))
                {
                    return locker.Value;
                }
            }
                throw new InvalidOperationException($"Cannot find locker with ID or keyword does not match");
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
