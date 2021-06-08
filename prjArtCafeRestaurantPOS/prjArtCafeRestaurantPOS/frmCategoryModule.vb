Public Class frmCategoryModule

    Dim checkerName As String
    Dim checkerActive As String
    Dim queryMaxID As String = "SELECT CategoryID FROM tbl_category ORDER BY CategoryID DESC"
    Private Sub frmCategoryModule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'values for CBO
        cmbIsActive.Items.Add("Yes")
        cmbIsActive.Items.Add("No")
        cmbIsActive.SelectedIndex = 0

        LoadCategory() 'Load datas to table
        txCategoryID.Text = Integer.Parse(GetMaxID(queryMaxID)) + 1 'displaying the next ID in txbox
    End Sub
    Sub LoadCategory()
        Dim query As String = "SELECT * FROM tbl_category"
        FillDBGrid(query, dgvCategory)
        dgvCategory.Columns(0).Width = 150
        dgvCategory.Columns(1).Width = 300
        dgvCategory.Columns(2).Width = 150
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim CategoryName As String = txCategoryName.Text
        Dim IsActive As String = cmbIsActive.Text

        Dim query As String = "Select CategoryName from tbl_category WHERE CategoryName = '" & CategoryName & "'"
        Dim checkNameExist = IsNameExisted(query) 'if name already existed

        If txCategoryName.Text = "" Or cmbIsActive.Text = "" Then
            MessageBox.Show("All fields are required. Please ensure all fields are completed.", "Saving Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf checkNameExist <> "" Then
            MessageBox.Show("Category name already exists in the database.", "Saving Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            'INSERT INTO DB
            Dim query1 As String = "INSERT INTO tbl_category (CategoryName, IsActive) " &
            "VALUES ('" + CategoryName + "', '" + IsActive + "')"
            SaveData(query1, "New menu category has been added.") 'Calling SAVEDATA Method from modQUERIES
            LoadCategory()
            'Setting values to default after saved
            txCategoryID.Text = Integer.Parse(GetMaxID(queryMaxID)) + 1
            cmbIsActive.SelectedIndex = 0
            txCategoryName.Text = ""
        End If
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim CategoryID As String = txCategoryID.Text
        Dim CategoryName As String = txCategoryName.Text
        Dim IsActive As String = cmbIsActive.Text

        Dim checkNameExist = IsNameExisted("Select CategoryName from tbl_category WHERE CategoryName = '" & CategoryName & "'") 'fetch data from DB if name already existed
        'if fields is empty
        If txCategoryName.Text = "" Or cmbIsActive.Text = "" Then
            MessageBox.Show("All fields are required. Please ensure all fields are completed.", "Updating Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            If checkerName = CategoryName And checkerActive = IsActive Then
                'No action if tanan fields no change
            Else
                If checkerName = CategoryName And checkerActive <> IsActive Then
                    'update the data
                    Dim query As String = "Update tbl_category SET CategoryName = '" + CategoryName + "', " & "IsActive = '" + IsActive + "' " &
                        "WHERE CategoryID = '" & CategoryID & "'"
                    UpdateData(query, "Category has been updated.") 'Calling UPDATEDATA Method from modQUERIES

                    LoadCategory() 'reload data in tables
                    'set all values to default after saving
                    txCategoryID.Text = Integer.Parse(GetMaxID(queryMaxID)) + 1
                    cmbIsActive.SelectedIndex = 0
                    txCategoryName.Text = ""
                ElseIf checkNameExist <> "" Then
                    MessageBox.Show("Category name already exists in the database.", "Updating Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    'update the data
                    Dim query As String = "Update tbl_category SET CategoryName = '" + CategoryName + "', " & "IsActive = '" + IsActive + "' " &
                        "WHERE CategoryID = '" & CategoryID & "'"
                    UpdateData(query, "Category has been updated.") 'Calling UPDATEDATA Method from modQUERIES

                    LoadCategory() 'reload data in tables
                    'set all values to default after saving
                    txCategoryID.Text = Integer.Parse(GetMaxID(queryMaxID)) + 1
                    cmbIsActive.SelectedIndex = 0
                    txCategoryName.Text = ""
                End If
            End If
        End If

    End Sub
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim id As Integer = Integer.Parse(txCategoryID.Text)
        Dim query As String = "DELETE FROM tbl_category WHERE CategoryID = '" & id & "'"
        DeleteData(query, "Category has been deleted.")

        LoadCategory()
        'txCategoryID.Text = txCategoryID.Text + 1
        cmbIsActive.SelectedIndex = 0
        txCategoryName.Text = ""
    End Sub
    Private Sub dgvCategory_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCategory.CellClick
        Dim i As Integer = e.RowIndex
        Try
            With dgvCategory
                txCategoryID.Text = .Item(0, i).Value
                txCategoryName.Text = .Item(1, i).Value
                cmbIsActive.Text = .Item(2, i).Value

                checkerName = .Item(1, i).Value 'set value sa checker - if same no action
                checkerActive = .Item(2, i).Value 'set value sa checker - checker if same no action
            End With
        Catch ex As Exception
            MessageBox.Show("Error: Datagrid CellClick() " & ex.Message, "Restaurant DBMS",
               MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        cmbIsActive.SelectedIndex = 0
        txCategoryName.Text = ""
        txCategoryID.Text = Integer.Parse(GetMaxID(queryMaxID)) + 1
    End Sub
    Private Sub btn_menu_Click(sender As Object, e As EventArgs) Handles btn_menu.Click
        txCategoryID.Text = Integer.Parse(GetMaxID(queryMaxID)) + 1
        cmbIsActive.SelectedIndex = 0
        txCategoryName.Text = ""
        frmMenuModule.Show()
        Me.Hide()
    End Sub

    Private Sub txbox_MouseUp(sender As Object, e As EventArgs) Handles txCategoryName.MouseUp
        txCategoryName.SelectAll()
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        txCategoryID.Text = Integer.Parse(GetMaxID(queryMaxID)) + 1
        cmbIsActive.SelectedIndex = 0
        txCategoryName.Text = ""
        frmSearchModule.Show()
        Me.Hide()
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frmHome.Show()
        Me.Hide()
    End Sub
End Class