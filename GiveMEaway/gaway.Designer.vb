<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class gaway
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(gaway))
        Me.playsound = New System.Windows.Forms.Button()
        Me.keybox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.addkey = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.remkey = New System.Windows.Forms.Button()
        Me.version = New System.Windows.Forms.Label()
        Me.aviablekeys = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'playsound
        '
        Me.playsound.Location = New System.Drawing.Point(301, 70)
        Me.playsound.Name = "playsound"
        Me.playsound.Size = New System.Drawing.Size(128, 38)
        Me.playsound.TabIndex = 0
        Me.playsound.Text = "Play Sound :3"
        Me.playsound.UseVisualStyleBackColor = True
        '
        'keybox
        '
        Me.keybox.Location = New System.Drawing.Point(146, 35)
        Me.keybox.Name = "keybox"
        Me.keybox.Size = New System.Drawing.Size(283, 20)
        Me.keybox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(146, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Key hier eintippen:"
        '
        'addkey
        '
        Me.addkey.Location = New System.Drawing.Point(13, 24)
        Me.addkey.Name = "addkey"
        Me.addkey.Size = New System.Drawing.Size(127, 38)
        Me.addkey.TabIndex = 3
        Me.addkey.Text = "Key hinzufügen"
        Me.addkey.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Verfügbare Keys:"
        '
        'remkey
        '
        Me.remkey.Location = New System.Drawing.Point(13, 70)
        Me.remkey.Name = "remkey"
        Me.remkey.Size = New System.Drawing.Size(127, 38)
        Me.remkey.TabIndex = 8
        Me.remkey.Text = "Key entfernen"
        Me.remkey.UseVisualStyleBackColor = True
        '
        'version
        '
        Me.version.AutoSize = True
        Me.version.Location = New System.Drawing.Point(275, 152)
        Me.version.Name = "version"
        Me.version.Size = New System.Drawing.Size(154, 13)
        Me.version.TabIndex = 11
        Me.version.Text = "Version 0.0.6 - Stable Any CPU"
        '
        'aviablekeys
        '
        Me.aviablekeys.FormattingEnabled = True
        Me.aviablekeys.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.aviablekeys.Location = New System.Drawing.Point(12, 181)
        Me.aviablekeys.Name = "aviablekeys"
        Me.aviablekeys.ScrollAlwaysVisible = True
        Me.aviablekeys.Size = New System.Drawing.Size(417, 303)
        Me.aviablekeys.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 114)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 22)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Liste leeren"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'gaway
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(441, 502)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.aviablekeys)
        Me.Controls.Add(Me.version)
        Me.Controls.Add(Me.remkey)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.addkey)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.keybox)
        Me.Controls.Add(Me.playsound)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(457, 541)
        Me.MinimumSize = New System.Drawing.Size(457, 541)
        Me.Name = "gaway"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GiveMEaway-Tool by KaefGAMES-Entertainment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents playsound As Button
    Friend WithEvents keybox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents addkey As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents remkey As Button
    Friend WithEvents version As Label
    Friend WithEvents aviablekeys As ListBox
    Friend WithEvents Button1 As Button
End Class
