Module random_File_Customer_type_Structure
    Structure CustomerType
        'Customer File variabes
        'the set lenght on the different fields used in the files
        <VBFixedString(3)> Public CustomerNo As String
        <VBFixedString(4)> Public Tittle As String
        <VBFixedString(20)> Public Forname As String
        <VBFixedString(20)> Public Surname As String
        <VBFixedString(3)> Public DoorNo As String
        <VBFixedString(20)> Public StreetName As String
        <VBFixedString(20)> Public Town As String
        <VBFixedString(20)> Public County As String
        <VBFixedString(8)> Public Postcode As String
        <VBFixedString(11)> Public MobileNo As String
        <VBFixedString(11)> Public LandlineNo As String
        <VBFixedString(30)> Public email As String
    End Structure
    'public variables so they can be accessed anywhere in the application
    'This is the file for the customer details
    Public OneCustomer As CustomerType
    'This is the number of records in the customer file
    Public NumberOfRecords As Integer
    'This is the number of records In the repair file
    Public noOfRecords As Integer
    'This is the file name of the repairs file
    Public oneRepair As RepairType
    'This is the file name of the order file
    Public OneOrder As OrderType
    'This is the number of records in the order file
    Public orderpositionofrecord As Integer
    Structure RepairType
        'Repairs file variables
        'the set lenght on the different fields used in the files
        <VBFixedString(3)> Public RepairNo As String
        <VBFixedString(30)> Public RepairName As String
        <VBFixedString(8)> Public RepairPrice As String
    End Structure
    Structure OrderType
        'order file variables
        'the set lenght on the different fields used in the files
        <VBFixedString(3)> Public CustNo As String
        <VBFixedString(20)> Public CustFor As String
        <VBFixedString(20)> Public CustSur As String
        <VBFixedString(3)> Public RepNo As String
        <VBFixedString(30)> Public RepName As String
        <VBFixedString(8)> Public RepPrice As String
    End Structure
End Module
