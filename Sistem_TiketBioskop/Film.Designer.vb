<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Film
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
        Me.DataGridViewFilm = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.StudioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FilmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JadwalTayangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridViewFilm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridViewFilm
        '
        Me.DataGridViewFilm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewFilm.Location = New System.Drawing.Point(26, 124)
        Me.DataGridViewFilm.Name = "DataGridViewFilm"
        Me.DataGridViewFilm.RowHeadersWidth = 51
        Me.DataGridViewFilm.RowTemplate.Height = 29
        Me.DataGridViewFilm.Size = New System.Drawing.Size(595, 237)
        Me.DataGridViewFilm.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(302, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Film"
        '
        'BtnTambah
        '
        Me.BtnTambah.Location = New System.Drawing.Point(645, 124)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(156, 38)
        Me.BtnTambah.TabIndex = 2
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Location = New System.Drawing.Point(645, 178)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(156, 38)
        Me.BtnEdit.TabIndex = 3
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.Location = New System.Drawing.Point(645, 232)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(156, 38)
        Me.BtnHapus.TabIndex = 4
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudioToolStripMenuItem, Me.FilmToolStripMenuItem, Me.JadwalTayangToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(843, 28)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'StudioToolStripMenuItem
        '
        Me.StudioToolStripMenuItem.Name = "StudioToolStripMenuItem"
        Me.StudioToolStripMenuItem.Size = New System.Drawing.Size(66, 24)
        Me.StudioToolStripMenuItem.Text = "Studio"
        '
        'FilmToolStripMenuItem
        '
        Me.FilmToolStripMenuItem.Name = "FilmToolStripMenuItem"
        Me.FilmToolStripMenuItem.Size = New System.Drawing.Size(51, 24)
        Me.FilmToolStripMenuItem.Text = "Film"
        '
        'JadwalTayangToolStripMenuItem
        '
        Me.JadwalTayangToolStripMenuItem.Name = "JadwalTayangToolStripMenuItem"
        Me.JadwalTayangToolStripMenuItem.Size = New System.Drawing.Size(118, 24)
        Me.JadwalTayangToolStripMenuItem.Text = "Jadwal Tayang"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Firebrick
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(645, 58)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(156, 41)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "SignOut"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Film
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(843, 387)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridViewFilm)
        Me.Name = "Film"
        Me.Text = "Film"
        CType(Me.DataGridViewFilm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewFilm As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnTambah As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents StudioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FilmToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JadwalTayangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
End Class
