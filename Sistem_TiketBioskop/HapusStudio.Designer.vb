<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HapusStudio
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
        Me.LabelStudio = New System.Windows.Forms.Label()
        Me.ButtonHapus = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(60, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(307, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Apakah Anda Ingin Menghapus Studio"
        '
        'LabelStudio
        '
        Me.LabelStudio.AutoSize = True
        Me.LabelStudio.Font = New System.Drawing.Font("Segoe UI", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelStudio.ForeColor = System.Drawing.Color.Red
        Me.LabelStudio.Location = New System.Drawing.Point(180, 98)
        Me.LabelStudio.Name = "LabelStudio"
        Me.LabelStudio.Size = New System.Drawing.Size(54, 62)
        Me.LabelStudio.TabIndex = 1
        Me.LabelStudio.Text = "1"
        '
        'ButtonHapus
        '
        Me.ButtonHapus.Location = New System.Drawing.Point(163, 188)
        Me.ButtonHapus.Name = "ButtonHapus"
        Me.ButtonHapus.Size = New System.Drawing.Size(94, 29)
        Me.ButtonHapus.TabIndex = 2
        Me.ButtonHapus.Text = "Hapus"
        Me.ButtonHapus.UseVisualStyleBackColor = True
        '
        'HapusStudio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 267)
        Me.Controls.Add(Me.ButtonHapus)
        Me.Controls.Add(Me.LabelStudio)
        Me.Controls.Add(Me.Label1)
        Me.Name = "HapusStudio"
        Me.Text = "HapusStudio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LabelStudio As Label
    Friend WithEvents ButtonHapus As Button
End Class
