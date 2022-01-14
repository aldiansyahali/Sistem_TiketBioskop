<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahStudio
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
        Me.lblKapasitas = New System.Windows.Forms.Label()
        Me.lblHarga = New System.Windows.Forms.Label()
        Me.TxtBoxKapasitas = New System.Windows.Forms.TextBox()
        Me.TxtBoxHarga = New System.Windows.Forms.TextBox()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblKapasitas
        '
        Me.lblKapasitas.AutoSize = True
        Me.lblKapasitas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKapasitas.Location = New System.Drawing.Point(39, 60)
        Me.lblKapasitas.Name = "lblKapasitas"
        Me.lblKapasitas.Size = New System.Drawing.Size(163, 24)
        Me.lblKapasitas.TabIndex = 0
        Me.lblKapasitas.Text = "Kapasitas Kursi :"
        '
        'lblHarga
        '
        Me.lblHarga.AutoSize = True
        Me.lblHarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHarga.Location = New System.Drawing.Point(39, 110)
        Me.lblHarga.Name = "lblHarga"
        Me.lblHarga.Size = New System.Drawing.Size(131, 24)
        Me.lblHarga.TabIndex = 1
        Me.lblHarga.Text = "Harga Kursi :"
        '
        'TxtBoxKapasitas
        '
        Me.TxtBoxKapasitas.Location = New System.Drawing.Point(263, 64)
        Me.TxtBoxKapasitas.Name = "TxtBoxKapasitas"
        Me.TxtBoxKapasitas.Size = New System.Drawing.Size(251, 20)
        Me.TxtBoxKapasitas.TabIndex = 2
        '
        'TxtBoxHarga
        '
        Me.TxtBoxHarga.Location = New System.Drawing.Point(263, 114)
        Me.TxtBoxHarga.Name = "TxtBoxHarga"
        Me.TxtBoxHarga.Size = New System.Drawing.Size(251, 20)
        Me.TxtBoxHarga.TabIndex = 3
        '
        'BtnTambah
        '
        Me.BtnTambah.Location = New System.Drawing.Point(229, 193)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(98, 29)
        Me.BtnTambah.TabIndex = 4
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'TambahStudio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 271)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.TxtBoxHarga)
        Me.Controls.Add(Me.TxtBoxKapasitas)
        Me.Controls.Add(Me.lblHarga)
        Me.Controls.Add(Me.lblKapasitas)
        Me.Name = "TambahStudio"
        Me.Text = "TambahStudio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblKapasitas As Label
    Friend WithEvents lblHarga As Label
    Friend WithEvents TxtBoxKapasitas As TextBox
    Friend WithEvents TxtBoxHarga As TextBox
    Friend WithEvents BtnTambah As Button
End Class
