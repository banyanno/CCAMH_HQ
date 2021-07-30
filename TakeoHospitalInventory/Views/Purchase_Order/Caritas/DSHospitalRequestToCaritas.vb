

Partial Public Class DSHospitalRequestToCaritas
    Partial Class CARITAS_REQ_ITEM_PROVIDER_INFODataTable

        Private Sub CARITAS_REQ_ITEM_PROVIDER_INFODataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.RequestDetailIDColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class
