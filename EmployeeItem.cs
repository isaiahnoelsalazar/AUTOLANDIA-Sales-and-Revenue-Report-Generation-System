namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    public class EmployeeItem
    {
        string id, name, mobileNumber;

        public EmployeeItem(string id, string name, string mobileNumber)
        {
            this.id = id;
            this.name = name;
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

        public string MobileNumber
        {
            get { return mobileNumber; }
            set { mobileNumber = value; }
        }
    }
}
