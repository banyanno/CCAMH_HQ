Module MEducation
    Function InsertEducation(ByVal Education As String) As Integer
        Dim sql As String = "INSERT INTO tblEducation VALUES('" & Education & "')"
        Return ModGlobleVariable.GENERAL_DAO.InsertDAO(sql)
    End Function
    Function UpdateEduation(ByVal eduNo As String, ByVal Education As String) As Integer
        Dim sql As String = "UPDATE tblEducation SET Education='" & Education & "' WHERE eduNo=" & eduNo
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(sql)
    End Function
    Function DeleteEduation(ByVal eduNo As String) As Integer
        Dim sql As String = "DELETE FROM tblEducation WHERE eduNo=" & eduNo
        Return ModGlobleVariable.GENERAL_DAO.DeleteDAO(sql)
    End Function
    Function SelectAllEduation() As DataTable
        Dim sql As String = "SELECT eduNo,Education FROM tblEducation ORDER BY Education ASC"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function
    Function checkEduation(ByVal Education As String) As Integer
        Dim sql As String = "select count(eduNo) from tblEducation where Education='" & Education & "'"
        Return ModGlobleVariable.GENERAL_DAO.SelectAsScalar(sql)
    End Function
End Module
