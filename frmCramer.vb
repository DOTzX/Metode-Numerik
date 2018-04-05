Imports System.IO

Public Class frmCramer

    Dim prec As Integer
    Dim htmlCode As String

    Private Sub wres(ByVal s As String)
        txtResult.Text += s
    End Sub
    Private Sub writeFormula(ByVal nama As String)
        htmlCode = "<h2><b>Metode Numerik | " & nama & " | Copyright &copy; Hugo Annito</b></h2><hr>"
        txtResult.Text = ""
        Dim result
        Dim tmp1, tmp2, tmp3, tmp
        tmp = ""
        tmp1 = ""
        tmp2 = ""
        tmp3 = ""
        result = "Persamaan:" & vbCrLf
        htmlCode += "<br><b>Persamaan:</b><br>"
        If x1.Text <> "" And x1.Text <> "+" Then tmp1 += x1.Text
        tmp1 += "x"
        If x2.Text <> "" And x2.Text <> "+" Then tmp2 += x2.Text
        tmp2 += "x"
        If Val(y1.Text) >= 0 And y1.Text <> "-" Then tmp1 += "+"
        If y1.Text <> "" And y1.Text <> "+" Then tmp1 += y1.Text
        tmp1 += "y"
        If Val(y2.Text) >= 0 And y2.Text <> "-" Then tmp2 += "+"
        If y2.Text <> "" And y2.Text <> "+" Then tmp2 += y2.Text
        tmp2 += "y"
        If x3.Text <> "" And x3.Text <> "+" Then tmp3 += x3.Text
        tmp3 += "x"
        If Val(y3.Text) >= 0 And y3.Text <> "-" Then tmp3 += "+"
        If y3.Text <> "" And y3.Text <> "+" Then tmp3 += y3.Text
        tmp3 += "y"
        If Val(z1.Text) >= 0 And z1.Text <> "-" Then tmp1 += "+"
        If z1.Text <> "" And z1.Text <> "+" Then tmp1 += z1.Text
        tmp1 += "z"
        If Val(z2.Text) >= 0 And z2.Text <> "-" Then tmp2 += "+"
        If z2.Text <> "" And z2.Text <> "+" Then tmp2 += z2.Text
        tmp2 += "z"
        If Val(z3.Text) >= 0 And z3.Text <> "-" Then tmp3 += "+"
        If z3.Text <> "" And z3.Text <> "+" Then tmp3 += z3.Text
        tmp3 += "z"
        tmp1 += " = " & sd1.Text
        tmp2 += " = " & sd2.Text
        tmp3 += " = " & sd3.Text
        tmp = tmp1
        tmp += vbCrLf & tmp2
        tmp += vbCrLf & tmp3
        result += tmp & vbCrLf & vbCrLf
        htmlCode += tmp.replace(vbCrLf, "<br>") & "<br><br>"
        wres(result)
    End Sub
    Private Sub writeTable(ByVal detname As String, ByVal baris1 As Object(), ByVal baris2 As Object(), ByVal baris3 As Object(), ByVal sd As Object())
        htmlCode += "Tabel Persamaan <b>" & detname & "</b><br>"
        htmlCode += "<table border='2' cellpadding='3' style='border-collapse:collapse; text-align:center; width:50%'>"
        htmlCode += "<thead>"
        htmlCode += "<tr>"
        htmlCode += "<th style='width:25%'>x</th>"
        htmlCode += "<th style='width:25%'>y</th>"
        htmlCode += "<th style='width:25%'>z</th>"
        htmlCode += "<th style='width:25%'></th>"
        htmlCode += "</tr>"
        htmlCode += "</thead>"
        htmlCode += "<tbody>"
        htmlCode += "<tr>"
        htmlCode += "<td>" & baris1(0).Text & "</td>"
        htmlCode += "<td>" & baris1(1).Text & "</td>"
        htmlCode += "<td>" & baris1(2).Text & "</td>"
        htmlCode += "<td>" & sd(0).Text & "</td>"
        htmlCode += "</tr>"
        htmlCode += "<tr>"
        htmlCode += "<td>" & baris2(0).Text & "</td>"
        htmlCode += "<td>" & baris2(1).Text & "</td>"
        htmlCode += "<td>" & baris2(2).Text & "</td>"
        htmlCode += "<td>" & sd(1).Text & "</td>"
        htmlCode += "</tr>"
        htmlCode += "<tr>"
        htmlCode += "<td>" & baris3(0).Text & "</td>"
        htmlCode += "<td>" & baris3(1).Text & "</td>"
        htmlCode += "<td>" & baris3(2).Text & "</td>"
        htmlCode += "<td>" & sd(2).Text & "</td>"
        htmlCode += "</tr>"
        htmlCode += "</tbody>"
        htmlCode += "</table>"
    End Sub
    Private Sub writeHTMLCode()
        Using writer As StreamWriter =
            New StreamWriter("result.html")
            writer.Write(htmlCode)
        End Using
        If rBrowser.Checked Then
            Process.Start("result.html")
        End If
    End Sub

    Private Sub replaceWithTable(ByVal baris1 As Object(), ByVal baris2 As Object(), ByVal baris3 As Object(), ByVal baris_col As Integer, ByVal val As Object())
        baris1(baris_col).Text = val(0).Text
        baris2(baris_col).Text = val(1).Text
        baris3(baris_col).Text = val(2).Text
    End Sub

    Private Function calcWriteDeterminant(ByVal detname As String, ByVal baris1 As Object(), ByVal baris2 As Object(), ByVal baris3 As Object(), ByVal sd As Object()) As Integer
        Dim res
        writeTable(detname, baris1, baris2, baris3, sd)
        Dim b1, b2, b3 As Integer()
        b1 = {Val(baris1(0).Text), Val(baris1(1).Text), Val(baris1(2).Text)}
        b2 = {Val(baris2(0).Text), Val(baris2(1).Text), Val(baris2(2).Text)}
        b3 = {Val(baris3(0).Text), Val(baris3(1).Text), Val(baris3(2).Text)}
        res = b1(0) * ((b2(1) * b3(2)) - (b2(2) * b3(1))) - b1(1) * ((b2(0) * b3(2)) - (b2(2) * b3(0))) + b1(2) * ((b2(0) * b3(1)) - (b2(1) * b3(0)))
        res = Math.Round(res, prec)
        Dim tmp As String = ""
        tmp = "" & _
              b1(0) & "(" & b2(1) & " x " & b3(2) & " - " & b2(2) & " x " & b3(1) & ") - " & _
              b1(1) & "(" & b2(0) & " x " & b3(2) & " - " & b2(2) & " x " & b3(0) & ") + " & _
              b1(2) & "(" & b2(0) & " x " & b3(1) & " - " & b2(1) & " x " & b3(0) & ")"
        wres("det. " & detname & " = " & res & vbCrLf & tmp & vbCrLf & vbCrLf)
        htmlCode += "<b>det. " & detname & "</b> = " & tmp & "<br><b>= " & res & "</b><br><br>"
        Return res
    End Function

    Private Sub bHitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bHitung.Click
        Try
            prec = Val(txtPrec.Text)
            writeFormula("SPL - Metode Cramer-Determinant")
            Dim detA, detX, detY, detZ As Double
            Dim a_b1 As Object() = {x1, y1, z1}
            Dim a_b2 As Object() = {x2, y2, z2}
            Dim a_b3 As Object() = {x3, y3, z3}
            Dim a_col1 As Object() = {x1, x2, x3}
            Dim a_col2 As Object() = {y1, y2, y3}
            Dim a_col3 As Object() = {z1, z2, z3}
            Dim a_sd As Object() = {sd1, sd2, sd3}
            Dim x_b1 As Object() = {x_x1, x_y1, x_z1}
            Dim x_b2 As Object() = {x_x2, x_y2, x_z2}
            Dim x_b3 As Object() = {x_x3, x_y3, x_z3}
            Dim y_b1 As Object() = {y_x1, y_y1, y_z1}
            Dim y_b2 As Object() = {y_x2, y_y2, y_z2}
            Dim y_b3 As Object() = {y_x3, y_y3, y_z3}
            Dim z_b1 As Object() = {z_x1, z_y1, z_z1}
            Dim z_b2 As Object() = {z_x2, z_y2, z_z2}
            Dim z_b3 As Object() = {z_x3, z_y3, z_z3}
            Dim x, y, z As Double
            detA = calcWriteDeterminant("A", a_b1, a_b2, a_b3, a_sd)
            replaceWithTable(x_b1, x_b2, x_b3, 0, a_sd)
            replaceWithTable(x_b1, x_b2, x_b3, 1, a_col2)
            replaceWithTable(x_b1, x_b2, x_b3, 2, a_col3)
            detX = calcWriteDeterminant("X", x_b1, x_b2, x_b3, a_col1)
            replaceWithTable(y_b1, y_b2, y_b3, 0, a_col1)
            replaceWithTable(y_b1, y_b2, y_b3, 1, a_sd)
            replaceWithTable(y_b1, y_b2, y_b3, 2, a_col3)
            detY = calcWriteDeterminant("Y", y_b1, y_b2, y_b3, a_col2)
            replaceWithTable(z_b1, z_b2, z_b3, 0, a_col1)
            replaceWithTable(z_b1, z_b2, z_b3, 1, a_col2)
            replaceWithTable(z_b1, z_b2, z_b3, 2, a_sd)
            detZ = calcWriteDeterminant("Z", z_b1, z_b2, z_b3, a_col3)
            x = Math.Round(detX / detA, prec)
            y = Math.Round(detY / detA, prec)
            z = Math.Round(detZ / detA, prec)
            wres(vbCrLf & _
                 "x = " & detX & " / " & detA & " = " & x & vbCrLf & _
                 "y = " & detY & " / " & detA & " = " & y & vbCrLf & _
                 "z = " & detZ & " / " & detA & " = " & z)
            htmlCode += "<b>x</b> = " & detX & " / " & detA & " = " & x & "<br>" & _
                        "<b>y</b> = " & detY & " / " & detA & " = " & y & "<br>" & _
                        "<b>z</b> = " & detZ & " / " & detA & " = " & z
            lblResult.Text = _
                "det A = " & detA & vbCrLf & _
                "det x = " & detX & vbCrLf & _
                "det y = " & detY & vbCrLf & _
                "det z = " & detZ & vbCrLf & _
                "x = " & x & vbCrLf & _
                "y = " & y & vbCrLf & _
                "z = " & z
            writeHTMLCode()
        Catch ex As Exception
            MsgBox("Error Found !" & vbCrLf & "==============" & vbCrLf & "Error Message: " & ex.Message & vbCrLf & "==============" & vbCrLf & "Error Detail:" & vbCrLf & vbCrLf & ex.ToString(), vbCritical, "Program Error Handler")
        End Try
    End Sub

    Private Sub frmCramer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblResult.Text = ""
    End Sub

End Class