namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    public class BillingItem
    {
        string id, progress, paymentMethod, lastUpdated, dateCreated;
        double orderBalance, discount, incompleteAmountPayment;

        public BillingItem(string id, double orderBalance, double discount, string progress, string paymentMethod, string lastUpdated, string dateCreated, double incompletePaymentAmount)
        {
            this.id = id;
            this.orderBalance = orderBalance;
            this.discount = discount;
            this.progress = progress;
            this.paymentMethod = paymentMethod;
            this.lastUpdated = lastUpdated;
            this.dateCreated = dateCreated;
            this.incompleteAmountPayment = incompletePaymentAmount;
        }

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public double Balance
        {
            get { return orderBalance; }
            set { orderBalance = value; }
        }

        public double Discount
        {
            get { return discount; }
            set { discount = value; }
        }

        public string Progress
        {
            get { return progress; }
            set { progress = value; }
        }

        public string PaymentMethod
        {
            get { return paymentMethod; }
            set { paymentMethod = value; }
        }

        public string LastUpdated
        {
            get { return lastUpdated; }
            set { lastUpdated = value; }
        }

        public string DateCreated
        {
            get { return dateCreated; }
            set { dateCreated = value; }
        }

        public double IncompletePaymentAmount
        {
            get { return incompleteAmountPayment; }
            set { incompleteAmountPayment = value; }
        }
    }
}
