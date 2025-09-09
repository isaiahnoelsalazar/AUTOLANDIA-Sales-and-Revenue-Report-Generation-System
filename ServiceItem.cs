namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    public class ServiceItem
    {
        string id, name, size;
        double price;

        public ServiceItem(string id, string name, string size, double price)
        {
            this.id = id;
            this.name = name;
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
