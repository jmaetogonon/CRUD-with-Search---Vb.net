Public Class frmMenuModule
    Dim checkerName As String
    Dim checkerActive As String
    Dim checkerPrice As String
    Dim checkerDesc As String
    Dim checkerCatID As String
    Dim queryMaxID As String = "SELECT MenuID FROM tbl_menu ORDER BY MenuID DESC" 'query para makuha MAX ID
    Private Sub frmCategoryModule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbIsActive.Items.Add("Yes") 'add value sa CMB
        cmbIsActive.Items.Add("No")
        cmbIsActive.SelectedIndex = 0 'set index sa CMB para YES default

        LoadCategory() 'call method na LOADCATEGORY para ma display values sa table

        'call method FILLCOMBOX arun ma fill ang values na category from DB (tbl category)
        FillComboBox(cmbCategoryID, "SELECT * FROM tbl_category", "tbl_category", "CategoryName", "CategoryID")
        cmbCategoryID.SelectedIndex = -1 'set index sa CMB para empty default

        txMenuID.Text = Integer.Parse(GetMaxID(queryMaxID)) + 1 'displaying the next ID in txbox
    End Sub

    'PAG DISPLAY DATA SA TABLES
    Sub LoadCategory()
        Dim query As String = "SELECT MenuID, MenuName, MenuDescription, MenuPrice, CategoryName, tbl_menu.IsActive FROM tbl_menu JOIN tbl_category USING (CategoryID)"
        FillDBGrid(query, dgvMenu)
        dgvMenu.Columns(0).Width = 50
        dgvMenu.Columns(1).Width = 120
        dgvMenu.Columns(2).Width = 170
        dgvMenu.Columns(3).Width = 80
        dgvMenu.Columns(4).Width = 100
        dgvMenu.Columns(5).Width = 100

        dgvMenu.Columns(3).DefaultCellStyle.Format = "N2"

    End Sub

    'BUTTON ADD
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim MenuName As String = txMenuName.Text
        Dim MenuDesc As String = txMenuDesc.Text
        Dim MenuPrice As String = txMenuPrice.Text
        Dim CategoryID As String = cmbCategoryID.SelectedValue
        Dim IsActive As String = cmbIsActive.Text

        Dim queryName As String = "Select MenuName from tbl_menu WHERE MenuName = '" & MenuName & "'"
        Dim checkNameExist = IsNameExisted(queryName) 'if name already existed

        If txMenuName.Text = "" Or txMenuDesc.Text = "" Or txMenuPrice.Text = "" Or cmbCategoryID.Text = "" Or cmbIsActive.Text = "" Then
            'if fileds are empty
            MessageBox.Show("All fields are required. Please ensure all fields are completed.", "Saving Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf checkNameExist <> "" Then
            'if name already existed in DB
            MessageBox.Show("Category name already exists in the database.", "Saving Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            'add new data
            Dim query As String = "INSERT INTO tbl_menu (MenuName, MenuDescription, MenuPrice, CategoryID, IsActive) " &
          "VALUES ('" + MenuName + "', '" + MenuDesc + "', '" + MenuPrice + "', '" + CategoryID + "', '" + IsActive + "')"
            SaveData(query, "New menu has been added.") 'Calling SAVEDATA Method from modQUERIES
            LoadCategory()

            'Setting values to default after save
            txMenuID.Text = Integer.Parse(GetMaxID(queryMaxID)) + 1 'displaying the next ID in txbox
            txMenuName.Text = ""
            txMenuDesc.Text = ""
            txMenuPrice.Text = ""
            cmbCategoryID.SelectedIndex = -1
            cmbIsActive.SelectedIndex = 0
        End If
    End Sub

    'EVERY CLICK SA TABLE MA SET VALUES SA TXBOX & CMB
    Private Sub dgvCategory_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMenu.CellClick
        Dim i As Integer = e.RowIndex
        Try
            With dgvMenu
                txMenuID.Text = .Item(0, i).Value
                txMenuName.Text = .Item(1, i).Value
                txMenuDesc.Text = .Item(2, i).Value
                txMenuPrice.Text = .Item(3, i).Value
                cmbCategoryID.Text = .Item(4, i).Value
                cmbIsActive.Text = .Item(5, i).Value

                checkerName = .Item(1, i).Value 'set value sa checker - if same no action
                checkerDesc = .Item(2, i).Value 'set value sa checker - checker if same no action
                checkerPrice = .Item(3, i).Value 'set value sa checker - if same no action
                checkerCatID = .Item(4, i).Value 'set value sa checker - checker if same no action
                checkerActive = .Item(5, i).Value 'set value sa checker - checker if same no action
            End With
        Catch ex As Exception
            MessageBox.Show("Error: Datagrid CellClick() " & ex.Message, "Restaurant DBMS",
               MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'BUTTON UPDATE
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim MenuID As String = txMenuID.Text
        Dim MenuName As String = txMenuName.Text
        Dim MenuDesc As String = txMenuDesc.Text
        Dim MenuPrice As String = txMenuPrice.Text
        Dim CategoryID As String = cmbCategoryID.Text
        Dim IsActive As String = cmbIsActive.Text
        Dim checkNameExist = IsNameExisted("Select MenuName from tbl_menu WHERE MenuName = '" & MenuName & "'") 'fetch data from DB if name already existed

        If txMenuName.Text = "" Or txMenuDesc.Text = "" Or txMenuPrice.Text = "" Or cmbCategoryID.Text = "" Or cmbIsActive.Text = "" Then
            MessageBox.Show("All fields are required. Please ensure all fields are completed.", "Updating Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If checkerName = MenuName And checkerDesc = MenuDesc And checkerPrice = MenuPrice And checkerCatID = CategoryID And checkerActive = IsActive Then
                'No action if tanan fields no change
                MessageBox.Show("CHECK YAWA " + checkerCatID + " " + CategoryID, "Updating Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If checkerName = MenuName And (checkerDesc <> MenuDesc Or checkerPrice <> MenuPrice Or checkerCatID <> CategoryID Or checkerActive <> IsActive) Then
                    'update the data
                    Dim query As String = "UPDATE tbl_menu SET MenuName = '" + MenuName + "', " & "MenuDescription = '" + MenuDesc + "', " &
                            "MenuPrice = '" + MenuPrice + "', " & "CategoryID = '" + cmbCategoryID.SelectedValue.ToString + "', " & "IsActive = '" + IsActive + "' " &
                            "WHERE MenuID = '" & MenuID & "'"
                    UpdateData(query, "Menu has been updated.") 'Calling UPDATEDATA Method from modQUERIES
                    LoadCategory() 'reload data in tables
                    'Setting values to default after update
                    txMenuName.Text = ""
                    txMenuDesc.Text = ""
                    txMenuPrice.Text = ""
                    cmbIsActive.SelectedIndex = 0
                    cmbCategoryID.SelectedIndex = -1
                    txMenuID.Text = Integer.Parse(GetMaxID(queryMaxID)) + 1
                ElseIf checkNameExist <> "" Then
                    MessageBox.Show("Menu already exists in the database.", "Updating Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("CHECK BUSIT ", "Updating Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub

    'BUTTON REMOVE
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim id As Integer = Integer.Parse(txMenuID.Text)
        Dim query As String = "DELETE FROM tbl_menu WHERE MenuID = '" & id & "'"
        DeleteData(query, "Menu has been deleted.")

        LoadCategory()

        'Setting values to default after update
        txMenuName.Text = ""
        txMenuDesc.Text = ""
        txMenuPrice.Text = ""
        cmbCategoryID.SelectedIndex = -1
        cmbIsActive.SelectedIndex = 0
        'txMenuID.Text = Integer.Parse(getMaxID(queryMaxID)) + 1

    End Sub

    Private Sub btn_category_Click(sender As Object, e As EventArgs) Handles btn_category.Click
        txMenuName.Text = ""
        txMenuDesc.Text = ""
        txMenuPrice.Text = ""
        cmbCategoryID.SelectedIndex = -1
        cmbIsActive.SelectedIndex = 0
        txMenuID.Text = Integer.Parse(GetMaxID(queryMaxID)) + 1
        frmCategoryModule.Show()
        Me.Hide()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txMenuName.Text = ""
        txMenuDesc.Text = ""
        txMenuPrice.Text = ""
        cmbCategoryID.SelectedIndex = -1
        cmbIsActive.SelectedIndex = 0
        txMenuID.Text = Integer.Parse(GetMaxID(queryMaxID)) + 1
    End Sub

    Private Sub txMenuPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txMenuPrice.KeyPress
        ' allow only numbers and the Backspace, dot
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If
        'ACCEPTS ONLY 2 DECIMAL PLACES
        If txMenuPrice.Text.Length > 0 Then
            Dim ary As Array = txMenuPrice.Text.Split(".")
            If ary.Length > 1 Then
                If CType(ary(1), String).Length > 1 Then
                    e.Handled = True
                    If e.KeyChar = ControlChars.Back Then
                        e.Handled = False
                    End If
                End If
            End If
        End If
    End Sub

    'Private Sub txMenuName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txMenuName.KeyPress
    'Aceept only letters, space and backspace - Name of the menu
    'If (Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> " "c AndAlso e.KeyChar <> ControlChars.Back) Then e.Handled = True
    'If (DirectCast(sender, TextBox).Text.Length = 0) Then e.KeyChar = Char.ToUpper(e.KeyChar)
    'End Sub
    Private Sub Txbox_MouseUp(sender As Object, e As EventArgs) Handles txMenuDesc.MouseUp, txMenuName.MouseUp, txMenuPrice.MouseUp
        txMenuDesc.SelectAll()
        txMenuName.SelectAll()
        txMenuPrice.SelectAll()
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        txMenuName.Text = ""
        txMenuDesc.Text = ""
        txMenuPrice.Text = ""
        cmbCategoryID.SelectedIndex = -1
        cmbIsActive.SelectedIndex = 0
        txMenuID.Text = Integer.Parse(GetMaxID(queryMaxID)) + 1
        frmSearchModule.Show()
        Me.Hide()
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frmHome.Show()
        Me.Hide()
    End Sub
End Class