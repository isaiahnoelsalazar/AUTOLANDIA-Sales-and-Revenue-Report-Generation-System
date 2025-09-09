namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    public class PackageItem
    {
        string id, name, details, size;
        double price;

        public PackageItem(string id, string name, string details, string size, double price)
        {
            this.id = id;
            this.name = name;
            this.details = details;
            this.size = size;
            this.price = price;
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

        public string Details
        {
            get { return details; }
            set { details = value; }
        }

        public string Size
        {
            get { return size; }
            set { size = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
