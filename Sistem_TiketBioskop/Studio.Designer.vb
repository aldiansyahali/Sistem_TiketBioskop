<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Studio
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.StudioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahStudioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kapasitas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Harga_Kursi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudioToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(579, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'StudioToolStripMenuItem
        '
        Me.StudioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahStudioToolStripMenuItem})
        Me.StudioToolStripMenuItem.Name = "StudioToolStripMenuItem"
        Me.StudioToolStripMenuItem.Size = New System.Drawing.Size(66, 24)
        Me.StudioToolStripMenuItem.Text = "Studio"
        '
        'TambahStudioToolStripMenuItem
        '
        Me.TambahStudioToolStripMenuItem.Name = "TambahStudioToolStripMenuItem"
        Me.TambahStudioToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.TambahStudioToolStripMenuItem.Text = "Tambah Studio"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Kapasitas, Me.Harga_Kursi})
        Me.DataGridView1.Location = New System.Drawing.Point(21, 61)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(531, 188)
        Me.DataGridView1.TabIndex = 1
        '
        'Id
        '
        Me.Id.HeaderText = "ID"
        Me.Id.MinimumWidth = 6
        Me.Id.Name = "Id"
        Me.Id.Width = 125
        '
        'Kapasitas
        '
        Me.Kapasitas.HeaderText = "Kapasitas"
        Me.Kapasitas.MinimumWidth = 6
        Me.Kapasitas.Name = "Kapasitas"
        Me.Kapasitas.Width = 125
        '
        'Harga_Kursi
        '
        Me.Harga_Kursi.HeaderText = "Harga Kursi"
        Me.Harga_Kursi.MinimumWidth = 6
        Me.Harga_Kursi.Name = "Harga_Kursi"
        Me.Harga_Kursi.Width = 125
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(458, 264)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 29)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Tambah"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(358, 264)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 29)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Hapus"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Studio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 403)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Studio"
        Me.Text = "Studio"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents StudioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TambahStudioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents Kapasitas As DataGridViewTextBoxColumn
    Friend WithEvents Harga_Kursi As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
