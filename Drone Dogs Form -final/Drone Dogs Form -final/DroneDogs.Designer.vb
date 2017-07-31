<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DroneDogs
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
        Me.btnExit.Location = New System.Drawing.Point(330, 206)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSubmitOrder
        '
        Me.btnSubmitOrder.Location = New System.Drawing.Point(177, 206)
        Me.btnSubmitOrder.Name = "btnSubmitOrder"
        Me.btnSubmitOrder.Size = New System.Drawing.Size(99, 23)
        Me.btnSubmitOrder.TabIndex = 7
        Me.btnSubmitOrder.Text = "Submit Order"
        Me.btnSubmitOrder.UseVisualStyleBackColor = True
        '
        'btnCalcOrder
        '
        Me.btnCalcOrder.Location = New System.Drawing.Point(30, 206)
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
        'DroneDogs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 410)
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
        Me.Name = "DroneDogs"
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

End Class
