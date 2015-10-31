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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.cancelbtt = New System.Windows.Forms.Button()
        Me.Downloadbtt = New System.Windows.Forms.Button()
        Me.pbar = New System.Windows.Forms.ProgressBar()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cancelbtt
        '
        Me.cancelbtt.Location = New System.Drawing.Point(12, 188)
        Me.cancelbtt.Name = "cancelbtt"
        Me.cancelbtt.Size = New System.Drawing.Size(138, 44)
        Me.cancelbtt.TabIndex = 0
        Me.cancelbtt.Text = "Download abbrechen"
        Me.cancelbtt.UseVisualStyleBackColor = True
        '
        'Downloadbtt
        '
        Me.Downloadbtt.Location = New System.Drawing.Point(12, 138)
        Me.Downloadbtt.Name = "Downloadbtt"
        Me.Downloadbtt.Size = New System.Drawing.Size(138, 44)
        Me.Downloadbtt.TabIndex = 1
        Me.Downloadbtt.Text = "Download starten"
        Me.Downloadbtt.UseVisualStyleBackColor = True
        '
        'pbar
        '
        Me.pbar.Location = New System.Drawing.Point(156, 161)
        Me.pbar.Name = "pbar"
        Me.pbar.Size = New System.Drawing.Size(431, 43)
        Me.pbar.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(138, 120)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(198, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(342, 39)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "GiveMEupdate-Tool"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(263, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(211, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Weil's so einfach sein kann..."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(599, 248)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pbar)
        Me.Controls.Add(Me.Downloadbtt)
        Me.Controls.Add(Me.cancelbtt)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(615, 287)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(615, 287)
        Me.Name = "Form1"
        Me.Text = "GiveMEupdate by KaefGAMES-Entertainment"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cancelbtt As Button
    Friend WithEvents Downloadbtt As Button
    Friend WithEvents pbar As ProgressBar
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
