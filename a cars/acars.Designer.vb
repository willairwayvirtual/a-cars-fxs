<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class acars
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.StFlight = New System.Windows.Forms.Button()
        Me.CompFlight = New System.Windows.Forms.Button()
        Me.PauseFlight = New System.Windows.Forms.Button()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblTimer = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(302, 13)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(230, 38)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(302, 79)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(230, 38)
        Me.TextBox2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(178, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 33)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = " FltNum"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(184, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 33)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "DeptAir"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, 123)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(819, 57)
        Me.DataGridView1.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Lime
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(559, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(260, 117)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "go"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'StFlight
        '
        Me.StFlight.BackColor = System.Drawing.Color.LightSalmon
        Me.StFlight.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StFlight.Location = New System.Drawing.Point(0, 284)
        Me.StFlight.Name = "StFlight"
        Me.StFlight.Size = New System.Drawing.Size(343, 51)
        Me.StFlight.TabIndex = 13
        Me.StFlight.Text = "start  Flight"
        Me.StFlight.UseVisualStyleBackColor = False
        '
        'CompFlight
        '
        Me.CompFlight.BackColor = System.Drawing.Color.Red
        Me.CompFlight.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CompFlight.Location = New System.Drawing.Point(348, 284)
        Me.CompFlight.Name = "CompFlight"
        Me.CompFlight.Size = New System.Drawing.Size(256, 51)
        Me.CompFlight.TabIndex = 14
        Me.CompFlight.Text = "Complete Flight"
        Me.CompFlight.UseVisualStyleBackColor = False
        '
        'PauseFlight
        '
        Me.PauseFlight.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PauseFlight.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PauseFlight.Location = New System.Drawing.Point(610, 284)
        Me.PauseFlight.Name = "PauseFlight"
        Me.PauseFlight.Size = New System.Drawing.Size(198, 51)
        Me.PauseFlight.TabIndex = 15
        Me.PauseFlight.Text = "pause"
        Me.PauseFlight.UseVisualStyleBackColor = False
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.BackColor = System.Drawing.Color.Red
        Me.Label71.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label71.Location = New System.Drawing.Point(120, 254)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(555, 20)
        Me.Label71.TabIndex = 16
        Me.Label71.Text = "Please put parking brake onAnd cut off your engine(s) before starting ACARS"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.lblTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.Location = New System.Drawing.Point(335, 181)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(176, 73)
        Me.lblTimer.TabIndex = 17
        Me.lblTimer.Text = "0:0:0"
        '
        'acars
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(813, 338)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.Label71)
        Me.Controls.Add(Me.PauseFlight)
        Me.Controls.Add(Me.CompFlight)
        Me.Controls.Add(Me.StFlight)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "acars"
        Me.Text = "a cars"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents StFlight As Button
    Friend WithEvents CompFlight As Button
    Friend WithEvents PauseFlight As Button
    Friend WithEvents Label71 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblTimer As Label
End Class
