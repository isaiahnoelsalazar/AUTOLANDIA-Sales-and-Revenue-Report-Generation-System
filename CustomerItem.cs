namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    public class CustomerItem
    {
        string id, name, plateNumbers, mobileNumber;

        public CustomerItem(string id, string name, string plateNumbers, string mobileNumber)
        {
            this.id = id;
            this.name = name;
            this.plateNumbers = plateNumbers;
            this.mobileNumber = mobileNumber;
        }

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string PlateNumbers
        {
            get { return plateNumbers; }
            set { plateNumbers = value; }
        }

        public string MobileNumber
        {
            get { return mobileNumber; }
            set { mobileNumber = value; }
        }
    }
}
