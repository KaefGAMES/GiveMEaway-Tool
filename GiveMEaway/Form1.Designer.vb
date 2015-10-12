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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.chooserandom = New System.Windows.Forms.Button()
        Me.keybox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.addkey = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.aviablekeys = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.keynr = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gversion = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'chooserandom
        '
        Me.chooserandom.Location = New System.Drawing.Point(287, 120)
        Me.chooserandom.Name = "chooserandom"
        Me.chooserandom.Size = New System.Drawing.Size(128, 24)
        Me.chooserandom.TabIndex = 0
        Me.chooserandom.Text = "Play Sound :3"
        Me.chooserandom.UseVisualStyleBackColor = True
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
        'aviablekeys
        '
        Me.aviablekeys.AcceptsTab = True
        Me.aviablekeys.AutoWordSelection = True
        Me.aviablekeys.DetectUrls = False
        Me.aviablekeys.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aviablekeys.Location = New System.Drawing.Point(12, 168)
        Me.aviablekeys.Name = "aviablekeys"
        Me.aviablekeys.ReadOnly = True
        Me.aviablekeys.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.aviablekeys.ShowSelectionMargin = True
        Me.aviablekeys.Size = New System.Drawing.Size(417, 322)
        Me.aviablekeys.TabIndex = 7
        Me.aviablekeys.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 70)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 38)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Key entfernen"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'keynr
        '
        Me.keynr.Location = New System.Drawing.Point(145, 80)
        Me.keynr.Name = "keynr"
        Me.keynr.Size = New System.Drawing.Size(55, 20)
        Me.keynr.TabIndex = 9
        Me.keynr.WordWrap = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(146, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Key # angeben:"
        '
        'gversion
        '
        Me.gversion.AutoSize = True
        Me.gversion.Location = New System.Drawing.Point(275, 152)
        Me.gversion.Name = "gversion"
        Me.gversion.Size = New System.Drawing.Size(154, 13)
        Me.gversion.TabIndex = 11
        Me.gversion.Text = "Version 0.0.3 - Stable Any CPU"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(441, 502)
        Me.Controls.Add(Me.gversion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.keynr)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.aviablekeys)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.addkey)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.keybox)
        Me.Controls.Add(Me.chooserandom)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(457, 541)
        Me.MinimumSize = New System.Drawing.Size(457, 541)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GiveMEaway-Tool by KaefGAMES-Entertainment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chooserandom As Button
    Friend WithEvents keybox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents addkey As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents aviablekeys As RichTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents keynr As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents gversion As Label
End Class
