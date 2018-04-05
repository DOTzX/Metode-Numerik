Imports System.IO

Public Class fmGauss

    Dim prec As Integer
    Dim htmlCode As String

    Private Sub wres(ByVal s As String)
        txtResult.Text += s
    End Sub
    Private Sub writeFormula(ByVal nama As String)
        htmlCode = "<h2><b>Metode Numerik | " & nama & " | Copyright &copy; Hugo Annito</b></h2><hr>"
        htmlCode += "<style>td.upper_line { border-top:solid 1px black; } table.fraction { text-align: center; vertical-align: middle;margin-top:0.5em; margin-bottom:0.5em; line-height: 2em; }</style>"
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
    Private Sub writeTable(ByVal floatalign As String, ByVal detname As String, _
                           ByVal baris1 As Double(), ByVal baris2 As Double(), ByVal baris3 As Double(), _
                           ByVal xyz As String())
        htmlCode += "<div style='float:" & floatalign & "; width:45%'>Tabel <b>" & detname & "</b><br>"
        htmlCode += "<table border='2' cellpadding='3' style='border-collapse:collapse; text-align:center; width:100%'>"
        'htmlCode += "<thead>"
        'htmlCode += "<tr>"
        'htmlCode += "<th style='width:20%'></th>"
        'htmlCode += "<th style='width:20%'></th>"
        'htmlCode += "<th style='width:20%'></th>"
        'htmlCode += "<th style='width:20%'></th>"
        'htmlCode += "<th style='width:20%'></th>"
        'htmlCode += "</tr>"
        'htmlCode += "</thead>"
        htmlCode += "<tbody>"
        htmlCode += "<tr>"
        htmlCode += "<td>" & baris1(0) & "</td>"
        htmlCode += "<td>" & baris1(1) & "</td>"
        htmlCode += "<td>" & baris1(2) & "</td>"
        htmlCode += "<td>" & xyz(0) & "</td>"
        htmlCode += "<td>" & baris1(3) & "</td>"
        htmlCode += "</tr>"
        htmlCode += "<tr>"
        htmlCode += "<td>" & baris2(0) & "</td>"
        htmlCode += "<td>" & baris2(1) & "</td>"
        htmlCode += "<td>" & baris2(2) & "</td>"
        htmlCode += "<td>" & xyz(1) & "</td>"
        htmlCode += "<td>" & baris2(3) & "</td>"
        htmlCode += "</tr>"
        htmlCode += "<tr>"
        htmlCode += "<td>" & baris3(0) & "</td>"
        htmlCode += "<td>" & baris3(1) & "</td>"
        htmlCode += "<td>" & baris3(2) & "</td>"
        htmlCode += "<td>" & xyz(2) & "</td>"
        htmlCode += "<td>" & baris3(3) & "</td>"
        htmlCode += "</tr>"
        htmlCode += "</tbody>"
        htmlCode += "</table></div>"
    End Sub

    Private Function CalcLast(ByVal baris1 As String(), ByVal baris2 As String(), ByVal baris3 As String(), ByVal sd As String()) As Double()
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

    Private Function CalcNumber(ByVal the As Double, ByVal bilangan As Double, ByVal penyebut As Double, ByVal patokan As Double) As Double
        If the = 0 Then Return the
        Dim res As Double = Math.Round(the - ((bilangan / penyebut) * patokan), prec)
        htmlCode += "" & _
        "<table style='float:left; margin-right:50px' class='fraction' cellpadding='2' cellspacing='2'>" & _
            "<tr>" & _
                "<td rowspan='2' nowrap='nowrap'>" & the & " -</td>" & _
                "<td nowrap='nowrap'>" & bilangan & "</td>" & _
                "<td rowspan='2' nowrap='nowrap'>x " & patokan & " = " & res & "</td>" & _
            "</tr><tr>" & _
                "<td class='upper_line'>" & penyebut & "</td>" & _
            "</tr>" & _
        "</table>"
        wres(the & " - ((" & bilangan & " / " & penyebut & ") * " & patokan & ")" & vbCrLf & "= " & res & vbCrLf & vbCrLf)
        Return res
    End Function

    Private Function buildBaris(ByVal baris As String()) As Double()
        Dim x, y, z, sd As Double
        x = Val(baris(0))
        y = Val(baris(1))
        z = Val(baris(2))
        sd = Val(baris(3))
        If baris(0) = "" Or baris(0) = "+" Then x = 1
        If baris(0) = "-" Then x = -1
        If baris(1) = "" Or baris(1) = "+" Then y = 1
        If baris(1) = "-" Then y = -1
        If baris(2) = "" Or baris(2) = "+" Then z = 1
        If baris(2) = "-" Then z = -1
        If baris(3) = "" Or baris(3) = "+" Then sd = 1
        If baris(3) = "-" Then sd = -1
        Return {x, y, z, sd}
    End Function

    Private Sub FillToTable(ByVal barisanName As String, _
                            ByVal baris1 As Double(), ByVal baris2 As Double(), ByVal baris3 As Double())
        If barisanName = "tbl1" Then
            x_x1.Text = baris1(0)
            x_y1.Text = baris1(1)
            x_z1.Text = baris1(2)
            x_x2.Text = baris2(0)
            x_y2.Text = baris2(1)
            x_z2.Text = baris2(2)
            x_x3.Text = baris3(0)
            x_y3.Text = baris3(1)
            x_z3.Text = baris3(2)
            x_sd1.Text = baris1(3)
            x_sd2.Text = baris2(3)
            x_sd3.Text = baris3(3)
        ElseIf barisanName = "tbl2" Then
            y_x1.Text = baris1(0)
            y_y1.Text = baris1(1)
            y_z1.Text = baris1(2)
            y_x2.Text = baris2(0)
            y_y2.Text = baris2(1)
            y_z2.Text = baris2(2)
            y_x3.Text = baris3(0)
            y_y3.Text = baris3(1)
            y_z3.Text = baris3(2)
            y_sd1.Text = baris1(3)
            y_sd2.Text = baris2(3)
            y_sd3.Text = baris3(3)
        End If
    End Sub

    Private Sub bHitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bHitung.Click
        Try
            Me.Width = 875
            gboxMcrXYZ.Visible = True
            txtResult.Text = ""
            prec = Val(txtPrec.Text)
            writeFormula("SPL - Metode Gauss")

            Dim baris1 As Double() = buildBaris({A11.Text, A12.Text, A13.Text, sd1.Text})
            Dim baris2 As Double() = buildBaris({A21.Text, A22.Text, A23.Text, sd2.Text})
            Dim baris3 As Double() = buildBaris({A31.Text, A32.Text, A33.Text, sd3.Text})
            writeTable("left", "Persamaan", baris1, baris2, baris3, {"x", "y", "z"})
            htmlCode += "<div style='clear:both' /><br>"

            Dim table1_baris1 As Double() = {baris1(0), baris1(1), baris1(2), baris1(3)}

            htmlCode += "<hr><br>"

            Dim table1_baris2 As Double()
            If baris2(0) <> 0 Then
                htmlCode += "<b>Table 1, Baris 2</b><br>"
                wres("____________________" & vbCrLf & "Table 1, Baris 2" & vbCrLf)
                table1_baris2 = {CalcNumber(baris2(0), baris2(0), table1_baris1(0), table1_baris1(0)), _
                                 CalcNumber(baris2(1), baris2(0), table1_baris1(0), table1_baris1(1)), _
                                 CalcNumber(baris2(2), baris2(0), table1_baris1(0), table1_baris1(2)), _
                                 CalcNumber(baris2(3), baris2(0), table1_baris1(0), table1_baris1(3))}
                htmlCode += "<div style='clear:both' /><br>"
            Else
                table1_baris2 = {baris2(0), baris2(1), baris2(2), baris2(3)}
            End If

            Dim table1_baris3 As Double()
            If baris3(0) <> 0 Then
                htmlCode += "<b>Table 1, Baris 3</b><br>"
                wres("____________________" & vbCrLf & "Table 1, Baris 3" & vbCrLf)
                table1_baris3 = {CalcNumber(baris3(0), baris3(0), table1_baris1(0), table1_baris1(0)), _
                                 CalcNumber(baris3(1), baris3(0), table1_baris1(0), table1_baris1(1)), _
                                 CalcNumber(baris3(2), baris3(0), table1_baris1(0), table1_baris1(2)), _
                                 CalcNumber(baris3(3), baris3(0), table1_baris1(0), table1_baris1(3))}
                htmlCode += "<div style='clear:both' /><br>"
            Else
                table1_baris3 = {baris3(0), baris3(1), baris3(2), baris3(3)}
            End If

            FillToTable("tbl1", table1_baris1, table1_baris2, table1_baris3)
            writeTable("left", "Ke-1", table1_baris1, table1_baris2, table1_baris3, {"x", "y", "z"})
            htmlCode += "<div style='clear:both' /><br>"

            htmlCode += "<hr><br>"

            Dim table2_baris1 As Double() = table1_baris1

            Dim table2_baris2 As Double() = table1_baris2

            Dim table2_baris3 As Double()
            If table1_baris3(1) <> 0 Then
                htmlCode += "<b>Table 2, Baris 3</b><br>"
                wres("____________________" & vbCrLf & "Table 2, Baris 3" & vbCrLf)
                table2_baris3 = {table1_baris3(0), _
                                 CalcNumber(table1_baris3(1), table1_baris3(1), table1_baris2(1), table1_baris2(1)), _
                                 CalcNumber(table1_baris3(2), table1_baris3(1), table1_baris2(1), table1_baris2(2)), _
                                 CalcNumber(table1_baris3(3), table1_baris3(1), table1_baris2(1), table1_baris2(3))}
                htmlCode += "<div style='clear:both' /><br>"
            Else
                table2_baris3 = {table1_baris3(0), table1_baris3(1), table1_baris3(2), table1_baris3(3)}
            End If

            FillToTable("tbl2", table2_baris1, table2_baris2, table2_baris3)
            writeTable("left", "Ke-2", table2_baris1, table2_baris2, table2_baris3, {"x", "y", "z"})
            htmlCode += "<div style='clear:both' /><br>"

            Dim table3_baris1 As Double() = table2_baris1

            Dim table3_baris2 As Double() = table2_baris2

            Dim table3_baris3 As Double() = table2_baris3

            Dim new_baris1 As String() = {table3_baris1(0), table3_baris1(1), table3_baris1(2)}
            Dim new_baris2 As String() = {table3_baris2(0), table3_baris2(1), table3_baris2(2)}
            Dim new_baris3 As String() = {table3_baris3(0), table3_baris3(1), table3_baris3(2)}
            Dim sd As String() = {table3_baris1(3), table3_baris2(3), table3_baris3(3)}
            Dim result_xyz As Double() = CalcLast(new_baris1, new_baris2, new_baris3, sd)
            Dim tmp = "x = " & result_xyz(0) & vbCrLf & "y = " & result_xyz(1) & vbCrLf & "z = " & result_xyz(2)
            htmlCode += "<br><br><b>Hasil:</b><br><b>x</b> = " & result_xyz(0) & _
                "<br><b>y</b> = " & result_xyz(1) & _
                "<br><b>z</b> = " & result_xyz(2)
            wres("____________________" & vbCrLf & vbCrLf & tmp)
            writeHTMLCode()
        Catch ex As Exception
            MsgBox("Error Found !" & vbCrLf & "==============" & vbCrLf & "Error Message: " & ex.Message & vbCrLf & "==============" & vbCrLf & "Error Detail:" & vbCrLf & vbCrLf & ex.ToString(), vbCritical, "Program Error Handler")
        End Try
    End Sub

    Private Sub fmGauss_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Width = 580
        gboxMcrXYZ.Visible = False
    End Sub

End Class