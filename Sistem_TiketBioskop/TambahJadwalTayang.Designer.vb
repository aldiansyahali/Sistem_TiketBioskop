<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahJadwalTayang
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBoxFilm = New System.Windows.Forms.ComboBox()
        Me.ComboBoxStudio = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtDetikMulai = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtMenitMulai = New System.Windows.Forms.TextBox()
        Me.TxtJamMulai = New System.Windows.Forms.TextBox()
        Me.TxtJamSelesai = New System.Windows.Forms.TextBox()
        Me.TxtMenitSelesai = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtDetikSelesai = New System.Windows.Forms.TextBox()
        Me.ButtonTambah = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(144, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(252, 31)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Tambah Jadwal Tayang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(51, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 28)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Film"
        '
        'ComboBoxFilm
        '
        Me.ComboBoxFilm.FormattingEnabled = True
        Me.ComboBoxFilm.Location = New System.Drawing.Point(205, 144)
        Me.ComboBoxFilm.Name = "ComboBoxFilm"
        Me.ComboBoxFilm.Size = New System.Drawing.Size(263, 28)
        Me.ComboBoxFilm.TabIndex = 9
        '
        'ComboBoxStudio
        '
        Me.ComboBoxStudio.FormattingEnabled = True
        Me.ComboBoxStudio.Location = New System.Drawing.Point(205, 199)
        Me.ComboBoxStudio.Name = "ComboBoxStudio"
        Me.ComboBoxStudio.Size = New System.Drawing.Size(263, 28)
        Me.ComboBoxStudio.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(51, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 28)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Studio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(51, 256)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 28)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Tanggal"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(51, 317)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 28)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Waktu Mulai"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(205, 258)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(263, 27)
        Me.DateTimePicker1.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(51, 374)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 28)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Waktu Selesai"
        '
        'TxtDetikMulai
        '
        Me.TxtDetikMulai.Location = New System.Drawing.Point(400, 321)
        Me.TxtDetikMulai.Name = "TxtDetikMulai"
        Me.TxtDetikMulai.Size = New System.Drawing.Size(68, 27)
        Me.TxtDetikMulai.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(280, 320)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(17, 28)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = ":"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(377, 320)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(17, 28)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = ":"
        '
        'TxtMenitMulai
        '
        Me.TxtMenitMulai.Location = New System.Drawing.Point(303, 321)
        Me.TxtMenitMulai.Name = "TxtMenitMulai"
        Me.TxtMenitMulai.Size = New System.Drawing.Size(68, 27)
        Me.TxtMenitMulai.TabIndex = 21
        '
        'TxtJamMulai
        '
        Me.TxtJamMulai.Location = New System.Drawing.Point(205, 321)
        Me.TxtJamMulai.Name = "TxtJamMulai"
        Me.TxtJamMulai.Size = New System.Drawing.Size(68, 27)
        Me.TxtJamMulai.TabIndex = 22
        '
        'TxtJamSelesai
        '
        Me.TxtJamSelesai.Location = New System.Drawing.Point(205, 378)
        Me.TxtJamSelesai.Name = "TxtJamSelesai"
        Me.TxtJamSelesai.Size = New System.Drawing.Size(68, 27)
        Me.TxtJamSelesai.TabIndex = 27
        '
        'TxtMenitSelesai
        '
        Me.TxtMenitSelesai.Location = New System.Drawing.Point(303, 378)
        Me.TxtMenitSelesai.Name = "TxtMenitSelesai"
        Me.TxtMenitSelesai.Size = New System.Drawing.Size(68, 27)
        Me.TxtMenitSelesai.TabIndex = 26
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(377, 377)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(17, 28)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = ":"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(280, 377)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(17, 28)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = ":"
        '
        'TxtDetikSelesai
        '
        Me.TxtDetikSelesai.Location = New System.Drawing.Point(400, 378)
        Me.TxtDetikSelesai.Name = "TxtDetikSelesai"
        Me.TxtDetikSelesai.Size = New System.Drawing.Size(68, 27)
        Me.TxtDetikSelesai.TabIndex = 23
        '
        'ButtonTambah
        '
        Me.ButtonTambah.Location = New System.Drawing.Point(374, 435)
        Me.ButtonTambah.Name = "ButtonTambah"
        Me.ButtonTambah.Size = New System.Drawing.Size(94, 29)
        Me.ButtonTambah.TabIndex = 28
        Me.ButtonTambah.Text = "Tambah"
        Me.ButtonTambah.UseVisualStyleBackColor = True
        '
        'TambahJadwalTayang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 541)
        Me.Controls.Add(Me.ButtonTambah)
        Me.Controls.Add(Me.TxtJamSelesai)
        Me.Controls.Add(Me.TxtMenitSelesai)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtDetikSelesai)
        Me.Controls.Add(Me.TxtJamMulai)
        Me.Controls.Add(Me.TxtMenitMulai)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtDetikMulai)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBoxStudio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBoxFilm)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "TambahJadwalTayang"
        Me.Text = "TambahJadwalTayang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBoxFilm As ComboBox
    Friend WithEvents ComboBoxStudio As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtDetikMulai As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtMenitMulai As TextBox
    Friend WithEvents TxtJamMulai As TextBox
    Friend WithEvents TxtJamSelesai As TextBox
    Friend WithEvents TxtMenitSelesai As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtDetikSelesai As TextBox
    Friend WithEvents ButtonTambah As Button
End Class
