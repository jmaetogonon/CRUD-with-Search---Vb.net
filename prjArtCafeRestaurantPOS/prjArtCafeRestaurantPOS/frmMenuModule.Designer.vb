<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenuModule
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dgvMenu = New System.Windows.Forms.DataGridView()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.cmbIsActive = New System.Windows.Forms.ComboBox()
        Me.txMenuDesc = New System.Windows.Forms.TextBox()
        Me.txMenuID = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_menu = New System.Windows.Forms.Button()
        Me.btn_category = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.gbInfo = New System.Windows.Forms.GroupBox()
        Me.cmbCategoryID = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txMenuPrice = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txMenuName = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.dgvMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.gbInfo.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvMenu
        '
        Me.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMenu.Location = New System.Drawing.Point(375, 105)
        Me.dgvMenu.Name = "dgvMenu"
        Me.dgvMenu.ReadOnly = True
        Me.dgvMenu.Size = New System.Drawing.Size(660, 450)
        Me.dgvMenu.TabIndex = 11
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Panel7.Location = New System.Drawing.Point(52, 226)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(267, 1)
        Me.Panel7.TabIndex = 20
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(52, 550)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(267, 1)
        Me.Panel5.TabIndex = 22
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(52, 479)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(267, 1)
        Me.Panel4.TabIndex = 23
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(52, 396)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(267, 1)
        Me.Panel3.TabIndex = 21
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Montserrat Light", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(199, 574)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(149, 35)
        Me.btnReset.TabIndex = 8
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'cmbIsActive
        '
        Me.cmbIsActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIsActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbIsActive.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbIsActive.FormattingEnabled = True
        Me.cmbIsActive.Location = New System.Drawing.Point(141, 334)
        Me.cmbIsActive.Name = "cmbIsActive"
        Me.cmbIsActive.Size = New System.Drawing.Size(153, 33)
        Me.cmbIsActive.TabIndex = 6
        '
        'txMenuDesc
        '
        Me.txMenuDesc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txMenuDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txMenuDesc.Location = New System.Drawing.Point(141, 196)
        Me.txMenuDesc.Margin = New System.Windows.Forms.Padding(5)
        Me.txMenuDesc.Name = "txMenuDesc"
        Me.txMenuDesc.Size = New System.Drawing.Size(153, 24)
        Me.txMenuDesc.TabIndex = 3
        '
        'txMenuID
        '
        Me.txMenuID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txMenuID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txMenuID.Location = New System.Drawing.Point(141, 103)
        Me.txMenuID.Margin = New System.Windows.Forms.Padding(5)
        Me.txMenuID.Name = "txMenuID"
        Me.txMenuID.ReadOnly = True
        Me.txMenuID.Size = New System.Drawing.Size(153, 24)
        Me.txMenuID.TabIndex = 30
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Panel6.Location = New System.Drawing.Point(52, 783)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(267, 1)
        Me.Panel6.TabIndex = 24
        '
        'btn_search
        '
        Me.btn_search.FlatAppearance.BorderSize = 0
        Me.btn_search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btn_search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_search.Font = New System.Drawing.Font("Montserrat Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_search.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_search.Location = New System.Drawing.Point(37, 495)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(307, 49)
        Me.btn_search.TabIndex = 15
        Me.btn_search.Text = "Search"
        Me.btn_search.UseVisualStyleBackColor = False
        '
        'btn_back
        '
        Me.btn_back.FlatAppearance.BorderSize = 0
        Me.btn_back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btn_back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_back.Font = New System.Drawing.Font("Montserrat Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_back.Location = New System.Drawing.Point(37, 728)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(307, 49)
        Me.btn_back.TabIndex = 16
        Me.btn_back.Text = "Back"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'btn_menu
        '
        Me.btn_menu.Enabled = False
        Me.btn_menu.FlatAppearance.BorderSize = 0
        Me.btn_menu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btn_menu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.btn_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_menu.Font = New System.Drawing.Font("Montserrat Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_menu.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_menu.Location = New System.Drawing.Point(37, 424)
        Me.btn_menu.Name = "btn_menu"
        Me.btn_menu.Size = New System.Drawing.Size(307, 49)
        Me.btn_menu.TabIndex = 14
        Me.btn_menu.Text = "Menu"
        Me.btn_menu.UseVisualStyleBackColor = False
        '
        'btn_category
        '
        Me.btn_category.FlatAppearance.BorderSize = 0
        Me.btn_category.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btn_category.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.btn_category.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_category.Font = New System.Drawing.Font("Montserrat Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_category.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_category.Location = New System.Drawing.Point(37, 341)
        Me.btn_category.Name = "btn_category"
        Me.btn_category.Size = New System.Drawing.Size(307, 49)
        Me.btn_category.TabIndex = 13
        Me.btn_category.Text = "Category"
        Me.btn_category.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Panel2.Controls.Add(Me.dgvMenu)
        Me.Panel2.Controls.Add(Me.btnReset)
        Me.Panel2.Controls.Add(Me.btnUpdate)
        Me.Panel2.Controls.Add(Me.btnRemove)
        Me.Panel2.Controls.Add(Me.gbInfo)
        Me.Panel2.Controls.Add(Me.btnAdd)
        Me.Panel2.Location = New System.Drawing.Point(370, -6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1060, 834)
        Me.Panel2.TabIndex = 17
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Montserrat Light", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(563, 574)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(149, 35)
        Me.btnUpdate.TabIndex = 9
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Font = New System.Drawing.Font("Montserrat Light", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.Location = New System.Drawing.Point(729, 574)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(149, 35)
        Me.btnRemove.TabIndex = 10
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'gbInfo
        '
        Me.gbInfo.Controls.Add(Me.cmbCategoryID)
        Me.gbInfo.Controls.Add(Me.Label13)
        Me.gbInfo.Controls.Add(Me.txMenuPrice)
        Me.gbInfo.Controls.Add(Me.Label12)
        Me.gbInfo.Controls.Add(Me.txMenuName)
        Me.gbInfo.Controls.Add(Me.Label11)
        Me.gbInfo.Controls.Add(Me.cmbIsActive)
        Me.gbInfo.Controls.Add(Me.txMenuDesc)
        Me.gbInfo.Controls.Add(Me.txMenuID)
        Me.gbInfo.Controls.Add(Me.Label7)
        Me.gbInfo.Controls.Add(Me.Label8)
        Me.gbInfo.Controls.Add(Me.Label9)
        Me.gbInfo.ForeColor = System.Drawing.SystemColors.Control
        Me.gbInfo.Location = New System.Drawing.Point(24, 95)
        Me.gbInfo.Name = "gbInfo"
        Me.gbInfo.Size = New System.Drawing.Size(336, 460)
        Me.gbInfo.TabIndex = 0
        Me.gbInfo.TabStop = False
        Me.gbInfo.Text = "Catrgory Information"
        '
        'cmbCategoryID
        '
        Me.cmbCategoryID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategoryID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCategoryID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCategoryID.FormattingEnabled = True
        Me.cmbCategoryID.Location = New System.Drawing.Point(141, 283)
        Me.cmbCategoryID.Name = "cmbCategoryID"
        Me.cmbCategoryID.Size = New System.Drawing.Size(153, 33)
        Me.cmbCategoryID.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(38, 290)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 16)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "CategoryID"
        '
        'txMenuPrice
        '
        Me.txMenuPrice.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txMenuPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txMenuPrice.Location = New System.Drawing.Point(141, 239)
        Me.txMenuPrice.Margin = New System.Windows.Forms.Padding(5)
        Me.txMenuPrice.Name = "txMenuPrice"
        Me.txMenuPrice.Size = New System.Drawing.Size(153, 24)
        Me.txMenuPrice.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(75, 247)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 16)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Price"
        '
        'txMenuName
        '
        Me.txMenuName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txMenuName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txMenuName.Location = New System.Drawing.Point(141, 147)
        Me.txMenuName.Margin = New System.Windows.Forms.Padding(5)
        Me.txMenuName.Name = "txMenuName"
        Me.txMenuName.Size = New System.Drawing.Size(153, 24)
        Me.txMenuName.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(69, 154)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 16)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(56, 344)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 16)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Is Active"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(57, 110)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 16)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Menu ID"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(38, 196)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 16)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Description"
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Montserrat Light", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(35, 574)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(149, 35)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Amatic SC", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.Control
        Me.Label10.Location = New System.Drawing.Point(187, 122)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(179, 68)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Restaurant"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Amatic SC", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.Control
        Me.lblTitle.Location = New System.Drawing.Point(3, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(277, 134)
        Me.lblTitle.TabIndex = 11
        Me.lblTitle.Text = "Art Cafe"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(8, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.btn_search)
        Me.Panel1.Controls.Add(Me.btn_back)
        Me.Panel1.Controls.Add(Me.btn_menu)
        Me.Panel1.Controls.Add(Me.btn_category)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Location = New System.Drawing.Point(-2, -6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(381, 837)
        Me.Panel1.TabIndex = 18
        '
        'frmMenuModule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1428, 824)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmMenuModule"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMenuModule"
        CType(Me.dgvMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.gbInfo.ResumeLayout(False)
        Me.gbInfo.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvMenu As DataGridView
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnReset As Button
    Friend WithEvents cmbIsActive As ComboBox
    Friend WithEvents txMenuDesc As TextBox
    Friend WithEvents txMenuID As TextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btn_search As Button
    Friend WithEvents btn_back As Button
    Friend WithEvents btn_menu As Button
    Friend WithEvents btn_category As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents gbInfo As GroupBox
    Friend WithEvents cmbCategoryID As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txMenuPrice As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txMenuName As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents Panel1 As Panel
End Class
