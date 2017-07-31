Public Class DroneDogsForm

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblPorkDogs.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Call method close to finish the application
        Me.Close()

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles lblSubtotal.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtBeefDogs_TextChanged(sender As Object, e As EventArgs) Handles txtBeefDogs.TextChanged

    End Sub

    Private Sub btnCalculateOrder_Click(sender As Object, e As EventArgs) Handles btnCalculateOrder.Click
        'Declare variables and constants
        Const DBL_SALES_TAX_RATE As Double = 0.07
        Const DBL_PRICE_HOT_DOG As Double = 1.99


        Dim intNumBeefDogs As Integer
        Dim intNumPorkDogs As Integer
        Dim intNumTurkeyDogs As Integer
        Dim intTotalHotDogsOrdered As Integer

        Dim dblOrderSubtotal As Double
        Dim dblTaxAmtSales As Double
        Dim dblTotalOrderCost As Double
        'End of the declare
        'Casting all the input values
        intNumBeefDogs = Convert.ToInt32(txtBeefDogs.Text)
        intNumPorkDogs = Convert.ToInt32(txtPorkDogs.Text)
        intNumTurkeyDogs = Convert.ToInt32(txtTurkeyDogs.Text)
        'End of cast

        'Sum of all hot dogs ordered

        intTotalHotDogsOrdered = (intNumBeefDogs + intNumPorkDogs + intNumTurkeyDogs)

        'Sum Order Subtotal (before taxes)
        dblOrderSubtotal = (intTotalHotDogsOrdered * DBL_PRICE_HOT_DOG)
        'Sum the amount of sales tax
        dblTaxAmtSales = (dblOrderSubTotal * DBL_SALES_TAX_RATE)
        'Sum total cost of the order
        dblTotalOrderCost = (dblOrderSubtotal + dblTaxAmtSales)

        'Casting variables to exhibit on txt labels
        txtTotalCost.Text = dblTotalOrderCost.ToString("c2")
        txtSalesTax.Text = dblTaxAmtSales.ToString("c2")
        txtSubtotal.Text = dblOrderSubtotal.ToString("c2")

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'Message box for the Submit Order Button
        MessageBox.Show("Thank you for ordering from DroneDogs!", _
           "Giovanna Monteiro")
    End Sub
End Class
