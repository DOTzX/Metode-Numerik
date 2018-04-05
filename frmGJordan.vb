Imports System.IO

Public Class frmGJordan


    Dim prec As Integer
    Dim htmlCode As String
    Dim defaultName As String()

    Private Sub writeFormula(ByVal nama As String)
        htmlCode = "<h2><b>Metode Numerik | " & nama & " | Copyright &copy; Hugo Annito</b></h2><hr>"
        htmlCode += "<style>td.upper_line { border-top:solid 1px black; } table.fraction { text-align: center; vertical-align: middle;margin-top:0.5em; margin-bottom:0.5em; line-height: 2em; }</style>"
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
        Return res
    End Function
    Private Function CalcNumberToOne(ByVal bilangan As Double, ByVal penyebut As Double) As Double
        If bilangan = 1 Then Return bilangan
        Dim res As Double = Math.Round(bilangan / penyebut, prec)
        htmlCode += "" & _
        "<table style='float:left; margin-right:50px' class='fraction' cellpadding='2' cellspacing='2'>" & _
            "<tr>" & _
                "<td nowrap='nowrap'>" & bilangan & "</td>" & _
                "<td rowspan='2' nowrap='nowrap'>= " & res & "</td>" & _
            "</tr><tr>" & _
                "<td class='upper_line'>" & penyebut & "</td>" & _
            "</tr>" & _
        "</table>"
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
        ElseIf barisanName = "tbl3" Then
            TextBox24.Text = baris1(0)
            TextBox23.Text = baris1(1)
            TextBox22.Text = baris1(2)
            TextBox21.Text = baris2(0)
            TextBox20.Text = baris2(1)
            TextBox19.Text = baris2(2)
            TextBox18.Text = baris3(0)
            TextBox17.Text = baris3(1)
            TextBox16.Text = baris3(2)
            TextBox15.Text = baris1(3)
            TextBox14.Text = baris2(3)
            TextBox13.Text = baris3(3)
        ElseIf barisanName = "tbl4" Then
            TextBox12.Text = baris1(0)
            TextBox11.Text = baris1(1)
            TextBox10.Text = baris1(2)
            TextBox9.Text = baris2(0)
            TextBox8.Text = baris2(1)
            TextBox7.Text = baris2(2)
            TextBox6.Text = baris3(0)
            TextBox5.Text = baris3(1)
            TextBox4.Text = baris3(2)
            TextBox3.Text = baris1(3)
            TextBox2.Text = baris2(3)
            TextBox1.Text = baris3(3)
        ElseIf barisanName = "tbl5" Then
            TextBox48.Text = baris1(0)
            TextBox47.Text = baris1(1)
            TextBox46.Text = baris1(2)
            TextBox45.Text = baris2(0)
            TextBox44.Text = baris2(1)
            TextBox43.Text = baris2(2)
            TextBox42.Text = baris3(0)
            TextBox41.Text = baris3(1)
            TextBox40.Text = baris3(2)
            TextBox39.Text = baris1(3)
            TextBox38.Text = baris2(3)
            TextBox37.Text = baris3(3)
        ElseIf barisanName = "tbl6" Then
            TextBox36.Text = baris1(0)
            TextBox35.Text = baris1(1)
            TextBox34.Text = baris1(2)
            TextBox33.Text = baris2(0)
            TextBox32.Text = baris2(1)
            TextBox31.Text = baris2(2)
            TextBox30.Text = baris3(0)
            TextBox29.Text = baris3(1)
            TextBox28.Text = baris3(2)
            TextBox27.Text = baris1(3)
            TextBox26.Text = baris2(3)
            TextBox25.Text = baris3(3)
        End If
    End Sub

    Private Sub bHitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bHitung.Click
        Try
            prec = Val(txtPrec.Text)
            writeFormula("SPL - Metode Gauss-Jordan")

            Dim baris1 As Double() = buildBaris({A11.Text, A12.Text, A13.Text, sd1.Text})
            Dim baris2 As Double() = buildBaris({A21.Text, A22.Text, A23.Text, sd2.Text})
            Dim baris3 As Double() = buildBaris({A31.Text, A32.Text, A33.Text, sd3.Text})
            writeTable("left", "Persamaan", baris1, baris2, baris3, {"x", "y", "z"})
            htmlCode += "<div style='clear:both' /><br>"

            '============================================================================================================================

            htmlCode += "<hr><br>"
            'htmlCode += "<b>Table 1, Baris 1</b><br>"

            Dim table1_baris1 As Double()
            If baris1(0) <> 1 Then
                htmlCode += "Catatan: Men-1 kan Kolom1 Baris1<br>"
                table1_baris1 = {CalcNumberToOne(baris1(0), baris1(0)), _
                                 CalcNumberToOne(baris1(1), baris1(0)), _
                                 CalcNumberToOne(baris1(2), baris1(0)), _
                                 CalcNumberToOne(baris1(3), baris1(0))}
                htmlCode += "<div style='clear:both' /><br>"
            Else
                htmlCode += "Kolom1 Baris1 sudah 1<br>"
                table1_baris1 = {baris1(0), baris1(1), baris1(2), baris1(3)}
            End If

            FillToTable("tbl1", table1_baris1, baris2, baris3)
            writeTable("left", "Ke-1", table1_baris1, baris2, baris3, {"x", "y", "z"})
            htmlCode += "<div style='clear:both' /><br>"
            '=================================================================================
            htmlCode += "<hr><br>"
            'htmlCode += "<b>Table 2, Baris 2</b><br>"

            Dim table1_baris2 As Double()
            If baris2(0) <> 0 Then
                htmlCode += "Catatan: Men-0 kan Kolom1 Baris2<br>"
                table1_baris2 = {CalcNumber(baris2(0), baris2(0), table1_baris1(0), table1_baris1(0)), _
                                 CalcNumber(baris2(1), baris2(0), table1_baris1(0), table1_baris1(1)), _
                                 CalcNumber(baris2(2), baris2(0), table1_baris1(0), table1_baris1(2)), _
                                 CalcNumber(baris2(3), baris2(0), table1_baris1(0), table1_baris1(3))}
                htmlCode += "<div style='clear:both' /><br>"
            Else
                htmlCode += "Kolom1 Baris2 sudah 0<br><br>"
                table1_baris2 = {baris2(0), baris2(1), baris2(2), baris2(3)}
            End If

            'htmlCode += "<b>Table 2, Baris 3</b><br>"

            Dim table1_baris3 As Double()
            If baris3(0) <> 0 Then
                htmlCode += "Catatan: Men-0 kan Kolom1 Baris3<br>"
                table1_baris3 = {CalcNumber(baris3(0), baris3(0), table1_baris1(0), table1_baris1(0)), _
                                 CalcNumber(baris3(1), baris3(0), table1_baris1(0), table1_baris1(1)), _
                                 CalcNumber(baris3(2), baris3(0), table1_baris1(0), table1_baris1(2)), _
                                 CalcNumber(baris3(3), baris3(0), table1_baris1(0), table1_baris1(3))}
                htmlCode += "<div style='clear:both' /><br>"
            Else
                htmlCode += "Kolom1 Baris3 sudah 0<br>"
                table1_baris3 = {baris3(0), baris3(1), baris3(2), baris3(3)}
            End If

            FillToTable("tbl2", table1_baris1, table1_baris2, table1_baris3)
            writeTable("left", "Ke-2", table1_baris1, table1_baris2, table1_baris3, {"x", "y", "z"})
            htmlCode += "<div style='clear:both' /><br>"
            '============================================================================================================================
            htmlCode += "<hr><br>"
            'htmlCode += "<b>Table 3, Baris 2</b><br>"

            Dim table2_baris2 As Double()
            If table1_baris2(1) <> 1 Then
                htmlCode += "Catatan: Men-1 kan Kolom2 Baris2<br>"
                table2_baris2 = {table1_baris2(0), _
                                 CalcNumberToOne(table1_baris2(1), table1_baris2(1)), _
                                 CalcNumberToOne(table1_baris2(2), table1_baris2(1)), _
                                 CalcNumberToOne(table1_baris2(3), table1_baris2(1))}
                htmlCode += "<div style='clear:both' /><br>"
            Else
                htmlCode += "Kolom2 Baris2 sudah 1<br>"
                table2_baris2 = {table1_baris2(0), table1_baris2(1), table1_baris2(2), table1_baris2(3)}
            End If

            FillToTable("tbl3", table1_baris1, table2_baris2, table1_baris3)
            writeTable("left", "Ke-3", table1_baris1, table2_baris2, table1_baris3, {"x", "y", "z"})
            htmlCode += "<div style='clear:both' /><br>"
            '=================================================================================
            htmlCode += "<hr><br>"
            'htmlCode += "<b>Table 4, Baris 1</b><br>"

            Dim table2_baris1 As Double()
            If table1_baris1(1) <> 0 Then
                htmlCode += "Catatan: Men-0 kan Kolom2 Baris1<br>"
                table2_baris1 = {table1_baris1(0), _
                                 CalcNumber(table1_baris1(1), table1_baris1(1), table2_baris2(1), table2_baris2(1)), _
                                 CalcNumber(table1_baris1(2), table1_baris1(1), table2_baris2(1), table2_baris2(2)), _
                                 CalcNumber(table1_baris1(3), table1_baris1(1), table2_baris2(1), table2_baris2(3))}
                htmlCode += "<div style='clear:both' /><br>"
            Else
                htmlCode += "Kolom2 Baris1 sudah 0<br><br>"
                table2_baris1 = {table1_baris1(0), table1_baris1(1), table1_baris1(2), table1_baris1(3)}
            End If

            'htmlCode += "<b>Table 4, Baris 3</b><br>"

            Dim table2_baris3 As Double()
            If table1_baris3(1) <> 0 Then
                htmlCode += "Catatan: Men-0 kan Kolom2 Baris3<br>"
                table2_baris3 = {table1_baris3(0), _
                                 CalcNumber(table1_baris3(1), table1_baris3(1), table2_baris2(1), table2_baris2(1)), _
                                 CalcNumber(table1_baris3(2), table1_baris3(1), table2_baris2(1), table2_baris2(2)), _
                                 CalcNumber(table1_baris3(3), table1_baris3(1), table2_baris2(1), table2_baris2(3))}
                htmlCode += "<div style='clear:both' /><br>"
            Else
                htmlCode += "Kolom2 Baris3 sudah 0<br>"
                table2_baris3 = {table1_baris3(0), table1_baris3(1), table1_baris3(2), table1_baris3(3)}
            End If
            
            FillToTable("tbl4", table2_baris1, table2_baris2, table2_baris3)
            writeTable("left", "Ke-4", table2_baris1, table2_baris2, table2_baris3, {"x", "y", "z"})
            htmlCode += "<div style='clear:both' /><br>"
            '============================================================================================================================
            htmlCode += "<hr><br>"
            'htmlCode += "<b>Table 5, Baris 3</b><br>"

            Dim table3_baris3 As Double()
            If table2_baris3(2) <> 1 Then
                htmlCode += "Catatan: Men-1 kan Kolom3 Baris3<br>"
                table3_baris3 = {table2_baris3(0), _
                                 table2_baris3(1), _
                                 CalcNumberToOne(table2_baris3(2), table2_baris3(2)), _
                                 CalcNumberToOne(table2_baris3(3), table2_baris3(2))}
                htmlCode += "<div style='clear:both' /><br>"
            Else
                htmlCode += "Kolom3 Baris3 sudah 1<br>"
                table3_baris3 = {table2_baris3(0), table2_baris3(1), table2_baris3(2), table2_baris3(3)}
            End If

            FillToTable("tbl5", table2_baris1, table2_baris2, table3_baris3)
            writeTable("left", "Ke-5", table2_baris1, table2_baris2, table3_baris3, {"x", "y", "z"})
            htmlCode += "<div style='clear:both' /><br>"
            '=================================================================================
            htmlCode += "<hr><br>"
            'htmlCode += "<b>Table 6, Baris 1</b><br>"

            Dim table3_baris1 As Double()
            If table2_baris1(2) <> 0 Then
                htmlCode += "Catatan: Men-0 kan Kolom3 Baris1<br>"
                table3_baris1 = {table2_baris1(0), _
                                 table2_baris1(1), _
                                 CalcNumber(table2_baris1(2), table2_baris1(2), table3_baris3(2), table3_baris3(2)), _
                                 CalcNumber(table2_baris1(3), table2_baris1(2), table3_baris3(2), table3_baris3(3))}
                htmlCode += "<div style='clear:both' /><br>"
            Else
                htmlCode += "Kolom3 Baris1 sudah 0<br><br>"
                table3_baris1 = {table2_baris1(0), table2_baris1(1), table2_baris1(2), table2_baris1(3)}
            End If

            'htmlCode += "<b>Table 6, Baris 2</b><br>"

            Dim table3_baris2 As Double()
            If table2_baris2(2) <> 0 Then
                htmlCode += "Catatan: Men-0 kan Kolom3 Baris2<br>"
                table3_baris2 = {table2_baris2(0), _
                                 table2_baris2(1), _
                                 CalcNumber(table2_baris2(2), table2_baris2(2), table3_baris3(2), table3_baris3(2)), _
                                 CalcNumber(table2_baris2(3), table2_baris2(2), table3_baris3(2), table3_baris3(3))}
                htmlCode += "<div style='clear:both' /><br>"
            Else
                htmlCode += "Kolom3 Baris2 sudah 0<br>"
                table3_baris2 = {table2_baris2(0), table2_baris2(1), table2_baris2(2), table2_baris2(3)}
            End If
            FillToTable("tbl6", table3_baris1, table3_baris2, table3_baris3)
            writeTable("left", "Ke-6", table3_baris1, table3_baris2, table3_baris3, {"x", "y", "z"})
            htmlCode += "<div style='clear:both' /><br>"
            '============================================================================================================================

            Dim result_xyz As Double() = {table3_baris1(3), table3_baris2(3), table3_baris3(3)}
            Dim tmp = "x = " & result_xyz(0) & vbCrLf & "y = " & result_xyz(1) & vbCrLf & "z = " & result_xyz(2)
            htmlCode += "<br><br><b>Hasil:</b><br><b>x</b> = " & result_xyz(0) & _
                "<br><b>y</b> = " & result_xyz(1) & _
                "<br><b>z</b> = " & result_xyz(2)
            writeHTMLCode()
        Catch ex As Exception
            MsgBox("Error Found !" & vbCrLf & "==============" & vbCrLf & "Error Message: " & ex.Message & vbCrLf & "==============" & vbCrLf & "Error Detail:" & vbCrLf & vbCrLf & ex.ToString(), vbCritical, "Program Error Handler")
        End Try
    End Sub


End Class