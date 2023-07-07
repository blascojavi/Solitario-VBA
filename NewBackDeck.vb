Public Class NewBackDeck
    Public traseraCambio As String
    Private Sub NewBackDeck_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PictureBox1.Image = My.Resources.background1
        PictureBox2.Image = My.Resources.background2
        PictureBox3.Image = My.Resources.background3
        PictureBox4.Image = My.Resources.background4
        PictureBox5.Image = My.Resources.background5
        RadioButton1.Name = "background1"
        RadioButton2.Name = "background2"
        RadioButton3.Name = "background3"
        RadioButton4.Name = "background4"
        RadioButton5.Name = "background5"
        AddHandler RadioButton1.CheckedChanged, AddressOf RadioButton_CheckedChanged
        AddHandler RadioButton2.CheckedChanged, AddressOf RadioButton_CheckedChanged
        AddHandler RadioButton3.CheckedChanged, AddressOf RadioButton_CheckedChanged
        AddHandler RadioButton4.CheckedChanged, AddressOf RadioButton_CheckedChanged
        AddHandler RadioButton5.CheckedChanged, AddressOf RadioButton_CheckedChanged


        Dim radioButtons As RadioButton() = {RadioButton1, RadioButton2, RadioButton3, RadioButton4, RadioButton5}
        For Each radioButton In radioButtons
            AddHandler radioButton.CheckedChanged, AddressOf RadioButton_CheckedChanged
        Next
        For Each radioButton In radioButtons
            AddHandler radioButton.CheckedChanged, AddressOf RadioButton_CheckedChanged
        Next


    End Sub




    Private Sub RadioButton_CheckedChanged(sender As Object, e As EventArgs)
        Dim radioButton As RadioButton = DirectCast(sender, RadioButton)
        If radioButton.Checked Then
            Dim valorSeleccionado As String = radioButton.Text
            ' Aquí puedes guardar el valor seleccionado en una variable o en algún otro lugar
            traseraCambio = radioButton.Name
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        traseraCambio = traseraCambio
        Form1.RecibirTraseraCambio(traseraCambio)
        Form1.inicioJuego()
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class