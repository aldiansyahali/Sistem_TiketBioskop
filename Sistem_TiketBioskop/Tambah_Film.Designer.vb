<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tambah_Film
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxJudulFilm = New System.Windows.Forms.TextBox()
        Me.TextBoxDirector = New System.Windows.Forms.TextBox()
        Me.TextBoxDuration = New System.Windows.Forms.TextBox()
        Me.TextBoxHargaFilm = New System.Windows.Forms.TextBox()
        Me.DateTimePickerReleased = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.ComboBoxGenre = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.RichTextBoxDeskripsi = New System.Windows.Forms.RichTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RBBhs_Inggris = New System.Windows.Forms.RadioButton()
        Me.RB_BhsIndo = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnTambahGambar = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Judul Film"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Genre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 380)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Director"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 502)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Date Released"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 690)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Harga Film"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(31, 438)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Duration"
        '
        'TextBoxJudulFilm
        '
        Me.TextBoxJudulFilm.Location = New System.Drawing.Point(207, 113)
        Me.TextBoxJudulFilm.Name = "TextBoxJudulFilm"
        Me.TextBoxJudulFilm.Size = New System.Drawing.Size(250, 27)
        Me.TextBoxJudulFilm.TabIndex = 6
        '
        'TextBoxDirector
        '
        Me.TextBoxDirector.Location = New System.Drawing.Point(207, 377)
        Me.TextBoxDirector.Name = "TextBoxDirector"
        Me.TextBoxDirector.Size = New System.Drawing.Size(250, 27)
        Me.TextBoxDirector.TabIndex = 8
        '
        'TextBoxDuration
        '
        Me.TextBoxDuration.Location = New System.Drawing.Point(207, 438)
        Me.TextBoxDuration.Name = "TextBoxDuration"
        Me.TextBoxDuration.Size = New System.Drawing.Size(250, 27)
        Me.TextBoxDuration.TabIndex = 9
        '
        'TextBoxHargaFilm
        '
        Me.TextBoxHargaFilm.Location = New System.Drawing.Point(207, 690)
        Me.TextBoxHargaFilm.Name = "TextBoxHargaFilm"
        Me.TextBoxHargaFilm.Size = New System.Drawing.Size(250, 27)
        Me.TextBoxHargaFilm.TabIndex = 11
        '
        'DateTimePickerReleased
        '
        Me.DateTimePickerReleased.Location = New System.Drawing.Point(207, 497)
        Me.DateTimePickerReleased.Name = "DateTimePickerReleased"
        Me.DateTimePickerReleased.Size = New System.Drawing.Size(250, 27)
        Me.DateTimePickerReleased.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(275, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(220, 34)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Tambah Film"
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Location = New System.Drawing.Point(626, 690)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(97, 40)
        Me.BtnSimpan.TabIndex = 14
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'ComboBoxGenre
        '
        Me.ComboBoxGenre.FormattingEnabled = True
        Me.ComboBoxGenre.Items.AddRange(New Object() {"Drama", "Action", "Comedy", "Horor"})
        Me.ComboBoxGenre.Location = New System.Drawing.Point(207, 169)
        Me.ComboBoxGenre.Name = "ComboBoxGenre"
        Me.ComboBoxGenre.Size = New System.Drawing.Size(250, 28)
        Me.ComboBoxGenre.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(28, 259)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 20)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Deskripsi"
        '
        'RichTextBoxDeskripsi
        '
        Me.RichTextBoxDeskripsi.Location = New System.Drawing.Point(207, 240)
        Me.RichTextBoxDeskripsi.Name = "RichTextBoxDeskripsi"
        Me.RichTextBoxDeskripsi.Size = New System.Drawing.Size(250, 94)
        Me.RichTextBoxDeskripsi.TabIndex = 17
        Me.RichTextBoxDeskripsi.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(31, 584)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 20)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Bahasa"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RBBhs_Inggris)
        Me.GroupBox1.Controls.Add(Me.RB_BhsIndo)
        Me.GroupBox1.Location = New System.Drawing.Point(207, 553)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(250, 106)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bahasa"
        '
        'RBBhs_Inggris
        '
        Me.RBBhs_Inggris.AutoSize = True
        Me.RBBhs_Inggris.Location = New System.Drawing.Point(21, 66)
        Me.RBBhs_Inggris.Name = "RBBhs_Inggris"
        Me.RBBhs_Inggris.Size = New System.Drawing.Size(126, 24)
        Me.RBBhs_Inggris.TabIndex = 1
        Me.RBBhs_Inggris.TabStop = True
        Me.RBBhs_Inggris.Text = "Bahasa Inggris"
        Me.RBBhs_Inggris.UseVisualStyleBackColor = True
        '
        'RB_BhsIndo
        '
        Me.RB_BhsIndo.AutoSize = True
        Me.RB_BhsIndo.Location = New System.Drawing.Point(21, 36)
        Me.RB_BhsIndo.Name = "RB_BhsIndo"
        Me.RB_BhsIndo.Size = New System.Drawing.Size(145, 24)
        Me.RB_BhsIndo.TabIndex = 0
        Me.RB_BhsIndo.TabStop = True
        Me.RB_BhsIndo.Text = "Bahasa Indonesia"
        Me.RB_BhsIndo.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(504, 113)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(219, 221)
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'BtnTambahGambar
        '
        Me.BtnTambahGambar.Location = New System.Drawing.Point(504, 354)
        Me.BtnTambahGambar.Name = "BtnTambahGambar"
        Me.BtnTambahGambar.Size = New System.Drawing.Size(219, 29)
        Me.BtnTambahGambar.TabIndex = 21
        Me.BtnTambahGambar.Text = "Tambah Gambar"
        Me.BtnTambahGambar.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Tambah_Film
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(766, 759)
        Me.Controls.Add(Me.BtnTambahGambar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.RichTextBoxDeskripsi)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ComboBoxGenre)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DateTimePickerReleased)
        Me.Controls.Add(Me.TextBoxHargaFilm)
        Me.Controls.Add(Me.TextBoxDuration)
        Me.Controls.Add(Me.TextBoxDirector)
        Me.Controls.Add(Me.TextBoxJudulFilm)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Tambah_Film"
        Me.Text = "Tambah_Film"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxJudulFilm As TextBox
    Friend WithEvents TextBoxDirector As TextBox
    Friend WithEvents TextBoxDuration As TextBox
    Friend WithEvents TextBoxHargaFilm As TextBox
    Friend WithEvents DateTimePickerReleased As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents ComboBoxGenre As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents RichTextBoxDeskripsi As RichTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RBBhs_Inggris As RadioButton
    Friend WithEvents RB_BhsIndo As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnTambahGambar As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
