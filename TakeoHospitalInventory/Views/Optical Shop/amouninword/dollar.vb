Imports System.Math

Public Class dollarOpticalShop
    Dim oneWords As String = ",មួយ,ពី,បី,បួន,ប្រាំ,ប្រាំមួយ,ប្រាំពិល,ប្រាំបី,ប្រាំបួន,ដប់,ដប់មួយ,ដប់ពី,ដប់បី,ដប់បួន,ដប់ប្រាំ,ដប់ប្រាំមួយ,ដប់ប្រាំពិល,ដប់ប្រាំបី,ដប់ប្រាំបួន"
    Dim ones() As String = oneWords.Split(",")
    Dim tenWords As String = ",ដប់,ម្ភៃ,សាមសិប,សែសិប,ហាសិប,ហុកសិប,ចិតសិប,បែតសិប,កាំសិប"
    Dim tens() As String = tenWords.Split(",")

    Public Function Convert(ByVal input As String) As String
        input = input.Replace("$", "").Replace(",", "")
        If input.Length > 12 Then Return "Error: that is too much for inputting this value."
        Dim dollars, cents As String
        If input.IndexOf(".") > 0 Then
            dollars = input.Substring(0, input.IndexOf(".")).PadLeft(9, "0")
            cents = input.Substring(input.IndexOf(".") + 1).PadRight(2, "0")
            If cents = "00" Then cents = "0"
        Else
            dollars = input.PadLeft(9, "0") : cents = "0"
        End If
        Dim output As String
        Dim mill, thou, hund, cent As Integer
        Dim mills, thous, hunds As String
        mill = CType(dollars.Substring(0, 3), Integer)
        thou = CType(dollars.Substring(3, 3), Integer)
        hund = CType(dollars.Substring(6, 3), Integer)
        cent = CType(cents, Integer)
        mills = convertHundreds(mill)
        thous = convertHundreds(thou)
        hunds = convertHundreds(hund)
        cents = convertHundreds(cent)
        output = IIf(mills.Trim = "", "", mills + "លាន ") '" Million ")
        output += IIf(thous.Trim = "", "", thous + "ពាន់​ ") '" Thousand ")
        output += IIf(hunds.Trim = "", "", hunds)
        output = IIf(output.Length = 0, "សូន្យ ដុល្លា ​ ", output + "ដុល្លា  ")
        output = IIf(output = "មួយ ដុល្លា  ", "មួយ ដុល្លា  ", output)
        'output = IIf(output.Length = 0, "សូន្យ ដុល្លា ​និង ", output + "ដុល្លា និង ")
        'output = IIf(output = "មួយ ដុល្លា និង ", "មួយ ដុល្លា និង ", output)
        'output += IIf(cents = "", "សូន្យ", cents) + " សេន"
        Return output
    End Function

    Private Function convertHundreds(ByVal input As Integer) As String
        Dim output As String
        If input <= 99 Then
            output = (convertTens(input))
        Else
            output = ones(Floor(input / 100))
            output += " រយ " ' " Hundred "
            If input - Floor(input / 100) * 100 = 0 Then
                output += ""
            Else
                output += "" + convertTens(input - Floor(input / 100) * 100)
            End If
        End If
        Return output
    End Function

    Function convertTens(ByVal input As Integer) As String
        Dim output As String
        If input < 20 Then
            output = ones(input)
            input = 0
        Else
            output = tens(CType(Floor(input / 10), Integer))
            input -= Floor(input / 10) * 10
        End If
        output = output + IIf(ones(input).Trim = "", "", "" + ones(input))
        Return output
    End Function
End Class
