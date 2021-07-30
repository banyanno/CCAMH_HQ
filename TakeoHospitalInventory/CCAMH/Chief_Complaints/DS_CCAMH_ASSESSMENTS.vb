Partial Class DS_CCAMH_ASSESSMENTS
    Partial Class CCAMH_VIEW_ACTIVE_ADVISED_CLIENTSDataTable

        Private Sub CCAMH_VIEW_ACTIVE_ADVISED_CLIENTSDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.CLIENT_ASSESS_DATEColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class

Namespace DS_CCAMH_ASSESSMENTSTableAdapters
    
    Partial Public Class CCAMH_CLIENT_ASSESSMENT_INFOTableAdapter
    End Class
End Namespace
