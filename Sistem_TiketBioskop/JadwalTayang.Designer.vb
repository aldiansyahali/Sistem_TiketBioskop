<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JadwalTayang
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
        Me.DGJadwalTayang = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.StudioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FilmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JadwalTayangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ButtonTambah = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.DGJadwalTayang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(290, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 31)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Jadwal Tayang"
        '
        'DGJadwalTayang
        '
        Me.DGJadwalTayang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGJadwalTayang.Location = New System.Drawing.Point(51, 130)
        Me.DGJadwalTayang.Name = "DGJadwalTayang"
        Me.DGJadwalTayang.RowHeadersWidth = 51
        Me.DGJadwalTayang.RowTemplate.Height = 29
        Me.DGJadwalTayang.Size = New System.Drawing.Size(643, 204)
        Me.DGJadwalTayang.TabIndex = 7
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudioToolStripMenuItem, Me.FilmToolStripMenuItem, Me.JadwalTayangToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(763, 28)
        Me.MenuStrip1.TabIndex = 8
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
        'ButtonTambah
        '
        Me.ButtonTambah.Location = New System.Drawing.Point(599, 349)
        Me.ButtonTambah.Name = "ButtonTambah"
        Me.ButtonTambah.Size = New System.Drawing.Size(94, 29)
        Me.ButtonTambah.TabIndex = 9
        Me.ButtonTambah.Text = "Tambah"
        Me.ButtonTambah.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(499, 349)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 29)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Edit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(399, 349)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(94, 29)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Hapus"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'JadwalTayang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(763, 431)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ButtonTambah)
        Me.Controls.Add(Me.DGJadwalTayang)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "JadwalTayang"
        Me.Text = "JadwalTayang"
        CType(Me.DGJadwalTayang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DGJadwalTayang As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents StudioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FilmToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JadwalTayangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ButtonTambah As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
