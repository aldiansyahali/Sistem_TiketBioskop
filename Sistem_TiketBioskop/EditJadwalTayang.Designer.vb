<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditJadwalTayang
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
        Me.ComboBoxSelesai = New System.Windows.Forms.ComboBox()
        Me.ComboBoxMulai = New System.Windows.Forms.ComboBox()
        Me.ButtonTambah = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBoxStudio = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBoxFilm = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ComboBoxSelesai
        '
        Me.ComboBoxSelesai.FormattingEnabled = True
        Me.ComboBoxSelesai.Items.AddRange(New Object() {"15:50", "19:25", "22:15"})
        Me.ComboBoxSelesai.Location = New System.Drawing.Point(210, 361)
        Me.ComboBoxSelesai.Name = "ComboBoxSelesai"
        Me.ComboBoxSelesai.Size = New System.Drawing.Size(263, 28)
        Me.ComboBoxSelesai.TabIndex = 42
        '
        'ComboBoxMulai
        '
        Me.ComboBoxMulai.FormattingEnabled = True
        Me.ComboBoxMulai.Items.AddRange(New Object() {"13:00", "16:00", "19:30"})
        Me.ComboBoxMulai.Location = New System.Drawing.Point(210, 308)
        Me.ComboBoxMulai.Name = "ComboBoxMulai"
        Me.ComboBoxMulai.Size = New System.Drawing.Size(263, 28)
        Me.ComboBoxMulai.TabIndex = 41
        '
        'ButtonTambah
        '
        Me.ButtonTambah.Location = New System.Drawing.Point(379, 422)
        Me.ButtonTambah.Name = "ButtonTambah"
        Me.ButtonTambah.Size = New System.Drawing.Size(94, 29)
        Me.ButtonTambah.TabIndex = 40
        Me.ButtonTambah.Text = "Simpan"
        Me.ButtonTambah.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(56, 361)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 28)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Waktu Selesai"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(56, 304)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 28)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Waktu Mulai"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(210, 245)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(263, 27)
        Me.DateTimePicker1.TabIndex = 37
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(56, 243)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 28)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Tanggal"
        '
        'ComboBoxStudio
        '
        Me.ComboBoxStudio.FormattingEnabled = True
        Me.ComboBoxStudio.Location = New System.Drawing.Point(210, 186)
        Me.ComboBoxStudio.Name = "ComboBoxStudio"
        Me.ComboBoxStudio.Size = New System.Drawing.Size(263, 28)
        Me.ComboBoxStudio.TabIndex = 35
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(56, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 28)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Studio"
        '
        'ComboBoxFilm
        '
        Me.ComboBoxFilm.FormattingEnabled = True
        Me.ComboBoxFilm.Location = New System.Drawing.Point(210, 131)
        Me.ComboBoxFilm.Name = "ComboBoxFilm"
        Me.ComboBoxFilm.Size = New System.Drawing.Size(263, 28)
        Me.ComboBoxFilm.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(56, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 28)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Film"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(149, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 31)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Edit Jadwal Tayang"
        '
        'EditJadwalTayang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 550)
        Me.Controls.Add(Me.ComboBoxSelesai)
        Me.Controls.Add(Me.ComboBoxMulai)
        Me.Controls.Add(Me.ButtonTambah)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBoxStudio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBoxFilm)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EditJadwalTayang"
        Me.Text = "EditJadwalTayang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBoxSelesai As ComboBox
    Friend WithEvents ComboBoxMulai As ComboBox
    Friend WithEvents ButtonTambah As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBoxStudio As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBoxFilm As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
