﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtKapasitas = New System.Windows.Forms.TextBox()
        Me.TxtHargaKursi = New System.Windows.Forms.TextBox()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kapasitas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Harga Kursi"
        '
        'TxtKapasitas
        '
        Me.TxtKapasitas.Location = New System.Drawing.Point(151, 57)
        Me.TxtKapasitas.Name = "TxtKapasitas"
        Me.TxtKapasitas.Size = New System.Drawing.Size(174, 27)
        Me.TxtKapasitas.TabIndex = 2
        '
        'TxtHargaKursi
        '
        Me.TxtHargaKursi.Location = New System.Drawing.Point(151, 103)
        Me.TxtHargaKursi.Name = "TxtHargaKursi"
        Me.TxtHargaKursi.Size = New System.Drawing.Size(174, 27)
        Me.TxtHargaKursi.TabIndex = 3
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Location = New System.Drawing.Point(230, 155)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(94, 29)
        Me.BtnSimpan.TabIndex = 4
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'TambahStudio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 259)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.TxtHargaKursi)
        Me.Controls.Add(Me.TxtKapasitas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "TambahStudio"
        Me.Text = "TambahStudio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtKapasitas As TextBox
    Friend WithEvents TxtHargaKursi As TextBox
    Friend WithEvents BtnSimpan As Button
End Class
