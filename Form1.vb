Imports System.Data.OleDb

Public Class Form1
    'Creación de imágenes miniaturas a partir de las imágenes de recursos
    Dim imagenClubs As Image = My.Resources.clubs.GetThumbnailImage(138, 210, Nothing, IntPtr.Zero)
    Dim imagenDiamonds As Image = My.Resources.diamonds.GetThumbnailImage(138, 210, Nothing, IntPtr.Zero)
    Dim imagenHearts As Image = My.Resources.hearts.GetThumbnailImage(138, 210, Nothing, IntPtr.Zero)
    Dim imagenSpades As Image = My.Resources.spades.GetThumbnailImage(138, 210, Nothing, IntPtr.Zero)
    Dim background1 As Image = My.Resources.background1.GetThumbnailImage(138, 210, Nothing, IntPtr.Zero)
    Dim background2 As Image = My.Resources.background1.GetThumbnailImage(138, 210, Nothing, IntPtr.Zero)
    Dim background3 As Image = My.Resources.background1.GetThumbnailImage(138, 210, Nothing, IntPtr.Zero)
    Dim background4 As Image = My.Resources.background1.GetThumbnailImage(138, 210, Nothing, IntPtr.Zero)

    Dim numeroAciertos As Integer = 0

    Dim carta As String



    Dim primeraTrebol As New PictureBox()
    Dim primeraDiamante As New PictureBox()
    Dim primeraCorazon As New PictureBox()
    Dim primeraEspadas As New PictureBox()

    Private listTrebolesImg As New List(Of Image)
    Private listCorazonesImg As New List(Of Image)
    Private listDiamantesImg As New List(Of Image)
    Private listPicasImg As New List(Of Image)

    Private cartasDisponibles As New List(Of Tuple(Of String, Image))



    Dim numAleatorioResult As String
    Dim resultPrueba As String
    Dim recurso As String
    Dim cartaAleatoria As New PictureBox
    Dim nombreJugador As String
    Dim tiempo As Integer = 0
    Dim contador As New Timer()
    ' Dim picturebox As PictureBox
    Public contadorPicture As Integer = 0
    Dim pictureboxList As New List(Of PictureBox)
    Dim posicionX As Integer = 40
    ' Dim currentCard As String = obtenerSiguienteCarta().Substring(6)
    ''La incializamos en 0 en la primera partida, por lo que en la primera siempre será boton derecho
    'pero aunque se pierda e iniciemos nuevo juego, se queda el valor de la última jugada que hemos perdido
    Dim previousCard As String = 0
    Public aciertos As Integer = 0
    Public errores As Integer = 0
    Public traseraCambio As String = "background1"
    Public nombreGanador As String
    Public tiempoGanador As String
    Public bandera As Boolean = True
    Public numsPrueba As New List(Of Integer)
    Public contAleatoria As Integer = 0
    Private listaCartas As List(Of String)
    Private indexActual As Integer




    Private Sub NewGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewGameToolStripMenuItem.Click
        ResetComponents()
        inicioJuego()
        '' crearAleatoria()
        '' aleatoriaNueva()
        dameNombre()
        bandera = True
        deck.Image = My.Resources.ResourceManager.GetObject(traseraCambio)

        deck.Enabled = True

        'Asignación de las imágenes miniaturas a los PictureBox correspondientes
        pictureBoxClubs.Image = imagenClubs
        pictureBoxDiamonds.Image = imagenDiamonds
        pictureBoxHearts.Image = imagenHearts
        PictureBoxSpades.Image = imagenSpades

        crearPrimeraCartaRuntime()

    End Sub


    Public Sub inicioJuego()
        ''cargamos el reverso de la carta al iniciar
        crearAleatoria()
        deck.Image = My.Resources.ResourceManager.GetObject(traseraCambio)
        tiempo = 0
        contador.Enabled = True
        ' cargarCartasBaraja()
    End Sub

    '   Private Sub cargarCartasBaraja()
    ' Llenar las listas de imágenes con las cartas correspondientes al inicio de cada juego
    '       listTrebolesImg.Clear()
    '      listCorazonesImg.Clear()
    '      listDiamantesImg.Clear()
    '     listPicasImg.Clear()

    ' For i As Integer = 1 To 13
    ''         listTrebolesImg.Add(My.Resources.ResourceManager.GetObject("clubs_" & i))
    'Next

    ' For i As Integer = 14 To 26
    '        listCorazonesImg.Add(My.Resources.ResourceManager.GetObject("hearts_" & (i - 13)))
    ' Next

    ' For i As Integer = 27 To 39
    '          listDiamantesImg.Add(My.Resources.ResourceManager.GetObject("diamonds_" & (i - 26)))
    '  Next
    '
    '  For i As Integer = 40 To 52
    '        listPicasImg.Add(My.Resources.ResourceManager.GetObject("spades_" & (i - 39)))
    '  Next
    '  End Sub

    Public Sub dameNombre()
        If String.IsNullOrEmpty(nombreJugador) Then
            nombreJugador = InputBox("Por favor ingrese su nombre:", "Nombre del jugador")
            If nombreJugador = "" Then
                MessageBox.Show("No ha introducido ningun nombre" & vbCrLf & "El nombre por defecto es Jugador 1", "Error", MessageBoxButtons.OK)
                ''Close()
                '' MessageBox.Show("El nombre por defecto es Jugador 1")
                nombreJugador = "jugador1"
            End If
        End If
        labelJugador.Text = nombreJugador

    End Sub


    Private Sub ChangeBackOfDeckToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeBackOfDeckToolStripMenuItem.Click
        NewBackDeck.Show()

    End Sub

    Private Sub ChangePlayerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePlayerToolStripMenuItem.Click
        nombreJugador = ""
        dameNombre()
    End Sub




    Public Sub ResetComponents() ''No elminia el ultimo picturebox
        ''numAleatorioResult = ""
        ''  resultPrueba = ""
        ''   recurso = ""
        cartaAleatoria = New PictureBox()
        ''nombreJugador = ""
        tiempo = 0
        contadorPicture = 0
        '' pictureboxList = New List(Of PictureBox)
        posicionX = 40
        ''  previousCard = 0
        aciertos = 0
        errores = 0
        numeroAciertos = 0

        borrarPictureViews()
        borrarPictureViewsnumeros()
        contador.Enabled = True
    End Sub
    Public Sub borrarPictureViews()

        For i As Integer = Me.Controls.Count - 1 To 0 Step -1
            Dim control As Control = Me.Controls(i)
            If control.GetType() = GetType(PictureBox) Then
                If control.Name.StartsWith("_") Then
                    Me.Controls.RemoveAt(i)
                    control.Dispose()
                End If
            End If
        Next


    End Sub


    Public Sub borrarPictureViewsnumeros()

        For i As Integer = Me.Controls.Count - 1 To 0 Step -1
            Dim control As Control = Me.Controls(i)
            If control.GetType() = GetType(PictureBox) Then
                Dim regex As New System.Text.RegularExpressions.Regex("[0-9]+")
                If regex.IsMatch(control.Name) AndAlso CInt(regex.Match(control.Name).Value) >= 1 AndAlso CInt(regex.Match(control.Name).Value) <= 52 Then
                    Me.Controls.RemoveAt(i)
                    control.Dispose()
                End If
            End If
        Next

    End Sub


    Public Sub crearPrimeraCartaRuntime()
        'Configuración de las propiedades de los PictureBox
        primeraTrebol.Name = "primeraTrebol"
        primeraDiamante.Name = "primeraDiamante"
        primeraCorazon.Name = "primeraCorazon"
        primeraEspadas.Name = "primeraEspadas"

        primeraTrebol.Location = New Point(353, 60)
        primeraDiamante.Location = New Point(561, 60)
        primeraCorazon.Location = New Point(735, 60)
        primeraEspadas.Location = New Point(933, 60)

        primeraTrebol.Size = New Size(138, 210)
        primeraDiamante.Size = New Size(138, 210)
        primeraCorazon.Size = New Size(138, 210)
        primeraEspadas.Size = New Size(138, 210)

        'Agregación de los PictureBox al formulario
        Me.Controls.Add(primeraTrebol)
        Me.Controls.Add(primeraDiamante)
        Me.Controls.Add(primeraCorazon)
        Me.Controls.Add(primeraEspadas)

        'Los pasams por delante de los ay creados
        '  primeraTrebol.BringToFront()
        '  primeraDiamante.BringToFront()
        '  primeraCorazon.BringToFront()
        '  primeraEspadas.BringToFront()

        'primeraTrebol.Image = My.Resources.ResourceManager.GetObject(background1)
        'primeraDiamante.Image = My.Resources.ResourceManager.GetObject(background1)
        'primeraCorazon.Image = My.Resources.ResourceManager.GetObject(background1)
        'primeraTrebol.Image = My.Resources.ResourceManager.GetObject(background1)



        '  primeraTrebol.Image = My.Resources.background1
        '   primeraDiamante.Image = My.Resources.background1
        '   primeraCorazon.Image = My.Resources.background1
        '   primeraEspadas.Image = My.Resources.background1

    End Sub


    Public Sub RecibirTraseraCambio(valor As String)
        'Aquí puedes utilizar el valor de traseraCambio como desees
        MessageBox.Show(valor)
        traseraCambio = valor
    End Sub



    Public Sub crearAleatoria()
        Dim random As New Random()
        Dim numsPrueba As New List(Of Integer)

        ' Agrega 52 números aleatorios a la lista "numsPrueba", sin repetirse
        For index = 1 To 52
            Dim numero As Integer
            Do
                numero = random.Next(1, 53)
            Loop Until Not numsPrueba.Contains(numero)
            numsPrueba.Add(numero)
        Next

        ' Crear la lista de cartas aleatorias
        listaCartas = New List(Of String)()
        For Each num In numsPrueba
            listaCartas.Add("_" & num)
        Next

        ' Reiniciar el índice actual
        indexActual = 0
    End Sub



    Public Function obtenerSiguienteCarta() As String
        'Verificar si se han agotado todas las cartas
        If indexActual >= listaCartas.Count Then
            'Reiniciar el índice actual y borrar todos los PictureBox creados
            indexActual = 0
            For i As Integer = Me.Controls.Count - 1 To 0 Step -1
                Dim control As Control = Me.Controls(i)
                If control.GetType() = GetType(PictureBox) Then
                    If control.Name.StartsWith("carta_") Then
                        Me.Controls.RemoveAt(i)
                        control.Dispose()
                    End If
                End If
            Next
            borrarPictureViews()
            'Si no pusieramos nada despues de aquí antes del end if, seguiria el juego sacando las cartas restantes hasta ganar al vaciar la lista, pero vamos ha hacer que acabe cuando hayan salido todas las cartas
            finDelJuego()
        End If

        'Obtener la siguiente carta de la lista
        carta = listaCartas(indexActual)

        'Incrementar el índice actual para la siguiente llamada
        indexActual += 1

        'Crear un PictureBox para la carta actual
        Dim pb As New PictureBox()
        'pb.Name = "carta_" & carta
        pb.Name = carta
        pb.Location = New Point(40 + (indexActual - 1) * 20, 300)
        pb.Size = New Size(138, 210)
        pb.Image = My.Resources.ResourceManager.GetObject(carta)
        Me.Controls.Add(pb)
        pb.BringToFront()

        ' suscribirse al evento MouseDown del picture box
        AddHandler pb.MouseDown, AddressOf pb_MouseDown


        'Devolver el nombre de la carta actual
        Return carta

    End Function





    Public Sub deck_MouseDown(sender As Object, e As MouseEventArgs) Handles deck.MouseDown
        obtenerSiguienteCarta()
        TextBox1.Text = carta

    End Sub




    '   Private Sub deck_MouseDown(sender As Object, e As MouseEventArgs) Handles deck.MouseDown
    '  If e.Button = MouseButtons.Right Then
    ' Dim carta As String = obtenerSiguienteCarta()
    ' If carta = "_1" Then
    '              MessageBox.Show("Es un as de tréboles!")
    '          End If
    '  End If
    '  End Sub

    Public Sub comprobarAs()



    End Sub

    'Perdona, se que hay mas opciones, pero esta es la que me ha salido, queria haer una lista de las cartas y asignarles un valor para despues acceder a el,
    'pero no me salia y he tirado por lo practico del If Else y funciona bien aunque sea muy largo


    '    Private Sub pb_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)

    ' If e.Button = MouseButtons.Right Then ' Verifica si se hizo clic en el botón derecho del mouse
    ' Aquí va el código para manejar el evento del clic derecho del mouse
    '   If carta = "_1" Then
    '              MessageBox.Show("Ha seleccionado el as de treboles")
    '  End If
    '   If carta = "_14" Then
    '            MessageBox.Show("Ha seleccionado el as de Corazones")
    '  End If
    '   If carta = "_27" Then
    '             MessageBox.Show("Ha seleccionado el as de Diamantes")
    '          End If
    'If carta = "_40" Then
    '              MessageBox.Show("Ha seleccionado el as de Picas")
    '   End If
    '  End If

    '  End Sub

    Private Sub pb_MouseDown(sender As Object, e As MouseEventArgs)
        ''SE QUE HAY OTROS MODOS, PERO AHORA MISMO ES EL QUE ME HA FUNCIONADO CORRECTAMENTE Y ES FUNCIONAL
        If e.Button = MouseButtons.Right Then ' Verifica si se hizo clic en el botón derecho del mouse
            ' Aquí va el código para manejar el evento del clic derecho del mouse
            If carta = "_1" Then
                '  MessageBox.Show("Ha seleccionado el as de treboles")
                Dim pb As PictureBox = CType(sender, PictureBox)
                pb.Location = pictureBoxClubs.Location ' Mueve la carta al pictureBoxClubs
                listaCartas.Remove("_1") ' Elimina el as de treboles de la listaCartas
                pb.Name = "1" ' Cambia el nombre del PictureBox a "1"
                numeroAciertos += 1
            ElseIf listaCartas.Contains("_1") = False AndAlso carta = "_2" Then
                ' MessageBox.Show("Ha seleccionado el dos de treboles")
                Dim pb As PictureBox = CType(sender, PictureBox)
                pb.Location = New Point(pictureBoxClubs.Location.X, pictureBoxClubs.Location.Y + 20) ' Mueve la carta al pictureBoxClubs pero 20 puntos hacia abajo
                listaCartas.Remove("_2") ' Elimina el as de treboles de la listaCartas
                pb.Name = "2" ' Cambia el nombre del PictureBox a "2"
                numeroAciertos += 1
            ElseIf listaCartas.Contains("_2") = False AndAlso carta = "_3" Then
                '  MessageBox.Show("Ha seleccionado el tres de treboles")
                Dim pb As PictureBox = CType(sender, PictureBox)
                pb.Location = New Point(pictureBoxClubs.Location.X, pictureBoxClubs.Location.Y + 40)
                listaCartas.Remove("_3") ' Elimina el tres de treboles de la listaCartas
                pb.Name = "3" ' Cambia el nombre del PictureBox a "3"
                numeroAciertos += 1
            ElseIf listaCartas.Contains("_3") = False AndAlso carta = "_4" Then
                ' MessageBox.Show("Ha seleccionado el cuatro de treboles")
                Dim pb As PictureBox = CType(sender, PictureBox)
                pb.Location = New Point(pictureBoxClubs.Location.X, pictureBoxClubs.Location.Y + 60) ' Mueve la carta al pictureBoxClubs pero 60 puntos hacia abajo
                listaCartas.Remove("_4") ' Elimina el cuatro de treboles de la listaCartas
                pb.Name = "4" ' Cambia el nombre del PictureBox a "4"
                numeroAciertos += 1
            ElseIf listaCartas.Contains("_4") = False AndAlso carta = "_5" Then
                ' MessageBox.Show("Ha seleccionado el cinco de treboles")
                Dim pb As PictureBox = CType(sender, PictureBox)
                pb.Location = New Point(pictureBoxClubs.Location.X, pictureBoxClubs.Location.Y + 80) ' Mueve la carta al pictureBoxClubs pero 80 puntos hacia abajo
                listaCartas.Remove("_5") ' Elimina el cinco de treboles de la listaCartas
                pb.Name = "5" ' Cambia el nombre del PictureBox a "5"
                numeroAciertos += 1
            ElseIf listaCartas.Contains("_5") = False AndAlso carta = "_6" Then
                '  MessageBox.Show("Ha seleccionado el seis de treboles")
                Dim pb As PictureBox = CType(sender, PictureBox)
                pb.Location = New Point(pictureBoxClubs.Location.X, pictureBoxClubs.Location.Y + 100) ' Mueve la carta al pictureBoxClubs pero 100 puntos hacia abajo
                listaCartas.Remove("_6") ' Elimina el seis de treboles de la listaCartas
                pb.Name = "6" ' Cambia el nombre del PictureBox a "6"
                numeroAciertos += 1
            ElseIf listaCartas.Contains("_6") = False AndAlso carta = "_7" Then
                '   MessageBox.Show("Ha seleccionado el siete de treboles")
                Dim pb As PictureBox = CType(sender, PictureBox)
                pb.Location = New Point(pictureBoxClubs.Location.X, pictureBoxClubs.Location.Y + 100)
                listaCartas.Remove("_7") ' Elimina el siete de treboles de la listaCartas
                pb.Name = "7" ' Cambia el nombre del PictureBox a "7"
                numeroAciertos += 1
            ElseIf listaCartas.Contains("_7") = False AndAlso carta = "_8" Then
                ' MessageBox.Show("Ha seleccionado el ocho de treboles")
                Dim pb As PictureBox = CType(sender, PictureBox)
                pb.Location = New Point(pictureBoxClubs.Location.X, pictureBoxClubs.Location.Y + 120)
                listaCartas.Remove("_8") ' Elimina el ocho de treboles de la listaCartas
                pb.Name = "8" ' Cambia el nombre del PictureBox a "8"
                numeroAciertos += 1
            ElseIf listaCartas.Contains("_8") = False AndAlso carta = "_9" Then
                '   MessageBox.Show("Ha seleccionado el nueve de treboles")
                Dim pb As PictureBox = CType(sender, PictureBox)
                pb.Location = New Point(pictureBoxClubs.Location.X, pictureBoxClubs.Location.Y + 140)
                listaCartas.Remove("_9") ' Elimina el nueve de treboles de la listaCartas
                pb.Name = "9" ' Cambia el nombre del PictureBox a "9"
                numeroAciertos += 1
            ElseIf listaCartas.Contains("_9") = False AndAlso carta = "_10" Then
                ' MessageBox.Show("Ha seleccionado el diez de treboles")
                Dim pb As PictureBox = CType(sender, PictureBox)
                pb.Location = New Point(pictureBoxClubs.Location.X, pictureBoxClubs.Location.Y + 160)
                listaCartas.Remove("_10") ' Elimina el diez de treboles de la listaCartas
                pb.Name = "10" ' Cambia el nombre del PictureBox a "10"
                numeroAciertos += 1
            ElseIf listaCartas.Contains("_10") = False AndAlso carta = "_11" Then
                ' MessageBox.Show("Ha seleccionado el J de treboles")
                Dim pb As PictureBox = CType(sender, PictureBox)
                pb.Location = New Point(pictureBoxClubs.Location.X, pictureBoxClubs.Location.Y + 180)
                listaCartas.Remove("_11") ' Elimina el J de treboles de la listaCartas
                pb.Name = "11" ' Cambia el nombre del PictureBox a "11"
                numeroAciertos += 1
            ElseIf listaCartas.Contains("_11") = False AndAlso carta = "_12" Then
                ' MessageBox.Show("Ha seleccionado el Q de treboles")
                Dim pb As PictureBox = CType(sender, PictureBox)
                pb.Location = New Point(pictureBoxClubs.Location.X, pictureBoxClubs.Location.Y + 200)
                listaCartas.Remove("_12") ' Elimina el Q de treboles de la listaCartas
                pb.Name = "12" ' Cambia el nombre del PictureBox a "12"
                numeroAciertos += 1
            ElseIf listaCartas.Contains("_12") = False AndAlso carta = "_13" Then
                '   MessageBox.Show("Ha seleccionado el K de treboles")
                Dim pb As PictureBox = CType(sender, PictureBox)
                pb.Location = New Point(pictureBoxClubs.Location.X, pictureBoxClubs.Location.Y + 220)
                listaCartas.Remove("_13") ' Elimina el K de treboles de la listaCartas
                pb.Name = "13" ' Cambia el nombre del PictureBox a "13"
                numeroAciertos += 1

            ElseIf carta = "_14" Then
                ' MessageBox.Show("Ha seleccionado el as de corazones")
                Dim pb As PictureBox = CType(sender, PictureBox)
                pb.Location = pictureBoxHearts.Location ' Mueve la carta al pictureBoxHearts
                listaCartas.Remove("_14") ' Elimina el as de corazones de la listaCartas
                pb.Name = "14" ' Cambia el nombre del PictureBox a "14"
                numeroAciertos += 1
            ElseIf listaCartas.Contains("_14") = False AndAlso carta = "_15" Then
                ' MessageBox.Show("Ha seleccionado el dos de corazones")
                Dim pb As PictureBox = CType(sender, PictureBox)
                pb.Location = New Point(pictureBoxHearts.Location.X, pictureBoxHearts.Location.Y + 20)
                listaCartas.Remove("_15") ' Elimina el dos de corazones de la listaCartas
                pb.Name = "15" ' Cambia el nombre del PictureBox
                numeroAciertos += 1

            ElseIf listaCartas.Contains("_15") = False AndAlso carta = "_16" Then
                ' MessageBox.Show("Ha seleccionado el tres de corazones")
                Dim pb As PictureBox = CType(sender, PictureBox)
                pb.Location = New Point(pictureBoxHearts.Location.X, pictureBoxHearts.Location.Y + 20)
                listaCartas.Remove("_16") ' Elimina el tres de corazones de la listaCartas
                pb.Name = "16" ' Cambia el nombre del PictureBox
                numeroAciertos += 1
            ElseIf listaCartas.Contains("_16") = False AndAlso carta = "_17" Then
                ' MessageBox.Show("Ha seleccionado el cuatro de corazones")
                Dim pb As PictureBox = CType(sender, PictureBox)
                pb.Location = New Point(pictureBoxHearts.Location.X, pictureBoxHearts.Location.Y + 60)
                listaCartas.Remove("_17") ' Elimina el cuatro de corazones de la listaCartas
                pb.Name = "17" ' Cambia el nombre del PictureBox
                numeroAciertos += 1

            ElseIf listaCartas.Contains("_17") = False AndAlso carta = "_18" Then
                ' MessageBox.Show("Ha seleccionado el cinco de corazones")
                Dim pb As PictureBox = CType(sender, PictureBox)
                pb.Location = New Point(pictureBoxHearts.Location.X, pictureBoxHearts.Location.Y + 80)
                listaCartas.Remove("_18") ' Elimina el cinco de corazones de la listaCartas
                pb.Name = "18" ' Cambia el nombre del PictureBox
                numeroAciertos += 1

            ElseIf listaCartas.Contains("_18") = False AndAlso carta = "_19" Then
                ' MessageBox.Show("Ha seleccionado el seis de corazones")
                Dim pb As PictureBox = CType(sender, PictureBox)
                pb.Location = New Point(pictureBoxHearts.Location.X, pictureBoxHearts.Location.Y + 100)
                listaCartas.Remove("_19") ' Elimina el seis de corazones de la listaCartas
                pb.Name = "19" ' Cambia el nombre del PictureBox
                numeroAciertos += 1

            ElseIf listaCartas.Contains("_19") = False AndAlso carta = "_20" Then
                ' MessageBox.Show("Ha seleccionado el siete de corazones")
                Dim pb As PictureBox = CType(sender, PictureBox)
                pb.Location = New Point(pictureBoxHearts.Location.X, pictureBoxHearts.Location.Y + 120)
                listaCartas.Remove("_20") ' Elimina el siete de corazones de la listaCartas
                pb.Name = "20" ' Cambia el nombre del PictureBox
                numeroAciertos += 1

            ElseIf listaCartas.Contains("_20") = False AndAlso carta = "_21" Then
                ' MessageBox.Show("Ha seleccionado el ocho de corazones")
                Dim pb As PictureBox = CType(sender, PictureBox)
                pb.Location = New Point(pictureBoxHearts.Location.X, pictureBoxHearts.Location.Y + 120)
                listaCartas.Remove("_21") ' Elimina el ocho de corazones de la listaCartas
                pb.Name = "21" ' Cambia el nombre del PictureBox
                numeroAciertos += 1

            ElseIf listaCartas.Contains("_21") = False AndAlso carta = "_22" Then
                ' MessageBox.Show("Ha seleccionado el nueve de corazones")
                Dim pb As PictureBox = CType(sender, PictureBox)
                pb.Location = New Point(pictureBoxHearts.Location.X, pictureBoxHearts.Location.Y + 140)
                listaCartas.Remove("_22") ' Elimina el nueve de corazones de la listaCartas
                pb.Name = "22" ' Cambia el nombre del PictureBox 
                numeroAciertos += 1

            ElseIf listaCartas.Contains("_22") = False AndAlso carta = "_23" Then
                ' MessageBox.Show("Ha seleccionado el diez de corazones")
                Dim pb As PictureBox = CType(sender, PictureBox)
                pb.Location = New Point(pictureBoxHearts.Location.X, pictureBoxHearts.Location.Y + 160)
                listaCartas.Remove("_23") ' Elimina el nueve de corazones de la listaCartas
                pb.Name = "23" ' Cambia el nombre del PictureBox 
                numeroAciertos += 1

            ElseIf listaCartas.Contains("_23") = False AndAlso carta = "_24" Then
                ' MessageBox.Show("Ha seleccionado el J de corazones")
                Dim pb As PictureBox = CType(sender, PictureBox)
                pb.Location = New Point(pictureBoxHearts.Location.X, pictureBoxHearts.Location.Y + 180)
                listaCartas.Remove("_24") ' Elimina el J de corazones de la listaCartas
                pb.Name = "24" ' Cambia el nombre del PictureBox  
                numeroAciertos += 1
            ElseIf listaCartas.Contains("_24") = False AndAlso carta = "_25" Then
                ' MessageBox.Show("Ha seleccionado el Q de corazones")
                Dim pb As PictureBox = CType(sender, PictureBox)
                pb.Location = New Point(pictureBoxHearts.Location.X, pictureBoxHearts.Location.Y + 200)
                listaCartas.Remove("_25") ' Elimina el Q de corazones de la listaCartas
                pb.Name = "25" ' Cambia el nombre del PictureBox
                numeroAciertos += 1
            ElseIf listaCartas.Contains("_25") = False AndAlso carta = "_26" Then
                ' MessageBox.Show("Ha seleccionado el K de corazones")
                Dim pb As PictureBox = CType(sender, PictureBox)
                pb.Location = New Point(pictureBoxHearts.Location.X, pictureBoxHearts.Location.Y + 220)
                listaCartas.Remove("_26") ' Elimina el K de corazones de la listaCartas
                pb.Name = "26" ' Cambia el nombre del PictureBox
                numeroAciertos += 1




            ElseIf carta = "_27" Then
                ' MessageBox.Show("Ha seleccionado el as de diamantes")
                Dim pb As PictureBox = CType(sender, PictureBox)
                pb.Location = pictureBoxDiamonds.Location ' Mueve la carta al pictureBoxDiamonds
                listaCartas.Remove("_27") ' Elimina el as de corazones de la listaCartas
                pb.Name = "27" ' Cambia el nombre del PictureBox
                numeroAciertos += 1
            ElseIf listaCartas.Contains("_27") = False AndAlso carta = "_28" Then
                ' MessageBox.Show("Ha seleccionado el dos de diamantes")
                Dim pb As PictureBox = CType(sender, PictureBox)
                pb.Location = New Point(pictureBoxDiamonds.Location.X, pictureBoxDiamonds.Location.Y + 20)
                listaCartas.Remove("_28") ' Elimina el dos de diamantes de la listaCartas
                pb.Name = "28" ' Cambia el nombre del PictureBox
                numeroAciertos += 1
            ElseIf listaCartas.Contains("_28") = False AndAlso carta = "_29" Then
                ' MessageBox.Show("Ha seleccionado el tres de diamantes")
                Dim pb As PictureBox = CType(sender, PictureBox)
                pb.Location = New Point(pictureBoxDiamonds.Location.X, pictureBoxDiamonds.Location.Y + 40)
                listaCartas.Remove("_29") ' Elimina el tres de diamantes de la listaCartas
                pb.Name = "29" ' Cambia el nombre del PictureBox
                numeroAciertos += 1
            ElseIf listaCartas.Contains("_29") = False AndAlso carta = "_30" Then
                ' MessageBox.Show("Ha seleccionado el cuatro de diamantes")
                Dim pb As PictureBox = CType(sender, PictureBox)
                pb.Location = New Point(pictureBoxDiamonds.Location.X, pictureBoxDiamonds.Location.Y + 60)
                listaCartas.Remove("_30") ' Elimina el cuatro de diamantes de la listaCartas
                pb.Name = "30" ' Cambia el nombre del PictureBox
                numeroAciertos += 1
            ElseIf listaCartas.Contains("_30") = False AndAlso carta = "_31" Then
                ' MessageBox.Show("Ha seleccionado el cinco de diamantes")
                Dim pb As PictureBox = CType(sender, PictureBox)
                pb.Location = New Point(pictureBoxDiamonds.Location.X, pictureBoxDiamonds.Location.Y + 80)
                listaCartas.Remove("_31") ' Elimina el cinco de diamantes de la listaCartas
                pb.Name = "31" ' Cambia el nombre del PictureBox
                numeroAciertos += 1
            ElseIf listaCartas.Contains("_31") = False AndAlso carta = "_32" Then
                ' MessageBox.Show("Ha seleccionado el seis de diamantes")
                Dim pb As PictureBox = CType(sender, PictureBox)
                pb.Location = New Point(pictureBoxDiamonds.Location.X, pictureBoxDiamonds.Location.Y + 100)
                listaCartas.Remove("_32") ' Elimina el seis de diamantes de la listaCartas
                pb.Name = "32" ' Cambia el nombre del PictureBox
                numeroAciertos += 1
            ElseIf listaCartas.Contains("_32") = False AndAlso carta = "_33" Then
                ' MessageBox.Show("Ha seleccionado el siete de diamantes")
                Dim pb As PictureBox = CType(sender, PictureBox)
                pb.Location = New Point(pictureBoxDiamonds.Location.X, pictureBoxDiamonds.Location.Y + 120)
                listaCartas.Remove("_33") ' Elimina el siete de diamantes de la listaCartas
                pb.Name = "33" ' Cambia el nombre del PictureBox
                numeroAciertos += 1
            ElseIf listaCartas.Contains("_33") = False AndAlso carta = "_34" Then
                ' MessageBox.Show("Ha seleccionado el ocho de diamantes")
                Dim pb As PictureBox = CType(sender, PictureBox)
                pb.Location = New Point(pictureBoxDiamonds.Location.X, pictureBoxDiamonds.Location.Y + 140)
                listaCartas.Remove("_34") ' Elimina el ocho de diamantes de la listaCartas
                pb.Name = "34" ' Cambia el nombre del PictureBox
                numeroAciertos += 1
            ElseIf listaCartas.Contains("_34") = False AndAlso carta = "_35" Then
                ' MessageBox.Show("Ha seleccionado el nueve de diamantes")
                Dim pb As PictureBox = CType(sender, PictureBox)
                pb.Location = New Point(pictureBoxDiamonds.Location.X, pictureBoxDiamonds.Location.Y + 160)
                listaCartas.Remove("_35") ' Elimina el nueve de diamantes de la listaCartas
                pb.Name = "35" ' Cambia el nombre del PictureBox
                numeroAciertos += 1
            ElseIf listaCartas.Contains("_35") = False AndAlso carta = "_36" Then
                ' MessageBox.Show("Ha seleccionado el diez de diamantes")
                Dim pb As PictureBox = CType(sender, PictureBox)
                pb.Location = New Point(pictureBoxDiamonds.Location.X, pictureBoxDiamonds.Location.Y + 180)
                listaCartas.Remove("_36") ' Elimina el diez de diamantes de la listaCartas
                pb.Name = "36" ' Cambia el nombre del PictureBox
                numeroAciertos += 1
            ElseIf listaCartas.Contains("_36") = False AndAlso carta = "_37" Then
                ' MessageBox.Show("Ha seleccionado el J de diamantes")
                Dim pb As PictureBox = CType(sender, PictureBox)
                pb.Location = New Point(pictureBoxDiamonds.Location.X, pictureBoxDiamonds.Location.Y + 200)
                listaCartas.Remove("_37") ' Elimina el J de diamantes de la listaCartas
                pb.Name = "37" ' Cambia el nombre del PictureBox
                numeroAciertos += 1
            ElseIf listaCartas.Contains("_37") = False AndAlso carta = "_38" Then
                ' MessageBox.Show("Ha seleccionado el Q de diamantes")
                Dim pb As PictureBox = CType(sender, PictureBox)
                pb.Location = New Point(pictureBoxDiamonds.Location.X, pictureBoxDiamonds.Location.Y + 220)
                listaCartas.Remove("_38") ' Elimina el Q de diamantes de la listaCartas
                pb.Name = "38" ' Cambia el nombre del PictureBox
                numeroAciertos += 1
            ElseIf listaCartas.Contains("_38") = False AndAlso carta = "_39" Then
                ' MessageBox.Show("Ha seleccionado el K de diamantes")
                Dim pb As PictureBox = CType(sender, PictureBox)
                pb.Location = New Point(pictureBoxDiamonds.Location.X, pictureBoxDiamonds.Location.Y + 240)
                listaCartas.Remove("_39") ' Elimina el K de diamantes de la listaCartas
                pb.Name = "39" ' Cambia el nombre del PictureBox
                numeroAciertos += 1

            ElseIf carta = "_40" Then
                ' MessageBox.Show("Ha seleccionado el as de picas")
                Dim pb As PictureBox = CType(sender, PictureBox)
                pb.Location = PictureBoxSpades.Location ' Mueve la carta al pictureBoxSpades
                listaCartas.Remove("_40") ' Elimina el as de corazones de la listaCartas
                pb.Name = "40" ' Cambia el nombre del PictureBox
                numeroAciertos += 1

            ElseIf listaCartas.Contains("_40") = False AndAlso carta = "_41" Then
                ' MessageBox.Show("Ha seleccionado el dos de picas")
                Dim pb As PictureBox = CType(sender, PictureBox)
                pb.Location = New Point(PictureBoxSpades.Location.X, PictureBoxSpades.Location.Y + 20)
                listaCartas.Remove("_41") ' Elimina el dos de picas de la listaCartas
                pb.Name = "41" ' Cambia el nombre del PictureBox
                numeroAciertos += 1

            ElseIf listaCartas.Contains("_41") = False AndAlso carta = "_42" Then
                ' MessageBox.Show("Ha seleccionado el tres de picas")
                Dim pb As PictureBox = CType(sender, PictureBox)
                pb.Location = New Point(PictureBoxSpades.Location.X, PictureBoxSpades.Location.Y + 40)
                listaCartas.Remove("_42") ' Elimina el tres de picas de la listaCartas
                pb.Name = "42" ' Cambia el nombre del PictureBox
                numeroAciertos += 1

            ElseIf listaCartas.Contains("_42") = False AndAlso carta = "_43" Then
                ' MessageBox.Show("Ha seleccionado el cuatro de picas")
                Dim pb As PictureBox = CType(sender, PictureBox)
                pb.Location = New Point(PictureBoxSpades.Location.X, PictureBoxSpades.Location.Y + 60)
                listaCartas.Remove("_43") ' Elimina el cuatro de picas de la listaCartas
                pb.Name = "43" ' Cambia el nombre del PictureBox
                numeroAciertos += 1
            ElseIf listaCartas.Contains("_43") = False AndAlso carta = "_44" Then
                ' MessageBox.Show("Ha seleccionado el cinco de picas")
                Dim pb As PictureBox = CType(sender, PictureBox)
                pb.Location = New Point(PictureBoxSpades.Location.X, PictureBoxSpades.Location.Y + 80)
                listaCartas.Remove("_44") ' Elimina el cinco de picas de la listaCartas
                pb.Name = "44" ' Cambia el nombre del PictureBox
                numeroAciertos += 1
            ElseIf listaCartas.Contains("_44") = False AndAlso carta = "_45" Then
                ' MessageBox.Show("Ha seleccionado el seis de picas")
                Dim pb As PictureBox = CType(sender, PictureBox)
                pb.Location = New Point(PictureBoxSpades.Location.X, PictureBoxSpades.Location.Y + 100)
                listaCartas.Remove("_45") ' Elimina el seis de picas de la listaCartas
                pb.Name = "45" ' Cambia el nombre del PictureBox
                numeroAciertos += 1
            ElseIf listaCartas.Contains("_45") = False AndAlso carta = "_46" Then
                ' MessageBox.Show("Ha seleccionado el siete de picas")
                Dim pb As PictureBox = CType(sender, PictureBox)
                pb.Location = New Point(PictureBoxSpades.Location.X, PictureBoxSpades.Location.Y + 120)
                listaCartas.Remove("_46") ' Elimina el siete de picas de la listaCartas
                pb.Name = "46" ' Cambia el nombre del PictureBox
                numeroAciertos += 1
            ElseIf listaCartas.Contains("_46") = False AndAlso carta = "_47" Then
                ' MessageBox.Show("Ha seleccionado el ocho de picas")
                Dim pb As PictureBox = CType(sender, PictureBox)
                pb.Location = New Point(PictureBoxSpades.Location.X, PictureBoxSpades.Location.Y + 140)
                listaCartas.Remove("_47") ' Elimina el ocho de picas de la listaCartas
                pb.Name = "47" ' Cambia el nombre del PictureBox
                numeroAciertos += 1
            ElseIf listaCartas.Contains("_47") = False AndAlso carta = "_48" Then
                ' MessageBox.Show("Ha seleccionado el nueve de picas")
                Dim pb As PictureBox = CType(sender, PictureBox)
                pb.Location = New Point(PictureBoxSpades.Location.X, PictureBoxSpades.Location.Y + 160)
                listaCartas.Remove("_48") ' Elimina el nueve de picas de la listaCartas
                pb.Name = "48" ' Cambia el nombre del PictureBox
                numeroAciertos += 1
            ElseIf listaCartas.Contains("_48") = False AndAlso carta = "_49" Then
                ' MessageBox.Show("Ha seleccionado el diez de picas")
                Dim pb As PictureBox = CType(sender, PictureBox)
                pb.Location = New Point(PictureBoxSpades.Location.X, PictureBoxSpades.Location.Y + 180)
                listaCartas.Remove("_49") ' Elimina el diez de picas de la listaCartas
                pb.Name = "49" ' Cambia el nombre del PictureBox
                numeroAciertos += 1
            ElseIf listaCartas.Contains("_49") = False AndAlso carta = "_50" Then
                ' MessageBox.Show("Ha seleccionado el J de picas")
                Dim pb As PictureBox = CType(sender, PictureBox)
                pb.Location = New Point(PictureBoxSpades.Location.X, PictureBoxSpades.Location.Y + 200)
                listaCartas.Remove("_50") ' Elimina el J de picas de la listaCartas
                pb.Name = "50" ' Cambia el nombre del PictureBox
                numeroAciertos += 1
            ElseIf listaCartas.Contains("_50") = False AndAlso carta = "_51" Then
                ' MessageBox.Show("Ha seleccionado el Q de picas")
                Dim pb As PictureBox = CType(sender, PictureBox)
                pb.Location = New Point(PictureBoxSpades.Location.X, PictureBoxSpades.Location.Y + 220)
                listaCartas.Remove("_51") ' Elimina el Q de picas de la listaCartas
                pb.Name = "51" ' Cambia el nombre del PictureBox
                numeroAciertos += 1
            ElseIf listaCartas.Contains("_51") = False AndAlso carta = "_52" Then
                ' MessageBox.Show("Ha seleccionado el K de picas")
                Dim pb As PictureBox = CType(sender, PictureBox)
                pb.Location = New Point(PictureBoxSpades.Location.X, PictureBoxSpades.Location.Y + 240)
                listaCartas.Remove("_52") ' Elimina el K de picas de la listaCartas
                pb.Name = "52" ' Cambia el nombre del PictureBox
                numeroAciertos += 1
            End If
            ' TextBoxAciertos.Text = numeroAciertos

            StatusStrip1.Items("lblAciertos1").Text = "numero de Aciertos:   " & numeroAciertos

            'CONTROLAMOS EL Fin del juego
            If listaCartas.Count = 0 Then
                contador.Stop()
                MessageBox.Show("Feliciades jugador " & nombreJugador & vbCrLf & " ¡¡Has ganado!! ", "Enhorabuena", MessageBoxButtons.OK)
                nombreGanador = nombreJugador
                tiempoGanador = tiempo

                MessageBox.Show("El Jugador " & nombreGanador & vbCrLf & "ha perdido el juego con un total de " & tiempoGanador & " segundos")



            End If


        End If


    End Sub




    Public Sub ActualizarTiempo(sender As Object, e As EventArgs)
        tiempo += 1
        StatusStrip1.Items("lblTiempo1").Text = "Time:   " & tiempo / 10 & "   Segundos"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler contador.Tick, AddressOf ActualizarTiempo
        RemoveHandler deck.Click, AddressOf deck_MouseDown
        centerForm()
    End Sub

    Private Sub ListingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListingsToolStripMenuItem.Click
        listings.Show()
    End Sub


    ' Private Sub insertInPartidas(result As Integer)
    'Dim rutaBD As String = Application.StartupPath + "\solitaire.mdb"
    'Dim con As New OleDbConnection
    '    con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & rutaBD


    ' Try
    '      con.Open()
    ''      Dim dataAdapter = New OleDbDataAdapter("SELECT * FROM Record", con)
    '  Dim conjuntoDatos As New DataSet
    '       dataAdapter.Fill(conjuntoDatos, "Record")
    ' For Each row As DataRow In conjuntoDatos.Tables("Record").Rows
    ' If row(3) > numeroCartonActual Then
    '  numeroCartonActual = row(3)
    '   End If
    '  Next
    ' Catch ex As OleDbException

    '        MessageBox.Show(ex.Message)
    'End Try



    '  End Sub

    Public Sub finDelJuego()
        'CONTROLAMOS EL Fin del juego

        contador.Stop()
        MessageBox.Show("Gracias por Jugar Player " & nombreJugador & vbCrLf & " ¡¡Has Perdido!! ", "Lo sentimos", MessageBoxButtons.OK)
        nombreGanador = nombreJugador
        tiempoGanador = tiempo
        MessageBox.Show("El Jugador " & nombreGanador & vbCrLf & "ha terminado el juego en un total de " & tiempoGanador & " segundos")
        InsertarDatos(nombreGanador, numeroAciertos, tiempo)
        deck.Enabled = False
        ResetComponents()
        borrarPictureViews()
        borrarPictureViewsnumeros()
    End Sub


    Private Sub InsertarDatos(nombreGanador As String, numeroAciertos As Integer, tiempo As Integer)
        Dim rutaBD As String = Application.StartupPath + "\solitaire.mdb"
        Dim con As New OleDbConnection
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & rutaBD

        Try
            con.Open()

            ' Comprueba el número de ID actual en la tabla
            Dim idActual As Integer = 0
            Dim dataAdapter As New OleDbDataAdapter("SELECT MAX(Id) FROM Record", con)
            Dim conjuntoDatos As New DataSet()
            dataAdapter.Fill(conjuntoDatos, "Record")
            If conjuntoDatos.Tables("Record").Rows.Count > 0 AndAlso Not IsDBNull(conjuntoDatos.Tables("Record").Rows(0)(0)) Then
                idActual = conjuntoDatos.Tables("Record").Rows(0)(0)
            End If

            ' Inserta los datos en la tabla
            Dim query As String = "INSERT INTO Record ( Player, Hits, [Time], WinDate) " &
                              "VALUES ( @Player, @Hits, @Time, @WinDate)"
            Dim comando As New OleDbCommand(query, con)

            comando.Parameters.AddWithValue("@Player", nombreGanador)
            comando.Parameters.AddWithValue("@Hits", numeroAciertos)
            comando.Parameters.AddWithValue("@Time", tiempo / 10)
            comando.Parameters.AddWithValue("@WinDate", DateTime.Today.ToString("dd/MM/yyyy"))
            comando.ExecuteNonQuery()
            ' Muestra un mensaje de confirmación si los datos se guardaron correctamente
            MessageBox.Show("Los datos se guardaron correctamente.", "Mensaje")
            'Mostramos un mensaje como que hay que volver a darle a jugar
            MessageBox.Show("El juego ha terminado, para volver a jugar dirijase a " & vbCrLf & "Files - New Game ", "End Of Game")

        Catch ex As OleDbException
            MessageBox.Show("Ocurrió un error al guardar los datos: " & ex.Message, "Error")
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub InstructionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstructionsToolStripMenuItem.Click
        instructions.Show()
    End Sub

    Private Sub centerForm()

        Dim r = Screen.PrimaryScreen.WorkingArea
        Dim x = r.Width - Me.Width
        Dim y = r.Height - Me.Height


        x = CInt(x / 2)
        y = CInt(y / 2)
        Me.StartPosition = FormStartPosition.Manual
        Me.Location = New Point(x, y)

    End Sub
End Class