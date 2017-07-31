Public Class CustomerForm
    'Form level member
    Private objCustomers As New ArrayList
    Private Sub CustomerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Pre-loading three customers to the form
        CreateCustomer("Darrel", "Hilton", "dhilton@somecompany.com")
        CreateCustomer("Fran", "Peoples", "fpeoples@thisorg.org")
        CreateCustomer("Bill", "Scott", "bscott@ourtown.gov")

    End Sub

    Public ReadOnly Property SelectedCustomer() As Customer
        Get
            If lstCustomerForm.SelectedIndex <> -1 Then
                'Return this customer
                Return CType(objCustomers(lstCustomerForm.SelectedIndex), Customer)
            End If
        End Get
    End Property

    Private Sub btnCustomerFormAddNewCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomerFormAddNewCustomer.Click
        'Begin of gettin the new customer information from the text boxes
        Dim strFirstName = txtCustomerFirstName.Text
        Dim strLastName = txtCustomerLastName.Text
        Dim strEmail = txtCustomerEmail.Text

        'Calling procedure to create new customer record from the information at the text boxes
        CreateCustomer(strFirstName, strLastName, strEmail)

    End Sub

    Public Sub CreateCustomer(firstName As String, lastName As String, email As String)
        'Declare a customer object
        Dim objNewCustomer As Customer

        'Create new customer
        objNewCustomer.FirstName = firstName
        objNewCustomer.LastName = lastName
        objNewCustomer.Email = email

        'Add the new customer to the list
        objCustomers.Add(objNewCustomer)

        'Add the new customer to the listBox control
        lstCustomerForm.Items.Add(objNewCustomer)
    End Sub

    Private Sub btnSelectCustomerFormHighlightedCustomer_Click(sender As Object, e As EventArgs) Handles btnSelectCustomerFormHighlightedCustomer.Click
        'If no customer is selected, then error and exit
        If lstCustomerForm.SelectedIndex = -1 Then
            'Display error message and exit
            MessageBox.Show("Error...no customer selected.", _
           "Giovanna Monteiro")
            Exit Sub
        End If
        'Get customer info and display it in the order form
        Dim objCustomerSelected As Customer = SelectedCustomer
        DroneDogsOrder.txtOrderFirstName.Text = objCustomerSelected.FirstName
        DroneDogsOrder.txtOrderLastName.Text = objCustomerSelected.LastName
        DroneDogsOrder.txtOrderEmail.Text = objCustomerSelected.Email




    End Sub
End Class