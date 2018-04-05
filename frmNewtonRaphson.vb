Imports System.IO

Public Class frmNewtonRaphson

    Dim prec As Integer = 2
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

    Private Function calcX1Turn(ByVal x As Double) As Double
        Dim res = x
        Dim tmpXP, tmpX
        If fX1P.Text = "" Then
            tmpXP = 0
        ElseIf fX1P.Text = "x" Or fX1P.Text = "X" Then
            tmpXP = x - 1
        Else
            tmpXP = Val(fX1P.Text) - 1
        End If
        If fX1.Text = "" Then
            tmpX = tmpXP + 1
        Else
            tmpX = Val(fX1.Text) * (tmpXP + 1)
        End If
        If tmpXP = 0 Then
            res = tmpX
        Else
            res = res ^ tmpXP
            res = res * tmpX
        End If
        Return res
    End Function
    Private Function calcX2Turn(ByVal x As Double) As Double
        Dim res = x
        Dim tmpXP, tmpX
        If fX2P.Text = "" Then
            tmpXP = 0
        ElseIf fX2P.Text = "x" Or fX2P.Text = "X" Then
            tmpXP = x - 1
        Else
            tmpXP = Val(fX2P.Text) - 1
        End If
        If fX2.Text = "" Then
            tmpX = tmpXP + 1
        Else
            tmpX = Val(fX2.Text) * (tmpXP + 1)
        End If
        If tmpXP = 0 Then
            res = tmpX
        Else
            res = res ^ tmpXP
            res = res * tmpX
        End If
        Return res
    End Function
    Private Function calcX3Turn(ByVal x As Double) As Double
        Dim res = x
        Dim tmpXP, tmpX
        If fX3P.Text = "" Then
            tmpXP = 0
        ElseIf fX3P.Text = "x" Or fX3P.Text = "X" Then
            tmpXP = x - 1
        Else
            tmpXP = Val(fX3P.Text) - 1
        End If
        If fX3.Text = "" Then
            tmpX = tmpXP + 1
        Else
            tmpX = Val(fX3.Text) * (tmpXP + 1)
        End If
        If tmpXP = 0 Then
            res = tmpX
        Else
            res = res ^ tmpXP
            res = res * tmpX
        End If
        Return res
    End Function
    Private Function calcFormulaTurn(ByVal x As Double) As Double
        Dim res = calcX1Turn(x)
        If useX2.Checked Then
            res = res + calcX2Turn(x)
        End If
        If useX3.Checked Then
            res = res + calcX3Turn(x)
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
        Dim tmp
        result += "Xo = " & txtXa.Text & vbCrLf
        result += "f(x) = "
        htmlCode += "<b>Xo</b> = " & txtXa.Text & "<br><b>f(x)</b> = "
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
        htmlCode += "<br>"
        wres(result)
    End Sub
    Private Function getTurn(ByVal xx As Object, ByVal xxP As Object) As ArrayList
        Dim tmpXP, tmpX
        If xxP.Text = "" Then
            tmpXP = 1 - 1
        ElseIf xxP.Text = "x" Or xxP.Text = "X" Then
            tmpXP = Val(txtXa.Text) - 1
        Else
            tmpXP = Val(xxP.Text) - 1
        End If
        If xx.Text = "" Then
            tmpX = tmpXP + 1
        Else
            tmpX = Val(xx.Text) * (tmpXP + 1)
        End If
        Dim list As New ArrayList
        list.Add(tmpX)
        list.Add(tmpXP)
        Return list
    End Function
    Private Sub writeFormulaTurn()
        Dim result = vbCrLf
        Dim tmp
        htmlCode = htmlCode
        result += "f'(x) = "
        htmlCode += "<b>f'(x)</b> = "
        Dim myx = getTurn(fX1, fX1P)
        If myx(0) = 1 Then
            tmp = "x"
        ElseIf (myx(0) > 0 Or myx(0) < 0) And myx(1) <> 0 Then
            tmp = myx(0) & "x"
        ElseIf (myx(0) > 0 Or myx(0) < 0) And myx(1) = 0 Then
            tmp = myx(0).ToString
        Else
            tmp = ""
        End If
        result += tmp
        htmlCode += tmp
        If myx(1) > 0 Or myx(1) < 0 Then
            result += "^" & myx(1)
            htmlCode += "<sup>" & myx(1) & "</sup>"
        End If
        If useX2.Checked Then
            myx = getTurn(fX2, fX2P)
            If Val(fX2.Text) > 0 Or fX2.Text = "" Then
                tmp = " + "
            Else
                tmp = " "
            End If
            If myx(0) = 1 Then
                tmp += "x"
            ElseIf (myx(0) > 0 Or myx(0) < 0) And myx(1) <> 0 Then
                tmp += myx(0) & "x"
            ElseIf (myx(0) > 0 Or myx(0) < 0) And myx(1) = 0 Then
                tmp += myx(0).ToString
            Else
                tmp += ""
            End If
            result += tmp
            htmlCode += tmp
            If myx(1) > 0 Or myx(1) < 0 Then
                result += "^" & myx(1)
                htmlCode += "<sup>" & myx(1) & "</sup>"
            End If
        End If
        If useX3.Checked Then
            myx = getTurn(fX3, fX3P)
            If Val(fX3.Text) > 0 Or fX3.Text = "" Then
                tmp = " + "
            Else
                tmp = " "
            End If
            If myx(0) = 1 Then
                tmp += "x"
            ElseIf (myx(0) > 0 Or myx(0) < 0) And myx(1) <> 0 Then
                tmp += myx(0) & "x"
            ElseIf (myx(0) > 0 Or myx(0) < 0) And myx(1) = 0 Then
                tmp += myx(0).ToString
            Else
                tmp += ""
            End If
            result += tmp
            htmlCode += tmp
            If myx(1) > 0 Or myx(1) < 0 Then
                result += "^" & myx(1)
                htmlCode += "<sup>" & myx(1) & "</sup>"
            End If
        End If
        htmlCode += "<br><br>"
        wres(result)
    End Sub
    Private Sub writeIterHead()
        dgvResult.Rows.Clear()
        dgvResult.ColumnCount = 4
        dgvResult.Columns(0).Name = "Iter ke-"
        dgvResult.Columns(1).Name = "f(x)"
        dgvResult.Columns(2).Name = "f'(x)"
        dgvResult.Columns(3).Name = "x"
        htmlCode += "<table border='2' cellpadding='3' style='border-collapse:collapse; text-align:center; width:100%'>"
        htmlCode += "<thead>"
        htmlCode += "<tr>"
        htmlCode += "<th style='width:25%'>Iter ke-</th>"
        htmlCode += "<th style='width:25%'>f(x)</th>"
        htmlCode += "<th style='width:25%'>f'(x)</th>"
        htmlCode += "<th style='width:25%'>x</th>"
        htmlCode += "</tr>"
        htmlCode += "</thead>"
        htmlCode += "<tbody>"
    End Sub
    Private Sub writeIter(ByVal n As String, _
                               ByVal fx As String, ByVal fxTurn As String, ByVal x As String)
        dgvResult.Rows.Add(New String() {n, fx, fxTurn, x})
        htmlCode += "<tr>"
        htmlCode += "<td>" & n & "</td>"
        htmlCode += "<td>" & fx & "</td>"
        htmlCode += "<td>" & fxTurn & "</td>"
        htmlCode += "<td>" & x & "</td>"
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

    Private Sub bHitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bHitung.Click
        Try
            prec = Val(txtPrec.Text)
            writeFormula("SPNL - Metode Newton-Raphson")
            writeFormulaTurn()
            Dim i = 1
            Dim xold = Val(txtXa.Text)
            Dim fx = calcFormula(xold)
            Dim fxTurn = calcFormulaTurn(xold)
            Dim xnew = Math.Round(xold - (fx / fxTurn), prec)
            writeIterHead()
            writeIter(i, fx, fxTurn, xnew)
            xold = xnew
            Do While i <= (Val(txtMaxIter.Text) - 1)
                i += 1
                fx = calcFormula(xold)
                fxTurn = calcFormulaTurn(xold)
                xnew = Math.Round(xold - (fx / fxTurn), prec)
                writeIter(i, fx, fxTurn, xnew)
                xold = xnew
            Loop
            wres(vbCrLf & vbCrLf & "x = " & xnew)
            htmlCode += "</tbody>"
            htmlCode += "</table>"
            htmlCode += "<br><br>x = " & xnew
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

    Private Sub frmNewtonRaphson_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblResult.Text = ""
    End Sub

End Class