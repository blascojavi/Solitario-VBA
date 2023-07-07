Imports System.ComponentModel
Imports System.Data.OleDb
Public Class listings

    Private Sub listings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rutaBD As String = Application.StartupPath + "\solitaire.mdb"
        Dim con As New OleDbConnection
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & rutaBD
        Dim conjuntoDatos As New DataSet()

        Try
            con.Open()
            Dim dataAdapter = New OleDbDataAdapter("SELECT * FROM Record", con)
            Dim tabla As New DataTable()
            dataAdapter.Fill(tabla)
            DataGridViewRecords.DataSource = tabla



            '  dataAdapter.Fill(conjuntoDatos, "Record")

        Catch ex As OleDbException

            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try

        '        dataGridViewRecords.DataSource = conjuntoDatos
        '       DataGridViewRecords.DataMember = "Record"
        '      DataGridViewRecords.AutoResizeColumns()
        ' Configura el control DataGridView

        'DataGridViewRecords.DataSource = conjuntoDatos.Tables("Record")
        'DataGridViewRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        'DataGridViewRecords.AutoResizeColumns()


        DataGridViewRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewRecords.AutoResizeColumns()

    End Sub




    Private Sub DataGridViewRecords_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewRecords.CellClick


        Dim selectedValue As String = DataGridViewRecords.Rows(e.RowIndex).Cells(1).Value.ToString()


        Dim rutaBD As String = Application.StartupPath + "\solitaire.mdb"
            Dim con As New OleDbConnection
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & rutaBD
            '  Dim conjuntoDatos As New DataSet()
            Dim dataAdapter As New OleDbDataAdapter
            Dim dataSet As New DataSet()

            Try
                con.Open()

            ' Definir la consulta SQL con un parámetro para el valor seleccionado
            Dim query As String = "SELECT * FROM Record WHERE Player = @Player"
            dataAdapter.SelectCommand = New OleDbCommand(query, con)
            dataAdapter.SelectCommand.Parameters.AddWithValue("@Player", selectedValue)

            ' Obtener los registros que coinciden con el valor seleccionado
            dataSet.Clear()
                dataAdapter.Fill(DataSet, "Record")

            ' Contar el número de registros correspondientes al jugador seleccionado
            Dim countQuery As String = "SELECT COUNT(*) FROM Record WHERE Player = @Player"
            Dim countCommand As New OleDbCommand(countQuery, con)
            countCommand.Parameters.AddWithValue("@Player", selectedValue)
            Dim count As Integer = CInt(countCommand.ExecuteScalar())

                ' Sumar los valores de la columna deseada y el número de veces que aparece el jugador
                Dim total As Integer = 0
            For Each row As DataRow In dataSet.Tables("Record").Rows
                total += Integer.Parse(row("Hits").ToString())
            Next
            total += count

            ' Mostrar el total de aciertos y el número de veces que aparece el jugador en el TextBox
            TextBoxPartidasJugadas.Text = total.ToString()
        Catch ex As OleDbException
                MessageBox.Show(ex.Message)
            Finally
                con.Close()
            End Try





        Try
            con.Open()

            ' Definir la consulta SQL con parámetros para el valor seleccionado y la columna "Tiempo"
            Dim query As String = "SELECT * FROM Record WHERE Player = @Player AND Time IS NOT NULL"
            dataAdapter.SelectCommand = New OleDbCommand(query, con)
            dataAdapter.SelectCommand.Parameters.AddWithValue("@Player", selectedValue)

            ' Obtener los registros que coinciden con el valor seleccionado
            dataSet.Clear()
            dataAdapter.Fill(dataSet, "Record")

            ' Sumar los valores de la columna deseada
            Dim total As Integer = 0
            For Each row As DataRow In dataSet.Tables("Record").Rows
                total += Integer.Parse(row("Time").ToString())
            Next

            ' Mostrar el tiempo jugado por el jugador en el TextBox
            TextBoxtiempoDeJuego.Text = total.ToString()
        Catch ex As OleDbException
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try






        Try
            con.Open()

            ' Definir la consulta SQL con parámetros para el valor seleccionado y la columna "Fecha"
            Dim query As String = "SELECT TOP 1 WinDate FROM Record WHERE Player = @Player AND WinDate IS NOT NULL ORDER BY WinDate DESC"
            dataAdapter.SelectCommand = New OleDbCommand(query, con)
            dataAdapter.SelectCommand.Parameters.AddWithValue("@Player", selectedValue)

            ' Obtener el registro que coincide con el valor seleccionado
            dataSet.Clear()
            dataAdapter.Fill(dataSet, "Record")

            ' Obtener la última fecha en la que el jugador ha jugado
            Dim lastDate As Date = dataSet.Tables("Record").Rows(0).Field(Of Date)("WinDate")

            ' Mostrar la última fecha en el TextBox
            TextBoxUltimaPartida.Text = lastDate.ToString("dd/MM/yyyy")
        Catch ex As OleDbException
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try







    End Sub





End Class