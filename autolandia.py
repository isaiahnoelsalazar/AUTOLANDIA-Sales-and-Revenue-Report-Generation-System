from easy_sql import EasySQL

import os.path
if not os.path.isfile("AUTOLANDIA.db"):
    a = EasySQL()

    AUTOLANDIA_ServiceList_columns = [
        {"ServiceId": "varchar"},
        {"ServiceName": "varchar"},
        {"ServiceSize": "varchar"},
        {"ServicePrice": "float"}
    ]
    AUTOLANDIA_PackageList_columns = [
        {"PackageId": "varchar"},
        {"PackageName": "varchar"},
        {"PackageDetails": "varchar"},
        {"PackageSize": "varchar"},
        {"PackagePrice": "float"}
    ]
    AUTOLANDIA_PaymentMethodList_columns = [
        {"PaymentMethodName": "varchar"}
    ]
    AUTOLANDIA_EmployeeList_columns = [
        {"EmployeeId": "varchar"},
        {"FirstName": "varchar"},
        {"MobileNumber": "varchar"},
        {"EmployeeAddress": "varchar"},
        {"LastName": "varchar"},
        {"MiddleName": "varchar"},
        {"EmployeeDocuments": "varchar"}
    ]
    AUTOLANDIA_EmployeeTimeList_columns = [
        {"EmployeeId": "varchar"},
        {"TimeIn": "varchar"},
        {"TimeOut": "varchar"},
        {"DateCreated": "varchar"}
    ]
    AUTOLANDIA_VehicleList_columns = [
        {"VehicleId": "varchar"},
        {"VehicleBrand": "varchar"},
        {"VehicleModel": "varchar"},
        {"VehicleSize": "varchar"},
        {"PlateNumber": "varchar"},
        {"CustomerId": "varchar"}
    ]
    AUTOLANDIA_CustomerList_columns = [
        {"CustomerId": "varchar"},
        {"FirstName": "varchar"},
        {"PlateNumbers": "varchar"},
        {"MobileNumber": "varchar"},
        {"CustomerAddress": "varchar"},
        {"LastName": "varchar"},
        {"MiddleName": "varchar"}
    ]
    AUTOLANDIA_ActivityList_columns = [
        {"Message": "varchar"}
    ]
    AUTOLANDIA_OrderList_columns = [
        {"OrderId": "varchar"},
        {"EmployeeIdList": "varchar"},
        {"ServiceIdList": "varchar"},
        {"PackageId": "varchar"},
        {"Extras": "varchar"},
        {"VehicleId": "varchar"},
        {"OrderProgress": "varchar"},
        {"DateUpdated": "varchar"},
        {"DateCreated": "varchar"}
    ]
    AUTOLANDIA_BillingList_columns = [
        {"BillingId": "varchar"},
        {"OrderBalance": "float"},
        {"OrderDiscount": "float"},
        {"BillingProgress": "varchar"},
        {"PaymentMethodName": "varchar"},
        {"DateUpdated": "varchar"},
        {"DateCreated": "varchar"}
    ]

    a.createTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", AUTOLANDIA_ServiceList_columns)
    a.createTable("AUTOLANDIA", "AUTOLANDIA_PackageList", AUTOLANDIA_PackageList_columns)
    a.createTable("AUTOLANDIA", "AUTOLANDIA_PaymentMethodList", AUTOLANDIA_PaymentMethodList_columns)
    a.createTable("AUTOLANDIA", "AUTOLANDIA_EmployeeList", AUTOLANDIA_EmployeeList_columns)
    a.createTable("AUTOLANDIA", "AUTOLANDIA_EmployeeTimeList", AUTOLANDIA_EmployeeTimeList_columns)
    a.createTable("AUTOLANDIA", "AUTOLANDIA_VehicleList", AUTOLANDIA_VehicleList_columns)
    a.createTable("AUTOLANDIA", "AUTOLANDIA_CustomerList", AUTOLANDIA_CustomerList_columns)
    a.createTable("AUTOLANDIA", "AUTOLANDIA_ActivityList", AUTOLANDIA_ActivityList_columns)
    a.createTable("AUTOLANDIA", "AUTOLANDIA_OrderList", AUTOLANDIA_OrderList_columns)
    a.createTable("AUTOLANDIA", "AUTOLANDIA_BillingList", AUTOLANDIA_BillingList_columns)

    package_value_0 = [
    {"PackageId": "P_B1"},
    {"PackageName": "Basic"},
    {"PackageDetails": "Wash,Armor All,Hand Wax,Under Wash"},
    {"PackageSize": "S"},
    {"PackagePrice": 1000}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_PackageList", package_value_0)
    package_value_1 = [
    {"PackageId": "P_B2"},
    {"PackageName": "Basic"},
    {"PackageDetails": "Wash,Armor All,Hand Wax,Under Wash"},
    {"PackageSize": "M"},
    {"PackagePrice": 1100}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_PackageList", package_value_1)
    package_value_2 = [
    {"PackageId": "P_B3"},
    {"PackageName": "Basic"},
    {"PackageDetails": "Wash,Armor All,Hand Wax,Under Wash"},
    {"PackageSize": "L"},
    {"PackagePrice": 1200}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_PackageList", package_value_2)
    package_value_3 = [
    {"PackageId": "P_B4"},
    {"PackageName": "Basic"},
    {"PackageDetails": "Wash,Armor All,Hand Wax,Under Wash"},
    {"PackageSize": "XL"},
    {"PackagePrice": 1300}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_PackageList", package_value_3)
    package_value_4 = [
    {"PackageId": "P_B5"},
    {"PackageName": "Basic"},
    {"PackageDetails": "Wash,Armor All,Hand Wax,Under Wash"},
    {"PackageSize": "XXL"},
    {"PackagePrice": 1600}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_PackageList", package_value_4)
    package_value_5 = [
    {"PackageId": "P_ST1"},
    {"PackageName": "Standard"},
    {"PackageDetails": "Wash,Armor All,Hand Wax,Under Wash,Glass Detailing"},
    {"PackageSize": "S"},
    {"PackagePrice": 2000}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_PackageList", package_value_5)
    package_value_6 = [
    {"PackageId": "P_ST2"},
    {"PackageName": "Standard"},
    {"PackageDetails": "Wash,Armor All,Hand Wax,Under Wash,Glass Detailing"},
    {"PackageSize": "M"},
    {"PackagePrice": 2200}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_PackageList", package_value_6)
    package_value_7 = [
    {"PackageId": "P_ST3"},
    {"PackageName": "Standard"},
    {"PackageDetails": "Wash,Armor All,Hand Wax,Under Wash,Glass Detailing"},
    {"PackageSize": "L"},
    {"PackagePrice": 2300}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_PackageList", package_value_7)
    package_value_8 = [
    {"PackageId": "P_ST4"},
    {"PackageName": "Standard"},
    {"PackageDetails": "Wash,Armor All,Hand Wax,Under Wash,Glass Detailing"},
    {"PackageSize": "XL"},
    {"PackagePrice": 2500}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_PackageList", package_value_8)
    package_value_9 = [
    {"PackageId": "P_ST5"},
    {"PackageName": "Standard"},
    {"PackageDetails": "Wash,Armor All,Hand Wax,Under Wash,Glass Detailing"},
    {"PackageSize": "XXL"},
    {"PackagePrice": 3000}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_PackageList", package_value_9)
    package_value_10 = [
    {"PackageId": "P_D1"},
    {"PackageName": "Deluxe"},
    {"PackageDetails": "Wash,Armor All,Asphalt Removal,Buff. Wax,Glass Detailing,BAC to Zero"},
    {"PackageSize": "S"},
    {"PackagePrice": 2600}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_PackageList", package_value_10)
    package_value_11 = [
    {"PackageId": "P_D2"},
    {"PackageName": "Deluxe"},
    {"PackageDetails": "Wash,Armor All,Asphalt Removal,Buff. Wax,Glass Detailing,BAC to Zero"},
    {"PackageSize": "M"},
    {"PackagePrice": 2900}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_PackageList", package_value_11)
    package_value_12 = [
    {"PackageId": "P_D3"},
    {"PackageName": "Deluxe"},
    {"PackageDetails": "Wash,Armor All,Asphalt Removal,Buff. Wax,Glass Detailing,BAC to Zero"},
    {"PackageSize": "L"},
    {"PackagePrice": 3100}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_PackageList", package_value_12)
    package_value_13 = [
    {"PackageId": "P_D4"},
    {"PackageName": "Deluxe"},
    {"PackageDetails": "Wash,Armor All,Asphalt Removal,Buff. Wax,Glass Detailing,BAC to Zero"},
    {"PackageSize": "XL"},
    {"PackagePrice": 3300}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_PackageList", package_value_13)
    package_value_14 = [
    {"PackageId": "P_D5"},
    {"PackageName": "Deluxe"},
    {"PackageDetails": "Wash,Armor All,Asphalt Removal,Buff. Wax,Glass Detailing,BAC to Zero"},
    {"PackageSize": "XXL"},
    {"PackagePrice": 4000}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_PackageList", package_value_14)
    package_value_15 = [
    {"PackageId": "P_U1"},
    {"PackageName": "Ultimate"},
    {"PackageDetails": "Wash,Armor All,Asphalt Removal,Buff. Wax,Glass Detailing,Under Wash,BAC to Zero"},
    {"PackageSize": "S"},
    {"PackagePrice": 3000}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_PackageList", package_value_15)
    package_value_16 = [
    {"PackageId": "P_U2"},
    {"PackageName": "Ultimate"},
    {"PackageDetails": "Wash,Armor All,Asphalt Removal,Buff. Wax,Glass Detailing,Under Wash,BAC to Zero"},
    {"PackageSize": "M"},
    {"PackagePrice": 3300}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_PackageList", package_value_16)
    package_value_17 = [
    {"PackageId": "P_U3"},
    {"PackageName": "Ultimate"},
    {"PackageDetails": "Wash,Armor All,Asphalt Removal,Buff. Wax,Glass Detailing,Under Wash,BAC to Zero"},
    {"PackageSize": "L"},
    {"PackagePrice": 3600}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_PackageList", package_value_17)
    package_value_18 = [
    {"PackageId": "P_U4"},
    {"PackageName": "Ultimate"},
    {"PackageDetails": "Wash,Armor All,Asphalt Removal,Buff. Wax,Glass Detailing,Under Wash,BAC to Zero"},
    {"PackageSize": "XL"},
    {"PackagePrice": 3900}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_PackageList", package_value_18)
    package_value_19 = [
    {"PackageId": "P_U5"},
    {"PackageName": "Ultimate"},
    {"PackageDetails": "Wash,Armor All,Asphalt Removal,Buff. Wax,Glass Detailing,Under Wash,BAC to Zero"},
    {"PackageSize": "XXL"},
    {"PackagePrice": 4600}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_PackageList", package_value_19)
    package_value_20 = [
    {"PackageId": "P_SU1"},
    {"PackageName": "Superior"},
    {"PackageDetails": "Wash,Armor All,3-Steps Buffing,Glass Detailing,Under Wash,BAC to Zero"},
    {"PackageSize": "S"},
    {"PackagePrice": 4500}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_PackageList", package_value_20)
    package_value_21 = [
    {"PackageId": "P_SU2"},
    {"PackageName": "Superior"},
    {"PackageDetails": "Wash,Armor All,3-Steps Buffing,Glass Detailing,Under Wash,BAC to Zero"},
    {"PackageSize": "M"},
    {"PackagePrice": 5000}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_PackageList", package_value_21)
    package_value_22 = [
    {"PackageId": "P_SU3"},
    {"PackageName": "Superior"},
    {"PackageDetails": "Wash,Armor All,3-Steps Buffing,Glass Detailing,Under Wash,BAC to Zero"},
    {"PackageSize": "L"},
    {"PackagePrice": 5500}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_PackageList", package_value_22)
    package_value_23 = [
    {"PackageId": "P_SU4"},
    {"PackageName": "Superior"},
    {"PackageDetails": "Wash,Armor All,3-Steps Buffing,Glass Detailing,Under Wash,BAC to Zero"},
    {"PackageSize": "XL"},
    {"PackagePrice": 6000}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_PackageList", package_value_23)
    package_value_24 = [
    {"PackageId": "P_SU5"},
    {"PackageName": "Superior"},
    {"PackageDetails": "Wash,Armor All,3-Steps Buffing,Glass Detailing,Under Wash,BAC to Zero"},
    {"PackageSize": "XXL"},
    {"PackagePrice": 7500}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_PackageList", package_value_24)
    service_value_0 = [
    {"ServiceId": "S_BWV1"},
    {"ServiceName": "Body Wash & Vacuum"},
    {"ServiceSize": "S"},
    {"ServicePrice": 140}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_0)
    service_value_1 = [
    {"ServiceId": "S_BWV2"},
    {"ServiceName": "Body Wash & Vacuum"},
    {"ServiceSize": "M"},
    {"ServicePrice": 160}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_1)
    service_value_2 = [
    {"ServiceId": "S_BWV3"},
    {"ServiceName": "Body Wash & Vacuum"},
    {"ServiceSize": "L"},
    {"ServicePrice": 180}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_2)
    service_value_3 = [
    {"ServiceId": "S_BWV4"},
    {"ServiceName": "Body Wash & Vacuum"},
    {"ServiceSize": "XL"},
    {"ServicePrice": 200}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_3)
    service_value_4 = [
    {"ServiceId": "S_BWV5"},
    {"ServiceName": "Body Wash & Vacuum"},
    {"ServiceSize": "XXL"},
    {"ServicePrice": 250}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_4)
    service_value_5 = [
    {"ServiceId": "S_AA1"},
    {"ServiceName": "Armor All"},
    {"ServiceSize": "S"},
    {"ServicePrice": 140}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_5)
    service_value_6 = [
    {"ServiceId": "S_AA2"},
    {"ServiceName": "Armor All"},
    {"ServiceSize": "M"},
    {"ServicePrice": 140}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_6)
    service_value_7 = [
    {"ServiceId": "S_AA3"},
    {"ServiceName": "Armor All"},
    {"ServiceSize": "L"},
    {"ServicePrice": 140}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_7)
    service_value_8 = [
    {"ServiceId": "S_AA4"},
    {"ServiceName": "Armor All"},
    {"ServiceSize": "XL"},
    {"ServicePrice": 140}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_8)
    service_value_9 = [
    {"ServiceId": "S_AA5"},
    {"ServiceName": "Armor All"},
    {"ServiceSize": "XXL"},
    {"ServicePrice": 200}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_9)
    service_value_10 = [
    {"ServiceId": "S_AR1"},
    {"ServiceName": "Asphalt Removal"},
    {"ServiceSize": "S"},
    {"ServicePrice": 200}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_10)
    service_value_11 = [
    {"ServiceId": "S_AR2"},
    {"ServiceName": "Asphalt Removal"},
    {"ServiceSize": "M"},
    {"ServicePrice": 230}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_11)
    service_value_12 = [
    {"ServiceId": "S_AR3"},
    {"ServiceName": "Asphalt Removal"},
    {"ServiceSize": "L"},
    {"ServicePrice": 250}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_12)
    service_value_13 = [
    {"ServiceId": "S_AR4"},
    {"ServiceName": "Asphalt Removal"},
    {"ServiceSize": "XL"},
    {"ServicePrice": 280}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_13)
    service_value_14 = [
    {"ServiceId": "S_AR5"},
    {"ServiceName": "Asphalt Removal"},
    {"ServiceSize": "XXL"},
    {"ServicePrice": 350}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_14)
    service_value_15 = [
    {"ServiceId": "S_SCCR1"},
    {"ServiceName": "Seat Cover - Cloth - Removal"},
    {"ServiceSize": "S"},
    {"ServicePrice": 150}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_15)
    service_value_16 = [
    {"ServiceId": "S_SCCR2"},
    {"ServiceName": "Seat Cover - Cloth - Removal"},
    {"ServiceSize": "M"},
    {"ServicePrice": 200}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_16)
    service_value_17 = [
    {"ServiceId": "S_SCCR3"},
    {"ServiceName": "Seat Cover - Cloth - Removal"},
    {"ServiceSize": "L"},
    {"ServicePrice": 250}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_17)
    service_value_18 = [
    {"ServiceId": "S_SCCR4"},
    {"ServiceName": "Seat Cover - Cloth - Removal"},
    {"ServiceSize": "XL"},
    {"ServicePrice": 250}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_18)
    service_value_19 = [
    {"ServiceId": "S_SCCR5"},
    {"ServiceName": "Seat Cover - Cloth - Removal"},
    {"ServiceSize": "XXL"},
    {"ServicePrice": 300}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_19)
    service_value_20 = [
    {"ServiceId": "S_SCCI1"},
    {"ServiceName": "Seat Cover - Cloth - Install"},
    {"ServiceSize": "S"},
    {"ServicePrice": 200}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_20)
    service_value_21 = [
    {"ServiceId": "S_SCCI2"},
    {"ServiceName": "Seat Cover - Cloth - Install"},
    {"ServiceSize": "M"},
    {"ServicePrice": 250}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_21)
    service_value_22 = [
    {"ServiceId": "S_SCCI3"},
    {"ServiceName": "Seat Cover - Cloth - Install"},
    {"ServiceSize": "L"},
    {"ServicePrice": 300}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_22)
    service_value_23 = [
    {"ServiceId": "S_SCCI4"},
    {"ServiceName": "Seat Cover - Cloth - Install"},
    {"ServiceSize": "XL"},
    {"ServicePrice": 350}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_23)
    service_value_24 = [
    {"ServiceId": "S_SCCI5"},
    {"ServiceName": "Seat Cover - Cloth - Install"},
    {"ServiceSize": "XXL"},
    {"ServicePrice": 350}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_24)
    service_value_25 = [
    {"ServiceId": "S_SCCL1"},
    {"ServiceName": "Seat Cover - Cloth - Laundry"},
    {"ServiceSize": "S"},
    {"ServicePrice": 150}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_25)
    service_value_26 = [
    {"ServiceId": "S_SCCL2"},
    {"ServiceName": "Seat Cover - Cloth - Laundry"},
    {"ServiceSize": "M"},
    {"ServicePrice": 150}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_26)
    service_value_27 = [
    {"ServiceId": "S_SCCL3"},
    {"ServiceName": "Seat Cover - Cloth - Laundry"},
    {"ServiceSize": "L"},
    {"ServicePrice": 200}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_27)
    service_value_28 = [
    {"ServiceId": "S_SCCL4"},
    {"ServiceName": "Seat Cover - Cloth - Laundry"},
    {"ServiceSize": "XL"},
    {"ServicePrice": 200}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_28)
    service_value_29 = [
    {"ServiceId": "S_SCCL5"},
    {"ServiceName": "Seat Cover - Cloth - Laundry"},
    {"ServiceSize": "XXL"},
    {"ServicePrice": 250}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_29)
    service_value_30 = [
    {"ServiceId": "S_SCLR1"},
    {"ServiceName": "Seat Cover - Leather - Removal"},
    {"ServiceSize": "S"},
    {"ServicePrice": 150}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_30)
    service_value_31 = [
    {"ServiceId": "S_SCLR2"},
    {"ServiceName": "Seat Cover - Leather - Removal"},
    {"ServiceSize": "M"},
    {"ServicePrice": 200}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_31)
    service_value_32 = [
    {"ServiceId": "S_SCLR3"},
    {"ServiceName": "Seat Cover - Leather - Removal"},
    {"ServiceSize": "L"},
    {"ServicePrice": 250}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_32)
    service_value_33 = [
    {"ServiceId": "S_SCLR4"},
    {"ServiceName": "Seat Cover - Leather - Removal"},
    {"ServiceSize": "XL"},
    {"ServicePrice": 250}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_33)
    service_value_34 = [
    {"ServiceId": "S_SCLR5"},
    {"ServiceName": "Seat Cover - Leather - Removal"},
    {"ServiceSize": "XXL"},
    {"ServicePrice": 300}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_34)
    service_value_35 = [
    {"ServiceId": "S_SCLI1"},
    {"ServiceName": "Seat Cover - Leather - Install"},
    {"ServiceSize": "S"},
    {"ServicePrice": 300}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_35)
    service_value_36 = [
    {"ServiceId": "S_SCLI2"},
    {"ServiceName": "Seat Cover - Leather - Install"},
    {"ServiceSize": "M"},
    {"ServicePrice": 350}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_36)
    service_value_37 = [
    {"ServiceId": "S_SCLI3"},
    {"ServiceName": "Seat Cover - Leather - Install"},
    {"ServiceSize": "L"},
    {"ServicePrice": 400}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_37)
    service_value_38 = [
    {"ServiceId": "S_SCLI4"},
    {"ServiceName": "Seat Cover - Leather - Install"},
    {"ServiceSize": "XL"},
    {"ServicePrice": 400}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_38)
    service_value_39 = [
    {"ServiceId": "S_SCLI5"},
    {"ServiceName": "Seat Cover - Leather - Install"},
    {"ServiceSize": "XXL"},
    {"ServicePrice": 450}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_39)
    service_value_40 = [
    {"ServiceId": "S_SCLL1"},
    {"ServiceName": "Seat Cover - Leather - Laundry"},
    {"ServiceSize": "S"},
    {"ServicePrice": 200}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_40)
    service_value_41 = [
    {"ServiceId": "S_SCLL2"},
    {"ServiceName": "Seat Cover - Leather - Laundry"},
    {"ServiceSize": "M"},
    {"ServicePrice": 200}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_41)
    service_value_42 = [
    {"ServiceId": "S_SCLL3"},
    {"ServiceName": "Seat Cover - Leather - Laundry"},
    {"ServiceSize": "L"},
    {"ServicePrice": 250}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_42)
    service_value_43 = [
    {"ServiceId": "S_SCLL4"},
    {"ServiceName": "Seat Cover - Leather - Laundry"},
    {"ServiceSize": "XL"},
    {"ServicePrice": 250}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_43)
    service_value_44 = [
    {"ServiceId": "S_SCLL5"},
    {"ServiceName": "Seat Cover - Leather - Laundry"},
    {"ServiceSize": "XXL"},
    {"ServicePrice": 300}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_44)
    service_value_45 = [
    {"ServiceId": "S_DBTZ1"},
    {"ServiceName": "Disinfection (Bac to Zero)"},
    {"ServiceSize": "S"},
    {"ServicePrice": 600}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_45)
    service_value_46 = [
    {"ServiceId": "S_DBTZ2"},
    {"ServiceName": "Disinfection (Bac to Zero)"},
    {"ServiceSize": "M"},
    {"ServicePrice": 600}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_46)
    service_value_47 = [
    {"ServiceId": "S_DBTZ3"},
    {"ServiceName": "Disinfection (Bac to Zero)"},
    {"ServiceSize": "L"},
    {"ServicePrice": 600}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_47)
    service_value_48 = [
    {"ServiceId": "S_DBTZ4"},
    {"ServiceName": "Disinfection (Bac to Zero)"},
    {"ServiceSize": "XL"},
    {"ServicePrice": 600}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_48)
    service_value_49 = [
    {"ServiceId": "S_DBTZ5"},
    {"ServiceName": "Disinfection (Bac to Zero)"},
    {"ServiceSize": "XXL"},
    {"ServicePrice": 600}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_49)
    service_value_50 = [
    {"ServiceId": "S_HC1"},
    {"ServiceName": "Headlights Cleaning"},
    {"ServiceSize": "S"},
    {"ServicePrice": 600}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_50)
    service_value_51 = [
    {"ServiceId": "S_HC2"},
    {"ServiceName": "Headlights Cleaning"},
    {"ServiceSize": "M"},
    {"ServicePrice": 600}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_51)
    service_value_52 = [
    {"ServiceId": "S_HC3"},
    {"ServiceName": "Headlights Cleaning"},
    {"ServiceSize": "L"},
    {"ServicePrice": 600}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_52)
    service_value_53 = [
    {"ServiceId": "S_HC4"},
    {"ServiceName": "Headlights Cleaning"},
    {"ServiceSize": "XL"},
    {"ServicePrice": 600}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_53)
    service_value_54 = [
    {"ServiceId": "S_HC5"},
    {"ServiceName": "Headlights Cleaning"},
    {"ServiceSize": "XXL"},
    {"ServicePrice": 600}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_54)
    service_value_55 = [
    {"ServiceId": "S_EW1"},
    {"ServiceName": "Engine Wash"},
    {"ServiceSize": "S"},
    {"ServicePrice": 700}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_55)
    service_value_56 = [
    {"ServiceId": "S_EW2"},
    {"ServiceName": "Engine Wash"},
    {"ServiceSize": "M"},
    {"ServicePrice": 700}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_56)
    service_value_57 = [
    {"ServiceId": "S_EW3"},
    {"ServiceName": "Engine Wash"},
    {"ServiceSize": "L"},
    {"ServicePrice": 700}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_57)
    service_value_58 = [
    {"ServiceId": "S_EW4"},
    {"ServiceName": "Engine Wash"},
    {"ServiceSize": "XL"},
    {"ServicePrice": 700}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_58)
    service_value_59 = [
    {"ServiceId": "S_EW5"},
    {"ServiceName": "Engine Wash"},
    {"ServiceSize": "XXL"},
    {"ServicePrice": 700}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_59)
    service_value_60 = [
    {"ServiceId": "S_MC1"},
    {"ServiceName": "Muffler Cleaning"},
    {"ServiceSize": "S"},
    {"ServicePrice": 500}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_60)
    service_value_61 = [
    {"ServiceId": "S_MC2"},
    {"ServiceName": "Muffler Cleaning"},
    {"ServiceSize": "M"},
    {"ServicePrice": 600}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_61)
    service_value_62 = [
    {"ServiceId": "S_MC3"},
    {"ServiceName": "Muffler Cleaning"},
    {"ServiceSize": "L"},
    {"ServicePrice": 700}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_62)
    service_value_63 = [
    {"ServiceId": "S_MC4"},
    {"ServiceName": "Muffler Cleaning"},
    {"ServiceSize": "XL"},
    {"ServicePrice": 800}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_63)
    service_value_64 = [
    {"ServiceId": "S_MC5"},
    {"ServiceName": "Muffler Cleaning"},
    {"ServiceSize": "XXL"},
    {"ServicePrice": 1000}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_64)
    service_value_65 = [
    {"ServiceId": "S_DGD1"},
    {"ServiceName": "Detailing - Glass Detailing"},
    {"ServiceSize": "S"},
    {"ServicePrice": 1000}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_65)
    service_value_66 = [
    {"ServiceId": "S_DGD2"},
    {"ServiceName": "Detailing - Glass Detailing"},
    {"ServiceSize": "M"},
    {"ServicePrice": 1100}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_66)
    service_value_67 = [
    {"ServiceId": "S_DGD3"},
    {"ServiceName": "Detailing - Glass Detailing"},
    {"ServiceSize": "L"},
    {"ServicePrice": 1200}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_67)
    service_value_68 = [
    {"ServiceId": "S_DGD4"},
    {"ServiceName": "Detailing - Glass Detailing"},
    {"ServiceSize": "XL"},
    {"ServicePrice": 1300}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_68)
    service_value_69 = [
    {"ServiceId": "S_DGD5"},
    {"ServiceName": "Detailing - Glass Detailing"},
    {"ServiceSize": "XXL"},
    {"ServicePrice": 1600}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_69)
    service_value_70 = [
    {"ServiceId": "S_DB3S1"},
    {"ServiceName": "Detailing - Buffing 3 Steps"},
    {"ServiceSize": "S"},
    {"ServicePrice": 2700}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_70)
    service_value_71 = [
    {"ServiceId": "S_DB3S2"},
    {"ServiceName": "Detailing - Buffing 3 Steps"},
    {"ServiceSize": "M"},
    {"ServicePrice": 3200}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_71)
    service_value_72 = [
    {"ServiceId": "S_DB3S3"},
    {"ServiceName": "Detailing - Buffing 3 Steps"},
    {"ServiceSize": "L"},
    {"ServicePrice": 3700}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_72)
    service_value_73 = [
    {"ServiceId": "S_DB3S4"},
    {"ServiceName": "Detailing - Buffing 3 Steps"},
    {"ServiceSize": "XL"},
    {"ServicePrice": 4200}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_73)
    service_value_74 = [
    {"ServiceId": "S_DB3S5"},
    {"ServiceName": "Detailing - Buffing 3 Steps"},
    {"ServiceSize": "XXL"},
    {"ServicePrice": 5200}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_74)
    service_value_75 = [
    {"ServiceId": "S_DI1"},
    {"ServiceName": "Detailing - Interior"},
    {"ServiceSize": "S"},
    {"ServicePrice": 3500}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_75)
    service_value_76 = [
    {"ServiceId": "S_DI2"},
    {"ServiceName": "Detailing - Interior"},
    {"ServiceSize": "M"},
    {"ServicePrice": 4000}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_76)
    service_value_77 = [
    {"ServiceId": "S_DI3"},
    {"ServiceName": "Detailing - Interior"},
    {"ServiceSize": "L"},
    {"ServicePrice": 4500}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_77)
    service_value_78 = [
    {"ServiceId": "S_DI4"},
    {"ServiceName": "Detailing - Interior"},
    {"ServiceSize": "XL"},
    {"ServicePrice": 5000}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_78)
    service_value_79 = [
    {"ServiceId": "S_DI5"},
    {"ServiceName": "Detailing - Interior"},
    {"ServiceSize": "XXL"},
    {"ServicePrice": 6000}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_79)
    service_value_80 = [
    {"ServiceId": "S_DE1"},
    {"ServiceName": "Detailing - Exterior"},
    {"ServiceSize": "S"},
    {"ServicePrice": 4000}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_80)
    service_value_81 = [
    {"ServiceId": "S_DE2"},
    {"ServiceName": "Detailing - Exterior"},
    {"ServiceSize": "M"},
    {"ServicePrice": 4500}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_81)
    service_value_82 = [
    {"ServiceId": "S_DE3"},
    {"ServiceName": "Detailing - Exterior"},
    {"ServiceSize": "L"},
    {"ServicePrice": 5000}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_82)
    service_value_83 = [
    {"ServiceId": "S_DE4"},
    {"ServiceName": "Detailing - Exterior"},
    {"ServiceSize": "XL"},
    {"ServicePrice": 5500}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_83)
    service_value_84 = [
    {"ServiceId": "S_DE5"},
    {"ServiceName": "Detailing - Exterior"},
    {"ServiceSize": "XXL"},
    {"ServicePrice": 6500}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_84)
    service_value_85 = [
    {"ServiceId": "S_DF1"},
    {"ServiceName": "Detailing - Full"},
    {"ServiceSize": "S"},
    {"ServicePrice": 7000}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_85)
    service_value_86 = [
    {"ServiceId": "S_DF2"},
    {"ServiceName": "Detailing - Full"},
    {"ServiceSize": "M"},
    {"ServicePrice": 8000}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_86)
    service_value_87 = [
    {"ServiceId": "S_DF3"},
    {"ServiceName": "Detailing - Full"},
    {"ServiceSize": "L"},
    {"ServicePrice": 9000}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_87)
    service_value_88 = [
    {"ServiceId": "S_DF4"},
    {"ServiceName": "Detailing - Full"},
    {"ServiceSize": "XL"},
    {"ServicePrice": 10000}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_88)
    service_value_89 = [
    {"ServiceId": "S_DF5"},
    {"ServiceName": "Detailing - Full"},
    {"ServiceSize": "XXL"},
    {"ServicePrice": 12000}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_89)
    service_value_90 = [
    {"ServiceId": "S_U1"},
    {"ServiceName": "Underwash"},
    {"ServiceSize": "S"},
    {"ServicePrice": 400}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_90)
    service_value_91 = [
    {"ServiceId": "S_U2"},
    {"ServiceName": "Underwash"},
    {"ServiceSize": "M"},
    {"ServicePrice": 450}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_91)
    service_value_92 = [
    {"ServiceId": "S_U3"},
    {"ServiceName": "Underwash"},
    {"ServiceSize": "L"},
    {"ServicePrice": 500}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_92)
    service_value_93 = [
    {"ServiceId": "S_U4"},
    {"ServiceName": "Underwash"},
    {"ServiceSize": "XL"},
    {"ServicePrice": 550}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_93)
    service_value_94 = [
    {"ServiceId": "S_U5"},
    {"ServiceName": "Underwash"},
    {"ServiceSize": "XXL"},
    {"ServicePrice": 600}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_94)
    service_value_95 = [
    {"ServiceId": "S_UC1"},
    {"ServiceName": "Under Coating"},
    {"ServiceSize": "S"},
    {"ServicePrice": 6000}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_95)
    service_value_96 = [
    {"ServiceId": "S_UC2"},
    {"ServiceName": "Under Coating"},
    {"ServiceSize": "M"},
    {"ServicePrice": 6500}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_96)
    service_value_97 = [
    {"ServiceId": "S_UC3"},
    {"ServiceName": "Under Coating"},
    {"ServiceSize": "L"},
    {"ServicePrice": 7000}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_97)
    service_value_98 = [
    {"ServiceId": "S_UC4"},
    {"ServiceName": "Under Coating"},
    {"ServiceSize": "XL"},
    {"ServicePrice": 7500}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_98)
    service_value_99 = [
    {"ServiceId": "S_UC5"},
    {"ServiceName": "Under Coating"},
    {"ServiceSize": "XXL"},
    {"ServicePrice": 8500}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_99)
    service_value_100 = [
    {"ServiceId": "S_HWM1"},
    {"ServiceName": "Hand Wax (Manual)"},
    {"ServiceSize": "S"},
    {"ServicePrice": 500}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_100)
    service_value_101 = [
    {"ServiceId": "S_HWM2"},
    {"ServiceName": "Hand Wax (Manual)"},
    {"ServiceSize": "M"},
    {"ServicePrice": 550}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_101)
    service_value_102 = [
    {"ServiceId": "S_HWM3"},
    {"ServiceName": "Hand Wax (Manual)"},
    {"ServiceSize": "L"},
    {"ServicePrice": 600}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_102)
    service_value_103 = [
    {"ServiceId": "S_HWM4"},
    {"ServiceName": "Hand Wax (Manual)"},
    {"ServiceSize": "XL"},
    {"ServicePrice": 650}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_103)
    service_value_104 = [
    {"ServiceId": "S_HWM5"},
    {"ServiceName": "Hand Wax (Manual)"},
    {"ServiceSize": "XXL"},
    {"ServicePrice": 750}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_104)
    service_value_105 = [
    {"ServiceId": "S_BWM1"},
    {"ServiceName": "Buff Wax (Machine)"},
    {"ServiceSize": "S"},
    {"ServicePrice": 900}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_105)
    service_value_106 = [
    {"ServiceId": "S_BWM2"},
    {"ServiceName": "Buff Wax (Machine)"},
    {"ServiceSize": "M"},
    {"ServicePrice": 100}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_106)
    service_value_107 = [
    {"ServiceId": "S_BWM3"},
    {"ServiceName": "Buff Wax (Machine)"},
    {"ServiceSize": "L"},
    {"ServicePrice": 1100}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_107)
    service_value_108 = [
    {"ServiceId": "S_BWM4"},
    {"ServiceName": "Buff Wax (Machine)"},
    {"ServiceSize": "XL"},
    {"ServicePrice": 1200}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_108)
    service_value_109 = [
    {"ServiceId": "S_BWM5"},
    {"ServiceName": "Buff Wax (Machine)"},
    {"ServiceSize": "XXL"},
    {"ServicePrice": 1500}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_109)
    service_value_110 = [
    {"ServiceId": "S_CCBP1"},
    {"ServiceName": "Ceramic Coating - Body Panels"},
    {"ServiceSize": "S"},
    {"ServicePrice": 15000}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_110)
    service_value_111 = [
    {"ServiceId": "S_CCBP2"},
    {"ServiceName": "Ceramic Coating - Body Panels"},
    {"ServiceSize": "M"},
    {"ServicePrice": 16000}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_111)
    service_value_112 = [
    {"ServiceId": "S_CCBP3"},
    {"ServiceName": "Ceramic Coating - Body Panels"},
    {"ServiceSize": "L"},
    {"ServicePrice": 17000}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_112)
    service_value_113 = [
    {"ServiceId": "S_CCBP4"},
    {"ServiceName": "Ceramic Coating - Body Panels"},
    {"ServiceSize": "XL"},
    {"ServicePrice": 18000}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_113)
    service_value_114 = [
    {"ServiceId": "S_CCBP5"},
    {"ServiceName": "Ceramic Coating - Body Panels"},
    {"ServiceSize": "XXL"},
    {"ServicePrice": 20000}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_114)
    service_value_115 = [
    {"ServiceId": "S_CCG1"},
    {"ServiceName": "Ceramic Coating - Glass"},
    {"ServiceSize": "S"},
    {"ServicePrice": 5000}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_115)
    service_value_116 = [
    {"ServiceId": "S_CCG2"},
    {"ServiceName": "Ceramic Coating - Glass"},
    {"ServiceSize": "M"},
    {"ServicePrice": 6000}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_116)
    service_value_117 = [
    {"ServiceId": "S_CCG3"},
    {"ServiceName": "Ceramic Coating - Glass"},
    {"ServiceSize": "L"},
    {"ServicePrice": 7000}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_117)
    service_value_118 = [
    {"ServiceId": "S_CCG4"},
    {"ServiceName": "Ceramic Coating - Glass"},
    {"ServiceSize": "XL"},
    {"ServicePrice": 8000}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_118)
    service_value_119 = [
    {"ServiceId": "S_CCG5"},
    {"ServiceName": "Ceramic Coating - Glass"},
    {"ServiceSize": "XXL"},
    {"ServicePrice": 10000}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_119)
    service_value_120 = [
    {"ServiceId": "S_CCR1"},
    {"ServiceName": "Ceramic Coating - Rims"},
    {"ServiceSize": "S"},
    {"ServicePrice": 3000}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_120)
    service_value_121 = [
    {"ServiceId": "S_CCR2"},
    {"ServiceName": "Ceramic Coating - Rims"},
    {"ServiceSize": "M"},
    {"ServicePrice": 4000}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_121)
    service_value_122 = [
    {"ServiceId": "S_CCR3"},
    {"ServiceName": "Ceramic Coating - Rims"},
    {"ServiceSize": "L"},
    {"ServicePrice": 5000}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_122)
    service_value_123 = [
    {"ServiceId": "S_CCR4"},
    {"ServiceName": "Ceramic Coating - Rims"},
    {"ServiceSize": "XL"},
    {"ServicePrice": 6000}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_123)
    service_value_124 = [
    {"ServiceId": "S_CCR5"},
    {"ServiceName": "Ceramic Coating - Rims"},
    {"ServiceSize": "XXL"},
    {"ServicePrice": 6000}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_124)
    service_value_125 = [
    {"ServiceId": "S_RBWWOH1"},
    {"ServiceName": "Repainting/Body Works - Wash Over (Hilamos)"},
    {"ServiceSize": "S"},
    {"ServicePrice": 30000}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_125)
    service_value_126 = [
    {"ServiceId": "S_RBWWOH2"},
    {"ServiceName": "Repainting/Body Works - Wash Over (Hilamos)"},
    {"ServiceSize": "M"},
    {"ServicePrice": 35000}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_126)
    service_value_127 = [
    {"ServiceId": "S_RBWWOH3"},
    {"ServiceName": "Repainting/Body Works - Wash Over (Hilamos)"},
    {"ServiceSize": "L"},
    {"ServicePrice": 40000}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_127)
    service_value_128 = [
    {"ServiceId": "S_RBWWOH4"},
    {"ServiceName": "Repainting/Body Works - Wash Over (Hilamos)"},
    {"ServiceSize": "XL"},
    {"ServicePrice": 45000}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_128)
    service_value_129 = [
    {"ServiceId": "S_RBWWOH5"},
    {"ServiceName": "Repainting/Body Works - Wash Over (Hilamos)"},
    {"ServiceSize": "XXL"},
    {"ServicePrice": 50000}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_129)
    service_value_130 = [
    {"ServiceId": "S_RBWPPPSA1"},
    {"ServiceName": "Repainting/Body Works - Per Panel Price Starts At"},
    {"ServiceSize": "S"},
    {"ServicePrice": 3500}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_130)
    service_value_131 = [
    {"ServiceId": "S_RBWPPPSA2"},
    {"ServiceName": "Repainting/Body Works - Per Panel Price Starts At"},
    {"ServiceSize": "M"},
    {"ServicePrice": 3500}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_131)
    service_value_132 = [
    {"ServiceId": "S_RBWPPPSA3"},
    {"ServiceName": "Repainting/Body Works - Per Panel Price Starts At"},
    {"ServiceSize": "L"},
    {"ServicePrice": 4000}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_132)
    service_value_133 = [
    {"ServiceId": "S_RBWPPPSA4"},
    {"ServiceName": "Repainting/Body Works - Per Panel Price Starts At"},
    {"ServiceSize": "XL"},
    {"ServicePrice": 4500}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_133)
    service_value_134 = [
    {"ServiceId": "S_RBWPPPSA5"},
    {"ServiceName": "Repainting/Body Works - Per Panel Price Starts At"},
    {"ServiceSize": "XXL"},
    {"ServicePrice": 5000}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_134)
    service_value_135 = [
    {"ServiceId": "S_RBWRC1"},
    {"ServiceName": "Repainting/Body Works - Rims - Car"},
    {"ServiceSize": "S"},
    {"ServicePrice": 5000}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_135)
    service_value_136 = [
    {"ServiceId": "S_RBWRC2"},
    {"ServiceName": "Repainting/Body Works - Rims - Car"},
    {"ServiceSize": "M"},
    {"ServicePrice": 5000}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_136)
    service_value_137 = [
    {"ServiceId": "S_RBWRC3"},
    {"ServiceName": "Repainting/Body Works - Rims - Car"},
    {"ServiceSize": "L"},
    {"ServicePrice": 6000}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_137)
    service_value_138 = [
    {"ServiceId": "S_RBWRC4"},
    {"ServiceName": "Repainting/Body Works - Rims - Car"},
    {"ServiceSize": "XL"},
    {"ServicePrice": 8000}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_138)
    service_value_139 = [
    {"ServiceId": "S_RBWRC5"},
    {"ServiceName": "Repainting/Body Works - Rims - Car"},
    {"ServiceSize": "XXL"},
    {"ServicePrice": 8000}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_ServiceList", service_value_139)
    payment_value_0 = [
    {"PaymentMethodName": "Cash"}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_PaymentMethodList", payment_value_0)
    payment_value_1 = [
    {"PaymentMethodName": "GCash"}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_PaymentMethodList", payment_value_1)
    payment_value_2 = [
    {"PaymentMethodName": "Banking"}
    ]
    a.insertToTable("AUTOLANDIA", "AUTOLANDIA_PaymentMethodList", payment_value_2)
