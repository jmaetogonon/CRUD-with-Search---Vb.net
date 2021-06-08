<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCategoryModule
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
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvCategory = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_menu = New System.Windows.Forms.Button()
        Me.btn_category = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.gbInfo = New System.Windows.Forms.GroupBox()
        Me.cmbIsActive = New System.Windows.Forms.ComboBox()
        Me.txCategoryName = New System.Windows.Forms.TextBox()
        Me.txCategoryID = New System.Windows.Forms.TextBox()
        CType(Me.dgvCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.gbInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Montserrat Light", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(35, 574)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(149, 35)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Montserrat Light", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(563, 574)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(149, 35)
        Me.btnUpdate.TabIndex = 5
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Font = New System.Drawing.Font("Montserrat Light", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.Location = New System.Drawing.Point(729, 574)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(149, 35)
        Me.btnRemove.TabIndex = 6
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Category ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 206)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Category Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(63, 277)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Is Active"
        '
        'dgvCategory
        '
        Me.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCategory.Location = New System.Drawing.Point(378, 105)
        Me.dgvCategory.Name = "dgvCategory"
        Me.dgvCategory.ReadOnly = True
        Me.dgvCategory.Size = New System.Drawing.Size(644, 450)
        Me.dgvCategory.TabIndex = 10
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
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(381, 837)
        Me.Panel1.TabIndex = 14
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Panel7.Location = New System.Drawing.Point(52, 226)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(267, 1)
        Me.Panel7.TabIndex = 16
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Panel6.Location = New System.Drawing.Point(52, 783)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(267, 1)
        Me.Panel6.TabIndex = 15
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(52, 550)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(267, 1)
        Me.Panel5.TabIndex = 19
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(52, 479)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(267, 1)
        Me.Panel4.TabIndex = 18
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(52, 396)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(267, 1)
        Me.Panel3.TabIndex = 16
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
        Me.btn_search.TabIndex = 9
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
        Me.btn_back.TabIndex = 10
        Me.btn_back.Text = "Back"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'btn_menu
        '
        Me.btn_menu.FlatAppearance.BorderSize = 0
        Me.btn_menu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btn_menu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.btn_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_menu.Font = New System.Drawing.Font("Montserrat Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_menu.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_menu.Location = New System.Drawing.Point(37, 424)
        Me.btn_menu.Name = "btn_menu"
        Me.btn_menu.Size = New System.Drawing.Size(307, 49)
        Me.btn_menu.TabIndex = 8
        Me.btn_menu.Text = "Menu"
        Me.btn_menu.UseVisualStyleBackColor = False
        '
        'btn_category
        '
        Me.btn_category.Enabled = False
        Me.btn_category.FlatAppearance.BorderSize = 0
        Me.btn_category.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btn_category.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.btn_category.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_category.Font = New System.Drawing.Font("Montserrat Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_category.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_category.Location = New System.Drawing.Point(37, 341)
        Me.btn_category.Name = "btn_category"
        Me.btn_category.Size = New System.Drawing.Size(307, 49)
        Me.btn_category.TabIndex = 7
        Me.btn_category.Text = "Category"
        Me.btn_category.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Amatic SC", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(187, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(179, 68)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Restaurant"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Amatic SC", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.Control
        Me.lblTitle.Location = New System.Drawing.Point(3, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(277, 134)
        Me.lblTitle.TabIndex = 12
        Me.lblTitle.Text = "Art Cafe"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnReset)
        Me.Panel2.Controls.Add(Me.btnUpdate)
        Me.Panel2.Controls.Add(Me.btnRemove)
        Me.Panel2.Controls.Add(Me.gbInfo)
        Me.Panel2.Controls.Add(Me.dgvCategory)
        Me.Panel2.Controls.Add(Me.btnAdd)
        Me.Panel2.Location = New System.Drawing.Point(372, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1060, 834)
        Me.Panel2.TabIndex = 15
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Montserrat Light", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(199, 574)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(149, 35)
        Me.btnReset.TabIndex = 4
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'gbInfo
        '
        Me.gbInfo.Controls.Add(Me.cmbIsActive)
        Me.gbInfo.Controls.Add(Me.txCategoryName)
        Me.gbInfo.Controls.Add(Me.txCategoryID)
        Me.gbInfo.Controls.Add(Me.Label3)
        Me.gbInfo.Controls.Add(Me.Label1)
        Me.gbInfo.Controls.Add(Me.Label2)
        Me.gbInfo.ForeColor = System.Drawing.SystemColors.Control
        Me.gbInfo.Location = New System.Drawing.Point(24, 95)
        Me.gbInfo.Name = "gbInfo"
        Me.gbInfo.Size = New System.Drawing.Size(336, 460)
        Me.gbInfo.TabIndex = 11
        Me.gbInfo.TabStop = False
        Me.gbInfo.Text = "Catrgory Information"
        '
        'cmbIsActive
        '
        Me.cmbIsActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIsActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbIsActive.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbIsActive.FormattingEnabled = True
        Me.cmbIsActive.Location = New System.Drawing.Point(148, 267)
        Me.cmbIsActive.Name = "cmbIsActive"
        Me.cmbIsActive.Size = New System.Drawing.Size(153, 33)
        Me.cmbIsActive.TabIndex = 2
        '
        'txCategoryName
        '
        Me.txCategoryName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txCategoryName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txCategoryName.Location = New System.Drawing.Point(148, 206)
        Me.txCategoryName.Margin = New System.Windows.Forms.Padding(5)
        Me.txCategoryName.Name = "txCategoryName"
        Me.txCategoryName.Size = New System.Drawing.Size(153, 24)
        Me.txCategoryName.TabIndex = 1
        '
        'txCategoryID
        '
        Me.txCategoryID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txCategoryID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txCategoryID.Location = New System.Drawing.Point(148, 142)
        Me.txCategoryID.Margin = New System.Windows.Forms.Padding(5)
        Me.txCategoryID.Name = "txCategoryID"
        Me.txCategoryID.ReadOnly = True
        Me.txCategoryID.Size = New System.Drawing.Size(153, 24)
        Me.txCategoryID.TabIndex = 0
        '
        'frmCategoryModule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1428, 824)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frmCategoryModule"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Category Module"
        CType(Me.dgvCategory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.gbInfo.ResumeLayout(False)
        Me.gbInfo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvCategory As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_back As Button
    Friend WithEvents btn_menu As Button
    Friend WithEvents btn_category As Button
    Friend WithEvents gbInfo As GroupBox
    Friend WithEvents btn_search As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents cmbIsActive As ComboBox
    Friend WithEvents txCategoryName As TextBox
    Friend WithEvents txCategoryID As TextBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
End Class
