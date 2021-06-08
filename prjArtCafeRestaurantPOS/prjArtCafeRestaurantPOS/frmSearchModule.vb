Public Class frmSearchModule

    Private Sub btn_searchMenu_Click(sender As Object, e As EventArgs) Handles btn_searchMenu.Click
        gbSearchCat.Visible = False
        gbSearchMenu.Visible = True
        btn_searchCat.Enabled = True
        btn_searchMenu.Enabled = False
    End Sub

    Private Sub btn_searchCat_Click(sender As Object, e As EventArgs) Handles btn_searchCat.Click
        gbSearchCat.Visible = True
        gbSearchMenu.Visible = False
        btn_searchMenu.Enabled = True
        btn_searchCat.Enabled = False
    End Sub

    Private Sub frmSearchModule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FilterCategoryData("")
        FilterMenuData("")
    End Sub

    Public Sub FilterCategoryData(ByVal ValueToSearch As String)
        Dim searchCatQuery As String = "SELECT * FROM tbl_category WHERE CONCAT(CategoryID, CategoryName, IsActive) LIKE '%" + ValueToSearch + "%'"
        FillDBGrid(searchCatQuery, dgvCategory)
        dgvCategory.Columns(0).Width = 150
        dgvCategory.Columns(1).Width = 400
        dgvCategory.Columns(2).Width = 200
    End Sub

    Public Sub FilterMenuData(ByVal ValueToSearch As String)
        Dim searchCMenuQuery As String = "SELECT MenuID AS ID, MenuName AS Name, MenuDescription AS Description, MenuPrice AS Price, CategoryName, tbl_menu.IsActive FROM tbl_menu JOIN tbl_category USING (CategoryID) WHERE CONCAT(MenuID,MenuName,MenuDescription,MenuPrice,CategoryName, tbl_menu.IsActive) LIKE '%" + ValueToSearch + "%'"
        FillDBGrid(searchCMenuQuery, dgvMenu)
        dgvMenu.Columns(0).Width = 50
        dgvMenu.Columns(1).Width = 150
        dgvMenu.Columns(2).Width = 210
        dgvMenu.Columns(3).Width = 100
        dgvMenu.Columns(4).Width = 150
        dgvMenu.Columns(5).Width = 100
    End Sub

    Private Sub dgvCategory_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        FilterCategoryData("")
    End Sub

    Private Sub dgvMenu_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        FilterMenuData("")
    End Sub

    Private Sub txSearch_TextChanged(sender As Object, e As EventArgs) Handles txSearch.TextChanged
        FilterCategoryData(txSearch.Text)
    End Sub

    Private Sub txSearchMenu_TextChanged(sender As Object, e As EventArgs) Handles txSearchMenu.TextChanged
        FilterMenuData(txSearchMenu.Text)
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frmCategoryModule.Show()
        Me.Hide()
    End Sub
    Private Sub txbox_MouseUp(sender As Object, e As EventArgs) Handles txSearch.MouseUp, txSearchMenu.MouseUp
        txSearch.SelectAll()
        txSearchMenu.SelectAll()
    End Sub
End Class