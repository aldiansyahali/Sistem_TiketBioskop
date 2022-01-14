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
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.TxtBoxHarga = New System.Windows.Forms.TextBox()
        Me.TxtBoxKapasitas = New System.Windows.Forms.TextBox()
        Me.lblHarga = New System.Windows.Forms.Label()
        Me.lblKapasitas = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnEdit
        '
        Me.BtnEdit.Location = New System.Drawing.Point(228, 193)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(98, 29)
        Me.BtnEdit.TabIndex = 9
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'TxtBoxHarga
        '
        Me.TxtBoxHarga.Location = New System.Drawing.Point(262, 114)
        Me.TxtBoxHarga.Name = "TxtBoxHarga"
        Me.TxtBoxHarga.Size = New System.Drawing.Size(251, 20)
        Me.TxtBoxHarga.TabIndex = 8
        '
        'TxtBoxKapasitas
        '
        Me.TxtBoxKapasitas.Location = New System.Drawing.Point(262, 64)
        Me.TxtBoxKapasitas.Name = "TxtBoxKapasitas"
        Me.TxtBoxKapasitas.Size = New System.Drawing.Size(251, 20)
        Me.TxtBoxKapasitas.TabIndex = 7
        '
        'lblHarga
        '
        Me.lblHarga.AutoSize = True
        Me.lblHarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHarga.Location = New System.Drawing.Point(38, 110)
        Me.lblHarga.Name = "lblHarga"
        Me.lblHarga.Size = New System.Drawing.Size(131, 24)
        Me.lblHarga.TabIndex = 6
        Me.lblHarga.Text = "Harga Kursi :"
        '
        'lblKapasitas
        '
        Me.lblKapasitas.AutoSize = True
        Me.lblKapasitas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKapasitas.Location = New System.Drawing.Point(38, 60)
        Me.lblKapasitas.Name = "lblKapasitas"
        Me.lblKapasitas.Size = New System.Drawing.Size(163, 24)
        Me.lblKapasitas.TabIndex = 5
        Me.lblKapasitas.Text = "Kapasitas Kursi :"
        '
        'EditStudio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 262)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.TxtBoxHarga)
        Me.Controls.Add(Me.TxtBoxKapasitas)
        Me.Controls.Add(Me.lblHarga)
        Me.Controls.Add(Me.lblKapasitas)
        Me.Name = "EditStudio"
        Me.Text = "EditStudio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnEdit As Button
    Friend WithEvents TxtBoxHarga As TextBox
    Friend WithEvents TxtBoxKapasitas As TextBox
    Friend WithEvents lblHarga As Label
    Friend WithEvents lblKapasitas As Label
End Class
