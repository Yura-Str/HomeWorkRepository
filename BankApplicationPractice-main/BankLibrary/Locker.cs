namespace BankLibrary
{
    class Locker
    {
        private object _data;
        private string _passWorld;
        private string _userName;

        public Locker(string passWorld, string userName)
        {
            _passWorld = passWorld;
            _userName = userName;
        }
        public Locker(object data)
        {
            _data = data;
        }



    }
}