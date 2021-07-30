Partial Class DS_CCAMHClientRegistration
    Partial Class CCAMH_CLIENTSDataTable



    End Class

    Partial Class CLIENT_REGISTRATION_DETAILDataTable

        Private Sub CLIENT_REGISTRATION_DETAILDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.CLIENT_WAITING_STATUSColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Class CLIENT_CA_SOCIALDataTable


    End Class

End Class

Namespace DS_CCAMHClientRegistrationTableAdapters
    
    Partial Public Class CCAMH_CLIENTSTableAdapter
    End Class
End Namespace

Namespace DS_CCAMHClientRegistrationTableAdapters
    
    Partial Public Class CCAMH_DIAGNOSISTableAdapter
    End Class
End Namespace

Namespace DS_CCAMHClientRegistrationTableAdapters
    
    Partial Public Class CLIENT_CA_SOCIALTableAdapter
    End Class
End Namespace
