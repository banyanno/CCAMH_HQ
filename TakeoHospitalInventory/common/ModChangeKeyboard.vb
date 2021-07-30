Module ModChangeKeyboard
    Private KhmerInput As InputLanguage
    Private EnglishInput As InputLanguage
    Public Sub ChangeInputLanguageBar()
        KhmerInput = InputLanguage.CurrentInputLanguage
        EnglishInput = InputLanguage.CurrentInputLanguage
        Dim count As Integer
        count = InputLanguage.InstalledInputLanguages.Count
        For i As Integer = 0 To count - 1
            If InputLanguage.InstalledInputLanguages(i).Culture.DisplayName.StartsWith("English") = True Then
                'Found an English Keyboard 

                EnglishInput = InputLanguage.InstalledInputLanguages(i)

            Else
                If InputLanguage.InstalledInputLanguages(i).Culture.DisplayName.StartsWith("Khmer") = True Then
                    'Found an Khmer Keyboard  
                    KhmerInput = InputLanguage.InstalledInputLanguages(i)
                End If
            End If
        Next i
    End Sub
    Public Sub SetKhmerLanguage()
        InputLanguage.CurrentInputLanguage = KhmerInput
    End Sub
    Public Sub SetEnglishLanguage()
        InputLanguage.CurrentInputLanguage = EnglishInput
    End Sub
End Module
