Module MImpressions

    '========================== Neuro =======================================

    Function InsertNeuro(ByVal SYM_NAME As String, ByVal DESC As String) As Integer
        Dim sql As String = "INSERT INTO CCAMH_NEURO (SYMPTOM_NAME,DESCRIPTION) VALUES(N'" & SYM_NAME & "',N'" & DESC & "')"
        Return ModGlobleVariable.GENERAL_DAO.InsertDAO(sql)
    End Function
    Function UpdateNeuro(ByVal SYM_NAME As String, ByVal DESC As String, SYMPTOM_ID As String) As Integer
        Dim sql As String = "UPDATE CCAMH_NEURO set SYMPTOM_NAME =N'" & SYM_NAME & "',DESCRIPTION=N'" & DESC & "' WHERE SYMPTOM_ID=" & SYMPTOM_ID
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(Sql)
    End Function
    Function DeleteNeuro(SYMPTOM_ID As Integer) As Integer
        Dim sql As String = "Delete FROM CCAMH_NEURO WHERE SYMPTOM_ID=" & SYMPTOM_ID
        Return ModGlobleVariable.GENERAL_DAO.DeleteDAO(sql)
    End Function
    Function GetAllNeuro() As DataTable
        Dim sql As String = "SELECT * FROM CCAMH_NEURO"
        Return ModGlobleVariable.GENERAL_DAO.SelectAsDataTable(sql)
    End Function
    '============================== Disorder ==========================================
    Function InsertDDisorder(ByVal SYM_NAME As String, ByVal DESC As String) As Integer
        Dim sql As String = "INSERT INTO CCAMH_CLIENT_DDISORDER (SYMPTOM_NAME,DESCRIPTION) VALUES(N'" & SYM_NAME & "',N'" & DESC & "' )"
        Return ModGlobleVariable.GENERAL_DAO.InsertDAO(sql)
    End Function
    Function UpdateDDisorder(SYM_NAME As String, DESC As String, SYMPTOM_ID As String) As Integer
        Dim sql As String = "UPDATE CCAMH_CLIENT_DDISORDER SET SYMPTOM_NAME=N'" & SYM_NAME & "',DESCRIPTION=N'" & DESCRIPTION & "' WHERE SYMPTOM_ID=" & SYMPTOM_ID
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(sql)
    End Function
    Function DeleteDDisorder(SYMPTOM_ID As String) As Integer
        Dim sql As String = "Delete FROM CCAMH_CLIENT_DDISORDER WHERE SYMPTOM_ID=" & SYMPTOM_ID
        Return ModGlobleVariable.GENERAL_DAO.DeleteDAO(sql)
    End Function
    Function GetAllDisorder() As DataTable
        Dim sql As String = "SELECT * FROM CCAMH_CLIENT_DDISORDER"
        Return ModGlobleVariable.GENERAL_DAO.SelectAsDataTable(sql)
    End Function


    '============================ PsyMajor ===========================================
    Function InsertPsyMajor(ByVal SYM_NAME As String, ByVal DESC As String) As Integer
        Dim sql As String = "INSERT INTO CCAMH_PSYCHO_MAJOR (SYMPTOM_NAME,DESCRIPTION) VALUES(N'" & SYM_NAME & "',N'" & DESC & "')"
        Return ModGlobleVariable.GENERAL_DAO.InsertDAO(sql)
    End Function
    Function UpdatePsyMajor(ByVal SYM_NAME As String, ByVal DESC As String, SYMPTOM_ID As Integer) As Integer
        Dim sql As String = "Update CCAMH_PSYCHO_MAJOR SET SYMPTOM_NAME=N'" & SYM_NAME & "', DESCRIPTION=N'" & DESC & "' WHERE SYMPTOM_ID=" & SYMPTOM_ID
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(sql)
    End Function
    Function DeletePsyMajor(SYMPTOM_ID As Integer) As Integer
        Dim sql As String = "Delete from CCAMH_PSYCHO_MAJOR  WHERE SYMPTOM_ID=" & SYMPTOM_ID
        Return ModGlobleVariable.GENERAL_DAO.DeleteDAO(sql)
    End Function

    Function GetAllPsyMajor() As DataTable
        Dim sql As String = "SELECT * FROM CCAMH_PSYCHO_MAJOR"
        Return ModGlobleVariable.GENERAL_DAO.SelectAsDataTable(sql)
    End Function


    '======================== PsyMinor ======================================
    Function InsertPsyMinor(ByVal SYM_NAME As String, ByVal DESC As String) As Integer
        Dim sql As String = "INSERT INTO CCAMH_PSYCHO_MINOR (SYMPTOM_NAME,DESCRIPTION) VALUES(N'" & SYM_NAME & "',N'" & DESC & "')"
        Return ModGlobleVariable.GENERAL_DAO.InsertDAO(sql)
    End Function

    Function UpdatePsyMinor(ByVal SYM_NAME As String, ByVal DESC As String, SYMPTOM_ID As Integer) As Integer
        Dim sql As String = "UPDATE CCAMH_PSYCHO_MINOR SET SYMPTOM_NAME=N'" & SYM_NAME & "',DESCRIPTION=N'" & DESC & "' WHERE SYMPTOM_ID=" & SYMPTOM_ID
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(sql)
    End Function

    Function DeletePsyMinor(SYMPTOM_ID As Integer) As Integer
        Dim sql As String = "DELETE FROM CCAMH_PSYCHO_MINOR  WHERE SYMPTOM_ID=" & SYMPTOM_ID
        Return ModGlobleVariable.GENERAL_DAO.DeleteDAO(sql)
    End Function
    Function GetAllPsyMinor() As DataTable
        Dim sql As String = "SELECT * FROM CCAMH_PSYCHO_MINOR"
        Return ModGlobleVariable.GENERAL_DAO.SelectAsDataTable(sql)
    End Function

    '=======================================================
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
