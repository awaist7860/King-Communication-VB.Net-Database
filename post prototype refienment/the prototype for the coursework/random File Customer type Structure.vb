Module random_File_Customer_type_Structure
    Structure CustomerType
        'Customer File
        <VBFixedString(3)> Public CustomerNo As String
        <VBFixedString(4)> Public Tittle As String
        <VBFixedString(12)> Public Forname As String
        <VBFixedString(12)> Public Surname As String
        <VBFixedString(3)> Public DoorNo As String
        <VBFixedString(12)> Public StreetName As String
        <VBFixedString(12)> Public Town As String
        <VBFixedString(12)> Public County As String
        <VBFixedString(8)> Public Postcode As String
        <VBFixedString(11)> Public MobileNo As String
        <VBFixedString(11)> Public LandlineNo As String
        <VBFixedString(30)> Public email As String
    End Structure
    'This is the file for the customer details
    Public OneCustomer As CustomerType
    'This is the number of records in the customer file
    Public NumberOfRecords As Integer
    'This is the number of records In the repair file
    Public noOfRecords As Integer
    'This is the file name of the repairs file
    Public oneRepair As RepairType


    Structure RepairType
        'Repairs file
        <VBFixedString(3)> Public RepairNo As String
        <VBFixedString(12)> Public RepairName As String
        <VBFixedString(8)> Public RepairPrice As String
    End Structure
End Module
