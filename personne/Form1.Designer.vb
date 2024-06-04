<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.OBR = New System.Windows.Forms.Label()
        Me.IMR = New System.Windows.Forms.Label()
        Me.RF = New System.Windows.Forms.RadioButton()
        Me.RM = New System.Windows.Forms.RadioButton()
        Me.CTC = New System.Windows.Forms.ComboBox()
        Me.CTM = New System.Windows.Forms.ComboBox()
        Me.CPG = New System.Windows.Forms.ComboBox()
        Me.CPKG = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BTNPROPOS = New System.Windows.Forms.Button()
        Me.BTNQUITTER = New System.Windows.Forms.Button()
        Me.BTNRAZ = New System.Windows.Forms.Button()
        Me.BTNTEST = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LDATE = New System.Windows.Forms.Label()
        Me.LHEURE = New System.Windows.Forms.Label()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.OBR)
        Me.GroupBox1.Controls.Add(Me.IMR)
        Me.GroupBox1.Controls.Add(Me.RF)
        Me.GroupBox1.Controls.Add(Me.RM)
        Me.GroupBox1.Controls.Add(Me.CTC)
        Me.GroupBox1.Controls.Add(Me.CTM)
        Me.GroupBox1.Controls.Add(Me.CPG)
        Me.GroupBox1.Controls.Add(Me.CPKG)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(38, 19)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(879, 396)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'OBR
        '
        Me.OBR.AutoSize = True
        Me.OBR.Location = New System.Drawing.Point(209, 360)
        Me.OBR.Name = "OBR"
        Me.OBR.Size = New System.Drawing.Size(61, 15)
        Me.OBR.TabIndex = 14
        Me.OBR.Text = "Label7"
        Me.OBR.Visible = False
        '
        'IMR
        '
        Me.IMR.AutoSize = True
        Me.IMR.Location = New System.Drawing.Point(209, 311)
        Me.IMR.Name = "IMR"
        Me.IMR.Size = New System.Drawing.Size(61, 15)
        Me.IMR.TabIndex = 13
        Me.IMR.Text = "Label6"
        Me.IMR.Visible = False
        '
        'RF
        '
        Me.RF.AutoSize = True
        Me.RF.Font = New System.Drawing.Font("Algerian", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RF.Location = New System.Drawing.Point(287, 149)
        Me.RF.Margin = New System.Windows.Forms.Padding(4)
        Me.RF.Name = "RF"
        Me.RF.Size = New System.Drawing.Size(39, 25)
        Me.RF.TabIndex = 12
        Me.RF.TabStop = True
        Me.RF.Text = "F"
        Me.RF.UseVisualStyleBackColor = True
        '
        'RM
        '
        Me.RM.AutoSize = True
        Me.RM.Font = New System.Drawing.Font("Algerian", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RM.Location = New System.Drawing.Point(170, 149)
        Me.RM.Margin = New System.Windows.Forms.Padding(4)
        Me.RM.Name = "RM"
        Me.RM.Size = New System.Drawing.Size(43, 25)
        Me.RM.TabIndex = 11
        Me.RM.TabStop = True
        Me.RM.Text = "M"
        Me.RM.UseVisualStyleBackColor = True
        '
        'CTC
        '
        Me.CTC.FormattingEnabled = True
        Me.CTC.Location = New System.Drawing.Point(287, 260)
        Me.CTC.Margin = New System.Windows.Forms.Padding(4)
        Me.CTC.MaxLength = 2
        Me.CTC.Name = "CTC"
        Me.CTC.Size = New System.Drawing.Size(118, 23)
        Me.CTC.TabIndex = 10
        '
        'CTM
        '
        Me.CTM.FormattingEnabled = True
        Me.CTM.Location = New System.Drawing.Point(170, 260)
        Me.CTM.Margin = New System.Windows.Forms.Padding(4)
        Me.CTM.Name = "CTM"
        Me.CTM.Size = New System.Drawing.Size(118, 23)
        Me.CTM.TabIndex = 9
        '
        'CPG
        '
        Me.CPG.FormattingEnabled = True
        Me.CPG.Location = New System.Drawing.Point(287, 199)
        Me.CPG.Margin = New System.Windows.Forms.Padding(4)
        Me.CPG.MaxLength = 2
        Me.CPG.Name = "CPG"
        Me.CPG.Size = New System.Drawing.Size(118, 23)
        Me.CPG.TabIndex = 8
        '
        'CPKG
        '
        Me.CPKG.FormattingEnabled = True
        Me.CPKG.Location = New System.Drawing.Point(170, 199)
        Me.CPKG.Margin = New System.Windows.Forms.Padding(4)
        Me.CPKG.Name = "CPKG"
        Me.CPKG.Size = New System.Drawing.Size(118, 23)
        Me.CPKG.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 360)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 15)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "OBSERVATION"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 311)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "INDICE DE MASSE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 262)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "TAILLE ( M )"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 208)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "POID ( KG )"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 156)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "SEXE"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BTNPROPOS)
        Me.GroupBox3.Controls.Add(Me.BTNQUITTER)
        Me.GroupBox3.Controls.Add(Me.BTNRAZ)
        Me.GroupBox3.Controls.Add(Me.BTNTEST)
        Me.GroupBox3.Location = New System.Drawing.Point(563, 27)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(300, 214)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "OPTION"
        '
        'BTNPROPOS
        '
        Me.BTNPROPOS.Enabled = False
        Me.BTNPROPOS.Location = New System.Drawing.Point(9, 161)
        Me.BTNPROPOS.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNPROPOS.Name = "BTNPROPOS"
        Me.BTNPROPOS.Size = New System.Drawing.Size(282, 40)
        Me.BTNPROPOS.TabIndex = 3
        Me.BTNPROPOS.Text = "A PROPOS"
        Me.BTNPROPOS.UseVisualStyleBackColor = True
        '
        'BTNQUITTER
        '
        Me.BTNQUITTER.Location = New System.Drawing.Point(9, 114)
        Me.BTNQUITTER.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNQUITTER.Name = "BTNQUITTER"
        Me.BTNQUITTER.Size = New System.Drawing.Size(282, 40)
        Me.BTNQUITTER.TabIndex = 2
        Me.BTNQUITTER.Text = "QUITTER"
        Me.BTNQUITTER.UseVisualStyleBackColor = True
        '
        'BTNRAZ
        '
        Me.BTNRAZ.Location = New System.Drawing.Point(9, 69)
        Me.BTNRAZ.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNRAZ.Name = "BTNRAZ"
        Me.BTNRAZ.Size = New System.Drawing.Size(282, 40)
        Me.BTNRAZ.TabIndex = 1
        Me.BTNRAZ.Text = "RAZ"
        Me.BTNRAZ.UseVisualStyleBackColor = True
        '
        'BTNTEST
        '
        Me.BTNTEST.Location = New System.Drawing.Point(9, 22)
        Me.BTNTEST.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNTEST.Name = "BTNTEST"
        Me.BTNTEST.Size = New System.Drawing.Size(282, 40)
        Me.BTNTEST.TabIndex = 0
        Me.BTNTEST.Text = "TESTER"
        Me.BTNTEST.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LDATE)
        Me.GroupBox2.Controls.Add(Me.LHEURE)
        Me.GroupBox2.Location = New System.Drawing.Point(27, 22)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(447, 98)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DATE ET HEURE"
        '
        'LDATE
        '
        Me.LDATE.AutoSize = True
        Me.LDATE.Font = New System.Drawing.Font("Algerian", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDATE.Location = New System.Drawing.Point(47, 46)
        Me.LDATE.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LDATE.Name = "LDATE"
        Me.LDATE.Size = New System.Drawing.Size(132, 21)
        Me.LDATE.TabIndex = 13
        Me.LDATE.Text = "30/04/ 2024"
        '
        'LHEURE
        '
        Me.LHEURE.AutoSize = True
        Me.LHEURE.Font = New System.Drawing.Font("Algerian", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LHEURE.Location = New System.Drawing.Point(284, 46)
        Me.LHEURE.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LHEURE.Name = "LHEURE"
        Me.LHEURE.Size = New System.Drawing.Size(94, 21)
        Me.LHEURE.TabIndex = 14
        Me.LHEURE.Text = "00:00:00"
        '
        'Timer
        '
        Me.Timer.Enabled = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCoral
        Me.ClientSize = New System.Drawing.Size(938, 444)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Algerian", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "INDICE DE MASSE CORPORELLE"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RF As System.Windows.Forms.RadioButton
    Friend WithEvents RM As System.Windows.Forms.RadioButton
    Friend WithEvents CTC As System.Windows.Forms.ComboBox
    Friend WithEvents CTM As System.Windows.Forms.ComboBox
    Friend WithEvents CPG As System.Windows.Forms.ComboBox
    Friend WithEvents CPKG As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents BTNPROPOS As System.Windows.Forms.Button
    Friend WithEvents BTNQUITTER As System.Windows.Forms.Button
    Friend WithEvents BTNRAZ As System.Windows.Forms.Button
    Friend WithEvents BTNTEST As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LHEURE As System.Windows.Forms.Label
    Friend WithEvents LDATE As System.Windows.Forms.Label
    Friend WithEvents OBR As System.Windows.Forms.Label
    Friend WithEvents IMR As System.Windows.Forms.Label
    Friend WithEvents Timer As System.Windows.Forms.Timer

End Class
