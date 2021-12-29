<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditStudio
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtHargaKursi = New System.Windows.Forms.TextBox()
        Me.TxtKapasitas = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(239, 161)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 29)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Simpan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TxtHargaKursi
        '
        Me.TxtHargaKursi.Location = New System.Drawing.Point(160, 109)
        Me.TxtHargaKursi.Name = "TxtHargaKursi"
        Me.TxtHargaKursi.Size = New System.Drawing.Size(174, 27)
        Me.TxtHargaKursi.TabIndex = 8
        '
        'TxtKapasitas
        '
        Me.TxtKapasitas.Location = New System.Drawing.Point(160, 63)
        Me.TxtKapasitas.Name = "TxtKapasitas"
        Me.TxtKapasitas.Size = New System.Drawing.Size(174, 27)
        Me.TxtKapasitas.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Harga Kursi"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Kapasitas"
        '
        'EditStudio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 261)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtHargaKursi)
        Me.Controls.Add(Me.TxtKapasitas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EditStudio"
        Me.Text = "EditStudio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TxtHargaKursi As TextBox
    Friend WithEvents TxtKapasitas As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
