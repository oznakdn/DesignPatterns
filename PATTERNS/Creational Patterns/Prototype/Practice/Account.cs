namespace Practice
{
    public class Account:PrototypeAccount
    {
        protected string Iban { get; set; }
        protected Customer Owner { get; set; }

        private double Balance;
        private double Credit;

        private bool OpenToWithdraw;
        private bool OpenToPayment;
        private bool OpenToTransfer;

        public double GetBalance()
        {
            return Balance;
        }

        public void SetBalance(double balance)
        {
            Balance = balance; 
        }

        public double GetCredit()
        {
            return Credit;
        }

        public void SetCredit(double credit)
        {
            Credit = credit; 
        }


        public bool GetToWithdraw()
        {
            return OpenToWithdraw;
        }

        public void SetToWithdraw(bool toWithdraw)
        {
            this.OpenToWithdraw = toWithdraw;
        }

        public bool GetToPayment()
        {
            return OpenToPayment;
        }

        public void SetToPayment(bool toPayment)
        {
            this.OpenToPayment = toPayment;
        }

        public bool GetToTransfer()
        {
            return OpenToTransfer;
        }

        public void SetToTranser(bool toTransfer)
        {
            this.OpenToTransfer = toTransfer;
        }


        public Account
        (
        string iban, 
        double balance, 
        double credit, 
        Customer owner, 
        bool openToWithdraw, 
        bool openToPayment,
        bool openToTransfer)
        {
            Iban = iban;
            Balance = balance;
            Credit = credit;
            Owner = owner;
            OpenToWithdraw = openToWithdraw;
            OpenToPayment = openToPayment;
            OpenToTransfer = openToTransfer;
        }

        public override PrototypeAccount Clone()
        {
            return this.MemberwiseClone() as PrototypeAccount;
        }

        public override string ToString()
        {
            return $"{Owner.CustomerName} {Iban} {Balance} {Credit}";
        }

    }
}