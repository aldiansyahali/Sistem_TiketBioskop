<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Hapus_Film
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelNamaFilm = New System.Windows.Forms.Label()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(105, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(192, 34)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Hapus Film"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(24, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(351, 28)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Yakin ingin menghapus koleksi film ini?"
        '
        'LabelNamaFilm
        '
        Me.LabelNamaFilm.AutoSize = True
        Me.LabelNamaFilm.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelNamaFilm.ForeColor = System.Drawing.Color.Red
        Me.LabelNamaFilm.Location = New System.Drawing.Point(128, 168)
        Me.LabelNamaFilm.Name = "LabelNamaFilm"
        Me.LabelNamaFilm.Size = New System.Drawing.Size(126, 31)
        Me.LabelNamaFilm.TabIndex = 16
        Me.LabelNamaFilm.Text = "Nama Film"
        '
        'BtnHapus
        '
        Me.BtnHapus.Location = New System.Drawing.Point(144, 257)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(94, 39)
        Me.BtnHapus.TabIndex = 17
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'Hapus_Film
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 330)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.LabelNamaFilm)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Name = "Hapus_Film"
        Me.Text = "Hapus_Film"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelNamaFilm As Label
    Friend WithEvents BtnHapus As Button
End Class
