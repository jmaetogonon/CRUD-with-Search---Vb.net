Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Data

Module Queries

    Public conn As MySqlConnection
    Public dataAdapter As MySqlDataAdapter
    Public myDataTable As DataTable
    Public myCommand As MySqlCommand
    Public ConnectionString As String = "Server=127.0.0.1;user id=root;password=;database=db_restaurant_janducayan;connect timeout = 99999;Allow Batch = true;Pooling= true;"
    Public response As String = ""
    Public id As String = ""
    Private dr As MySqlDataReader

    'Saving/Adding new data
    Public Function SaveData(ByVal query As String, ByVal successMsg As String) As Boolean
        Dim result As Boolean = False
        response = MsgBox("Are you sure to save the new category?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Saving Utility")
        If response = vbYes Then
            conn = New MySqlConnection
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            Try
                conn.ConnectionString = ConnectionString
                conn.Open()
                myCommand = New MySqlCommand(query, conn)
                myCommand.ExecuteNonQuery()
                conn.Close()
                conn = Nothing
                MsgBox(successMsg)
                result = True
            Catch ex As Exception
                MessageBox.Show("Error:" + ex.ToString())
            End Try
        Else
            MsgBox("Action was cancelled...")
        End If
        Return result
    End Function

    'Updating new data
    Public Function UpdateData(ByVal query As String, ByVal successMsg As String) As Boolean
        Dim result As Boolean = False
        'MsgBox(query)
        response = MsgBox("Are you sure to update the category?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Saving Utility")
        If response = vbYes Then
            conn = New MySqlConnection
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            Try
                conn.ConnectionString = ConnectionString
                conn.Open()
                myCommand = New MySqlCommand(query, conn)
                myCommand.ExecuteNonQuery()
                conn.Close()
                conn = Nothing
                MsgBox(successMsg)
                result = True
            Catch ex As Exception
                MessageBox.Show("Error:" + ex.ToString())
            End Try
        Else
            MsgBox("Action was cancelled...")
        End If
        Return result
    End Function

    Public Sub FillDBGrid(ByVal q As String, ByVal data_grid_name As DataGridView)
        Dim bindingSource1 As New BindingSource()

        conn = New MySqlConnection
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If

        Try
            data_grid_name.Columns.Clear()
            data_grid_name.DataSource = ""

            conn.ConnectionString = ConnectionString
            conn.Open()
            myCommand = New MySqlCommand(q, conn)

            dataAdapter = New MySqlDataAdapter(myCommand)
            myDataTable = New DataTable
            dataAdapter.Fill(myDataTable)
            bindingSource1.DataSource = myDataTable
            data_grid_name.DataSource = bindingSource1
            'data_grid_name.DataBindings
            'data_grid_name.DataBind()
            data_grid_name.Refresh()
            conn.Close()
            dataAdapter = Nothing
            myDataTable = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            conn.Dispose()
        End Try
    End Sub

    Public Function DeleteData(ByVal query As String, ByVal successMsg As String) As Boolean
        Dim result As Boolean = False
        'MsgBox(query)
        response = MsgBox("Are you sure to delete the data?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Saving Utility")
        If response = vbYes Then
            conn = New MySqlConnection
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If

            Try
                conn.ConnectionString = ConnectionString
                conn.Open()
                'query = "DELETE FROM " + Table_Name
                myCommand = New MySqlCommand(query, conn)
                myCommand.ExecuteNonQuery()
                conn.Close()
                conn = Nothing
                MsgBox(successMsg)
                result = True
            Catch ex As Exception
                MessageBox.Show("Category cannot be deleted. This item is referred to by another object.", "Removing Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try
        Else
            MsgBox("Action was cancelled...")
        End If
        Return result
    End Function
    Public Function GetMaxID(ByVal query As String) As String
        Dim maxID As String = ""
        Try
            conn.Open()
            myCommand = New MySqlCommand(query, conn)
            dr = myCommand.ExecuteReader

            dr.Read()

            maxID = DirectCast(dr, IDataRecord)(0)

            conn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            dr.Dispose()
        End Try

        Return maxID
    End Function

    Public Sub FillComboBox(ByVal combo_box_name As ComboBox, ByVal query As String, ByVal table_name As String, ByVal data As String, ByVal index As String)
        Dim bindingSource1 As New BindingSource()
        conn = New MySqlConnection
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If

        Try
            conn.ConnectionString = ConnectionString
            conn.Open()
            myCommand = New MySqlCommand(query, conn)

            dataAdapter = New MySqlDataAdapter(myCommand)
            myDataTable = New DataTable
            dataAdapter.Fill(myDataTable)
            combo_box_name.DisplayMember = data
            combo_box_name.ValueMember = index
            bindingSource1.DataSource = myDataTable
            combo_box_name.DataSource = bindingSource1
            'dgEmployee.Refresh()
            conn.Close()
            dataAdapter = Nothing
            myDataTable = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub


    Public Function IsNameExisted(ByVal queryCP As String) As String
        Dim strResult As String = ""
        conn = New MySqlConnection
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        Try
            conn.ConnectionString = ConnectionString
            conn.Open()
            myCommand = New MySqlCommand(queryCP, conn)

            Dim myReaderCP As MySqlDataReader = myCommand.ExecuteReader()
            If myReaderCP.Read() = True Then
                strResult = myReaderCP.GetValue(0)
            End If
            myReaderCP.Close()
            conn.Close()

        Catch exceptionCP As Exception
            MessageBox.Show("Error:" + exceptionCP.Message)
        End Try
        Return strResult
    End Function
End Module
