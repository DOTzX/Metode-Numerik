Imports System.IO

Public Class frmDoolittleCrout

    Dim prec As Integer
    Dim htmlCode As String
    Dim page As Integer

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
        If A11.Text <> "" And A11.Text <> "+" Then tmp1 += A11.Text
        tmp1 += "x"
        If A21.Text <> "" And A21.Text <> "+" Then tmp2 += A21.Text
        tmp2 += "x"
        If Val(A12.Text) >= 0 And A12.Text <> "-" Then tmp1 += "+"
        If A12.Text <> "" And A12.Text <> "+" Then tmp1 += A12.Text
        tmp1 += "y"
        If Val(A22.Text) >= 0 And A22.Text <> "-" Then tmp2 += "+"
        If A22.Text <> "" And A22.Text <> "+" Then tmp2 += A22.Text
        tmp2 += "y"
        If A31.Text <> "" And A31.Text <> "+" Then tmp3 += A31.Text
        tmp3 += "x"
        If Val(A32.Text) >= 0 And A32.Text <> "-" Then tmp3 += "+"
        If A32.Text <> "" And A32.Text <> "+" Then tmp3 += A32.Text
        tmp3 += "y"
        If Val(A13.Text) >= 0 And A13.Text <> "-" Then tmp1 += "+"
        If A13.Text <> "" And A13.Text <> "+" Then tmp1 += A13.Text
        tmp1 += "z"
        If Val(A23.Text) >= 0 And A23.Text <> "-" Then tmp2 += "+"
        If A23.Text <> "" And A23.Text <> "+" Then tmp2 += A23.Text
        tmp2 += "z"
        If Val(A33.Text) >= 0 And A33.Text <> "-" Then tmp3 += "+"
        If A33.Text <> "" And A33.Text <> "+" Then tmp3 += A33.Text
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
    Private Sub writeHTMLCode()
        Using writer As StreamWriter =
            New StreamWriter("result.html")
            writer.Write(htmlCode)
        End Using
        If rBrowser.Checked Then
            Process.Start("result.html")
        End If
    End Sub
    Private Sub writeTable(ByVal floatalign As String, ByVal detname As String, ByVal baris1 As String(), ByVal baris2 As String(), ByVal baris3 As String(), _
                           Optional ByVal xyz As String() = Nothing, Optional ByVal sd As String() = Nothing)
        htmlCode += "<div style='float:" & floatalign & "; width:45%'>Tabel <b>" & detname & "</b><br>"
        htmlCode += "<table border='2' cellpadding='3' style='border-collapse:collapse; text-align:center; width:100%'>"
        htmlCode += "<thead>"
        htmlCode += "<tr>"
        htmlCode += "<th style='width:20%'>x</th>"
        htmlCode += "<th style='width:20%'>y</th>"
        htmlCode += "<th style='width:20%'>z</th>"
        If Not xyz Is Nothing Then htmlCode += "<th style='width:20%'></th>"
        If Not sd Is Nothing Then htmlCode += "<th style='width:20%'></th>"
        htmlCode += "</tr>"
        htmlCode += "</thead>"
        htmlCode += "<tbody>"
        htmlCode += "<tr>"
        htmlCode += "<td>" & baris1(0) & "</td>"
        If baris1(1) = "black" Then
            htmlCode += "<td style='background-color: black'></td>"
        Else
            htmlCode += "<td>" & baris1(1) & "</td>"
        End If
        If baris1(2) = "black" Then
            htmlCode += "<td style='background-color: black'></td>"
        Else
            htmlCode += "<td>" & baris1(2) & "</td>"
        End If
        If Not xyz Is Nothing Then htmlCode += "<td>" & xyz(0) & "</td>"
        If Not sd Is Nothing Then htmlCode += "<td>" & sd(0) & "</td>"
        htmlCode += "</tr>"
        htmlCode += "<tr>"
        If baris2(0) = "black" Then
            htmlCode += "<td style='background-color: black'></td>"
        Else
            htmlCode += "<td>" & baris2(0) & "</td>"
        End If
        htmlCode += "<td>" & baris2(1) & "</td>"
        If baris2(2) = "black" Then
            htmlCode += "<td style='background-color: black'></td>"
        Else
            htmlCode += "<td>" & baris2(2) & "</td>"
        End If
        If Not xyz Is Nothing Then htmlCode += "<td>" & xyz(1) & "</td>"
        If Not sd Is Nothing Then htmlCode += "<td>" & sd(1) & "</td>"
        htmlCode += "</tr>"
        htmlCode += "<tr>"
        If baris3(0) = "black" Then
            htmlCode += "<td style='background-color: black'></td>"
        Else
            htmlCode += "<td>" & baris3(0) & "</td>"
        End If
        If baris3(1) = "black" Then
            htmlCode += "<td style='background-color: black'></td>"
        Else
            htmlCode += "<td>" & baris3(1) & "</td>"
        End If
        htmlCode += "<td>" & baris3(2) & "</td>"
        If Not xyz Is Nothing Then htmlCode += "<td>" & xyz(2) & "</td>"
        If Not sd Is Nothing Then htmlCode += "<td>" & sd(2) & "</td>"
        htmlCode += "</tr>"
        htmlCode += "</tbody>"
        htmlCode += "</table></div>"
        If detname = "[L].[Y] = [B]" Then
            x_x1.Text = baris1(0)
            x_y1.Text = baris1(1)
            x_z1.Text = baris1(2)
            x_x2.Text = baris2(0)
            x_y2.Text = baris2(1)
            x_z2.Text = baris2(2)
            x_x3.Text = baris3(0)
            x_y3.Text = baris3(1)
            x_z3.Text = baris3(2)
            x_sd1.Text = sd(0)
            x_sd2.Text = sd(1)
            x_sd3.Text = sd(2)
        ElseIf detname = "[U].[X] = [Y]" Then
            y_x1.Text = baris1(0)
            y_y1.Text = baris1(1)
            y_z1.Text = baris1(2)
            y_x2.Text = baris2(0)
            y_y2.Text = baris2(1)
            y_z2.Text = baris2(2)
            y_x3.Text = baris3(0)
            y_y3.Text = baris3(1)
            y_z3.Text = baris3(2)
            y_sd1.Text = sd(0)
            y_sd2.Text = sd(1)
            y_sd3.Text = sd(2)
        End If
    End Sub

    Private Sub SetText(ByVal obj As Object, ByVal vals As Double)
        obj.Text = vals
    End Sub

    Private Function GetText(ByVal obj As Object) As Double
        Dim res = Val(obj.Text)
        If obj.Text = "" Then res = 1
        If obj.Text = "-" Then res = -1
        If obj.Text = "+" Then res = 1
        Return res
    End Function

    Private Function CalcOne(ByVal baris1 As String(), ByVal baris2 As String(), ByVal baris3 As String(), ByVal sd As String()) As Double()
        Dim y1, y2, y3
        htmlCode += "<b>Mencari Y1, Y2, Y3</b><br>"
        htmlCode += "<table border='0' cellpadding='3' style='width:50%'>"
        htmlCode += "<thead>"
        htmlCode += "<tr>"
        htmlCode += "<th style='width:50%'></th>"
        htmlCode += "<th style='width:50%'></th>"
        htmlCode += "</tr>"
        htmlCode += "</thead>"
        htmlCode += "<tbody>"

        y1 = Math.Round(sd(0) / baris1(0), prec)
        Label1.Text = baris1(0) & "y1"
        Label2.Text = "= " & sd(0)
        Label11.Text = "y1"
        Label3.Text = "= " & sd(0) & " / " & baris1(0)
        Label41.Text = "y1"
        Label40.Text = "= " & y1

        htmlCode += "<tr>"
        htmlCode += "<td style='text-align:right'>" & Label1.Text & "</td>"
        htmlCode += "<td>" & Label2.Text & "</td>"
        htmlCode += "</tr>"
        htmlCode += "<tr>"
        htmlCode += "<td style='text-align:right'>" & Label11.Text & "</td>"
        htmlCode += "<td>" & Label3.Text & "</td>"
        htmlCode += "</tr>"
        htmlCode += "<tr>"
        htmlCode += "<td style='text-align:right'><b>" & Label41.Text & "</b></td>"
        htmlCode += "<td>" & Label40.Text & "</td>"
        htmlCode += "</tr>"
        htmlCode += "<tr><td></td></tr>"

        Label15.Text = baris2(0) & "y1 + " & baris2(1) & "y2"
        Label14.Text = "= " & sd(1)
        Label13.Text = baris2(0) & "(" & y1 & ") + " & baris2(1) & "y2"
        Label12.Text = "= " & sd(1)
        y2 = baris2(0) * y1
        Label19.Text = y2 & " + " & baris2(1) & "y2"
        Label18.Text = "= " & sd(1)
        Label17.Text = baris2(1) & "y2"
        Label16.Text = "= " & sd(1) & " - " & y2
        y2 = sd(1) - y2
        Label23.Text = baris2(1) & "y2"
        Label22.Text = "= " & y2
        Label21.Text = "y2"
        Label20.Text = "= " & y2 & " / " & baris2(1)
        y2 = Math.Round(y2 / baris2(1), prec)
        Label25.Text = "y2"
        Label24.Text = "= " & y2

        htmlCode += "<tr>"
        htmlCode += "<td style='text-align:right'>" & Label15.Text & "</td>"
        htmlCode += "<td>" & Label14.Text & "</td>"
        htmlCode += "</tr>"
        htmlCode += "<tr>"
        htmlCode += "<td style='text-align:right'>" & Label13.Text & "</td>"
        htmlCode += "<td>" & Label12.Text & "</td>"
        htmlCode += "</tr>"
        htmlCode += "<tr>"
        htmlCode += "<td style='text-align:right'>" & Label19.Text & "</td>"
        htmlCode += "<td>" & Label18.Text & "</td>"
        htmlCode += "</tr>"
        htmlCode += "<tr>"
        htmlCode += "<td style='text-align:right'>" & Label17.Text & "</td>"
        htmlCode += "<td>" & Label16.Text & "</td>"
        htmlCode += "</tr>"
        htmlCode += "<tr>"
        htmlCode += "<td style='text-align:right'>" & Label23.Text & "</td>"
        htmlCode += "<td>" & Label22.Text & "</td>"
        htmlCode += "</tr>"
        htmlCode += "<tr>"
        htmlCode += "<td style='text-align:right'>" & Label21.Text & "</td>"
        htmlCode += "<td>" & Label20.Text & "</td>"
        htmlCode += "</tr>"
        htmlCode += "<tr>"
        htmlCode += "<td style='text-align:right'><b>" & Label25.Text & "</b></td>"
        htmlCode += "<td>" & Label24.Text & "</td>"
        htmlCode += "</tr>"
        htmlCode += "<tr><td></td></tr>"

        Label39.Text = baris3(0) & "y1 + " & baris3(1) & "y2 + " & baris3(2) & "y3"
        Label38.Text = "= " & sd(2)
        Label37.Text = baris3(0) & "(" & y1 & ") + " & baris3(1) & "(" & y2 & ") + " & baris3(2) & "y3"
        Label36.Text = "= " & sd(2)
        y3 = baris3(0) * y1 + baris3(1) * y2
        Label35.Text = y3 & " + " & baris3(2) & "y3"
        Label34.Text = "= " & sd(2)
        Label33.Text = baris3(2) & "y3"
        Label32.Text = "= " & sd(2) & " - " & y3
        y3 = sd(2) - y3
        Label31.Text = baris3(2) & "y3"
        Label30.Text = "= " & y3
        Label29.Text = "y3"
        Label28.Text = "= " & y3 & " / " & baris3(2)
        y3 = Math.Round(y3 / baris3(2), prec)
        Label27.Text = "y3"
        Label26.Text = "= " & y3

        htmlCode += "<tr>"
        htmlCode += "<td style='text-align:right'>" & Label39.Text & "</td>"
        htmlCode += "<td>" & Label38.Text & "</td>"
        htmlCode += "</tr>"
        htmlCode += "<tr>"
        htmlCode += "<td style='text-align:right'>" & Label37.Text & "</td>"
        htmlCode += "<td>" & Label36.Text & "</td>"
        htmlCode += "</tr>"
        htmlCode += "<tr>"
        htmlCode += "<td style='text-align:right'>" & Label35.Text & "</td>"
        htmlCode += "<td>" & Label34.Text & "</td>"
        htmlCode += "</tr>"
        htmlCode += "<tr>"
        htmlCode += "<td style='text-align:right'>" & Label33.Text & "</td>"
        htmlCode += "<td>" & Label32.Text & "</td>"
        htmlCode += "</tr>"
        htmlCode += "<tr>"
        htmlCode += "<td style='text-align:right'>" & Label31.Text & "</td>"
        htmlCode += "<td>" & Label30.Text & "</td>"
        htmlCode += "</tr>"
        htmlCode += "<tr>"
        htmlCode += "<td style='text-align:right'>" & Label29.Text & "</td>"
        htmlCode += "<td>" & Label28.Text & "</td>"
        htmlCode += "</tr>"
        htmlCode += "<tr>"
        htmlCode += "<td style='text-align:right'><b>" & Label27.Text & "</b></td>"
        htmlCode += "<td>" & Label26.Text & "</td>"
        htmlCode += "</tr>"
        htmlCode += "<tr><td></td></tr>"

        htmlCode += "</tbody>"
        htmlCode += "</table>"

        Dim res As Double() = {y1, y2, y3}
        Return res
    End Function

    Private Function CalcTwo(ByVal baris1 As String(), ByVal baris2 As String(), ByVal baris3 As String(), ByVal sd As String()) As Double()
        Dim x, y, z
        htmlCode += "<b>Mencari X, Y, Z</b><br>"
        htmlCode += "<table border='0' cellpadding='3' style='width:50%'>"
        htmlCode += "<thead>"
        htmlCode += "<tr>"
        htmlCode += "<th style='width:50%'></th>"
        htmlCode += "<th style='width:50%'></th>"
        htmlCode += "</tr>"
        htmlCode += "</thead>"
        htmlCode += "<tbody>"

        z = Math.Round(sd(2) / baris3(2), prec)
        Label75.Text = baris3(2) & "z"
        Label74.Text = "= " & sd(2)
        Label73.Text = "z"
        Label72.Text = "= " & sd(2) & " / " & baris3(2)
        Label43.Text = "z"
        Label42.Text = "= " & z

        htmlCode += "<tr>"
        htmlCode += "<td style='text-align:right'>" & Label75.Text & "</td>"
        htmlCode += "<td>" & Label74.Text & "</td>"
        htmlCode += "</tr>"
        htmlCode += "<tr>"
        htmlCode += "<td style='text-align:right'>" & Label73.Text & "</td>"
        htmlCode += "<td>" & Label72.Text & "</td>"
        htmlCode += "</tr>"
        htmlCode += "<tr>"
        htmlCode += "<td style='text-align:right'><b>" & Label43.Text & "</b></td>"
        htmlCode += "<td>" & Label42.Text & "</td>"
        htmlCode += "</tr>"
        htmlCode += "<tr><td></td></tr>"

        Label71.Text = baris2(1) & "y + " & baris2(2) & "z"
        Label70.Text = "= " & sd(1)
        Label69.Text = baris2(1) & "y + " & baris2(2) & "(" & z & ")"
        Label68.Text = "= " & sd(1)
        y = baris2(2) * z
        Label67.Text = baris2(1) & "y + " & y
        Label66.Text = "= " & sd(1)
        Label65.Text = baris2(1) & "y"
        Label64.Text = "= " & sd(1) & " - " & y
        y = sd(1) - y
        Label63.Text = baris2(1) & "y"
        Label62.Text = "= " & y
        Label61.Text = "y"
        Label60.Text = "= " & y & " / " & baris2(1)
        y = Math.Round(y / baris2(1), prec)
        Label59.Text = "y"
        Label58.Text = "= " & y

        htmlCode += "<tr>"
        htmlCode += "<td style='text-align:right'>" & Label71.Text & "</td>"
        htmlCode += "<td>" & Label70.Text & "</td>"
        htmlCode += "</tr>"
        htmlCode += "<tr>"
        htmlCode += "<td style='text-align:right'>" & Label69.Text & "</td>"
        htmlCode += "<td>" & Label68.Text & "</td>"
        htmlCode += "</tr>"
        htmlCode += "<tr>"
        htmlCode += "<td style='text-align:right'>" & Label67.Text & "</td>"
        htmlCode += "<td>" & Label66.Text & "</td>"
        htmlCode += "</tr>"
        htmlCode += "<tr>"
        htmlCode += "<td style='text-align:right'>" & Label65.Text & "</td>"
        htmlCode += "<td>" & Label64.Text & "</td>"
        htmlCode += "</tr>"
        htmlCode += "<tr>"
        htmlCode += "<td style='text-align:right'>" & Label63.Text & "</td>"
        htmlCode += "<td>" & Label62.Text & "</td>"
        htmlCode += "</tr>"
        htmlCode += "<tr>"
        htmlCode += "<td style='text-align:right'>" & Label61.Text & "</td>"
        htmlCode += "<td>" & Label60.Text & "</td>"
        htmlCode += "</tr>"
        htmlCode += "<tr>"
        htmlCode += "<td style='text-align:right'><b>" & Label59.Text & "</b></td>"
        htmlCode += "<td>" & Label58.Text & "</td>"
        htmlCode += "</tr>"
        htmlCode += "<tr><td></td></tr>"

        Label57.Text = baris1(0) & "x + " & baris1(1) & "y + " & baris1(2) & "z"
        Label56.Text = "= " & sd(0)
        Label55.Text = baris1(0) & "x + " & baris1(1) & "(" & y & ") + " & baris1(2) & "(" & z & ")"
        Label54.Text = "= " & sd(0)
        x = baris1(1) * y + baris1(2) * z
        Label53.Text = baris1(0) & "x + " & x
        Label52.Text = "= " & sd(0)
        Label51.Text = baris1(0) & "x"
        Label50.Text = "= " & sd(0) & " - " & x
        x = sd(0) - x
        Label49.Text = baris1(0) & "x"
        Label48.Text = "= " & x
        Label47.Text = "x"
        Label46.Text = "= " & x & " / " & baris1(0)
        x = Math.Round(x / baris1(0), prec)
        Label45.Text = "x"
        Label44.Text = "= " & x

        htmlCode += "<tr>"
        htmlCode += "<td style='text-align:right'>" & Label57.Text & "</td>"
        htmlCode += "<td>" & Label56.Text & "</td>"
        htmlCode += "</tr>"
        htmlCode += "<tr>"
        htmlCode += "<td style='text-align:right'>" & Label55.Text & "</td>"
        htmlCode += "<td>" & Label54.Text & "</td>"
        htmlCode += "</tr>"
        htmlCode += "<tr>"
        htmlCode += "<td style='text-align:right'>" & Label53.Text & "</td>"
        htmlCode += "<td>" & Label52.Text & "</td>"
        htmlCode += "</tr>"
        htmlCode += "<tr>"
        htmlCode += "<td style='text-align:right'>" & Label51.Text & "</td>"
        htmlCode += "<td>" & Label50.Text & "</td>"
        htmlCode += "</tr>"
        htmlCode += "<tr>"
        htmlCode += "<td style='text-align:right'>" & Label49.Text & "</td>"
        htmlCode += "<td>" & Label48.Text & "</td>"
        htmlCode += "</tr>"
        htmlCode += "<tr>"
        htmlCode += "<td style='text-align:right'>" & Label47.Text & "</td>"
        htmlCode += "<td>" & Label46.Text & "</td>"
        htmlCode += "</tr>"
        htmlCode += "<tr>"
        htmlCode += "<td style='text-align:right'><b>" & Label45.Text & "</b></td>"
        htmlCode += "<td>" & Label44.Text & "</td>"
        htmlCode += "</tr>"
        htmlCode += "<tr><td></td></tr>"

        htmlCode += "</tbody>"
        htmlCode += "</table>"

        Dim res As Double() = {x, y, z}
        Return res
    End Function

    Private Sub bCrout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bCrout.Click
        Try
            bPrev.Visible = True
            bNext.Visible = True
            pageSwitch(1)

            txtResult.Text = ""
            prec = Val(txtPrec.Text)
            writeFormula("SPL - Metode Dekomposisi LU, Pend. Crout")

            Dim ll11 = Math.Round(GetText(A11), prec)
            Dim ll21 = Math.Round(GetText(A21), prec)
            Dim ll31 = Math.Round(GetText(A31), prec)
            wres("L11 = A11 = " & GetText(A11) & vbCrLf & vbCrLf)
            wres("L21 = A21 = " & GetText(A21) & vbCrLf & vbCrLf)
            wres("L31 = A31 = " & GetText(A31) & vbCrLf & vbCrLf)

            Dim lu12 = Math.Round(GetText(A12) / ll11, prec)
            Dim lu13 = Math.Round(GetText(A13) / ll11, prec)
            wres("U12 = A12/L11 = " & GetText(A12) & "/" & ll11 & " = " & lu12 & vbCrLf & vbCrLf)
            wres("U13 = A23/L11 = " & GetText(A23) & "/" & ll11 & " = " & lu13 & vbCrLf & vbCrLf)

            Dim ll22 = Math.Round(GetText(A22) - ll21 * lu12, prec)
            Dim ll32 = Math.Round(GetText(A32) - ll31 * lu12, prec)
            wres("L22 = A22-L21*U12 = " & GetText(A22) & " - " & ll21 & " * " & lu12 & " = " & ll22 & vbCrLf & vbCrLf)
            wres("L32 = A32-L31*U12 = " & GetText(A32) & " - " & ll31 & " * " & lu12 & " = " & ll32 & vbCrLf & vbCrLf)

            Dim lu23 = Math.Round((GetText(A23) - ll21 * lu13) / ll22, prec)
            Dim ll33 = Math.Round(GetText(A33) - ll31 * lu13 - ll32 * lu23, prec)
            wres("U23 = (A23-L21*U13)/L22 = (" & GetText(A23) & " - " & ll21 & " * " & lu13 & ") / " & ll22 & " = " & lu23 & vbCrLf & vbCrLf)
            wres("L33 = A33-L31*U13-L32*U23 = " & GetText(A33) & " - " & ll31 & " * " & lu13 & " - " & ll32 & " * " & lu23 & " = " & ll33 & vbCrLf & vbCrLf)

            SetText(L11, ll11)
            SetText(L21, ll21)
            SetText(L31, ll31)
            SetText(U12, lu12)
            SetText(U13, lu13)
            SetText(L22, ll22)
            SetText(L32, ll32)
            SetText(U23, lu23)
            SetText(L33, ll33)
            SetText(U11, 1)
            SetText(U22, 1)
            SetText(U33, 1)

            Dim sd As String() = {sd1.Text, sd2.Text, sd3.Text}

            Dim baris1 As String() = {A11.Text, A12.Text, A13.Text}
            Dim baris2 As String() = {A21.Text, A22.Text, A23.Text}
            Dim baris3 As String() = {A31.Text, A32.Text, A33.Text}
            writeTable("left", "[A]", baris1, baris2, baris3)
            htmlCode += "<div style='clear:both' /><br>"

            baris1 = {L11.Text, "black", "black"}
            baris2 = {L21.Text, L22.Text, "black"}
            baris3 = {L31.Text, L32.Text, L33.Text}
            writeTable("left", "[L]ower", baris1, baris2, baris3)
            baris1 = {U11.Text, U12.Text, U13.Text}
            baris2 = {"black", U22.Text, U23.Text}
            baris3 = {"black", "black", U33.Text}
            writeTable("right", "[U]pper", baris1, baris2, baris3)
            htmlCode += "<div style='clear:both' /><br>"

            htmlCode += "<b>L<sub>11</sub></b> = A<sub>11</sub> = " & GetText(A11) & "<br>"
            htmlCode += "<b>L<sub>21</sub></b> = A<sub>21</sub> = " & GetText(A21) & "<br>"
            htmlCode += "<b>L<sub>31</sub></b> = A<sub>31</sub> = " & GetText(A31) & "<br>"
            htmlCode += "<b>U<sub>12</sub></b> = A<sub>12</sub> / L<sub>11</sub> = " & GetText(A12) & " / " & ll11 & " = " & lu12 & "<br>"
            htmlCode += "<b>U<sub>13</sub></b> = A<sub>23</sub> / L<sub>11</sub> = " & GetText(A23) & " / " & ll11 & " = " & lu13 & "<br>"
            htmlCode += "<b>L<sub>22</sub></b> = A<sub>22</sub> - L<sub>21</sub> * U<sub>12</sub> = " & GetText(A22) & " - " & ll21 & " * " & lu12 & " = " & ll22 & "<br>"
            htmlCode += "<b>L<sub>32</sub></b> = A<sub>32</sub> - L<sub>31</sub> * U<sub>12</sub> = " & GetText(A32) & " - " & ll31 & " * " & lu12 & " = " & ll32 & "<br>"
            htmlCode += "<b>U<sub>23</sub></b> = (A<sub>23</sub> - L<sub>21</sub> * U<sub>13</sub>) / L<sub>22</sub> = (" & GetText(A23) & " - " & ll21 & " * " & lu13 & ") / " & ll22 & " = " & lu23 & "<br>"
            htmlCode += "<b>L<sub>33</sub></b> = A<sub>33</sub> - L<sub>31</sub> * U<sub>13</sub> - L<sub>32</sub> * U<sub>23</sub> = " & GetText(A33) & " - " & ll31 & " * " & lu13 & " - " & ll32 & " * " & lu23 & " = " & ll33 & "<br>"
            htmlCode += "<br><br>"

            baris1 = {L11.Text, "0", "0"}
            baris2 = {L21.Text, L22.Text, "0"}
            baris3 = {L31.Text, L32.Text, L33.Text}
            writeTable("left", "[L].[Y] = [B]", baris1, baris2, baris3, {"y1", "y2", "y3"}, sd)
            htmlCode += "<div style='clear:both' /><br>"

            Dim result_yyy As Double() = CalcOne(baris1, baris2, baris3, sd)

            sd = {result_yyy(0), result_yyy(1), result_yyy(2)}
            baris1 = {U11.Text, U12.Text, U13.Text}
            baris2 = {"0", U22.Text, U23.Text}
            baris3 = {"0", "0", U33.Text}
            writeTable("left", "[U].[X] = [Y]", baris1, baris2, baris3, {"x", "y", "z"}, sd)
            htmlCode += "<div style='clear:both' /><br>"

            Dim result_xyz As Double() = CalcTwo(baris1, baris2, baris3, sd)

            Dim tmp = "x = " & result_xyz(0) & vbCrLf & "y = " & result_xyz(1) & vbCrLf & "z = " & result_xyz(2)

            htmlCode += "<br><br><b>Hasil:</b><br><b>x</b> = " & result_xyz(0) & _
                "<br><b>y</b> = " & result_xyz(1) & _
                "<br><b>z</b> = " & result_xyz(2)

            lblResult.Text = "Hasil:" & vbCrLf & tmp
            writeHTMLCode()
        Catch ex As Exception
            MsgBox("Error Found !" & vbCrLf & "==============" & vbCrLf & "Error Message: " & ex.Message & vbCrLf & "==============" & vbCrLf & "Error Detail:" & vbCrLf & vbCrLf & ex.ToString(), vbCritical, "Program Error Handler")
        End Try
    End Sub

    Private Sub bDoolittle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bDoolittle.Click
        Try
            bPrev.Visible = True
            bNext.Visible = True
            pageSwitch(1)

            txtResult.Text = ""
            prec = Val(txtPrec.Text)
            writeFormula("SPL - Metode Dekomposisi LU, Pend. Doolittle")

            Dim lu11 = Math.Round(GetText(A11), prec)
            Dim lu12 = Math.Round(GetText(A12), prec)
            Dim lu13 = Math.Round(GetText(A13), prec)
            wres("U11 = A11 = " & GetText(A11) & vbCrLf & vbCrLf)
            wres("U12 = A12 = " & GetText(A12) & vbCrLf & vbCrLf)
            wres("U13 = A13 = " & GetText(A13) & vbCrLf & vbCrLf)

            Dim ll21 = Math.Round(GetText(A21) / lu11, prec)
            Dim ll31 = Math.Round(GetText(A31) / lu11, prec)
            wres("L21 = A21/U11 = " & GetText(A21) & "/" & lu11 & " = " & ll21 & vbCrLf & vbCrLf)
            wres("L31 = A31/U11 = " & GetText(A31) & "/" & lu11 & " = " & ll31 & vbCrLf & vbCrLf)

            Dim lu22 = Math.Round(GetText(A22) - ll21 * lu12, prec)
            Dim lu23 = Math.Round(GetText(A23) - ll21 * lu13, prec)
            wres("U22 = A22-L21*U12 = " & GetText(A22) & " - " & ll21 & " * " & lu12 & " = " & lu22 & vbCrLf & vbCrLf)
            wres("U23 = A23-L21*U13 = " & GetText(A23) & " - " & ll21 & " * " & lu13 & " = " & lu23 & vbCrLf & vbCrLf)

            Dim ll32 = Math.Round((GetText(A32) - ll31 * lu12) / lu22, prec)
            Dim lu33 = Math.Round(GetText(A33) - ll31 * lu13 - ll32 * lu23, prec)
            wres("L32 = (A32-L31*U12)/U22 = (" & GetText(A32) & " - " & ll31 & " * " & lu12 & ") / " & lu22 & " = " & ll32 & vbCrLf & vbCrLf)
            wres("U33 = A33-L31*U13-L32*U23 = " & GetText(A33) & " - " & ll31 & " * " & lu13 & " - " & ll32 & " * " & lu23 & " = " & lu33 & vbCrLf & vbCrLf)

            SetText(U11, lu11)
            SetText(U12, lu12)
            SetText(U13, lu13)
            SetText(L21, ll21)
            SetText(L31, ll31)
            SetText(U22, lu22)
            SetText(U23, lu23)
            SetText(L32, ll32)
            SetText(U33, lu33)
            SetText(L11, 1)
            SetText(L22, 1)
            SetText(L33, 1)

            Dim sd As String() = {sd1.Text, sd2.Text, sd3.Text}

            Dim baris1 As String() = {A11.Text, A12.Text, A13.Text}
            Dim baris2 As String() = {A21.Text, A22.Text, A23.Text}
            Dim baris3 As String() = {A31.Text, A32.Text, A33.Text}
            writeTable("left", "[A]", baris1, baris2, baris3)
            htmlCode += "<div style='clear:both' /><br>"

            baris1 = {L11.Text, "black", "black"}
            baris2 = {L21.Text, L22.Text, "black"}
            baris3 = {L31.Text, L32.Text, L33.Text}
            writeTable("left", "[L]ower", baris1, baris2, baris3)
            baris1 = {U11.Text, U12.Text, U13.Text}
            baris2 = {"black", U22.Text, U23.Text}
            baris3 = {"black", "black", U33.Text}
            writeTable("right", "[U]pper", baris1, baris2, baris3)
            htmlCode += "<div style='clear:both' /><br>"

            htmlCode += "<b>L<sub>11</sub></b> = A<sub>11</sub> = " & GetText(A11) & "<br>"
            htmlCode += "<b>L<sub>12</sub></b> = A<sub>12</sub> = " & GetText(A12) & "<br>"
            htmlCode += "<b>L<sub>13</sub></b> = A<sub>13</sub> = " & GetText(A13) & "<br>"
            htmlCode += "<b>L<sub>21</sub></b> = A<sub>21</sub> / U<sub>11</sub> = " & GetText(A21) & " / " & lu11 & " = " & ll21 & "<br>"
            htmlCode += "<b>L<sub>31</sub></b> = A<sub>31</sub> / U<sub>11</sub> = " & GetText(A31) & " / " & lu11 & " = " & ll31 & "<br>"
            htmlCode += "<b>U<sub>22</sub></b> = A<sub>22</sub> - L<sub>21</sub> * U<sub>12</sub> = " & GetText(A22) & " - " & ll21 & " * " & lu12 & " = " & lu22 & "<br>"
            htmlCode += "<b>U<sub>23</sub></b> = A<sub>23</sub> - L<sub>21</sub> * U<sub>13</sub> = " & GetText(A23) & " - " & ll21 & " * " & lu13 & " = " & lu23 & "<br>"
            htmlCode += "<b>L<sub>32</sub></b> = (A<sub>32</sub> - L<sub>31</sub> * U<sub>12</sub>) / U<sub>22</sub> = (" & GetText(A32) & " - " & ll31 & " * " & lu12 & ") / " & lu22 & " = " & ll32 & "<br>"
            htmlCode += "<b>U<sub>33</sub></b> = A<sub>33</sub> - L<sub>31</sub> * U<sub>13</sub> - L<sub>32</sub> * U<sub>23</sub> = " & GetText(A33) & " - " & ll31 & " * " & lu13 & " - " & ll32 & " * " & lu23 & " = " & lu33 & "<br>"
            htmlCode += "<br><br>"

            baris1 = {L11.Text, "0", "0"}
            baris2 = {L21.Text, L22.Text, "0"}
            baris3 = {L31.Text, L32.Text, L33.Text}
            writeTable("left", "[L].[Y] = [B]", baris1, baris2, baris3, {"y1", "y2", "y3"}, sd)
            htmlCode += "<div style='clear:both' /><br>"

            Dim result_yyy As Double() = CalcOne(baris1, baris2, baris3, sd)

            sd = {result_yyy(0), result_yyy(1), result_yyy(2)}
            baris1 = {U11.Text, U12.Text, U13.Text}
            baris2 = {"0", U22.Text, U23.Text}
            baris3 = {"0", "0", U33.Text}
            writeTable("left", "[U].[X] = [Y]", baris1, baris2, baris3, {"x", "y", "z"}, sd)
            htmlCode += "<div style='clear:both' /><br>"

            Dim result_xyz As Double() = CalcTwo(baris1, baris2, baris3, sd)

            Dim tmp = "x = " & result_xyz(0) & vbCrLf & "y = " & result_xyz(1) & vbCrLf & "z = " & result_xyz(2)

            htmlCode += "<br><br><b>Hasil:</b><br><b>x</b> = " & result_xyz(0) & _
                "<br><b>y</b> = " & result_xyz(1) & _
                "<br><b>z</b> = " & result_xyz(2)

            lblResult.Text = "Hasil:" & vbCrLf & tmp
            writeHTMLCode()
        Catch ex As Exception
            MsgBox("Error Found !" & vbCrLf & "==============" & vbCrLf & "Error Message: " & ex.Message & vbCrLf & "==============" & vbCrLf & "Error Detail:" & vbCrLf & vbCrLf & ex.ToString(), vbCritical, "Program Error Handler")
        End Try
    End Sub

    Private Sub pageSwitch(ByVal pg As Integer)
        If pg = 1 Then
            bPrev.Enabled = False
            bNext.Enabled = True
            gboxYYY.Visible = False
            gboxXYZ.Visible = False
            gboxL.Visible = True
            gboxU.Visible = True
            gboxMcrYYY.Visible = False
            gboxMcrXYZ.Visible = False
            Me.Width = 630
        ElseIf pg = 2 Then
            bPrev.Enabled = True
            bNext.Enabled = True
            gboxYYY.Visible = True
            gboxXYZ.Visible = True
            gboxL.Visible = False
            gboxU.Visible = False
            gboxMcrYYY.Visible = True
            gboxMcrXYZ.Visible = False
            Me.Width = 925
        ElseIf pg = 3 Then
            bPrev.Enabled = True
            bNext.Enabled = False
            gboxMcrYYY.Visible = False
            gboxMcrXYZ.Visible = True
        End If
        page = pg
    End Sub

    Private Sub frmDoolittleCrout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblResult.Text = ""
        page = 0
        bPrev.Visible = False
        bNext.Visible = False
        gboxYYY.Visible = False
        gboxXYZ.Visible = False
        gboxMcrYYY.Visible = False
        gboxMcrXYZ.Visible = False
        Me.Width = 630
    End Sub

    Private Sub bPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bPrev.Click
        pageSwitch(page - 1)
    End Sub

    Private Sub bNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bNext.Click
        pageSwitch(page + 1)
    End Sub

End Class