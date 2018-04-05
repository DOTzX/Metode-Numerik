<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewtonRaphson
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewtonRaphson))
        Me.txtXa = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.fX1 = New System.Windows.Forms.TextBox()
        Me.fxx1 = New System.Windows.Forms.Label()
        Me.fX1P = New System.Windows.Forms.TextBox()
        Me.fX2 = New System.Windows.Forms.TextBox()
        Me.fxx2 = New System.Windows.Forms.Label()
        Me.fX2P = New System.Windows.Forms.TextBox()
        Me.useX2 = New System.Windows.Forms.CheckBox()
        Me.useC = New System.Windows.Forms.CheckBox()
        Me.fX3 = New System.Windows.Forms.TextBox()
        Me.fC = New System.Windows.Forms.TextBox()
        Me.fxx3 = New System.Windows.Forms.Label()
        Me.useX3 = New System.Windows.Forms.CheckBox()
        Me.fX3P = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtMaxIter = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPrec = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rBrowser = New System.Windows.Forms.RadioButton()
        Me.rAppDGV = New System.Windows.Forms.RadioButton()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.dgvResult = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.bHitung = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtXa
        '
        Me.txtXa.Location = New System.Drawing.Point(50, 18)
        Me.txtXa.Name = "txtXa"
        Me.txtXa.Size = New System.Drawing.Size(60, 20)
        Me.txtXa.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Xo"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.fX1)
        Me.GroupBox3.Controls.Add(Me.fxx1)
        Me.GroupBox3.Controls.Add(Me.fX1P)
        Me.GroupBox3.Controls.Add(Me.fX2)
        Me.GroupBox3.Controls.Add(Me.fxx2)
        Me.GroupBox3.Controls.Add(Me.fX2P)
        Me.GroupBox3.Controls.Add(Me.useX2)
        Me.GroupBox3.Controls.Add(Me.useC)
        Me.GroupBox3.Controls.Add(Me.fX3)
        Me.GroupBox3.Controls.Add(Me.fC)
        Me.GroupBox3.Controls.Add(Me.fxx3)
        Me.GroupBox3.Controls.Add(Me.useX3)
        Me.GroupBox3.Controls.Add(Me.fX3P)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 56)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(371, 76)
        Me.GroupBox3.TabIndex = 33
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "f(x)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "f(x) ="
        '
        'fX1
        '
        Me.fX1.Location = New System.Drawing.Point(39, 25)
        Me.fX1.Name = "fX1"
        Me.fX1.Size = New System.Drawing.Size(28, 20)
        Me.fX1.TabIndex = 5
        '
        'fxx1
        '
        Me.fxx1.AutoSize = True
        Me.fxx1.Location = New System.Drawing.Point(69, 31)
        Me.fxx1.Name = "fxx1"
        Me.fxx1.Size = New System.Drawing.Size(12, 13)
        Me.fxx1.TabIndex = 6
        Me.fxx1.Text = "x"
        '
        'fX1P
        '
        Me.fX1P.Location = New System.Drawing.Point(82, 15)
        Me.fX1P.Name = "fX1P"
        Me.fX1P.Size = New System.Drawing.Size(28, 20)
        Me.fX1P.TabIndex = 7
        '
        'fX2
        '
        Me.fX2.Enabled = False
        Me.fX2.Location = New System.Drawing.Point(116, 24)
        Me.fX2.Name = "fX2"
        Me.fX2.Size = New System.Drawing.Size(28, 20)
        Me.fX2.TabIndex = 8
        '
        'fxx2
        '
        Me.fxx2.AutoSize = True
        Me.fxx2.Enabled = False
        Me.fxx2.Location = New System.Drawing.Point(146, 30)
        Me.fxx2.Name = "fxx2"
        Me.fxx2.Size = New System.Drawing.Size(12, 13)
        Me.fxx2.TabIndex = 9
        Me.fxx2.Text = "x"
        '
        'fX2P
        '
        Me.fX2P.Enabled = False
        Me.fX2P.Location = New System.Drawing.Point(159, 14)
        Me.fX2P.Name = "fX2P"
        Me.fX2P.Size = New System.Drawing.Size(28, 20)
        Me.fX2P.TabIndex = 10
        '
        'useX2
        '
        Me.useX2.AutoSize = True
        Me.useX2.Location = New System.Drawing.Point(116, 50)
        Me.useX2.Name = "useX2"
        Me.useX2.Size = New System.Drawing.Size(76, 17)
        Me.useX2.TabIndex = 12
        Me.useX2.Text = "Gunakan?"
        Me.useX2.UseVisualStyleBackColor = True
        '
        'useC
        '
        Me.useC.AutoSize = True
        Me.useC.Location = New System.Drawing.Point(280, 50)
        Me.useC.Name = "useC"
        Me.useC.Size = New System.Drawing.Size(76, 17)
        Me.useC.TabIndex = 18
        Me.useC.Text = "Gunakan?"
        Me.useC.UseVisualStyleBackColor = True
        '
        'fX3
        '
        Me.fX3.Enabled = False
        Me.fX3.Location = New System.Drawing.Point(198, 24)
        Me.fX3.Name = "fX3"
        Me.fX3.Size = New System.Drawing.Size(28, 20)
        Me.fX3.TabIndex = 13
        '
        'fC
        '
        Me.fC.Enabled = False
        Me.fC.Location = New System.Drawing.Point(280, 24)
        Me.fC.Name = "fC"
        Me.fC.Size = New System.Drawing.Size(76, 20)
        Me.fC.TabIndex = 17
        '
        'fxx3
        '
        Me.fxx3.AutoSize = True
        Me.fxx3.Enabled = False
        Me.fxx3.Location = New System.Drawing.Point(228, 30)
        Me.fxx3.Name = "fxx3"
        Me.fxx3.Size = New System.Drawing.Size(12, 13)
        Me.fxx3.TabIndex = 14
        Me.fxx3.Text = "x"
        '
        'useX3
        '
        Me.useX3.AutoSize = True
        Me.useX3.Location = New System.Drawing.Point(198, 50)
        Me.useX3.Name = "useX3"
        Me.useX3.Size = New System.Drawing.Size(76, 17)
        Me.useX3.TabIndex = 16
        Me.useX3.Text = "Gunakan?"
        Me.useX3.UseVisualStyleBackColor = True
        '
        'fX3P
        '
        Me.fX3P.Enabled = False
        Me.fX3P.Location = New System.Drawing.Point(241, 14)
        Me.fX3P.Name = "fX3P"
        Me.fX3P.Size = New System.Drawing.Size(28, 20)
        Me.fX3P.TabIndex = 15
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtMaxIter)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.txtPrec)
        Me.GroupBox4.Location = New System.Drawing.Point(517, 13)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(114, 118)
        Me.GroupBox4.TabIndex = 35
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Opsi"
        '
        'txtMaxIter
        '
        Me.txtMaxIter.Location = New System.Drawing.Point(13, 37)
        Me.txtMaxIter.Name = "txtMaxIter"
        Me.txtMaxIter.Size = New System.Drawing.Size(92, 20)
        Me.txtMaxIter.TabIndex = 22
        Me.txtMaxIter.Text = "5"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Max Iter"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Comma"
        '
        'txtPrec
        '
        Me.txtPrec.Location = New System.Drawing.Point(13, 79)
        Me.txtPrec.Name = "txtPrec"
        Me.txtPrec.Size = New System.Drawing.Size(92, 20)
        Me.txtPrec.TabIndex = 25
        Me.txtPrec.Text = "2"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rBrowser)
        Me.GroupBox2.Controls.Add(Me.rAppDGV)
        Me.GroupBox2.Location = New System.Drawing.Point(517, 137)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(114, 74)
        Me.GroupBox2.TabIndex = 34
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tulis Hasil di"
        '
        'rBrowser
        '
        Me.rBrowser.AutoSize = True
        Me.rBrowser.Location = New System.Drawing.Point(8, 47)
        Me.rBrowser.Name = "rBrowser"
        Me.rBrowser.Size = New System.Drawing.Size(63, 17)
        Me.rBrowser.TabIndex = 28
        Me.rBrowser.Text = "Browser"
        Me.rBrowser.UseVisualStyleBackColor = True
        '
        'rAppDGV
        '
        Me.rAppDGV.AutoSize = True
        Me.rAppDGV.Checked = True
        Me.rAppDGV.Location = New System.Drawing.Point(8, 24)
        Me.rAppDGV.Name = "rAppDGV"
        Me.rAppDGV.Size = New System.Drawing.Size(97, 17)
        Me.rAppDGV.TabIndex = 29
        Me.rAppDGV.TabStop = True
        Me.rAppDGV.Text = "Aplikasi (Tabel)"
        Me.rAppDGV.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.Location = New System.Drawing.Point(11, 143)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(496, 67)
        Me.lblResult.TabIndex = 37
        Me.lblResult.Text = "RESULTO"
        '
        'dgvResult
        '
        Me.dgvResult.AllowUserToAddRows = False
        Me.dgvResult.AllowUserToDeleteRows = False
        Me.dgvResult.AllowUserToOrderColumns = True
        Me.dgvResult.AllowUserToResizeRows = False
        Me.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResult.Location = New System.Drawing.Point(11, 223)
        Me.dgvResult.Name = "dgvResult"
        Me.dgvResult.ReadOnly = True
        Me.dgvResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvResult.ShowCellErrors = False
        Me.dgvResult.ShowEditingIcon = False
        Me.dgvResult.ShowRowErrors = False
        Me.dgvResult.Size = New System.Drawing.Size(621, 162)
        Me.dgvResult.TabIndex = 36
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(150, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(174, 39)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Catatan:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Pangkat dapat ""x"" itu sendiri" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Paling belakang adalah konstanta"
        '
        'bHitung
        '
        Me.bHitung.Location = New System.Drawing.Point(395, 9)
        Me.bHitung.Name = "bHitung"
        Me.bHitung.Size = New System.Drawing.Size(111, 122)
        Me.bHitung.TabIndex = 39
        Me.bHitung.Text = "Hitung"
        Me.bHitung.UseVisualStyleBackColor = True
        '
        'frmNewtonRaphson
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 397)
        Me.Controls.Add(Me.bHitung)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.dgvResult)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.txtXa)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmNewtonRaphson"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Newton-Raphson"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtXa As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents fX1 As System.Windows.Forms.TextBox
    Friend WithEvents fxx1 As System.Windows.Forms.Label
    Friend WithEvents fX1P As System.Windows.Forms.TextBox
    Friend WithEvents fX2 As System.Windows.Forms.TextBox
    Friend WithEvents fxx2 As System.Windows.Forms.Label
    Friend WithEvents fX2P As System.Windows.Forms.TextBox
    Friend WithEvents useX2 As System.Windows.Forms.CheckBox
    Friend WithEvents useC As System.Windows.Forms.CheckBox
    Friend WithEvents fX3 As System.Windows.Forms.TextBox
    Friend WithEvents fC As System.Windows.Forms.TextBox
    Friend WithEvents fxx3 As System.Windows.Forms.Label
    Friend WithEvents useX3 As System.Windows.Forms.CheckBox
    Friend WithEvents fX3P As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtMaxIter As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPrec As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rBrowser As System.Windows.Forms.RadioButton
    Friend WithEvents rAppDGV As System.Windows.Forms.RadioButton
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents dgvResult As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents bHitung As System.Windows.Forms.Button
End Class
