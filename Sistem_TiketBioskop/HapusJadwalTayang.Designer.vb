<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HapusJadwalTayang
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
        Me.ButtonHapus = New System.Windows.Forms.Button()
        Me.LabelJadwal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtonHapus
        '
        Me.ButtonHapus.Location = New System.Drawing.Point(166, 216)
        Me.ButtonHapus.Name = "ButtonHapus"
        Me.ButtonHapus.Size = New System.Drawing.Size(94, 29)
        Me.ButtonHapus.TabIndex = 5
        Me.ButtonHapus.Text = "Hapus"
        Me.ButtonHapus.UseVisualStyleBackColor = True
        '
        'LabelJadwal
        '
        Me.LabelJadwal.AutoSize = True
        Me.LabelJadwal.Font = New System.Drawing.Font("Segoe UI", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelJadwal.ForeColor = System.Drawing.Color.Red
        Me.LabelJadwal.Location = New System.Drawing.Point(183, 126)
        Me.LabelJadwal.Name = "LabelJadwal"
        Me.LabelJadwal.Size = New System.Drawing.Size(54, 62)
        Me.LabelJadwal.TabIndex = 4
        Me.LabelJadwal.Text = "1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(30, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(369, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Apakah Anda Ingin Menghapus Jadwal Tayang"
        '
        'HapusJadwalTayang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 319)
        Me.Controls.Add(Me.ButtonHapus)
        Me.Controls.Add(Me.LabelJadwal)
        Me.Controls.Add(Me.Label1)
        Me.Name = "HapusJadwalTayang"
        Me.Text = "HapusJadwalTayang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonHapus As Button
    Friend WithEvents LabelJadwal As Label
    Friend WithEvents Label1 As Label
End Class
