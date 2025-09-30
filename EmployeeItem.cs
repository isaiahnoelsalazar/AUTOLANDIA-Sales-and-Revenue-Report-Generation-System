namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    public class EmployeeItem
    {
        string id, fname, mobileNumber, address, lname, mname, documents;

        public EmployeeItem(string id, string fname, string mobileNumber, string address, string lname, string mname, string documents)
        {
            this.id = id;
            this.fname = fname;
            this.mobileNumber = mobileNumber;
            this.address = address;
            this.lname = lname;
            this.mname = mname;
            this.documents = documents;
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

        public string Documents
        {
            get { return documents; }
            set { documents = value; }
        }
    }
}
