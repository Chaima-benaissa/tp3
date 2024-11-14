<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        list = New ComboBox()
        rb1 = New RadioButton()
        rb2 = New RadioButton()
        rb3 = New RadioButton()
        b1 = New CheckBox()
        b2 = New CheckBox()
        b3 = New CheckBox()
        b4 = New CheckBox()
        btn = New Button()
        SuspendLayout()
        ' 
        ' list
        ' 
        list.FormattingEnabled = True
        list.Items.AddRange(New Object() {"petit", "moyenne", "grande"})
        list.Location = New Point(138, 66)
        list.Name = "list"
        list.Size = New Size(151, 28)
        list.TabIndex = 0
        ' 
        ' rb1
        ' 
        rb1.AutoSize = True
        rb1.BackColor = Color.MistyRose
        rb1.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        rb1.ForeColor = Color.DarkRed
        rb1.Location = New Point(12, 149)
        rb1.Name = "rb1"
        rb1.Size = New Size(114, 27)
        rb1.TabIndex = 1
        rb1.TabStop = True
        rb1.Text = "croute fine"
        rb1.UseVisualStyleBackColor = False
        ' 
        ' rb2
        ' 
        rb2.AutoSize = True
        rb2.BackColor = Color.MistyRose
        rb2.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        rb2.ForeColor = Color.DarkRed
        rb2.Location = New Point(150, 149)
        rb2.Name = "rb2"
        rb2.Size = New Size(153, 27)
        rb2.TabIndex = 2
        rb2.TabStop = True
        rb2.Text = "croute classique"
        rb2.UseVisualStyleBackColor = False
        ' 
        ' rb3
        ' 
        rb3.AutoSize = True
        rb3.BackColor = Color.MistyRose
        rb3.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        rb3.ForeColor = Color.DarkRed
        rb3.Location = New Point(317, 149)
        rb3.Name = "rb3"
        rb3.Size = New Size(140, 27)
        rb3.TabIndex = 3
        rb3.TabStop = True
        rb3.Text = "croute épaisse"
        rb3.UseVisualStyleBackColor = False
        ' 
        ' b1
        ' 
        b1.AutoSize = True
        b1.BackColor = Color.MistyRose
        b1.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        b1.ForeColor = Color.DarkRed
        b1.Location = New Point(69, 221)
        b1.Name = "b1"
        b1.Size = New Size(129, 27)
        b1.TabIndex = 4
        b1.Text = "champigions"
        b1.UseVisualStyleBackColor = False
        ' 
        ' b2
        ' 
        b2.AutoSize = True
        b2.BackColor = Color.MistyRose
        b2.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        b2.ForeColor = Color.DarkRed
        b2.Location = New Point(69, 280)
        b2.Name = "b2"
        b2.Size = New Size(75, 27)
        b2.TabIndex = 5
        b2.Text = "olives"
        b2.UseVisualStyleBackColor = False
        ' 
        ' b3
        ' 
        b3.AutoSize = True
        b3.BackColor = Color.MistyRose
        b3.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        b3.ForeColor = Color.DarkRed
        b3.Location = New Point(69, 327)
        b3.Name = "b3"
        b3.Size = New Size(98, 27)
        b3.TabIndex = 6
        b3.Text = "poivrons"
        b3.UseVisualStyleBackColor = False
        ' 
        ' b4
        ' 
        b4.AutoSize = True
        b4.BackColor = Color.MistyRose
        b4.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        b4.ForeColor = Color.DarkRed
        b4.Location = New Point(69, 377)
        b4.Name = "b4"
        b4.Size = New Size(215, 27)
        b4.TabIndex = 7
        b4.Text = "fromage supplimentaire"
        b4.UseVisualStyleBackColor = False
        ' 
        ' btn
        ' 
        btn.BackColor = Color.Salmon
        btn.Font = New Font("Harlow Solid Italic", 10.8F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btn.Location = New Point(150, 410)
        btn.Name = "btn"
        btn.Size = New Size(242, 68)
        btn.TabIndex = 8
        btn.Text = "afficher la commande"
        btn.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MistyRose
        ClientSize = New Size(709, 490)
        Controls.Add(b3)
        Controls.Add(b1)
        Controls.Add(b2)
        Controls.Add(b4)
        Controls.Add(btn)
        Controls.Add(rb3)
        Controls.Add(rb2)
        Controls.Add(rb1)
        Controls.Add(list)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents list As ComboBox
    Friend WithEvents rb1 As RadioButton
    Friend WithEvents rb2 As RadioButton
    Friend WithEvents rb3 As RadioButton
    Friend WithEvents b1 As CheckBox
    Friend WithEvents b2 As CheckBox
    Friend WithEvents b3 As CheckBox
    Friend WithEvents b4 As CheckBox
    Friend WithEvents btn As Button

End Class
