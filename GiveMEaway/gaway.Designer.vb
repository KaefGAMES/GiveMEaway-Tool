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
        Me.typekeyhere = New System.Windows.Forms.Label()
        Me.addkey = New System.Windows.Forms.Button()
        Me.avkeystxt = New System.Windows.Forms.Label()
        Me.remkey = New System.Windows.Forms.Button()
        Me.version = New System.Windows.Forms.Label()
        Me.aviablekeys = New System.Windows.Forms.ListBox()
        Me.clearlist = New System.Windows.Forms.Button()
        Me.copytoclip = New System.Windows.Forms.Button()
        Me.chooserandom = New System.Windows.Forms.Button()
        Me.randomtooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.copytoclipb = New System.Windows.Forms.ToolTip(Me.components)
        Me.opensettings = New System.Windows.Forms.Button()
        Me.remlist = New System.Windows.Forms.ToolTip(Me.components)
        Me.playsoundtooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.remkeytooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.addkeytooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.keyboxtooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.plusbtt = New System.Windows.Forms.Button()
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
        Me.keybox.Size = New System.Drawing.Size(256, 20)
        Me.keybox.TabIndex = 1
        Me.keyboxtooltip.SetToolTip(Me.keybox, "Tippe deinen Key hier ein um Ihn der Liste hinzuzufügen.")
        '
        'typekeyhere
        '
        Me.typekeyhere.AutoSize = True
        Me.typekeyhere.Location = New System.Drawing.Point(146, 15)
        Me.typekeyhere.Name = "typekeyhere"
        Me.typekeyhere.Size = New System.Drawing.Size(94, 13)
        Me.typekeyhere.TabIndex = 2
        Me.typekeyhere.Text = "Key hier eintippen:"
        '
        'addkey
        '
        Me.addkey.Location = New System.Drawing.Point(13, 24)
        Me.addkey.Name = "addkey"
        Me.addkey.Size = New System.Drawing.Size(127, 38)
        Me.addkey.TabIndex = 3
        Me.addkey.Text = "Key hinzufügen"
        Me.addkeytooltip.SetToolTip(Me.addkey, "Fügt einen neuen Key aus der Textbox zur Liste hinzu." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Speichert die Liste anschl" &
        "ießend in der Keys.txt")
        Me.addkey.UseVisualStyleBackColor = True
        '
        'avkeystxt
        '
        Me.avkeystxt.AutoSize = True
        Me.avkeystxt.Location = New System.Drawing.Point(13, 152)
        Me.avkeystxt.Name = "avkeystxt"
        Me.avkeystxt.Size = New System.Drawing.Size(88, 13)
        Me.avkeystxt.TabIndex = 6
        Me.avkeystxt.Text = "Verfügbare Keys:"
        '
        'remkey
        '
        Me.remkey.Location = New System.Drawing.Point(13, 70)
        Me.remkey.Name = "remkey"
        Me.remkey.Size = New System.Drawing.Size(127, 38)
        Me.remkey.TabIndex = 8
        Me.remkey.Text = "Key entfernen"
        Me.remkeytooltip.SetToolTip(Me.remkey, "Entfernt die aktuelle Auswahl aus der Liste und aus der Keys.txt")
        Me.remkey.UseVisualStyleBackColor = True
        '
        'version
        '
        Me.version.AutoSize = True
        Me.version.Location = New System.Drawing.Point(265, 152)
        Me.version.Name = "version"
        Me.version.Size = New System.Drawing.Size(154, 13)
        Me.version.TabIndex = 11
        Me.version.Text = "Version 0.0.7 - Stable Any CPU"
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
        'clearlist
        '
        Me.clearlist.Location = New System.Drawing.Point(12, 114)
        Me.clearlist.Name = "clearlist"
        Me.clearlist.Size = New System.Drawing.Size(127, 22)
        Me.clearlist.TabIndex = 14
        Me.clearlist.Text = "Liste leeren"
        Me.remlist.SetToolTip(Me.clearlist, "Leert die komplette Liste.")
        Me.clearlist.UseVisualStyleBackColor = True
        '
        'copytoclip
        '
        Me.copytoclip.Location = New System.Drawing.Point(118, 153)
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
        Me.randomtooltip.SetToolTip(Me.chooserandom, resources.GetString("chooserandom.ToolTip"))
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
        'opensettings
        '
        Me.opensettings.Location = New System.Drawing.Point(301, 114)
        Me.opensettings.Name = "opensettings"
        Me.opensettings.Size = New System.Drawing.Size(127, 22)
        Me.opensettings.TabIndex = 18
        Me.opensettings.Text = "Einstellungen"
        Me.copytoclipb.SetToolTip(Me.opensettings, "Kopiert deine Auswahl aus der Liste in die Zwischenablage. (STRG+C)")
        Me.opensettings.UseVisualStyleBackColor = True
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
        'remkeytooltip
        '
        Me.remkeytooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.remkeytooltip.ToolTipTitle = "So funktioniert's:"
        '
        'addkeytooltip
        '
        Me.addkeytooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.addkeytooltip.ToolTipTitle = "So funktioniert's:"
        '
        'keyboxtooltip
        '
        Me.keyboxtooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.keyboxtooltip.ToolTipTitle = "So funktioniert's:"
        '
        'plusbtt
        '
        Me.plusbtt.Location = New System.Drawing.Point(408, 34)
        Me.plusbtt.Name = "plusbtt"
        Me.plusbtt.Size = New System.Drawing.Size(20, 22)
        Me.plusbtt.TabIndex = 17
        Me.plusbtt.Text = "+"
        Me.plusbtt.UseVisualStyleBackColor = True
        '
        'gaway
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(441, 502)
        Me.Controls.Add(Me.opensettings)
        Me.Controls.Add(Me.plusbtt)
        Me.Controls.Add(Me.chooserandom)
        Me.Controls.Add(Me.copytoclip)
        Me.Controls.Add(Me.clearlist)
        Me.Controls.Add(Me.aviablekeys)
        Me.Controls.Add(Me.version)
        Me.Controls.Add(Me.remkey)
        Me.Controls.Add(Me.avkeystxt)
        Me.Controls.Add(Me.addkey)
        Me.Controls.Add(Me.typekeyhere)
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
    Friend WithEvents typekeyhere As Label
    Friend WithEvents addkey As Button
    Friend WithEvents avkeystxt As Label
    Friend WithEvents remkey As Button
    Friend WithEvents version As Label
    Friend WithEvents aviablekeys As ListBox
    Friend WithEvents clearlist As Button
    Friend WithEvents copytoclip As Button
    Friend WithEvents chooserandom As Button
    Friend WithEvents randomtooltip As ToolTip
    Friend WithEvents copytoclipb As ToolTip
    Friend WithEvents remlist As ToolTip
    Friend WithEvents playsoundtooltip As ToolTip
    Friend WithEvents remkeytooltip As ToolTip
    Friend WithEvents addkeytooltip As ToolTip
    Friend WithEvents keyboxtooltip As ToolTip
    Friend WithEvents plusbtt As Button
    Friend WithEvents opensettings As Button
End Class
