namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    public class OrderItem
    {
        string id, employeeID, plateNumber, serviceIDList, packageIDList, dateCreated;
        double balance;

        public OrderItem(string id, string employeeID, string plateNumber, string serviceIDList, string packageIDList, double balance, string dateCreated)
        {
            this.id = id;
            this.employeeID = employeeID;
            this.plateNumber = plateNumber;
            this.serviceIDList = serviceIDList;
            this.packageIDList = packageIDList;
            this.balance = balance;
            this.dateCreated = dateCreated;
        }

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public string EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }

        public string PlateNumber
        {
            get { return plateNumber; }
            set { plateNumber = value; }
        }

        public string ServiceIDList
        {
            get { return serviceIDList; }
            set { serviceIDList = value; }
        }

        public string PackageIDList
        {
            get { return packageIDList; }
            set { packageIDList = value; }
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public string DateCreated
        {
            get { return dateCreated; }
            set { dateCreated = value; }
        }
    }
}
