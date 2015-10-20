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
        Me.components = New System.ComponentModel.Container()
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
        Me.copytoclip = New System.Windows.Forms.Button()
        Me.chooserandom = New System.Windows.Forms.Button()
        Me.randomtooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.copytoclipb = New System.Windows.Forms.ToolTip(Me.components)
        Me.remlist = New System.Windows.Forms.ToolTip(Me.components)
        Me.playsoundtooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'playsound
        '
        Me.playsound.Location = New System.Drawing.Point(301, 70)
        Me.playsound.Name = "playsound"
        Me.playsound.Size = New System.Drawing.Size(128, 38)
        Me.playsound.TabIndex = 0
        Me.playsound.Text = "Play Sound :3"
        Me.playsoundtooltip.SetToolTip(Me.playsound, "Spielt den ""standard"" Sound ab. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Siehe dazu: Sounds\default.wav)")
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
        Me.version.Location = New System.Drawing.Point(269, 163)
        Me.version.Name = "version"
        Me.version.Size = New System.Drawing.Size(163, 13)
        Me.version.TabIndex = 11
        Me.version.Text = "Version 0.0.6.1 - Stable Any CPU"
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
        Me.remlist.SetToolTip(Me.Button1, "Leert die komplette Liste.")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'copytoclip
        '
        Me.copytoclip.Location = New System.Drawing.Point(130, 153)
        Me.copytoclip.Name = "copytoclip"
        Me.copytoclip.Size = New System.Drawing.Size(127, 22)
        Me.copytoclip.TabIndex = 15
        Me.copytoclip.Text = "Auswahl kopieren"
        Me.copytoclipb.SetToolTip(Me.copytoclip, "Kopiert deine Auswahl aus der Liste in die Zwischenablage. (STRG+C)")
        Me.copytoclip.UseVisualStyleBackColor = True
        '
        'chooserandom
        '
        Me.chooserandom.Location = New System.Drawing.Point(146, 70)
        Me.chooserandom.Name = "chooserandom"
        Me.chooserandom.Size = New System.Drawing.Size(127, 38)
        Me.chooserandom.TabIndex = 16
        Me.chooserandom.Text = "GiveMErandom"
        Me.randomtooltip.SetToolTip(Me.chooserandom, "Wählt einen zufälligen Key aus der Liste aus und spielt dabei einen Sound ab." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "De" &
        "r ausgewählte Key wird direkt in die Zwischenablage (STRG+C) kopiert und kann" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "v" &
        "erschickt werden.")
        Me.chooserandom.UseVisualStyleBackColor = True
        '
        'randomtooltip
        '
        Me.randomtooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.randomtooltip.ToolTipTitle = "So funktioniert's:"
        '
        'copytoclipb
        '
        Me.copytoclipb.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.copytoclipb.ToolTipTitle = "So funktioniert's:"
        '
        'remlist
        '
        Me.remlist.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.remlist.ToolTipTitle = "So funktioniert's:"
        '
        'playsoundtooltip
        '
        Me.playsoundtooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.playsoundtooltip.ToolTipTitle = "So funktioniert's:"
        '
        'gaway
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(441, 502)
        Me.Controls.Add(Me.chooserandom)
        Me.Controls.Add(Me.copytoclip)
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
    Friend WithEvents copytoclip As Button
    Friend WithEvents chooserandom As Button
    Friend WithEvents randomtooltip As ToolTip
    Friend WithEvents copytoclipb As ToolTip
    Friend WithEvents remlist As ToolTip
    Friend WithEvents playsoundtooltip As ToolTip
End Class
