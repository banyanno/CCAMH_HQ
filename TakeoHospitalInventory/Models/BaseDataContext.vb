Public Class BaseDataContext
    Private THIDataContext As KTGSYSDataContext
    Private THIDataContextUser As DataClassesUserManagmentDataContext
    Private THIDataContextOpticalShop As LinqOpticalShopClassesDataContext

    Public Sub New()
        THIDataContext = New KTGSYSDataContext
        THIDataContextUser = New DataClassesUserManagmentDataContext
        THIDataContextOpticalShop = New LinqOpticalShopClassesDataContext
    End Sub

    ReadOnly Property getTHIDataContext() As KTGSYSDataContext
        Get
            Return THIDataContext
        End Get
    End Property

    ReadOnly Property getTHIDataContextUserManagement() As DataClassesUserManagmentDataContext
        Get
            Return THIDataContextUser
        End Get
    End Property
    ReadOnly Property getTHIDataContextOpticalShop() As LinqOpticalShopClassesDataContext
        Get
            Return THIDataContextOpticalShop
        End Get
    End Property
End Class
