<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerForm
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
        Me.lblDroneDogsCustomerFormName = New System.Windows.Forms.Label()
        Me.picDroneDogsLogo = New System.Windows.Forms.PictureBox()
        Me.lstCustomerForm = New System.Windows.Forms.ListBox()
        Me.lblCustomerFormFirstName = New System.Windows.Forms.Label()
        Me.lblCustomerFormLastName = New System.Windows.Forms.Label()
        Me.lblCustomerFormEmail = New System.Windows.Forms.Label()
        Me.txtCustomerFirstName = New System.Windows.Forms.TextBox()
        Me.txtCustomerLastName = New System.Windows.Forms.TextBox()
        Me.txtCustomerEmail = New System.Windows.Forms.TextBox()
        Me.btnCustomerFormAddNewCustomer = New System.Windows.Forms.Button()
        Me.btnSelectCustomerFormHighlightedCustomer = New System.Windows.Forms.Button()
        CType(Me.picDroneDogsLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDroneDogsCustomerFormName
        '
        Me.lblDroneDogsCustomerFormName.AutoSize = True
        Me.lblDroneDogsCustomerFormName.Font = New System.Drawing.Font("Forte", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDroneDogsCustomerFormName.ForeColor = System.Drawing.Color.Crimson
        Me.lblDroneDogsCustomerFormName.Location = New System.Drawing.Point(132, 26)
        Me.lblDroneDogsCustomerFormName.Name = "lblDroneDogsCustomerFormName"
        Me.lblDroneDogsCustomerFormName.Size = New System.Drawing.Size(260, 17)
        Me.lblDroneDogsCustomerFormName.TabIndex = 17
        Me.lblDroneDogsCustomerFormName.Text = "DRONEDOGS CUSTOMER FORM"
        '
        'picDroneDogsLogo
        '
        Me.picDroneDogsLogo.Image = Global.Drone_Dogs_Form__final.My.Resources.Resources.xid_82854470_1
        Me.picDroneDogsLogo.Location = New System.Drawing.Point(590, 51)
        Me.picDroneDogsLogo.Name = "picDroneDogsLogo"
        Me.picDroneDogsLogo.Size = New System.Drawing.Size(100, 131)
        Me.picDroneDogsLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDroneDogsLogo.TabIndex = 18
        Me.picDroneDogsLogo.TabStop = False
        '
        'lstCustomerForm
        '
        Me.lstCustomerForm.FormattingEnabled = True
        Me.lstCustomerForm.Location = New System.Drawing.Point(57, 89)
        Me.lstCustomerForm.Name = "lstCustomerForm"
        Me.lstCustomerForm.Size = New System.Drawing.Size(489, 160)
        Me.lstCustomerForm.TabIndex = 19
        '
        'lblCustomerFormFirstName
        '
        Me.lblCustomerFormFirstName.AutoSize = True
        Me.lblCustomerFormFirstName.Location = New System.Drawing.Point(99, 274)
        Me.lblCustomerFormFirstName.Name = "lblCustomerFormFirstName"
        Me.lblCustomerFormFirstName.Size = New System.Drawing.Size(60, 13)
        Me.lblCustomerFormFirstName.TabIndex = 20
        Me.lblCustomerFormFirstName.Text = "First Name:"
        '
        'lblCustomerFormLastName
        '
        Me.lblCustomerFormLastName.AutoSize = True
        Me.lblCustomerFormLastName.Location = New System.Drawing.Point(99, 310)
        Me.lblCustomerFormLastName.Name = "lblCustomerFormLastName"
        Me.lblCustomerFormLastName.Size = New System.Drawing.Size(61, 13)
        Me.lblCustomerFormLastName.TabIndex = 21
        Me.lblCustomerFormLastName.Text = "Last Name:"
        '
        'lblCustomerFormEmail
        '
        Me.lblCustomerFormEmail.AutoSize = True
        Me.lblCustomerFormEmail.Location = New System.Drawing.Point(99, 344)
        Me.lblCustomerFormEmail.Name = "lblCustomerFormEmail"
        Me.lblCustomerFormEmail.Size = New System.Drawing.Size(35, 13)
        Me.lblCustomerFormEmail.TabIndex = 22
        Me.lblCustomerFormEmail.Text = "Email:"
        '
        'txtCustomerFirstName
        '
        Me.txtCustomerFirstName.Location = New System.Drawing.Point(244, 267)
        Me.txtCustomerFirstName.Name = "txtCustomerFirstName"
        Me.txtCustomerFirstName.Size = New System.Drawing.Size(266, 20)
        Me.txtCustomerFirstName.TabIndex = 23
        '
        'txtCustomerLastName
        '
        Me.txtCustomerLastName.Location = New System.Drawing.Point(244, 303)
        Me.txtCustomerLastName.Name = "txtCustomerLastName"
        Me.txtCustomerLastName.Size = New System.Drawing.Size(266, 20)
        Me.txtCustomerLastName.TabIndex = 24
        '
        'txtCustomerEmail
        '
        Me.txtCustomerEmail.Location = New System.Drawing.Point(244, 337)
        Me.txtCustomerEmail.Name = "txtCustomerEmail"
        Me.txtCustomerEmail.Size = New System.Drawing.Size(266, 20)
        Me.txtCustomerEmail.TabIndex = 25
        '
        'btnCustomerFormAddNewCustomer
        '
        Me.btnCustomerFormAddNewCustomer.Location = New System.Drawing.Point(57, 399)
        Me.btnCustomerFormAddNewCustomer.Name = "btnCustomerFormAddNewCustomer"
        Me.btnCustomerFormAddNewCustomer.Size = New System.Drawing.Size(211, 23)
        Me.btnCustomerFormAddNewCustomer.TabIndex = 26
        Me.btnCustomerFormAddNewCustomer.Text = "Add New Customer"
        Me.btnCustomerFormAddNewCustomer.UseVisualStyleBackColor = True
        '
        'btnSelectCustomerFormHighlightedCustomer
        '
        Me.btnSelectCustomerFormHighlightedCustomer.Location = New System.Drawing.Point(384, 399)
        Me.btnSelectCustomerFormHighlightedCustomer.Name = "btnSelectCustomerFormHighlightedCustomer"
        Me.btnSelectCustomerFormHighlightedCustomer.Size = New System.Drawing.Size(197, 23)
        Me.btnSelectCustomerFormHighlightedCustomer.TabIndex = 27
        Me.btnSelectCustomerFormHighlightedCustomer.Text = "Select Highlighted Customer"
        Me.btnSelectCustomerFormHighlightedCustomer.UseVisualStyleBackColor = True
        '
        'CustomerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(739, 459)
        Me.Controls.Add(Me.btnSelectCustomerFormHighlightedCustomer)
        Me.Controls.Add(Me.btnCustomerFormAddNewCustomer)
        Me.Controls.Add(Me.txtCustomerEmail)
        Me.Controls.Add(Me.txtCustomerLastName)
        Me.Controls.Add(Me.txtCustomerFirstName)
        Me.Controls.Add(Me.lblCustomerFormEmail)
        Me.Controls.Add(Me.lblCustomerFormLastName)
        Me.Controls.Add(Me.lblCustomerFormFirstName)
        Me.Controls.Add(Me.lstCustomerForm)
        Me.Controls.Add(Me.picDroneDogsLogo)
        Me.Controls.Add(Me.lblDroneDogsCustomerFormName)
        Me.Name = "CustomerForm"
        Me.Text = "Giovanna Monteiro"
        CType(Me.picDroneDogsLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDroneDogsCustomerFormName As System.Windows.Forms.Label
    Friend WithEvents picDroneDogsLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lstCustomerForm As System.Windows.Forms.ListBox
    Friend WithEvents lblCustomerFormFirstName As System.Windows.Forms.Label
    Friend WithEvents lblCustomerFormLastName As System.Windows.Forms.Label
    Friend WithEvents lblCustomerFormEmail As System.Windows.Forms.Label
    Friend WithEvents txtCustomerFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtCustomerLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtCustomerEmail As System.Windows.Forms.TextBox
    Friend WithEvents btnCustomerFormAddNewCustomer As System.Windows.Forms.Button
    Friend WithEvents btnSelectCustomerFormHighlightedCustomer As System.Windows.Forms.Button
End Class
