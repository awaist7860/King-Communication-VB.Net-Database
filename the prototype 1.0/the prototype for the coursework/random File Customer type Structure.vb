Module random_File_Customer_type_Structure
    Structure CustomerType

        <VBFixedString(6)> Public CustomerNo As String
        <VBFixedString(4)> Public Tittle As String
        <VBFixedString(12)> Public Forname As String
        <VBFixedString(12)> Public Surname As String
        <VBFixedString(3)> Public DoorNo As String
        <VBFixedString(12)> Public StreetName As String
        <VBFixedString(12)> Public Town As String
        <VBFixedString(12)> Public City As String
        <VBFixedString(8)> Public Postcode As String
        <VBFixedString(11)> Public MobileNo As String
        <VBFixedString(11)> Public LandlineNo As String
        <VBFixedString(30)> Public email As String
    End Structure
    Public OneCustomer As CustomerType
    Public NumberOfRecords As Integer
End Module
