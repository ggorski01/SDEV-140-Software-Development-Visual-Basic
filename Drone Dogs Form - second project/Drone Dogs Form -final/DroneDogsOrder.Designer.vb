<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DroneDogsOrder
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
        Me.lblBeef = New System.Windows.Forms.Label()
        Me.lblPork = New System.Windows.Forms.Label()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.lblTurkey = New System.Windows.Forms.Label()
        Me.lblSalesTax = New System.Windows.Forms.Label()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnSubmitOrder = New System.Windows.Forms.Button()
        Me.btnCalcOrder = New System.Windows.Forms.Button()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.txtSalesTax = New System.Windows.Forms.TextBox()
        Me.txtTotalCost = New System.Windows.Forms.TextBox()
        Me.txtBeef = New System.Windows.Forms.TextBox()
        Me.txtPork = New System.Windows.Forms.TextBox()
        Me.txtTurkey = New System.Windows.Forms.TextBox()
        Me.picDroneDogsLogo = New System.Windows.Forms.PictureBox()
        Me.lblDroneDogsName = New System.Windows.Forms.Label()
        Me.btnOrderGetCustomerInfo = New System.Windows.Forms.Button()
        Me.btnOrderClearForm = New System.Windows.Forms.Button()
        Me.lblOrderFirstName = New System.Windows.Forms.Label()
        Me.lblOrderLastName = New System.Windows.Forms.Label()
        Me.lblOrderEmail = New System.Windows.Forms.Label()
        Me.txtOrderFirstName = New System.Windows.Forms.TextBox()
        Me.txtOrderLastName = New System.Windows.Forms.TextBox()
        Me.txtOrderEmail = New System.Windows.Forms.TextBox()
        Me.chkLocation = New System.Windows.Forms.CheckBox()
        Me.lblLocation = New System.Windows.Forms.Label()
        CType(Me.picDroneDogsLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblBeef
        '
        Me.lblBeef.AutoSize = True
        Me.lblBeef.Location = New System.Drawing.Point(27, 73)
        Me.lblBeef.Name = "lblBeef"
        Me.lblBeef.Size = New System.Drawing.Size(67, 13)
        Me.lblBeef.TabIndex = 0
        Me.lblBeef.Text = "# BeefDogs:"
        '
        'lblPork
        '
        Me.lblPork.AutoSize = True
        Me.lblPork.Location = New System.Drawing.Point(27, 111)
        Me.lblPork.Name = "lblPork"
        Me.lblPork.Size = New System.Drawing.Size(67, 13)
        Me.lblPork.TabIndex = 1
        Me.lblPork.Text = "# PorkDogs:"
        '
        'lblSubTotal
        '
        Me.lblSubTotal.AutoSize = True
        Me.lblSubTotal.Location = New System.Drawing.Point(27, 261)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(49, 13)
        Me.lblSubTotal.TabIndex = 2
        Me.lblSubTotal.Text = "Subtotal:"
        '
        'lblTurkey
        '
        Me.lblTurkey.AutoSize = True
        Me.lblTurkey.Location = New System.Drawing.Point(27, 146)
        Me.lblTurkey.Name = "lblTurkey"
        Me.lblTurkey.Size = New System.Drawing.Size(81, 13)
        Me.lblTurkey.TabIndex = 3
        Me.lblTurkey.Text = "# Turkey Dogs:"
        '
        'lblSalesTax
        '
        Me.lblSalesTax.AutoSize = True
        Me.lblSalesTax.Location = New System.Drawing.Point(27, 304)
        Me.lblSalesTax.Name = "lblSalesTax"
        Me.lblSalesTax.Size = New System.Drawing.Size(57, 13)
        Me.lblSalesTax.TabIndex = 4
        Me.lblSalesTax.Text = "Sales Tax:"
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Location = New System.Drawing.Point(27, 347)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(58, 13)
        Me.lblTotalCost.TabIndex = 5
        Me.lblTotalCost.Text = "Total Cost:"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(330, 603)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSubmitOrder
        '
        Me.btnSubmitOrder.Location = New System.Drawing.Point(48, 603)
        Me.btnSubmitOrder.Name = "btnSubmitOrder"
        Me.btnSubmitOrder.Size = New System.Drawing.Size(99, 23)
        Me.btnSubmitOrder.TabIndex = 7
        Me.btnSubmitOrder.Text = "Submit Order"
        Me.btnSubmitOrder.UseVisualStyleBackColor = True
        '
        'btnCalcOrder
        '
        Me.btnCalcOrder.Location = New System.Drawing.Point(102, 198)
        Me.btnCalcOrder.Name = "btnCalcOrder"
        Me.btnCalcOrder.Size = New System.Drawing.Size(96, 23)
        Me.btnCalcOrder.TabIndex = 8
        Me.btnCalcOrder.Text = "Calculate Order"
        Me.btnCalcOrder.UseVisualStyleBackColor = True
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Location = New System.Drawing.Point(146, 261)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.ReadOnly = True
        Me.txtSubTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtSubTotal.TabIndex = 9
        '
        'txtSalesTax
        '
        Me.txtSalesTax.Location = New System.Drawing.Point(146, 304)
        Me.txtSalesTax.Name = "txtSalesTax"
        Me.txtSalesTax.ReadOnly = True
        Me.txtSalesTax.Size = New System.Drawing.Size(100, 20)
        Me.txtSalesTax.TabIndex = 10
        '
        'txtTotalCost
        '
        Me.txtTotalCost.Location = New System.Drawing.Point(146, 347)
        Me.txtTotalCost.Name = "txtTotalCost"
        Me.txtTotalCost.ReadOnly = True
        Me.txtTotalCost.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalCost.TabIndex = 11
        '
        'txtBeef
        '
        Me.txtBeef.Location = New System.Drawing.Point(146, 73)
        Me.txtBeef.Name = "txtBeef"
        Me.txtBeef.Size = New System.Drawing.Size(100, 20)
        Me.txtBeef.TabIndex = 12
        '
        'txtPork
        '
        Me.txtPork.Location = New System.Drawing.Point(146, 111)
        Me.txtPork.Name = "txtPork"
        Me.txtPork.Size = New System.Drawing.Size(100, 20)
        Me.txtPork.TabIndex = 13
        '
        'txtTurkey
        '
        Me.txtTurkey.Location = New System.Drawing.Point(146, 146)
        Me.txtTurkey.Name = "txtTurkey"
        Me.txtTurkey.Size = New System.Drawing.Size(100, 20)
        Me.txtTurkey.TabIndex = 14
        '
        'picDroneDogsLogo
        '
        Me.picDroneDogsLogo.Image = Global.Drone_Dogs_Form__final.My.Resources.Resources.xid_82854470_1
        Me.picDroneDogsLogo.Location = New System.Drawing.Point(330, 28)
        Me.picDroneDogsLogo.Name = "picDroneDogsLogo"
        Me.picDroneDogsLogo.Size = New System.Drawing.Size(100, 131)
        Me.picDroneDogsLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDroneDogsLogo.TabIndex = 15
        Me.picDroneDogsLogo.TabStop = False
        '
        'lblDroneDogsName
        '
        Me.lblDroneDogsName.AutoSize = True
        Me.lblDroneDogsName.Font = New System.Drawing.Font("Forte", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDroneDogsName.ForeColor = System.Drawing.Color.Crimson
        Me.lblDroneDogsName.Location = New System.Drawing.Point(80, 28)
        Me.lblDroneDogsName.Name = "lblDroneDogsName"
        Me.lblDroneDogsName.Size = New System.Drawing.Size(225, 17)
        Me.lblDroneDogsName.TabIndex = 16
        Me.lblDroneDogsName.Text = "DRONEDOGS ORDER FORM"
        '
        'btnOrderGetCustomerInfo
        '
        Me.btnOrderGetCustomerInfo.Location = New System.Drawing.Point(30, 398)
        Me.btnOrderGetCustomerInfo.Name = "btnOrderGetCustomerInfo"
        Me.btnOrderGetCustomerInfo.Size = New System.Drawing.Size(142, 23)
        Me.btnOrderGetCustomerInfo.TabIndex = 17
        Me.btnOrderGetCustomerInfo.Text = "Get Customer Info"
        Me.btnOrderGetCustomerInfo.UseVisualStyleBackColor = True
        '
        'btnOrderClearForm
        '
        Me.btnOrderClearForm.Location = New System.Drawing.Point(249, 397)
        Me.btnOrderClearForm.Name = "btnOrderClearForm"
        Me.btnOrderClearForm.Size = New System.Drawing.Size(155, 23)
        Me.btnOrderClearForm.TabIndex = 18
        Me.btnOrderClearForm.Text = "Clear Form"
        Me.btnOrderClearForm.UseVisualStyleBackColor = True
        '
        'lblOrderFirstName
        '
        Me.lblOrderFirstName.AutoSize = True
        Me.lblOrderFirstName.Location = New System.Drawing.Point(45, 443)
        Me.lblOrderFirstName.Name = "lblOrderFirstName"
        Me.lblOrderFirstName.Size = New System.Drawing.Size(60, 13)
        Me.lblOrderFirstName.TabIndex = 19
        Me.lblOrderFirstName.Text = "First Name:"
        '
        'lblOrderLastName
        '
        Me.lblOrderLastName.AutoSize = True
        Me.lblOrderLastName.Location = New System.Drawing.Point(45, 482)
        Me.lblOrderLastName.Name = "lblOrderLastName"
        Me.lblOrderLastName.Size = New System.Drawing.Size(61, 13)
        Me.lblOrderLastName.TabIndex = 20
        Me.lblOrderLastName.Text = "Last Name:"
        '
        'lblOrderEmail
        '
        Me.lblOrderEmail.AutoSize = True
        Me.lblOrderEmail.Location = New System.Drawing.Point(45, 526)
        Me.lblOrderEmail.Name = "lblOrderEmail"
        Me.lblOrderEmail.Size = New System.Drawing.Size(35, 13)
        Me.lblOrderEmail.TabIndex = 21
        Me.lblOrderEmail.Text = "Email:"
        '
        'txtOrderFirstName
        '
        Me.txtOrderFirstName.Location = New System.Drawing.Point(146, 436)
        Me.txtOrderFirstName.Name = "txtOrderFirstName"
        Me.txtOrderFirstName.ReadOnly = True
        Me.txtOrderFirstName.Size = New System.Drawing.Size(209, 20)
        Me.txtOrderFirstName.TabIndex = 22
        '
        'txtOrderLastName
        '
        Me.txtOrderLastName.Location = New System.Drawing.Point(146, 482)
        Me.txtOrderLastName.Name = "txtOrderLastName"
        Me.txtOrderLastName.ReadOnly = True
        Me.txtOrderLastName.Size = New System.Drawing.Size(209, 20)
        Me.txtOrderLastName.TabIndex = 23
        '
        'txtOrderEmail
        '
        Me.txtOrderEmail.Location = New System.Drawing.Point(146, 519)
        Me.txtOrderEmail.Name = "txtOrderEmail"
        Me.txtOrderEmail.ReadOnly = True
        Me.txtOrderEmail.Size = New System.Drawing.Size(209, 20)
        Me.txtOrderEmail.TabIndex = 24
        '
        'chkLocation
        '
        Me.chkLocation.AutoSize = True
        Me.chkLocation.Location = New System.Drawing.Point(48, 564)
        Me.chkLocation.Name = "chkLocation"
        Me.chkLocation.Size = New System.Drawing.Size(15, 14)
        Me.chkLocation.TabIndex = 25
        Me.chkLocation.UseVisualStyleBackColor = True
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Location = New System.Drawing.Point(80, 564)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(287, 13)
        Me.lblLocation.TabIndex = 26
        Me.lblLocation.Text = "I give DroneDogs permission to use my location information."
        '
        'DroneDogsOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 638)
        Me.Controls.Add(Me.lblLocation)
        Me.Controls.Add(Me.chkLocation)
        Me.Controls.Add(Me.txtOrderEmail)
        Me.Controls.Add(Me.txtOrderLastName)
        Me.Controls.Add(Me.txtOrderFirstName)
        Me.Controls.Add(Me.lblOrderEmail)
        Me.Controls.Add(Me.lblOrderLastName)
        Me.Controls.Add(Me.lblOrderFirstName)
        Me.Controls.Add(Me.btnOrderClearForm)
        Me.Controls.Add(Me.btnOrderGetCustomerInfo)
        Me.Controls.Add(Me.lblDroneDogsName)
        Me.Controls.Add(Me.picDroneDogsLogo)
        Me.Controls.Add(Me.txtTurkey)
        Me.Controls.Add(Me.txtPork)
        Me.Controls.Add(Me.txtBeef)
        Me.Controls.Add(Me.txtTotalCost)
        Me.Controls.Add(Me.txtSalesTax)
        Me.Controls.Add(Me.txtSubTotal)
        Me.Controls.Add(Me.btnCalcOrder)
        Me.Controls.Add(Me.btnSubmitOrder)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.lblSalesTax)
        Me.Controls.Add(Me.lblTurkey)
        Me.Controls.Add(Me.lblSubTotal)
        Me.Controls.Add(Me.lblPork)
        Me.Controls.Add(Me.lblBeef)
        Me.Name = "DroneDogsOrder"
        Me.Text = "Giovanna Monteiro"
        CType(Me.picDroneDogsLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblBeef As System.Windows.Forms.Label
    Friend WithEvents lblPork As System.Windows.Forms.Label
    Friend WithEvents lblSubTotal As System.Windows.Forms.Label
    Friend WithEvents lblTurkey As System.Windows.Forms.Label
    Friend WithEvents lblSalesTax As System.Windows.Forms.Label
    Friend WithEvents lblTotalCost As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSubmitOrder As System.Windows.Forms.Button
    Friend WithEvents btnCalcOrder As System.Windows.Forms.Button
    Friend WithEvents txtSubTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtSalesTax As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalCost As System.Windows.Forms.TextBox
    Friend WithEvents txtBeef As System.Windows.Forms.TextBox
    Friend WithEvents txtPork As System.Windows.Forms.TextBox
    Friend WithEvents txtTurkey As System.Windows.Forms.TextBox
    Friend WithEvents picDroneDogsLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblDroneDogsName As System.Windows.Forms.Label
    Friend WithEvents btnOrderGetCustomerInfo As System.Windows.Forms.Button
    Friend WithEvents btnOrderClearForm As System.Windows.Forms.Button
    Friend WithEvents lblOrderFirstName As System.Windows.Forms.Label
    Friend WithEvents lblOrderLastName As System.Windows.Forms.Label
    Friend WithEvents lblOrderEmail As System.Windows.Forms.Label
    Friend WithEvents txtOrderFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtOrderLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtOrderEmail As System.Windows.Forms.TextBox
    Friend WithEvents chkLocation As System.Windows.Forms.CheckBox
    Friend WithEvents lblLocation As System.Windows.Forms.Label

End Class
