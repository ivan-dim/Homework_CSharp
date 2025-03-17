namespace HomeworkClass06
{
    public class Customer
    {
        public string FullName { get; set; }
        private string _CardNum;
        public string CardNum
        {
            get { return _CardNum; }
        }
        private string _pin;
        private int _balance;

        public Customer(string fullName, string cardNum, string pin, int startBalance = 0)
        {
            FullName = fullName;
            _CardNum = cardNum.Replace("-", "");
            _pin = pin;
            _balance = startBalance;
        }

        public bool Validation(string pin)
        {
            return _pin == pin;
        }

        public int GetBal()
        {
            return _balance;
        }

        public bool Withdraw(int amount)
        {
            if (amount <= 0)
                return false;
            if (amount > _balance)
                return false;
            _balance -= amount;
            return true;
        }

        public void Depo(int amount)
        {
            if (amount > 0)
                _balance += amount;
        }
    }
}