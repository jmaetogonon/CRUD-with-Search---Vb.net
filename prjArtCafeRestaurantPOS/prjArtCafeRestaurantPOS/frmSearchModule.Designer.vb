<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchModule
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
        Me.gbSearchCat = New System.Windows.Forms.GroupBox()
        Me.dgvCategory = New System.Windows.Forms.DataGridView()
        Me.txSearch = New System.Windows.Forms.TextBox()
        Me.gbSearchMenu = New System.Windows.Forms.GroupBox()
        Me.dgvMenu = New System.Windows.Forms.DataGridView()
        Me.txSearchMenu = New System.Windows.Forms.TextBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btn_searchMenu = New System.Windows.Forms.Button()
        Me.btn_searchCat = New System.Windows.Forms.Button()
        Me.gbSearchCat.SuspendLayout()
        CType(Me.dgvCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbSearchMenu.SuspendLayout()
        CType(Me.dgvMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbSearchCat
        '
        Me.gbSearchCat.Controls.Add(Me.dgvCategory)
        Me.gbSearchCat.Controls.Add(Me.txSearch)
        Me.gbSearchCat.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSearchCat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.gbSearchCat.Location = New System.Drawing.Point(413, 57)
        Me.gbSearchCat.Name = "gbSearchCat"
        Me.gbSearchCat.Size = New System.Drawing.Size(986, 719)
        Me.gbSearchCat.TabIndex = 4
        Me.gbSearchCat.TabStop = False
        Me.gbSearchCat.Text = "Category"
        '
        'dgvCategory
        '
        Me.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCategory.Location = New System.Drawing.Point(104, 140)
        Me.dgvCategory.Name = "dgvCategory"
        Me.dgvCategory.ReadOnly = True
        Me.dgvCategory.Size = New System.Drawing.Size(784, 527)
        Me.dgvCategory.TabIndex = 1
        '
        'txSearch
        '
        Me.txSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txSearch.Location = New System.Drawing.Point(132, 82)
        Me.txSearch.Margin = New System.Windows.Forms.Padding(5)
        Me.txSearch.Name = "txSearch"
        Me.txSearch.Size = New System.Drawing.Size(728, 24)
        Me.txSearch.TabIndex = 0
        '
        'gbSearchMenu
        '
        Me.gbSearchMenu.Controls.Add(Me.dgvMenu)
        Me.gbSearchMenu.Controls.Add(Me.txSearchMenu)
        Me.gbSearchMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSearchMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.gbSearchMenu.Location = New System.Drawing.Point(412, 57)
        Me.gbSearchMenu.Name = "gbSearchMenu"
        Me.gbSearchMenu.Size = New System.Drawing.Size(986, 719)
        Me.gbSearchMenu.TabIndex = 5
        Me.gbSearchMenu.TabStop = False
        Me.gbSearchMenu.Text = "Menu"
        Me.gbSearchMenu.Visible = False
        '
        'dgvMenu
        '
        Me.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMenu.Location = New System.Drawing.Point(93, 149)
        Me.dgvMenu.Name = "dgvMenu"
        Me.dgvMenu.ReadOnly = True
        Me.dgvMenu.Size = New System.Drawing.Size(803, 519)
        Me.dgvMenu.TabIndex = 1
        '
        'txSearchMenu
        '
        Me.txSearchMenu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txSearchMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txSearchMenu.Location = New System.Drawing.Point(130, 83)
        Me.txSearchMenu.Margin = New System.Windows.Forms.Padding(5)
        Me.txSearchMenu.Name = "txSearchMenu"
        Me.txSearchMenu.Size = New System.Drawing.Size(728, 24)
        Me.txSearchMenu.TabIndex = 1
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Panel7.Location = New System.Drawing.Point(52, 226)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(267, 1)
        Me.Panel7.TabIndex = 20
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Panel6.Location = New System.Drawing.Point(52, 783)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(267, 1)
        Me.Panel6.TabIndex = 24
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
        Me.btn_back.TabIndex = 8
        Me.btn_back.Text = "Back"
        Me.btn_back.UseVisualStyleBackColor = False
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
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.btn_searchMenu)
        Me.Panel1.Controls.Add(Me.btn_back)
        Me.Panel1.Controls.Add(Me.btn_searchCat)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(379, 839)
        Me.Panel1.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat Light", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(120, 330)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 51)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Search"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(52, 550)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(267, 1)
        Me.Panel5.TabIndex = 22
        '
        'btn_searchMenu
        '
        Me.btn_searchMenu.FlatAppearance.BorderSize = 0
        Me.btn_searchMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btn_searchMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.btn_searchMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_searchMenu.Font = New System.Drawing.Font("Montserrat Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_searchMenu.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_searchMenu.Location = New System.Drawing.Point(37, 495)
        Me.btn_searchMenu.Name = "btn_searchMenu"
        Me.btn_searchMenu.Size = New System.Drawing.Size(307, 49)
        Me.btn_searchMenu.TabIndex = 7
        Me.btn_searchMenu.Text = "Menu"
        Me.btn_searchMenu.UseVisualStyleBackColor = False
        '
        'btn_searchCat
        '
        Me.btn_searchCat.Enabled = False
        Me.btn_searchCat.FlatAppearance.BorderSize = 0
        Me.btn_searchCat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btn_searchCat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.btn_searchCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_searchCat.Font = New System.Drawing.Font("Montserrat Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_searchCat.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_searchCat.Location = New System.Drawing.Point(37, 424)
        Me.btn_searchCat.Name = "btn_searchCat"
        Me.btn_searchCat.Size = New System.Drawing.Size(307, 49)
        Me.btn_searchCat.TabIndex = 6
        Me.btn_searchCat.Text = "Category"
        Me.btn_searchCat.UseVisualStyleBackColor = False
        '
        'frmSearchModule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1428, 824)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.gbSearchMenu)
        Me.Controls.Add(Me.gbSearchCat)
        Me.Name = "frmSearchModule"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSearchModule"
        Me.gbSearchCat.ResumeLayout(False)
        Me.gbSearchCat.PerformLayout()
        CType(Me.dgvCategory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbSearchMenu.ResumeLayout(False)
        Me.gbSearchMenu.PerformLayout()
        CType(Me.dgvMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbSearchCat As GroupBox
    Friend WithEvents txSearch As TextBox
    Friend WithEvents gbSearchMenu As GroupBox
    Friend WithEvents dgvMenu As DataGridView
    Friend WithEvents txSearchMenu As TextBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_back As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btn_searchMenu As Button
    Friend WithEvents btn_searchCat As Button
    Friend WithEvents dgvCategory As DataGridView
End Class
