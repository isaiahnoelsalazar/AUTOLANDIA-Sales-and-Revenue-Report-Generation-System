﻿namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    public class OrderItem
    {
        string id, employeeIDList, serviceIDList, packageID, extras, vehicleId, progress, lastUpdated, dateCreated;

        public OrderItem(string id, string employeeIDList, string serviceIDList, string packageID, string extras, string vehicleId, string progress, string lastUpdated, string dateCreated)
        {
            this.id = id;
            this.employeeIDList = employeeIDList;
            this.serviceIDList = serviceIDList;
            this.packageID = packageID;
            this.extras = extras;
            this.vehicleId = vehicleId;
            this.progress = progress;
            this.lastUpdated = lastUpdated;
            this.dateCreated = dateCreated;
        }

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public string EmployeeIDList
        {
            get { return employeeIDList; }
            set { employeeIDList = value; }
        }

        public string ServiceIDList
        {
            get { return serviceIDList; }
            set { serviceIDList = value; }
        }

        public string PackageID
        {
            get { return packageID; }
            set { packageID = value; }
        }

        public string Extras
        {
            get { return extras; }
            set { extras = value; }
        }

        public string VehicleId
        {
            get { return vehicleId; }
            set { vehicleId = value; }
        }

        public string Progress
        {
            get { return progress; }
            set { progress = value; }
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
    }
}
