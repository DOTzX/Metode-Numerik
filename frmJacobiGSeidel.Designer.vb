<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJacobiGSeidel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmJacobiGSeidel))
        Me.xx1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rUse1 = New System.Windows.Forms.RadioButton()
        Me.rUse4 = New System.Windows.Forms.RadioButton()
        Me.rUse3 = New System.Windows.Forms.RadioButton()
        Me.rUse2 = New System.Windows.Forms.RadioButton()
        Me.txtMaxIter = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPrec = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rBrowser = New System.Windows.Forms.RadioButton()
        Me.rAppText = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.bJacobi = New System.Windows.Forms.Button()
        Me.bGSeidel = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ttbY = New System.Windows.Forms.Label()
        Me.ttbX = New System.Windows.Forms.Label()
        Me.tbU = New System.Windows.Forms.TextBox()
        Me.ttbU = New System.Windows.Forms.Label()
        Me.tbZ = New System.Windows.Forms.TextBox()
        Me.ttbZ = New System.Windows.Forms.Label()
        Me.tbY = New System.Windows.Forms.TextBox()
        Me.tbX = New System.Windows.Forms.TextBox()
        Me.yy1 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.sd4 = New System.Windows.Forms.TextBox()
        Me.ssd4 = New System.Windows.Forms.Label()
        Me.uu4 = New System.Windows.Forms.Label()
        Me.zz4 = New System.Windows.Forms.Label()
        Me.u4 = New System.Windows.Forms.TextBox()
        Me.z4 = New System.Windows.Forms.TextBox()
        Me.y4 = New System.Windows.Forms.TextBox()
        Me.x4 = New System.Windows.Forms.TextBox()
        Me.xx4 = New System.Windows.Forms.Label()
        Me.yy4 = New System.Windows.Forms.Label()
        Me.sd3 = New System.Windows.Forms.TextBox()
        Me.ssd3 = New System.Windows.Forms.Label()
        Me.uu3 = New System.Windows.Forms.Label()
        Me.zz3 = New System.Windows.Forms.Label()
        Me.u3 = New System.Windows.Forms.TextBox()
        Me.z3 = New System.Windows.Forms.TextBox()
        Me.y3 = New System.Windows.Forms.TextBox()
        Me.x3 = New System.Windows.Forms.TextBox()
        Me.xx3 = New System.Windows.Forms.Label()
        Me.yy3 = New System.Windows.Forms.Label()
        Me.sd2 = New System.Windows.Forms.TextBox()
        Me.ssd2 = New System.Windows.Forms.Label()
        Me.uu2 = New System.Windows.Forms.Label()
        Me.zz2 = New System.Windows.Forms.Label()
        Me.u2 = New System.Windows.Forms.TextBox()
        Me.z2 = New System.Windows.Forms.TextBox()
        Me.y2 = New System.Windows.Forms.TextBox()
        Me.x2 = New System.Windows.Forms.TextBox()
        Me.xx2 = New System.Windows.Forms.Label()
        Me.yy2 = New System.Windows.Forms.Label()
        Me.sd1 = New System.Windows.Forms.TextBox()
        Me.ssd1 = New System.Windows.Forms.Label()
        Me.uu1 = New System.Windows.Forms.Label()
        Me.zz1 = New System.Windows.Forms.Label()
        Me.u1 = New System.Windows.Forms.TextBox()
        Me.z1 = New System.Windows.Forms.TextBox()
        Me.y1 = New System.Windows.Forms.TextBox()
        Me.x1 = New System.Windows.Forms.TextBox()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.dgvResult = New System.Windows.Forms.DataGridView()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dgvResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'xx1
        '
        Me.xx1.AutoSize = True
        Me.xx1.Location = New System.Drawing.Point(68, 28)
        Me.xx1.Name = "xx1"
        Me.xx1.Size = New System.Drawing.Size(12, 13)
        Me.xx1.TabIndex = 2
        Me.xx1.Text = "x"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rUse1)
        Me.GroupBox4.Controls.Add(Me.rUse4)
        Me.GroupBox4.Controls.Add(Me.rUse3)
        Me.GroupBox4.Controls.Add(Me.rUse2)
        Me.GroupBox4.Controls.Add(Me.txtMaxIter)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.txtPrec)
        Me.GroupBox4.Location = New System.Drawing.Point(426, 13)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(114, 199)
        Me.GroupBox4.TabIndex = 36
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Opsi"
        '
        'rUse1
        '
        Me.rUse1.AutoSize = True
        Me.rUse1.Checked = True
        Me.rUse1.Location = New System.Drawing.Point(16, 111)
        Me.rUse1.Name = "rUse1"
        Me.rUse1.Size = New System.Drawing.Size(78, 17)
        Me.rUse1.TabIndex = 29
        Me.rUse1.TabStop = True
        Me.rUse1.Text = "Gunakan 1"
        Me.rUse1.UseVisualStyleBackColor = True
        '
        'rUse4
        '
        Me.rUse4.AutoSize = True
        Me.rUse4.Location = New System.Drawing.Point(16, 172)
        Me.rUse4.Name = "rUse4"
        Me.rUse4.Size = New System.Drawing.Size(78, 17)
        Me.rUse4.TabIndex = 28
        Me.rUse4.Text = "Gunakan 4"
        Me.rUse4.UseVisualStyleBackColor = True
        '
        'rUse3
        '
        Me.rUse3.AutoSize = True
        Me.rUse3.Location = New System.Drawing.Point(16, 152)
        Me.rUse3.Name = "rUse3"
        Me.rUse3.Size = New System.Drawing.Size(78, 17)
        Me.rUse3.TabIndex = 27
        Me.rUse3.Text = "Gunakan 3"
        Me.rUse3.UseVisualStyleBackColor = True
        '
        'rUse2
        '
        Me.rUse2.AutoSize = True
        Me.rUse2.Location = New System.Drawing.Point(16, 131)
        Me.rUse2.Name = "rUse2"
        Me.rUse2.Size = New System.Drawing.Size(78, 17)
        Me.rUse2.TabIndex = 26
        Me.rUse2.Text = "Gunakan 2"
        Me.rUse2.UseVisualStyleBackColor = True
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
        Me.GroupBox2.Controls.Add(Me.rAppText)
        Me.GroupBox2.Location = New System.Drawing.Point(544, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(124, 86)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tulis Hasil di"
        '
        'rBrowser
        '
        Me.rBrowser.AutoSize = True
        Me.rBrowser.Location = New System.Drawing.Point(24, 50)
        Me.rBrowser.Name = "rBrowser"
        Me.rBrowser.Size = New System.Drawing.Size(63, 17)
        Me.rBrowser.TabIndex = 28
        Me.rBrowser.Text = "Browser"
        Me.rBrowser.UseVisualStyleBackColor = True
        '
        'rAppText
        '
        Me.rAppText.AutoSize = True
        Me.rAppText.Checked = True
        Me.rAppText.Location = New System.Drawing.Point(24, 27)
        Me.rAppText.Name = "rAppText"
        Me.rAppText.Size = New System.Drawing.Size(61, 17)
        Me.rAppText.TabIndex = 29
        Me.rAppText.TabStop = True
        Me.rAppText.Text = "Aplikasi"
        Me.rAppText.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.bJacobi)
        Me.GroupBox1.Controls.Add(Me.bGSeidel)
        Me.GroupBox1.Location = New System.Drawing.Point(544, 104)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(124, 108)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Metode"
        '
        'bJacobi
        '
        Me.bJacobi.Location = New System.Drawing.Point(13, 26)
        Me.bJacobi.Name = "bJacobi"
        Me.bJacobi.Size = New System.Drawing.Size(104, 27)
        Me.bJacobi.TabIndex = 19
        Me.bJacobi.Text = "Jacobi"
        Me.bJacobi.UseVisualStyleBackColor = True
        '
        'bGSeidel
        '
        Me.bGSeidel.Location = New System.Drawing.Point(13, 59)
        Me.bGSeidel.Name = "bGSeidel"
        Me.bGSeidel.Size = New System.Drawing.Size(104, 27)
        Me.bGSeidel.TabIndex = 20
        Me.bGSeidel.Text = "G.-Seidel"
        Me.bGSeidel.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ttbY)
        Me.GroupBox3.Controls.Add(Me.ttbX)
        Me.GroupBox3.Controls.Add(Me.tbU)
        Me.GroupBox3.Controls.Add(Me.ttbU)
        Me.GroupBox3.Controls.Add(Me.tbZ)
        Me.GroupBox3.Controls.Add(Me.ttbZ)
        Me.GroupBox3.Controls.Add(Me.tbY)
        Me.GroupBox3.Controls.Add(Me.tbX)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 14)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(409, 57)
        Me.GroupBox3.TabIndex = 37
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tebakan awal"
        '
        'ttbY
        '
        Me.ttbY.AutoSize = True
        Me.ttbY.Enabled = False
        Me.ttbY.Location = New System.Drawing.Point(118, 27)
        Me.ttbY.Name = "ttbY"
        Me.ttbY.Size = New System.Drawing.Size(14, 13)
        Me.ttbY.TabIndex = 11
        Me.ttbY.Text = "Y"
        '
        'ttbX
        '
        Me.ttbX.AutoSize = True
        Me.ttbX.Location = New System.Drawing.Point(17, 28)
        Me.ttbX.Name = "ttbX"
        Me.ttbX.Size = New System.Drawing.Size(14, 13)
        Me.ttbX.TabIndex = 10
        Me.ttbX.Text = "X"
        '
        'tbU
        '
        Me.tbU.Enabled = False
        Me.tbU.Location = New System.Drawing.Point(334, 23)
        Me.tbU.Name = "tbU"
        Me.tbU.Size = New System.Drawing.Size(56, 20)
        Me.tbU.TabIndex = 9
        Me.tbU.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ttbU
        '
        Me.ttbU.AutoSize = True
        Me.ttbU.Enabled = False
        Me.ttbU.Location = New System.Drawing.Point(314, 27)
        Me.ttbU.Name = "ttbU"
        Me.ttbU.Size = New System.Drawing.Size(15, 13)
        Me.ttbU.TabIndex = 8
        Me.ttbU.Text = "U"
        '
        'tbZ
        '
        Me.tbZ.Enabled = False
        Me.tbZ.Location = New System.Drawing.Point(236, 23)
        Me.tbZ.Name = "tbZ"
        Me.tbZ.Size = New System.Drawing.Size(56, 20)
        Me.tbZ.TabIndex = 7
        Me.tbZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ttbZ
        '
        Me.ttbZ.AutoSize = True
        Me.ttbZ.Enabled = False
        Me.ttbZ.Location = New System.Drawing.Point(216, 27)
        Me.ttbZ.Name = "ttbZ"
        Me.ttbZ.Size = New System.Drawing.Size(14, 13)
        Me.ttbZ.TabIndex = 6
        Me.ttbZ.Text = "Z"
        '
        'tbY
        '
        Me.tbY.Enabled = False
        Me.tbY.Location = New System.Drawing.Point(138, 23)
        Me.tbY.Name = "tbY"
        Me.tbY.Size = New System.Drawing.Size(56, 20)
        Me.tbY.TabIndex = 5
        Me.tbY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbX
        '
        Me.tbX.Location = New System.Drawing.Point(35, 23)
        Me.tbX.Name = "tbX"
        Me.tbX.Size = New System.Drawing.Size(56, 20)
        Me.tbX.TabIndex = 3
        Me.tbX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'yy1
        '
        Me.yy1.AutoSize = True
        Me.yy1.Enabled = False
        Me.yy1.Location = New System.Drawing.Point(148, 28)
        Me.yy1.Name = "yy1"
        Me.yy1.Size = New System.Drawing.Size(12, 13)
        Me.yy1.TabIndex = 4
        Me.yy1.Text = "y"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.sd4)
        Me.GroupBox5.Controls.Add(Me.ssd4)
        Me.GroupBox5.Controls.Add(Me.uu4)
        Me.GroupBox5.Controls.Add(Me.zz4)
        Me.GroupBox5.Controls.Add(Me.u4)
        Me.GroupBox5.Controls.Add(Me.z4)
        Me.GroupBox5.Controls.Add(Me.y4)
        Me.GroupBox5.Controls.Add(Me.x4)
        Me.GroupBox5.Controls.Add(Me.xx4)
        Me.GroupBox5.Controls.Add(Me.yy4)
        Me.GroupBox5.Controls.Add(Me.sd3)
        Me.GroupBox5.Controls.Add(Me.ssd3)
        Me.GroupBox5.Controls.Add(Me.uu3)
        Me.GroupBox5.Controls.Add(Me.zz3)
        Me.GroupBox5.Controls.Add(Me.u3)
        Me.GroupBox5.Controls.Add(Me.z3)
        Me.GroupBox5.Controls.Add(Me.y3)
        Me.GroupBox5.Controls.Add(Me.x3)
        Me.GroupBox5.Controls.Add(Me.xx3)
        Me.GroupBox5.Controls.Add(Me.yy3)
        Me.GroupBox5.Controls.Add(Me.sd2)
        Me.GroupBox5.Controls.Add(Me.ssd2)
        Me.GroupBox5.Controls.Add(Me.uu2)
        Me.GroupBox5.Controls.Add(Me.zz2)
        Me.GroupBox5.Controls.Add(Me.u2)
        Me.GroupBox5.Controls.Add(Me.z2)
        Me.GroupBox5.Controls.Add(Me.y2)
        Me.GroupBox5.Controls.Add(Me.x2)
        Me.GroupBox5.Controls.Add(Me.xx2)
        Me.GroupBox5.Controls.Add(Me.yy2)
        Me.GroupBox5.Controls.Add(Me.sd1)
        Me.GroupBox5.Controls.Add(Me.ssd1)
        Me.GroupBox5.Controls.Add(Me.uu1)
        Me.GroupBox5.Controls.Add(Me.zz1)
        Me.GroupBox5.Controls.Add(Me.u1)
        Me.GroupBox5.Controls.Add(Me.z1)
        Me.GroupBox5.Controls.Add(Me.y1)
        Me.GroupBox5.Controls.Add(Me.x1)
        Me.GroupBox5.Controls.Add(Me.xx1)
        Me.GroupBox5.Controls.Add(Me.yy1)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 78)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(408, 134)
        Me.GroupBox5.TabIndex = 38
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Persamaan"
        '
        'sd4
        '
        Me.sd4.Enabled = False
        Me.sd4.Location = New System.Drawing.Point(341, 100)
        Me.sd4.Name = "sd4"
        Me.sd4.Size = New System.Drawing.Size(57, 20)
        Me.sd4.TabIndex = 45
        Me.sd4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ssd4
        '
        Me.ssd4.AutoSize = True
        Me.ssd4.Enabled = False
        Me.ssd4.Location = New System.Drawing.Point(322, 103)
        Me.ssd4.Name = "ssd4"
        Me.ssd4.Size = New System.Drawing.Size(13, 13)
        Me.ssd4.TabIndex = 44
        Me.ssd4.Text = "="
        '
        'uu4
        '
        Me.uu4.AutoSize = True
        Me.uu4.Enabled = False
        Me.uu4.Location = New System.Drawing.Point(306, 106)
        Me.uu4.Name = "uu4"
        Me.uu4.Size = New System.Drawing.Size(13, 13)
        Me.uu4.TabIndex = 41
        Me.uu4.Text = "u"
        '
        'zz4
        '
        Me.zz4.AutoSize = True
        Me.zz4.Enabled = False
        Me.zz4.Location = New System.Drawing.Point(228, 106)
        Me.zz4.Name = "zz4"
        Me.zz4.Size = New System.Drawing.Size(12, 13)
        Me.zz4.TabIndex = 39
        Me.zz4.Text = "z"
        '
        'u4
        '
        Me.u4.Enabled = False
        Me.u4.Location = New System.Drawing.Point(246, 99)
        Me.u4.Name = "u4"
        Me.u4.Size = New System.Drawing.Size(56, 20)
        Me.u4.TabIndex = 43
        Me.u4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'z4
        '
        Me.z4.Enabled = False
        Me.z4.Location = New System.Drawing.Point(166, 99)
        Me.z4.Name = "z4"
        Me.z4.Size = New System.Drawing.Size(56, 20)
        Me.z4.TabIndex = 42
        Me.z4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'y4
        '
        Me.y4.Enabled = False
        Me.y4.Location = New System.Drawing.Point(85, 99)
        Me.y4.Name = "y4"
        Me.y4.Size = New System.Drawing.Size(56, 20)
        Me.y4.TabIndex = 40
        Me.y4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'x4
        '
        Me.x4.Enabled = False
        Me.x4.Location = New System.Drawing.Point(8, 99)
        Me.x4.Name = "x4"
        Me.x4.Size = New System.Drawing.Size(56, 20)
        Me.x4.TabIndex = 38
        Me.x4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'xx4
        '
        Me.xx4.AutoSize = True
        Me.xx4.Enabled = False
        Me.xx4.Location = New System.Drawing.Point(68, 106)
        Me.xx4.Name = "xx4"
        Me.xx4.Size = New System.Drawing.Size(12, 13)
        Me.xx4.TabIndex = 36
        Me.xx4.Text = "x"
        '
        'yy4
        '
        Me.yy4.AutoSize = True
        Me.yy4.Enabled = False
        Me.yy4.Location = New System.Drawing.Point(148, 106)
        Me.yy4.Name = "yy4"
        Me.yy4.Size = New System.Drawing.Size(12, 13)
        Me.yy4.TabIndex = 37
        Me.yy4.Text = "y"
        '
        'sd3
        '
        Me.sd3.Enabled = False
        Me.sd3.Location = New System.Drawing.Point(341, 74)
        Me.sd3.Name = "sd3"
        Me.sd3.Size = New System.Drawing.Size(57, 20)
        Me.sd3.TabIndex = 35
        Me.sd3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ssd3
        '
        Me.ssd3.AutoSize = True
        Me.ssd3.Enabled = False
        Me.ssd3.Location = New System.Drawing.Point(322, 77)
        Me.ssd3.Name = "ssd3"
        Me.ssd3.Size = New System.Drawing.Size(13, 13)
        Me.ssd3.TabIndex = 34
        Me.ssd3.Text = "="
        '
        'uu3
        '
        Me.uu3.AutoSize = True
        Me.uu3.Enabled = False
        Me.uu3.Location = New System.Drawing.Point(306, 80)
        Me.uu3.Name = "uu3"
        Me.uu3.Size = New System.Drawing.Size(13, 13)
        Me.uu3.TabIndex = 31
        Me.uu3.Text = "u"
        '
        'zz3
        '
        Me.zz3.AutoSize = True
        Me.zz3.Enabled = False
        Me.zz3.Location = New System.Drawing.Point(228, 80)
        Me.zz3.Name = "zz3"
        Me.zz3.Size = New System.Drawing.Size(12, 13)
        Me.zz3.TabIndex = 29
        Me.zz3.Text = "z"
        '
        'u3
        '
        Me.u3.Enabled = False
        Me.u3.Location = New System.Drawing.Point(246, 73)
        Me.u3.Name = "u3"
        Me.u3.Size = New System.Drawing.Size(56, 20)
        Me.u3.TabIndex = 33
        Me.u3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'z3
        '
        Me.z3.Enabled = False
        Me.z3.Location = New System.Drawing.Point(166, 73)
        Me.z3.Name = "z3"
        Me.z3.Size = New System.Drawing.Size(56, 20)
        Me.z3.TabIndex = 32
        Me.z3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'y3
        '
        Me.y3.Enabled = False
        Me.y3.Location = New System.Drawing.Point(85, 73)
        Me.y3.Name = "y3"
        Me.y3.Size = New System.Drawing.Size(56, 20)
        Me.y3.TabIndex = 30
        Me.y3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'x3
        '
        Me.x3.Enabled = False
        Me.x3.Location = New System.Drawing.Point(8, 73)
        Me.x3.Name = "x3"
        Me.x3.Size = New System.Drawing.Size(56, 20)
        Me.x3.TabIndex = 28
        Me.x3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'xx3
        '
        Me.xx3.AutoSize = True
        Me.xx3.Enabled = False
        Me.xx3.Location = New System.Drawing.Point(68, 80)
        Me.xx3.Name = "xx3"
        Me.xx3.Size = New System.Drawing.Size(12, 13)
        Me.xx3.TabIndex = 26
        Me.xx3.Text = "x"
        '
        'yy3
        '
        Me.yy3.AutoSize = True
        Me.yy3.Enabled = False
        Me.yy3.Location = New System.Drawing.Point(148, 80)
        Me.yy3.Name = "yy3"
        Me.yy3.Size = New System.Drawing.Size(12, 13)
        Me.yy3.TabIndex = 27
        Me.yy3.Text = "y"
        '
        'sd2
        '
        Me.sd2.Enabled = False
        Me.sd2.Location = New System.Drawing.Point(341, 48)
        Me.sd2.Name = "sd2"
        Me.sd2.Size = New System.Drawing.Size(57, 20)
        Me.sd2.TabIndex = 25
        Me.sd2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ssd2
        '
        Me.ssd2.AutoSize = True
        Me.ssd2.Enabled = False
        Me.ssd2.Location = New System.Drawing.Point(322, 51)
        Me.ssd2.Name = "ssd2"
        Me.ssd2.Size = New System.Drawing.Size(13, 13)
        Me.ssd2.TabIndex = 24
        Me.ssd2.Text = "="
        '
        'uu2
        '
        Me.uu2.AutoSize = True
        Me.uu2.Enabled = False
        Me.uu2.Location = New System.Drawing.Point(306, 54)
        Me.uu2.Name = "uu2"
        Me.uu2.Size = New System.Drawing.Size(13, 13)
        Me.uu2.TabIndex = 21
        Me.uu2.Text = "u"
        '
        'zz2
        '
        Me.zz2.AutoSize = True
        Me.zz2.Enabled = False
        Me.zz2.Location = New System.Drawing.Point(228, 54)
        Me.zz2.Name = "zz2"
        Me.zz2.Size = New System.Drawing.Size(12, 13)
        Me.zz2.TabIndex = 19
        Me.zz2.Text = "z"
        '
        'u2
        '
        Me.u2.Enabled = False
        Me.u2.Location = New System.Drawing.Point(246, 47)
        Me.u2.Name = "u2"
        Me.u2.Size = New System.Drawing.Size(56, 20)
        Me.u2.TabIndex = 23
        Me.u2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'z2
        '
        Me.z2.Enabled = False
        Me.z2.Location = New System.Drawing.Point(166, 47)
        Me.z2.Name = "z2"
        Me.z2.Size = New System.Drawing.Size(56, 20)
        Me.z2.TabIndex = 22
        Me.z2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'y2
        '
        Me.y2.Enabled = False
        Me.y2.Location = New System.Drawing.Point(85, 47)
        Me.y2.Name = "y2"
        Me.y2.Size = New System.Drawing.Size(56, 20)
        Me.y2.TabIndex = 20
        Me.y2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'x2
        '
        Me.x2.Enabled = False
        Me.x2.Location = New System.Drawing.Point(8, 47)
        Me.x2.Name = "x2"
        Me.x2.Size = New System.Drawing.Size(56, 20)
        Me.x2.TabIndex = 18
        Me.x2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'xx2
        '
        Me.xx2.AutoSize = True
        Me.xx2.Enabled = False
        Me.xx2.Location = New System.Drawing.Point(68, 54)
        Me.xx2.Name = "xx2"
        Me.xx2.Size = New System.Drawing.Size(12, 13)
        Me.xx2.TabIndex = 16
        Me.xx2.Text = "x"
        '
        'yy2
        '
        Me.yy2.AutoSize = True
        Me.yy2.Enabled = False
        Me.yy2.Location = New System.Drawing.Point(148, 54)
        Me.yy2.Name = "yy2"
        Me.yy2.Size = New System.Drawing.Size(12, 13)
        Me.yy2.TabIndex = 17
        Me.yy2.Text = "y"
        '
        'sd1
        '
        Me.sd1.Location = New System.Drawing.Point(341, 22)
        Me.sd1.Name = "sd1"
        Me.sd1.Size = New System.Drawing.Size(57, 20)
        Me.sd1.TabIndex = 15
        Me.sd1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ssd1
        '
        Me.ssd1.AutoSize = True
        Me.ssd1.Location = New System.Drawing.Point(322, 25)
        Me.ssd1.Name = "ssd1"
        Me.ssd1.Size = New System.Drawing.Size(13, 13)
        Me.ssd1.TabIndex = 14
        Me.ssd1.Text = "="
        '
        'uu1
        '
        Me.uu1.AutoSize = True
        Me.uu1.Enabled = False
        Me.uu1.Location = New System.Drawing.Point(306, 28)
        Me.uu1.Name = "uu1"
        Me.uu1.Size = New System.Drawing.Size(13, 13)
        Me.uu1.TabIndex = 12
        Me.uu1.Text = "u"
        '
        'zz1
        '
        Me.zz1.AutoSize = True
        Me.zz1.Enabled = False
        Me.zz1.Location = New System.Drawing.Point(228, 28)
        Me.zz1.Name = "zz1"
        Me.zz1.Size = New System.Drawing.Size(12, 13)
        Me.zz1.TabIndex = 10
        Me.zz1.Text = "z"
        '
        'u1
        '
        Me.u1.Enabled = False
        Me.u1.Location = New System.Drawing.Point(246, 21)
        Me.u1.Name = "u1"
        Me.u1.Size = New System.Drawing.Size(56, 20)
        Me.u1.TabIndex = 13
        Me.u1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'z1
        '
        Me.z1.Enabled = False
        Me.z1.Location = New System.Drawing.Point(166, 21)
        Me.z1.Name = "z1"
        Me.z1.Size = New System.Drawing.Size(56, 20)
        Me.z1.TabIndex = 12
        Me.z1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'y1
        '
        Me.y1.Enabled = False
        Me.y1.Location = New System.Drawing.Point(85, 21)
        Me.y1.Name = "y1"
        Me.y1.Size = New System.Drawing.Size(56, 20)
        Me.y1.TabIndex = 11
        Me.y1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'x1
        '
        Me.x1.Location = New System.Drawing.Point(8, 21)
        Me.x1.Name = "x1"
        Me.x1.Size = New System.Drawing.Size(56, 20)
        Me.x1.TabIndex = 10
        Me.x1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtResult
        '
        Me.txtResult.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResult.Location = New System.Drawing.Point(12, 282)
        Me.txtResult.Multiline = True
        Me.txtResult.Name = "txtResult"
        Me.txtResult.ReadOnly = True
        Me.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtResult.Size = New System.Drawing.Size(409, 168)
        Me.txtResult.TabIndex = 39
        '
        'dgvResult
        '
        Me.dgvResult.AllowUserToAddRows = False
        Me.dgvResult.AllowUserToDeleteRows = False
        Me.dgvResult.AllowUserToOrderColumns = True
        Me.dgvResult.AllowUserToResizeRows = False
        Me.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResult.Location = New System.Drawing.Point(427, 225)
        Me.dgvResult.Name = "dgvResult"
        Me.dgvResult.ReadOnly = True
        Me.dgvResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvResult.ShowCellErrors = False
        Me.dgvResult.ShowEditingIcon = False
        Me.dgvResult.ShowRowErrors = False
        Me.dgvResult.Size = New System.Drawing.Size(241, 225)
        Me.dgvResult.TabIndex = 40
        '
        'lblResult
        '
        Me.lblResult.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.Location = New System.Drawing.Point(10, 225)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(411, 54)
        Me.lblResult.TabIndex = 41
        Me.lblResult.Text = "RESULTO"
        '
        'frmJacobiGSeidel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 462)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.dgvResult)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmJacobiGSeidel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jacobi / Gauss-Seidel"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.dgvResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents xx1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtMaxIter As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPrec As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rBrowser As System.Windows.Forms.RadioButton
    Friend WithEvents rAppText As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents bJacobi As System.Windows.Forms.Button
    Friend WithEvents bGSeidel As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents tbU As System.Windows.Forms.TextBox
    Friend WithEvents ttbU As System.Windows.Forms.Label
    Friend WithEvents tbZ As System.Windows.Forms.TextBox
    Friend WithEvents ttbZ As System.Windows.Forms.Label
    Friend WithEvents tbY As System.Windows.Forms.TextBox
    Friend WithEvents yy1 As System.Windows.Forms.Label
    Friend WithEvents tbX As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents ttbY As System.Windows.Forms.Label
    Friend WithEvents ttbX As System.Windows.Forms.Label
    Friend WithEvents uu1 As System.Windows.Forms.Label
    Friend WithEvents zz1 As System.Windows.Forms.Label
    Friend WithEvents u1 As System.Windows.Forms.TextBox
    Friend WithEvents z1 As System.Windows.Forms.TextBox
    Friend WithEvents y1 As System.Windows.Forms.TextBox
    Friend WithEvents x1 As System.Windows.Forms.TextBox
    Friend WithEvents sd4 As System.Windows.Forms.TextBox
    Friend WithEvents ssd4 As System.Windows.Forms.Label
    Friend WithEvents uu4 As System.Windows.Forms.Label
    Friend WithEvents zz4 As System.Windows.Forms.Label
    Friend WithEvents u4 As System.Windows.Forms.TextBox
    Friend WithEvents z4 As System.Windows.Forms.TextBox
    Friend WithEvents y4 As System.Windows.Forms.TextBox
    Friend WithEvents x4 As System.Windows.Forms.TextBox
    Friend WithEvents xx4 As System.Windows.Forms.Label
    Friend WithEvents yy4 As System.Windows.Forms.Label
    Friend WithEvents sd3 As System.Windows.Forms.TextBox
    Friend WithEvents ssd3 As System.Windows.Forms.Label
    Friend WithEvents uu3 As System.Windows.Forms.Label
    Friend WithEvents zz3 As System.Windows.Forms.Label
    Friend WithEvents u3 As System.Windows.Forms.TextBox
    Friend WithEvents z3 As System.Windows.Forms.TextBox
    Friend WithEvents y3 As System.Windows.Forms.TextBox
    Friend WithEvents x3 As System.Windows.Forms.TextBox
    Friend WithEvents xx3 As System.Windows.Forms.Label
    Friend WithEvents yy3 As System.Windows.Forms.Label
    Friend WithEvents sd2 As System.Windows.Forms.TextBox
    Friend WithEvents ssd2 As System.Windows.Forms.Label
    Friend WithEvents uu2 As System.Windows.Forms.Label
    Friend WithEvents zz2 As System.Windows.Forms.Label
    Friend WithEvents u2 As System.Windows.Forms.TextBox
    Friend WithEvents z2 As System.Windows.Forms.TextBox
    Friend WithEvents y2 As System.Windows.Forms.TextBox
    Friend WithEvents x2 As System.Windows.Forms.TextBox
    Friend WithEvents xx2 As System.Windows.Forms.Label
    Friend WithEvents yy2 As System.Windows.Forms.Label
    Friend WithEvents sd1 As System.Windows.Forms.TextBox
    Friend WithEvents ssd1 As System.Windows.Forms.Label
    Friend WithEvents txtResult As System.Windows.Forms.TextBox
    Friend WithEvents rUse4 As System.Windows.Forms.RadioButton
    Friend WithEvents rUse3 As System.Windows.Forms.RadioButton
    Friend WithEvents rUse2 As System.Windows.Forms.RadioButton
    Friend WithEvents rUse1 As System.Windows.Forms.RadioButton
    Friend WithEvents dgvResult As System.Windows.Forms.DataGridView
    Friend WithEvents lblResult As System.Windows.Forms.Label
End Class
