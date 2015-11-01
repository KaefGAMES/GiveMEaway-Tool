<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mkey
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mkey))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Key1 = New System.Windows.Forms.TextBox()
        Me.key2 = New System.Windows.Forms.TextBox()
        Me.key3 = New System.Windows.Forms.TextBox()
        Me.key4 = New System.Windows.Forms.TextBox()
        Me.key5 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(0, 195)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(365, 48)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Keys hinzufügen"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(227, 24)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Mehrere Keys hinzufügen"
        '
        'Key1
        '
        Me.Key1.Location = New System.Drawing.Point(12, 46)
        Me.Key1.Name = "Key1"
        Me.Key1.Size = New System.Drawing.Size(341, 20)
        Me.Key1.TabIndex = 7
        '
        'key2
        '
        Me.key2.Location = New System.Drawing.Point(12, 72)
        Me.key2.Name = "key2"
        Me.key2.Size = New System.Drawing.Size(341, 20)
        Me.key2.TabIndex = 8
        '
        'key3
        '
        Me.key3.Location = New System.Drawing.Point(12, 98)
        Me.key3.Name = "key3"
        Me.key3.Size = New System.Drawing.Size(341, 20)
        Me.key3.TabIndex = 9
        '
        'key4
        '
        Me.key4.Location = New System.Drawing.Point(12, 124)
        Me.key4.Name = "key4"
        Me.key4.Size = New System.Drawing.Size(341, 20)
        Me.key4.TabIndex = 10
        '
        'key5
        '
        Me.key5.Location = New System.Drawing.Point(12, 150)
        Me.key5.Name = "key5"
        Me.key5.Size = New System.Drawing.Size(341, 20)
        Me.key5.TabIndex = 11
        '
        'Mkey
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 243)
        Me.Controls.Add(Me.key5)
        Me.Controls.Add(Me.key4)
        Me.Controls.Add(Me.key3)
        Me.Controls.Add(Me.key2)
        Me.Controls.Add(Me.Key1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(381, 282)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(381, 282)
        Me.Name = "Mkey"
        Me.Text = "GiveMEaway - GoMultiline"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Key1 As TextBox
    Friend WithEvents key2 As TextBox
    Friend WithEvents key3 As TextBox
    Friend WithEvents key4 As TextBox
    Friend WithEvents key5 As TextBox
End Class
