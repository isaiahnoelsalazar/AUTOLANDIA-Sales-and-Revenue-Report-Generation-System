namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    public class CustomerItem
    {
        string id, fname, plateNumbers, mobileNumber, address, lname, mname;

        public CustomerItem(string id, string fname, string plateNumbers, string mobileNumber, string address, string lname, string mname)
        {
            this.id = id;
            this.fname = fname;
            this.plateNumbers = plateNumbers;
            this.mobileNumber = mobileNumber;
            this.address = address;
            this.lname = lname;
            this.mname = mname;
        }

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public string FirstName
        {
            get { return fname; }
            set { fname = value; }
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

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string LastName
        {
            get { return lname; }
            set { lname = value; }
        }

        public string MiddleName
        {
            get { return mname; }
            set { mname = value; }
        }
    }
}
