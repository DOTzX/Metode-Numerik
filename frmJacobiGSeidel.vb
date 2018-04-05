Imports System.IO

Public Class frmJacobiGSeidel

    Dim prec As Integer
    Dim htmlCode As String
    Dim patokan As Integer = 1

    Private Sub changeGunakan(ByVal gunakanX As Integer)
        patokan = gunakanX
        tbY.Enabled = False
        ttbY.Enabled = False
        tbZ.Enabled = False
        ttbZ.Enabled = False
        tbU.Enabled = False
        ttbU.Enabled = False
        tbX.Text = ""
        tbY.Text = ""
        tbZ.Text = ""
        tbU.Text = ""
        x2.Enabled = False
        x3.Enabled = False
        x4.Enabled = False
        xx2.Enabled = False
        xx3.Enabled = False
        xx4.Enabled = False
        x1.Text = ""
        x2.Text = ""
        x3.Text = ""
        x4.Text = ""
        y1.Enabled = False
        y2.Enabled = False
        y3.Enabled = False
        y4.Enabled = False
        yy1.Enabled = False
        yy2.Enabled = False
        yy3.Enabled = False
        yy4.Enabled = False
        y1.Text = ""
        y2.Text = ""
        y3.Text = ""
        y4.Text = ""
        z1.Enabled = False
        z2.Enabled = False
        z3.Enabled = False
        z4.Enabled = False
        zz1.Enabled = False
        zz2.Enabled = False
        zz3.Enabled = False
        zz4.Enabled = False
        z1.Text = ""
        z2.Text = ""
        z3.Text = ""
        z4.Text = ""
        u1.Enabled = False
        u2.Enabled = False
        u3.Enabled = False
        u4.Enabled = False
        uu1.Enabled = False
        uu2.Enabled = False
        uu3.Enabled = False
        uu4.Enabled = False
        u1.Text = ""
        u2.Text = ""
        u3.Text = ""
        u4.Text = ""
        sd2.Enabled = False
        sd3.Enabled = False
        sd4.Enabled = False
        ssd2.Enabled = False
        ssd3.Enabled = False
        ssd4.Enabled = False
        sd1.Text = ""
        sd2.Text = ""
        sd3.Text = ""
        sd4.Text = ""
        If gunakanX >= 2 Then
            tbY.Enabled = True
            ttbY.Enabled = True
            sd2.Enabled = True
            ssd2.Enabled = True
            x2.Enabled = True
            xx2.Enabled = True
            y1.Enabled = True
            y2.Enabled = True
            yy1.Enabled = True
            yy2.Enabled = True
            If gunakanX >= 3 Then
                tbZ.Enabled = True
                ttbZ.Enabled = True
                sd3.Enabled = True
                ssd3.Enabled = True
                x3.Enabled = True
                xx3.Enabled = True
                y3.Enabled = True
                yy3.Enabled = True
                z1.Enabled = True
                z2.Enabled = True
                z3.Enabled = True
                zz1.Enabled = True
                zz2.Enabled = True
                zz3.Enabled = True
                If gunakanX >= 4 Then
                    tbU.Enabled = True
                    ttbU.Enabled = True
                    sd4.Enabled = True
                    ssd4.Enabled = True
                    x4.Enabled = True
                    xx4.Enabled = True
                    y4.Enabled = True
                    yy4.Enabled = True
                    z4.Enabled = True
                    zz4.Enabled = True
                    u1.Enabled = True
                    u2.Enabled = True
                    u3.Enabled = True
                    u4.Enabled = True
                    uu1.Enabled = True
                    uu2.Enabled = True
                    uu3.Enabled = True
                    uu4.Enabled = True
                End If
            End If
        End If
    End Sub

    Private Sub rUse1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rUse1.CheckedChanged
        changeGunakan(1)
    End Sub

    Private Sub rUse2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rUse2.CheckedChanged
        changeGunakan(2)
    End Sub

    Private Sub rUse3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rUse3.CheckedChanged
        changeGunakan(3)
    End Sub

    Private Sub rUse4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rUse4.CheckedChanged
        changeGunakan(4)
    End Sub

    Private Sub wres(ByVal s As String)
        txtResult.Text += s
    End Sub
    Private Sub writeFormula(ByVal nama As String)
        htmlCode = "<h2><b>Metode Numerik | " & nama & " | Copyright &copy; Hugo Annito</b></h2><hr>"
        txtResult.Text = ""
        Dim result = "Tebakan Awal = (" & tbX.Text
        Dim tmp1, tmp2, tmp3, tmp4, tmp
        tmp = ""
        tmp1 = ""
        tmp2 = ""
        tmp3 = ""
        tmp4 = ""
        If patokan >= 2 Then result += ", " & tbY.Text
        If patokan >= 3 Then result += ", " & tbZ.Text
        If patokan >= 4 Then result += ", " & tbU.Text
        result += ")" & vbCrLf & "Persamaan:" & vbCrLf
        htmlCode += "<b>Tebakan Awal</b> = (" & tbX.Text
        If patokan >= 2 Then htmlCode += ", " & tbY.Text
        If patokan >= 3 Then htmlCode += ", " & tbZ.Text
        If patokan >= 4 Then htmlCode += ", " & tbU.Text
        htmlCode += ")" & vbCrLf & "<br><b>Persamaan:</b><br>"
        If x1.Text <> "" And x1.Text <> "+" Then tmp1 += x1.Text
        tmp1 += "x"
        If patokan >= 2 Then
            If x2.Text <> "" And x2.Text <> "+" Then tmp2 += x2.Text
            tmp2 += "x"
            If Val(y1.Text) >= 0 And y1.Text <> "-" Then tmp1 += "+"
            If y1.Text <> "" And y1.Text <> "+" Then tmp1 += y1.Text
            tmp1 += "y"
            If Val(y2.Text) >= 0 And y2.Text <> "-" Then tmp2 += "+"
            If y2.Text <> "" And y2.Text <> "+" Then tmp2 += y2.Text
            tmp2 += "y"
        End If
        If patokan >= 3 Then
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
        End If
        If patokan >= 4 Then
            If x4.Text <> "" And x4.Text <> "+" Then tmp4 += x4.Text
            tmp4 += "x"
            If Val(y4.Text) >= 0 And y4.Text <> "-" Then tmp4 += "+"
            If y4.Text <> "" And y4.Text <> "+" Then tmp4 += y4.Text
            tmp4 += "y"
            If Val(z4.Text) >= 0 And z4.Text <> "-" Then tmp4 += "+"
            If z4.Text <> "" And z4.Text <> "+" Then tmp4 += z4.Text
            tmp4 += "z"
            If Val(u1.Text) >= 0 And u1.Text <> "-" Then tmp1 += "+"
            If u1.Text <> "" And u1.Text <> "+" Then tmp1 += u1.Text
            tmp1 += "u"
            If Val(u2.Text) >= 0 And u2.Text <> "-" Then tmp2 += "+"
            If u2.Text <> "" And u2.Text <> "+" Then tmp2 += u2.Text
            tmp2 += "u"
            If Val(u3.Text) >= 0 And u3.Text <> "-" Then tmp3 += "+"
            If u3.Text <> "" And u3.Text <> "+" Then tmp3 += u3.Text
            tmp3 += "u"
            If Val(u4.Text) >= 0 And u4.Text <> "-" Then tmp4 += "+"
            If u4.Text <> "" And u4.Text <> "+" Then tmp4 += u4.Text
            tmp4 += "u"
        End If
        tmp1 += " = " & sd1.Text
        If patokan >= 2 Then tmp2 += " = " & sd2.Text
        If patokan >= 3 Then tmp3 += " = " & sd3.Text
        If patokan >= 4 Then tmp4 += " = " & sd4.Text
        tmp = tmp1
        If patokan >= 2 Then tmp += vbCrLf & tmp2
        If patokan >= 3 Then tmp += vbCrLf & tmp3
        If patokan >= 4 Then tmp += vbCrLf & tmp4
        result += tmp & vbCrLf
        htmlCode += tmp.replace(vbCrLf, "<br>") & "<br>"
        wres(result)
    End Sub
    Private Sub writeIterHead()
        dgvResult.Rows.Clear()
        dgvResult.ColumnCount = patokan + 1
        dgvResult.Columns(0).Name = "Iter ke-"
        dgvResult.Columns(1).Name = "x"
        If patokan >= 2 Then dgvResult.Columns(2).Name = "y"
        If patokan >= 3 Then dgvResult.Columns(3).Name = "z"
        If patokan >= 4 Then dgvResult.Columns(4).Name = "u"
        htmlCode += "<table border='2' cellpadding='3' style='border-collapse:collapse; text-align:center; width:100%'>"
        htmlCode += "<thead>"
        htmlCode += "<tr>"
        htmlCode += "<th style='width:20%'>Iter ke-</th>"
        htmlCode += "<th style='width:20%'>x</th>"
        If patokan >= 2 Then htmlCode += "<th style='width:20%'>y</th>"
        If patokan >= 3 Then htmlCode += "<th style='width:20%'>z</th>"
        If patokan >= 4 Then htmlCode += "<th style='width:20%'>u</th>"
        htmlCode += "</tr>"
        htmlCode += "</thead>"
        htmlCode += "<tbody>"
    End Sub
    Private Sub writeIter(ByVal n As String, ByVal xyzu As Double())
        If patokan = 1 Then dgvResult.Rows.Add(n, xyzu(0))
        If patokan = 2 Then dgvResult.Rows.Add(n, xyzu(0), xyzu(1))
        If patokan = 3 Then dgvResult.Rows.Add(n, xyzu(0), xyzu(1), xyzu(2))
        If patokan = 4 Then dgvResult.Rows.Add(n, xyzu(0), xyzu(1), xyzu(2), xyzu(3))
        htmlCode += "<tr>"
        htmlCode += "<td>" & n & "</td>"
        htmlCode += "<td>" & xyzu(0) & "</td>"
        If patokan >= 2 Then htmlCode += "<td>" & xyzu(1) & "</td>"
        If patokan >= 3 Then htmlCode += "<td>" & xyzu(2) & "</td>"
        If patokan >= 4 Then htmlCode += "<td>" & xyzu(3) & "</td>"
        htmlCode += "</tr>"
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
    Private Sub writeIterHeadXYZU(ByVal n As String)
        wres(vbCrLf & "Iterasi ke-" & n & vbCrLf)
        htmlCode += "<br>Iterasi ke-" & n & "<br>"
    End Sub

    Private Function hitungBarisX(ByVal Consta As Double(), ByVal xyzu As Double()) As Double
        Dim varsd = sd1.Text
        Dim vartxt = "x"
        Dim s = 0
        Dim a = 1
        Dim b = 2
        Dim c = 3
        '==========
        Dim res As Double = -9999
        Dim txt = ""
        Dim dibagikandgn As Double = Consta(s)
        If dibagikandgn > 0 Then
            res = Val(varsd)
            If patokan >= 2 Then
                res += -1.0 * Consta(a) * xyzu(a)
            End If
            If patokan >= 3 Then
                res += -1.0 * Consta(b) * xyzu(b)
            End If
            If patokan >= 4 Then
                res += -1.0 * Consta(c) * xyzu(c)
            End If
            res /= dibagikandgn
            txt = vartxt & " = (" & Val(varsd)
            If patokan >= 2 Then
                Dim gg = -1.0 * Consta(a)
                If gg >= 0 Then txt += "+"
                txt += gg.ToString
                txt += "(" & xyzu(a) & ")"
            End If
            If patokan >= 3 Then
                Dim gg = -1.0 * Consta(b)
                If gg >= 0 Then txt += "+"
                txt += gg.ToString
                txt += "(" & xyzu(b) & ")"
            End If
            If patokan >= 4 Then
                Dim gg = -1.0 * Consta(c)
                If gg >= 0 Then txt += "+"
                txt += gg.ToString
                txt += "(" & xyzu(c) & ")"
            End If
            txt += ")/" & dibagikandgn & " = " & Math.Round(res, prec)
        Else
            res = -1.0 * Val(varsd)
            If patokan >= 2 Then
                res += Consta(a) * xyzu(a)
            End If
            If patokan >= 3 Then
                res += Consta(b) * xyzu(b)
            End If
            If patokan >= 4 Then
                res += Consta(c) * xyzu(c)
            End If
            res /= -1.0 * dibagikandgn
            txt = vartxt & " = (" & -1.0 * Val(varsd)
            If patokan >= 2 Then
                Dim gg = Consta(a)
                If gg >= 0 Then txt += "+"
                txt += gg.ToString
                txt += "(" & xyzu(a) & ")"
            End If
            If patokan >= 3 Then
                Dim gg = Consta(b)
                If gg >= 0 Then txt += "+"
                txt += gg.ToString
                txt += "(" & xyzu(b) & ")"
            End If
            If patokan >= 4 Then
                Dim gg = Consta(c)
                If gg >= 0 Then txt += "+"
                txt += gg.ToString
                txt += "(" & xyzu(c) & ")"
            End If
            txt += ")/" & -1.0 * dibagikandgn & " = " & Math.Round(res, prec)
        End If
        htmlCode += txt & "<br>"
        wres(txt & vbCrLf)
        Return Math.Round(res, prec)
    End Function

    Private Function hitungBarisY(ByVal Consta As Double(), ByVal xyzu As Double()) As Double
        Dim res As Double = -9999
        If patokan < 2 Then Return res
        '==========
        Dim varsd = sd2.Text
        Dim vartxt = "y"
        Dim s = 1
        Dim a = 0
        Dim b = 2
        Dim c = 3
        '==========
        Dim txt = ""
        Dim dibagikandgn As Double = Consta(s)
        If dibagikandgn > 0 Then
            res = Val(varsd)
            res += -1.0 * Consta(a) * xyzu(a)
            If patokan >= 3 Then
                res += -1.0 * Consta(b) * xyzu(b)
            End If
            If patokan >= 4 Then
                res += -1.0 * Consta(c) * xyzu(c)
            End If
            res /= dibagikandgn
            txt = vartxt & " = (" & Val(varsd)
            Dim gg = -1.0 * Consta(a)
            If gg >= 0 Then txt += "+"
            txt += gg.ToString
            txt += "(" & xyzu(a) & ")"
            If patokan >= 3 Then
                gg = -1.0 * Consta(b)
                If gg >= 0 Then txt += "+"
                txt += gg.ToString
                txt += "(" & xyzu(b) & ")"
            End If
            If patokan >= 4 Then
                gg = -1.0 * Consta(c)
                If gg >= 0 Then txt += "+"
                txt += gg.ToString
                txt += "(" & xyzu(c) & ")"
            End If
            txt += ")/" & dibagikandgn & " = " & Math.Round(res, prec)
        Else
            res = -1.0 * Val(varsd)
            res += Consta(a) * xyzu(a)
            If patokan >= 3 Then
                res += Consta(b) * xyzu(b)
            End If
            If patokan >= 4 Then
                res += Consta(c) * xyzu(c)
            End If
            res /= -1.0 * dibagikandgn
            txt = vartxt & " = (" & -1.0 * Val(varsd)
            Dim gg = Consta(a)
            If gg >= 0 Then txt += "+"
            txt += gg.ToString
            txt += "(" & xyzu(a) & ")"
            If patokan >= 3 Then
                gg = Consta(b)
                If gg >= 0 Then txt += "+"
                txt += gg.ToString
                txt += "(" & xyzu(b) & ")"
            End If
            If patokan >= 4 Then
                gg = Consta(c)
                If gg >= 0 Then txt += "+"
                txt += gg.ToString
                txt += "(" & xyzu(c) & ")"
            End If
            txt += ")/" & -1.0 * dibagikandgn & " = " & Math.Round(res, prec)
        End If
        htmlCode += txt & "<br>"
        wres(txt & vbCrLf)
        Return Math.Round(res, prec)
    End Function

    Private Function hitungBarisZ(ByVal Consta As Double(), ByVal xyzu As Double()) As Double
        Dim res As Double = -9999
        If patokan < 3 Then Return res
        '==========
        Dim varsd = sd3.Text
        Dim vartxt = "z"
        Dim s = 2
        Dim a = 0
        Dim b = 1
        Dim c = 3
        '==========
        Dim txt = ""
        Dim dibagikandgn As Double = Consta(s)
        If dibagikandgn > 0 Then
            res = Val(varsd)
            res += -1.0 * Consta(a) * xyzu(a)
            res += -1.0 * Consta(b) * xyzu(b)
            If patokan >= 4 Then
                res += -1.0 * Consta(c) * xyzu(c)
            End If
            res /= dibagikandgn
            txt = vartxt & " = (" & Val(varsd)
            Dim gg = -1.0 * Consta(a)
            If gg >= 0 Then txt += "+"
            txt += gg.ToString
            txt += "(" & xyzu(a) & ")"
            gg = -1.0 * Consta(b)
            If gg >= 0 Then txt += "+"
            txt += gg.ToString
            txt += "(" & xyzu(b) & ")"
            If patokan >= 4 Then
                gg = -1.0 * Consta(c)
                If gg >= 0 Then txt += "+"
                txt += gg.ToString
                txt += "(" & xyzu(c) & ")"
            End If
            txt += ")/" & dibagikandgn & " = " & Math.Round(res, prec)
        Else
            res = -1.0 * Val(varsd)
            res += Consta(a) * xyzu(a)
            res += Consta(b) * xyzu(b)
            If patokan >= 4 Then
                res += Consta(c) * xyzu(c)
            End If
            res /= -1.0 * dibagikandgn
            txt = vartxt & " = (" & -1.0 * Val(varsd)
            Dim gg = Consta(a)
            If gg >= 0 Then txt += "+"
            txt += gg.ToString
            txt += "(" & xyzu(a) & ")"
            gg = Consta(b)
            If gg >= 0 Then txt += "+"
            txt += gg.ToString
            txt += "(" & xyzu(b) & ")"
            If patokan >= 4 Then
                gg = Consta(c)
                If gg >= 0 Then txt += "+"
                txt += gg.ToString
                txt += "(" & xyzu(c) & ")"
            End If
            txt += ")/" & -1.0 * dibagikandgn & " = " & Math.Round(res, prec)
        End If
        htmlCode += txt & "<br>"
        wres(txt & vbCrLf)
        Return Math.Round(res, prec)
    End Function

    Private Function hitungBarisU(ByVal Consta As Double(), ByVal xyzu As Double()) As Double
        Dim res As Double = -9999
        If patokan < 4 Then Return res
        '==========
        Dim varsd = sd4.Text
        Dim vartxt = "u"
        Dim s = 3
        Dim a = 0
        Dim b = 1
        Dim c = 2
        '==========
        Dim txt = ""
        Dim dibagikandgn As Double = Consta(s)
        If dibagikandgn > 0 Then
            res = Val(varsd)
            res += -1.0 * Consta(a) * xyzu(a)
            res += -1.0 * Consta(b) * xyzu(b)
            res += -1.0 * Consta(c) * xyzu(c)
            res /= dibagikandgn
            txt = vartxt & " = (" & Val(varsd)
            Dim gg = -1.0 * Consta(a)
            If gg >= 0 Then txt += "+"
            txt += gg.ToString
            txt += "(" & xyzu(a) & ")"
            gg = -1.0 * Consta(b)
            If gg >= 0 Then txt += "+"
            txt += gg.ToString
            txt += "(" & xyzu(b) & ")"
            gg = -1.0 * Consta(c)
            If gg >= 0 Then txt += "+"
            txt += gg.ToString
            txt += "(" & xyzu(c) & ")"
            txt += ")/" & dibagikandgn & " = " & Math.Round(res, prec)
        Else
            res = -1.0 * Val(varsd)
            res += Consta(a) * xyzu(a)
            res += Consta(b) * xyzu(b)
            res += Consta(c) * xyzu(c)
            res /= -1.0 * dibagikandgn
            txt = vartxt & " = (" & -1.0 * Val(varsd)
            Dim gg = Consta(a)
            If gg >= 0 Then txt += "+"
            txt += gg.ToString
            txt += "(" & xyzu(a) & ")"
            gg = Consta(b)
            If gg >= 0 Then txt += "+"
            txt += gg.ToString
            txt += "(" & xyzu(b) & ")"
            gg = Consta(c)
            If gg >= 0 Then txt += "+"
            txt += gg.ToString
            txt += "(" & xyzu(c) & ")"
            txt += ")/" & -1.0 * dibagikandgn & " = " & Math.Round(res, prec)
        End If
        htmlCode += txt & "<br>"
        wres(txt & vbCrLf)
        Return Math.Round(res, prec)
    End Function

    Private Function arrayListCreator(ByVal x As String, ByVal y As String, ByVal z As String, ByVal u As String) As Double()
        If x = "" Or x = "+" Then x = 1
        If y = "" Or y = "+" Then y = 1
        If z = "" Or z = "+" Then z = 1
        If u = "" Or u = "+" Then u = 1
        If x = "-" Then x = -1
        If y = "-" Then y = -1
        If z = "-" Then z = -1
        If u = "-" Then u = -1
        Dim res As Double() = {Val(x), Val(y), Val(z), Val(u)}
        Return res
    End Function

    Private Sub bJacobi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bJacobi.Click
        Try
            prec = Val(txtPrec.Text)
            writeFormula("SPL - Metode Jacobi")
            Dim i = 1
            Dim tbakan_xyzu As Double() = arrayListCreator(tbX.Text, tbY.Text, tbZ.Text, tbU.Text)
            Dim const_xyzu_baris1 As Double() = arrayListCreator(x1.Text, y1.Text, z1.Text, u1.Text)
            Dim const_xyzu_baris2 As Double() = arrayListCreator(x2.Text, y2.Text, z2.Text, u2.Text)
            Dim const_xyzu_baris3 As Double() = arrayListCreator(x3.Text, y3.Text, z3.Text, u3.Text)
            Dim const_xyzu_baris4 As Double() = arrayListCreator(x4.Text, y4.Text, z4.Text, u4.Text)
            Dim result_xyzu As Double()
            Dim x, y, z, u As Double
            writeIterHeadXYZU(i)
            x = hitungBarisX(const_xyzu_baris1, tbakan_xyzu)
            y = hitungBarisY(const_xyzu_baris2, tbakan_xyzu)
            z = hitungBarisZ(const_xyzu_baris3, tbakan_xyzu)
            u = hitungBarisU(const_xyzu_baris4, tbakan_xyzu)
            result_xyzu = {x, y, z, u}
            tbakan_xyzu = result_xyzu
            writeIterHead()
            writeIter(i, result_xyzu)
            Do While i <= (Val(txtMaxIter.Text) - 1)
                i += 1
                writeIterHeadXYZU(i)
                x = hitungBarisX(const_xyzu_baris1, tbakan_xyzu)
                y = hitungBarisY(const_xyzu_baris2, tbakan_xyzu)
                z = hitungBarisZ(const_xyzu_baris3, tbakan_xyzu)
                u = hitungBarisU(const_xyzu_baris4, tbakan_xyzu)
                result_xyzu = {x, y, z, u}
                tbakan_xyzu = result_xyzu
                writeIter(i, result_xyzu)
            Loop
            Dim tmp = "x = " & x
            If patokan >= 2 Then tmp += vbCrLf & "y = " & y
            If patokan >= 3 Then tmp += vbCrLf & "z = " & z
            If patokan >= 4 Then tmp += vbCrLf & "u = " & u
            wres(vbCrLf & vbCrLf & tmp)
            lblResult.Text = tmp
            htmlCode += "</tbody>"
            htmlCode += "</table>"
            tmp = "<br><br>x = " & x
            If patokan >= 2 Then tmp += "<br>y = " & y
            If patokan >= 3 Then tmp += "<br>z = " & z
            If patokan >= 4 Then tmp += "<br>u = " & u
            htmlCode += tmp
            writeHTMLCode()
        Catch ex As Exception
            MsgBox("Error Found !" & vbCrLf & "==============" & vbCrLf & "Error Message: " & ex.Message & vbCrLf & "==============" & vbCrLf & "Error Detail:" & vbCrLf & vbCrLf & ex.ToString(), vbCritical, "Program Error Handler")
        End Try
    End Sub

    Private Sub bGSeidel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bGSeidel.Click
        Try
            prec = Val(txtPrec.Text)
            writeFormula("SPL - Metode Gauss-Seidel")
            Dim i = 1
            Dim tbakan_xyzu As Double() = arrayListCreator(tbX.Text, tbY.Text, tbZ.Text, tbU.Text)
            Dim const_xyzu_baris1 As Double() = arrayListCreator(x1.Text, y1.Text, z1.Text, u1.Text)
            Dim const_xyzu_baris2 As Double() = arrayListCreator(x2.Text, y2.Text, z2.Text, u2.Text)
            Dim const_xyzu_baris3 As Double() = arrayListCreator(x3.Text, y3.Text, z3.Text, u3.Text)
            Dim const_xyzu_baris4 As Double() = arrayListCreator(x4.Text, y4.Text, z4.Text, u4.Text)
            Dim result_xyzu As Double()
            Dim x, y, z, u As Double
            writeIterHeadXYZU(i)
            x = hitungBarisX(const_xyzu_baris1, tbakan_xyzu)
            tbakan_xyzu = {x, tbakan_xyzu(1), tbakan_xyzu(2), tbakan_xyzu(3)}
            y = hitungBarisY(const_xyzu_baris2, tbakan_xyzu)
            tbakan_xyzu = {x, y, tbakan_xyzu(2), tbakan_xyzu(3)}
            z = hitungBarisZ(const_xyzu_baris3, tbakan_xyzu)
            tbakan_xyzu = {x, y, z, tbakan_xyzu(3)}
            u = hitungBarisU(const_xyzu_baris4, tbakan_xyzu)
            result_xyzu = {x, y, z, u}
            tbakan_xyzu = result_xyzu
            writeIterHead()
            writeIter(i, result_xyzu)
            Do While i <= (Val(txtMaxIter.Text) - 1)
                i += 1
                writeIterHeadXYZU(i)
                x = hitungBarisX(const_xyzu_baris1, tbakan_xyzu)
                tbakan_xyzu = {x, y, z, u}
                y = hitungBarisY(const_xyzu_baris2, tbakan_xyzu)
                tbakan_xyzu = {x, y, z, u}
                z = hitungBarisZ(const_xyzu_baris3, tbakan_xyzu)
                tbakan_xyzu = {x, y, z, u}
                u = hitungBarisU(const_xyzu_baris4, tbakan_xyzu)
                result_xyzu = {x, y, z, u}
                tbakan_xyzu = result_xyzu
                writeIter(i, result_xyzu)
            Loop
            Dim tmp = "x = " & x
            If patokan >= 2 Then tmp += vbCrLf & "y = " & y
            If patokan >= 3 Then tmp += vbCrLf & "z = " & z
            If patokan >= 4 Then tmp += vbCrLf & "u = " & u
            wres(vbCrLf & vbCrLf & tmp)
            lblResult.Text = tmp
            htmlCode += "</tbody>"
            htmlCode += "</table>"
            tmp = "<br><br>x = " & x
            If patokan >= 2 Then tmp += "<br>y = " & y
            If patokan >= 3 Then tmp += "<br>z = " & z
            If patokan >= 4 Then tmp += "<br>u = " & u
            htmlCode += tmp
            writeHTMLCode()
        Catch ex As Exception
            MsgBox("Error Found !" & vbCrLf & "==============" & vbCrLf & "Error Message: " & ex.Message & vbCrLf & "==============" & vbCrLf & "Error Detail:" & vbCrLf & vbCrLf & ex.ToString(), vbCritical, "Program Error Handler")
        End Try
    End Sub

    Private Sub frmJacobiGSeidel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblResult.Text = ""
    End Sub

End Class