﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gsettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(gsettings))
        Me.save = New System.Windows.Forms.Button()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.langEN = New System.Windows.Forms.CheckBox()
        Me.langDE = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.playsyes = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.playsno = New System.Windows.Forms.CheckBox()
        Me.TabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'save
        '
        Me.save.Location = New System.Drawing.Point(260, 251)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(125, 22)
        Me.save.TabIndex = 0
        Me.save.Text = "Speichern"
        Me.save.UseVisualStyleBackColor = True
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.TabPage1)
        Me.TabControl.Controls.Add(Me.TabPage2)
        Me.TabControl.Controls.Add(Me.TabPage3)
        Me.TabControl.Location = New System.Drawing.Point(13, 13)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(372, 232)
        Me.TabControl.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Controls.Add(Me.langEN)
        Me.TabPage1.Controls.Add(Me.langDE)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(364, 206)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Sprache / Language"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(6, 134)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(352, 66)
        Me.TextBox1.TabIndex = 3
        '
        'langEN
        '
        Me.langEN.AutoSize = True
        Me.langEN.Location = New System.Drawing.Point(10, 59)
        Me.langEN.Name = "langEN"
        Me.langEN.Size = New System.Drawing.Size(111, 17)
        Me.langEN.TabIndex = 2
        Me.langEN.Text = "Englisch / English"
        Me.langEN.UseVisualStyleBackColor = True
        '
        'langDE
        '
        Me.langDE.AutoSize = True
        Me.langDE.Location = New System.Drawing.Point(10, 36)
        Me.langDE.Name = "langDE"
        Me.langDE.Size = New System.Drawing.Size(114, 17)
        Me.langDE.TabIndex = 1
        Me.langDE.Text = "Deutsch / German"
        Me.langDE.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Wähle eine Sprache / Choose a language"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TextBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(364, 206)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Anbieter / Host"
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(6, 86)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(351, 17)
        Me.TextBox2.TabIndex = 0
        Me.TextBox2.Text = "Noch nicht verfügbar!"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.playsno)
        Me.TabPage3.Controls.Add(Me.Label2)
        Me.TabPage3.Controls.Add(Me.playsyes)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(364, 206)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Sounds"
        '
        'playsyes
        '
        Me.playsyes.AutoSize = True
        Me.playsyes.Location = New System.Drawing.Point(10, 36)
        Me.playsyes.Name = "playsyes"
        Me.playsyes.Size = New System.Drawing.Size(47, 17)
        Me.playsyes.TabIndex = 0
        Me.playsyes.Text = "YES"
        Me.playsyes.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Sound abspielen / Play Sound"
        '
        'playsno
        '
        Me.playsno.AutoSize = True
        Me.playsno.Location = New System.Drawing.Point(10, 59)
        Me.playsno.Name = "playsno"
        Me.playsno.Size = New System.Drawing.Size(42, 17)
        Me.playsno.TabIndex = 2
        Me.playsno.Text = "NO"
        Me.playsno.UseVisualStyleBackColor = True
        '
        'gsettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 285)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.save)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(413, 324)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(413, 324)
        Me.Name = "gsettings"
        Me.Text = "GiveMEsettings"
        Me.TabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents save As Button
    Friend WithEvents TabControl As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents langEN As CheckBox
    Friend WithEvents langDE As CheckBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents playsyes As CheckBox
    Friend WithEvents playsno As CheckBox
End Class