Public Class frmMain

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmBisectionRegulSecant.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        frmNewtonRaphson.Show()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        frmJacobiGSeidel.Show()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        frmCramer.Show()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        frmDoolittleCrout.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        fmGauss.Show()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        frmGJordan.Show()
    End Sub

    Private Sub frmMain_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ShowModification As Boolean = False
        If My.Application.Info.Copyright <> "Copyright © Hugo 2017" Then ShowModification = True
        If My.Application.Info.CompanyName <> "Hugo Soft." Then ShowModification = True
        If My.Application.Info.Trademark <> "Hugo Soft." Then ShowModification = True
        If My.Application.Info.Description <> "Aplikasi Metode Numerik by Hugo Annito" Then ShowModification = True
        If ShowModification Then
            MsgBox("Tidak dapat membuka aplikasi dikarenakan terdapat modifikasi", MsgBoxStyle.Critical)
            End
        End If
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        MsgBox("Aplikasi Metode Numerik" & vbCrLf & _
               "Dibuat/dikembangkan oleh Hugo Annito" & vbCrLf & _
               "Menggunakan VS2010 VB.NET" & vbCrLf & _
               "Last Build. 20 Nov 2017" & vbCrLf & _
               "" & vbCrLf & _
               "NIM: 162101736", vbInformation)
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        MsgBox("Umum:" & vbCrLf & _
               "1. Ketik persamaan-nya" & vbCrLf & _
               "2. Atur [Opsi]-nya (Opsional)" & vbCrLf & _
               "3. Atur [Tulis Hasil]-nya (Opsional)" & vbCrLf & _
               "4. Klik [Hitung] atau klik 'metode-nya'." & vbCrLf & _
               "" & vbCrLf & _
               "Khusus Jacobi / Gauss-Seidel:" & vbCrLf & _
               "1. Atur [Opsi]-nya (Opsional)" & vbCrLf & _
               "2. Atur [Tulis Hasil]-nya (Opsional)" & vbCrLf & _
               "3. Ketik persamaan-nya" & vbCrLf & _
               "4. Klik [Hitung] atau klik 'metode-nya'.", vbInformation)
    End Sub

End Class
