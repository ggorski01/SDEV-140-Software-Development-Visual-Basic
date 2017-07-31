<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Buttons
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
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnString = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(30, 64)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add Integers"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnString
        '
        Me.btnString.Location = New System.Drawing.Point(30, 156)
        Me.btnString.Name = "btnString"
        Me.btnString.Size = New System.Drawing.Size(113, 23)
        Me.btnString.TabIndex = 1
        Me.btnString.Text = "Concatenate String"
        Me.btnString.UseVisualStyleBackColor = True
        '
        'Buttons
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnString)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "Buttons"
        Me.Text = "Giovanna Monteiro"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnString As System.Windows.Forms.Button

End Class
