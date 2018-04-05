Imports System.IO

Public Class frmBisectionRegulSecant

    Dim prec As Integer
    Dim htmlCode As String

    Private Function calcX1(ByVal x As Double) As Double
        Dim res = x
        If fX1P.Text = "x" Or fX1P.Text = "X" Then
            res = res ^ x
        ElseIf fX1P.Text <> "" Then
            res = res ^ Val(fX1P.Text)
        End If
        If fX1.Text <> "" Then
            res = res * Val(fX1.Text)
        End If
        Return res
    End Function
    Private Function calcX2(ByVal x As Double) As Double
        Dim res = x
        If fX2P.Text = "x" Or fX2P.Text = "X" Then
            res = res ^ x
        ElseIf fX2P.Text <> "" Then
            res = res ^ Val(fX2P.Text)
        End If
        If fX2.Text <> "" Then
            res = res * Val(fX2.Text)
        End If
        Return res
    End Function
    Private Function calcX3(ByVal x As Double) As Double
        Dim res = x
        If fX3P.Text = "x" Or fX3P.Text = "X" Then
            res = res ^ x
        ElseIf fX3P.Text <> "" Then
            res = res ^ Val(fX3P.Text)
        End If
        If fX3.Text <> "" Then
            res = res * Val(fX3.Text)
        End If
        Return res
    End Function
    Private Function calcC() As Double
        Return New DataTable().Compute(fC.Text, Nothing)
    End Function
    Private Function calcFormula(ByVal x As Double) As Double
        Dim res = calcX1(x)
        If useX2.Checked Then
            res = res + calcX2(x)
        End If
        If useX3.Checked Then
            res = res + calcX3(x)
        End If
        If useC.Checked Then
            res = res + calcC()
        End If
        Return Math.Round(res, prec)
    End Function

    Private Sub wres(ByVal s As String)
        lblResult.Text += s
    End Sub
    Private Sub writeFormula(ByVal nama As String)
        htmlCode = "<h2><b>Metode Numerik | " & nama & " | Copyright &copy; Hugo Annito</b></h2><hr>"
        lblResult.Text = ""
        Dim result = ""
        Dim tmp = ""
        result += "Xa = " & txtXa.Text & ", Xb = " & txtXb.Text & vbCrLf
        result += "f(x) = "
        htmlCode += "<b>Xa</b> = " & txtXa.Text & ", <b>Xb</b> = " & txtXb.Text & "<br><b>f(x)</b> = "
        If fX1.Text <> "" Then
            tmp = fX1.Text & "x"
        Else
            tmp = "x"
        End If
        result += tmp
        htmlCode += tmp
        If fX1P.Text <> "" Then
            result += "^" & fX1P.Text
            htmlCode += "<sup>" & fX1P.Text & "</sup>"
        End If
        If useX2.Checked Then
            If Val(fX2.Text) > 0 Or fX2.Text = "" Then
                tmp = " + "
            Else
                tmp = " "
            End If
            If fX2.Text <> "" Then
                tmp += fX2.Text & "x"
            Else
                tmp += "x"
            End If
            result += tmp
            htmlCode += tmp
            If fX2P.Text <> "" Then
                result += "^" & fX2P.Text
                htmlCode += "<sup>" & fX2P.Text & "</sup>"
            End If
        End If
        If useX3.Checked Then
            If Val(fX3.Text) > 0 Or fX3.Text = "" Then
                tmp = " + "
            Else
                tmp = " "
            End If
            If fX3.Text <> "" Then
                tmp += fX3.Text & "x"
            Else
                tmp += "x"
            End If
            result += tmp
            htmlCode += tmp
            If fX3P.Text <> "" Then
                result += "^" & fX3P.Text
                htmlCode += "<sup>" & fX3P.Text & "</sup>"
            End If
        End If
        If useC.Checked Then
            If Val(fC.Text) > 0 Then
                tmp = " + " & fC.Text
            Else
                tmp = " " & fC.Text
            End If
            result += tmp
            htmlCode += tmp
        End If
        htmlCode += "<br><br>"
        wres(result)
    End Sub
    Private Sub writeIterHead()
        dgvResult.Rows.Clear()
        dgvResult.ColumnCount = 7
        dgvResult.Columns(0).Name = "Iter ke-"
        dgvResult.Columns(1).Name = "Xa"
        dgvResult.Columns(2).Name = "Xb"
        dgvResult.Columns(3).Name = "Xt"
        dgvResult.Columns(4).Name = "f(Xa)"
        dgvResult.Columns(5).Name = "f(Xb)"
        dgvResult.Columns(6).Name = "f(Xt)"
        htmlCode += "<table border='2' cellpadding='3' style='border-collapse:collapse; text-align:center; width:100%'>"
        htmlCode += "<thead>"
        htmlCode += "<tr>"
        htmlCode += "<th style='width:10%'>Iter ke-</th>"
        htmlCode += "<th style='width:10%'>Xa</th>"
        htmlCode += "<th style='width:10%'>Xb</th>"
        htmlCode += "<th style='width:10%'>Xt</th>"
        htmlCode += "<th style='width:10%'>f(Xa)</th>"
        htmlCode += "<th style='width:10%'>f(Xb)</th>"
        htmlCode += "<th style='width:10%'>f(Xt)</th>"
        htmlCode += "</tr>"
        htmlCode += "</thead>"
        htmlCode += "<tbody>"
    End Sub
    Private Sub writeIter(ByVal n As String, _
                               ByVal xa As String, ByVal xb As String, ByVal xt As String, _
                               ByVal fxa As String, ByVal fxb As String, ByVal fxt As String)
        dgvResult.Rows.Add(New String() {n, xa, xb, xt, fxa, fxb, fxt})
        htmlCode += "<tr>"
        htmlCode += "<td>" & n & "</td>"
        htmlCode += "<td>" & xa & "</td>"
        htmlCode += "<td>" & xb & "</td>"
        htmlCode += "<td>" & xt & "</td>"
        htmlCode += "<td>" & fxa & "</td>"
        htmlCode += "<td>" & fxb & "</td>"
        htmlCode += "<td>" & fxt & "</td>"
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

    Private Sub bBisection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bBisection.Click
        Try
            prec = Val(txtPrec.Text)
            writeFormula("SPNL - Metode Bisection")
            Dim i = 1
            Dim xa = Val(txtXa.Text)
            Dim xb = Val(txtXb.Text)
            Dim xt = Math.Round((xa + xb) / 2, prec)
            Dim fxa = calcFormula(xa)
            Dim fxb = calcFormula(xb)
            Dim fxt = calcFormula(xt)
            Dim check = fxa * fxb
            If check > 0 Then
                wres(vbCrLf & vbCrLf & "f(Xa) * (fXt) = " & fxa & " * " & fxb & " = " & check & ", ini tidak memenuhi syarat")
                htmlCode += "f(Xa) * (fXt) = " & fxa & " * " & fxb & " = " & check & ", ini <b>tidak</b> memenuhi syarat<br><br>"
                writeIterHead()
                writeIter(i, xa, xb, "", fxa, fxb, "")
                htmlCode += "</tbody>"
                htmlCode += "</table>"
                writeHTMLCode()
                Exit Sub
            Else
                writeIterHead()
                writeIter(i, xa, xb, xt, fxa, fxb, fxt)
            End If
            Do While i <= (Val(txtMaxIter.Text) - 1)
                If (fxa * fxt) < 0 Then
                    xb = xt
                Else
                    xa = xt
                End If
                xa = Math.Round(xa, prec)
                xb = Math.Round(xb, prec)
                xt = Math.Round((xa + xb) / 2, prec)
                fxa = calcFormula(xa)
                fxb = calcFormula(xb)
                fxt = calcFormula(xt)
                i += 1
                writeIter(i, xa, xb, xt, fxa, fxb, fxt)
            Loop
            wres(vbCrLf & vbCrLf & "x = " & xt)
            htmlCode += "</tbody>"
            htmlCode += "</table>"
            htmlCode += "<br><br>x = " & xt
            writeHTMLCode()
        Catch ex As Exception
            MsgBox("Error Found !" & vbCrLf & "==============" & vbCrLf & "Error Message: " & ex.Message & vbCrLf & "==============" & vbCrLf & "Error Detail:" & vbCrLf & vbCrLf & ex.ToString(), vbCritical, "Program Error Handler")
        End Try
    End Sub

    Private Sub bRegulasi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bRegulasi.Click
        Try
            prec = Val(txtPrec.Text)
            writeFormula("SPNL - Metode Regulasi")
            Dim i = 1
            Dim xa = Val(txtXa.Text)
            Dim xb = Val(txtXb.Text)
            Dim fxa = calcFormula(xa)
            Dim fxb = calcFormula(xb)
            Dim xt = Math.Round(xa - ((xb - xa) / (fxb - fxa)) * fxa, prec)
            Dim fxt = calcFormula(xt)
            Dim check = fxa * fxb
            If check > 0 Then
                wres(vbCrLf & vbCrLf & "f(Xa) * (fXt) = " & fxa & " * " & fxb & " = " & check & ", ini tidak memenuhi syarat")
                htmlCode += "f(Xa) * (fXt) = " & fxa & " * " & fxb & " = " & check & ", ini <b>tidak</b> memenuhi syarat<br><br>"
                writeIterHead()
                writeIter(i, xa, xb, "", fxa, fxb, "")
                htmlCode += "</tbody>"
                htmlCode += "</table>"
                writeHTMLCode()
                Exit Sub
            Else
                writeIterHead()
                writeIter(i, xa, xb, xt, fxa, fxb, fxt)
            End If
            Do While i <= (Val(txtMaxIter.Text) - 1)
                If (fxa * fxt) < 0 Then
                    xb = xt
                Else
                    xa = xt
                End If
                xa = Math.Round(xa, prec)
                xb = Math.Round(xb, prec)
                fxa = calcFormula(xa)
                fxb = calcFormula(xb)
                xt = Math.Round(xa - ((xb - xa) / (fxb - fxa)) * fxa, prec)
                fxt = calcFormula(xt)
                i += 1
                writeIter(i, xa, xb, xt, fxa, fxb, fxt)
            Loop
            wres(vbCrLf & vbCrLf & "x = " & xt)
            htmlCode += "</tbody>"
            htmlCode += "</table>"
            htmlCode += "<br><br>x = " & xt
            writeHTMLCode()
        Catch ex As Exception
            MsgBox("Error Found !" & vbCrLf & "==============" & vbCrLf & "Error Message: " & ex.Message & vbCrLf & "==============" & vbCrLf & "Error Detail:" & vbCrLf & vbCrLf & ex.ToString(), vbCritical, "Program Error Handler")
        End Try
    End Sub

    Private Sub bSecant_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSecant.Click
        Try
            prec = Val(txtPrec.Text)
            writeFormula("SPNL - Metode Secant")
            Dim i = 1
            Dim xa = Val(txtXa.Text)
            Dim xb = Val(txtXb.Text)
            Dim fxa = calcFormula(xa)
            Dim fxb = calcFormula(xb)
            Dim xt = Math.Round(xb - (fxb * (xb - xa) / (fxb - fxa)), prec)
            Dim fxt = calcFormula(xt)
            writeIterHead()
            writeIter(i, xa, xb, xt, fxa, fxb, fxt)
            Do While i <= (Val(txtMaxIter.Text) - 1)
                xa = xb
                xb = xt
                fxa = calcFormula(xa)
                fxb = calcFormula(xb)
                xt = Math.Round(xb - (fxb * (xb - xa) / (fxb - fxa)), prec)
                fxt = calcFormula(xt)
                i += 1
                writeIter(i, xa, xb, xt, fxa, fxb, fxt)
            Loop
            wres(vbCrLf & vbCrLf & "x = " & xt)
            htmlCode += "</tbody>"
            htmlCode += "</table>"
            htmlCode += "<br><br>x = " & xt
            writeHTMLCode()
        Catch ex As Exception
            MsgBox("Error Found !" & vbCrLf & "==============" & vbCrLf & "Error Message: " & ex.Message & vbCrLf & "==============" & vbCrLf & "Error Detail:" & vbCrLf & vbCrLf & ex.ToString(), vbCritical, "Program Error Handler")
        End Try
    End Sub

    Private Sub useX2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles useX2.CheckedChanged
        fX2.Enabled = Not fX2.Enabled
        fxx2.Enabled = Not fxx2.Enabled
        fX2P.Enabled = Not fX2P.Enabled
        If Not useX2.Checked Then
            fX2.Text = ""
            fX2P.Text = ""
        End If
    End Sub

    Private Sub useX3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles useX3.CheckedChanged
        fX3.Enabled = Not fX3.Enabled
        fxx3.Enabled = Not fxx3.Enabled
        fX3P.Enabled = Not fX3P.Enabled
        If Not useX3.Checked Then
            fX3.Text = ""
            fX3P.Text = ""
        End If
    End Sub

    Private Sub useC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles useC.CheckedChanged
        fC.Enabled = Not fC.Enabled
        If Not useC.Checked Then
            fC.Text = ""
        End If
    End Sub

    Private Sub rAppDGV_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rAppDGV.CheckedChanged
        If rAppDGV.Checked Then
            dgvResult.Visible = True
            lblResult.Visible = True
            Me.Height = 426
        End If
    End Sub

    Private Sub rBrowser_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rBrowser.CheckedChanged
        If rBrowser.Checked Then
            dgvResult.Visible = False
            lblResult.Visible = False
            Me.Height = 252
        End If
    End Sub

    Private Sub frmBisectionRegulSecant_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblResult.Text = ""
    End Sub

End Class