<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.labelJugador = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptioonsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePlayerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeBackOfDeckToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InstructionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.lblTiempo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.successes = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxAciertos = New System.Windows.Forms.TextBox()
        Me.deck = New System.Windows.Forms.PictureBox()
        Me.pictureBoxClubs = New System.Windows.Forms.PictureBox()
        Me.pictureBoxDiamonds = New System.Windows.Forms.PictureBox()
        Me.pictureBoxHearts = New System.Windows.Forms.PictureBox()
        Me.pictureBox = New System.Windows.Forms.PictureBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblTiempo1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblAciertos1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PictureBoxSpades = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        CType(Me.deck, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBoxClubs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBoxDiamonds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBoxHearts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBoxSpades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labelJugador
        '
        Me.labelJugador.AutoSize = True
        Me.labelJugador.Location = New System.Drawing.Point(309, 60)
        Me.labelJugador.Name = "labelJugador"
        Me.labelJugador.Size = New System.Drawing.Size(0, 20)
        Me.labelJugador.TabIndex = 19
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ListingsToolStripMenuItem, Me.OptioonsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1750, 33)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewGameToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(54, 29)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewGameToolStripMenuItem
        '
        Me.NewGameToolStripMenuItem.Name = "NewGameToolStripMenuItem"
        Me.NewGameToolStripMenuItem.Size = New System.Drawing.Size(200, 34)
        Me.NewGameToolStripMenuItem.Text = "New Game"
        '
        'ListingsToolStripMenuItem
        '
        Me.ListingsToolStripMenuItem.Name = "ListingsToolStripMenuItem"
        Me.ListingsToolStripMenuItem.Size = New System.Drawing.Size(87, 29)
        Me.ListingsToolStripMenuItem.Text = "Listings"
        '
        'OptioonsToolStripMenuItem
        '
        Me.OptioonsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangePlayerToolStripMenuItem, Me.ChangeBackOfDeckToolStripMenuItem, Me.InstructionsToolStripMenuItem})
        Me.OptioonsToolStripMenuItem.Name = "OptioonsToolStripMenuItem"
        Me.OptioonsToolStripMenuItem.Size = New System.Drawing.Size(103, 29)
        Me.OptioonsToolStripMenuItem.Text = "Optioons"
        '
        'ChangePlayerToolStripMenuItem
        '
        Me.ChangePlayerToolStripMenuItem.Name = "ChangePlayerToolStripMenuItem"
        Me.ChangePlayerToolStripMenuItem.Size = New System.Drawing.Size(279, 34)
        Me.ChangePlayerToolStripMenuItem.Text = "change player"
        '
        'ChangeBackOfDeckToolStripMenuItem
        '
        Me.ChangeBackOfDeckToolStripMenuItem.Name = "ChangeBackOfDeckToolStripMenuItem"
        Me.ChangeBackOfDeckToolStripMenuItem.Size = New System.Drawing.Size(279, 34)
        Me.ChangeBackOfDeckToolStripMenuItem.Text = "change back of Deck"
        '
        'InstructionsToolStripMenuItem
        '
        Me.InstructionsToolStripMenuItem.Name = "InstructionsToolStripMenuItem"
        Me.InstructionsToolStripMenuItem.Size = New System.Drawing.Size(279, 34)
        Me.InstructionsToolStripMenuItem.Text = "instructions"
        '
        'StatusStrip
        '
        Me.StatusStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblTiempo, Me.successes})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 979)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1730, 32)
        Me.StatusStrip.TabIndex = 24
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'lblTiempo
        '
        Me.lblTiempo.Name = "lblTiempo"
        Me.lblTiempo.Size = New System.Drawing.Size(54, 25)
        Me.lblTiempo.Text = "Time:"
        '
        'successes
        '
        Me.successes.Name = "successes"
        Me.successes.Size = New System.Drawing.Size(94, 25)
        Me.successes.Text = "Successes:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(313, 93)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(188, 26)
        Me.TextBox1.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(309, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 20)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Num Carta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(317, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 20)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Num Aciertos"
        '
        'TextBoxAciertos
        '
        Me.TextBoxAciertos.Location = New System.Drawing.Point(321, 182)
        Me.TextBoxAciertos.Name = "TextBoxAciertos"
        Me.TextBoxAciertos.Size = New System.Drawing.Size(100, 26)
        Me.TextBoxAciertos.TabIndex = 28
        '
        'deck
        '
        Me.deck.Location = New System.Drawing.Point(12, 60)
        Me.deck.Name = "deck"
        Me.deck.Size = New System.Drawing.Size(268, 392)
        Me.deck.TabIndex = 16
        Me.deck.TabStop = False
        '
        'pictureBoxClubs
        '
        Me.pictureBoxClubs.Location = New System.Drawing.Point(533, 60)
        Me.pictureBoxClubs.Name = "pictureBoxClubs"
        Me.pictureBoxClubs.Size = New System.Drawing.Size(268, 392)
        Me.pictureBoxClubs.TabIndex = 20
        Me.pictureBoxClubs.TabStop = False
        '
        'pictureBoxDiamonds
        '
        Me.pictureBoxDiamonds.Location = New System.Drawing.Point(821, 60)
        Me.pictureBoxDiamonds.Name = "pictureBoxDiamonds"
        Me.pictureBoxDiamonds.Size = New System.Drawing.Size(268, 392)
        Me.pictureBoxDiamonds.TabIndex = 21
        Me.pictureBoxDiamonds.TabStop = False
        '
        'pictureBoxHearts
        '
        Me.pictureBoxHearts.Location = New System.Drawing.Point(1105, 60)
        Me.pictureBoxHearts.Name = "pictureBoxHearts"
        Me.pictureBoxHearts.Size = New System.Drawing.Size(268, 392)
        Me.pictureBoxHearts.TabIndex = 22
        Me.pictureBoxHearts.TabStop = False
        '
        'pictureBox
        '
        Me.pictureBox.Location = New System.Drawing.Point(1105, 90)
        Me.pictureBox.Name = "pictureBox"
        Me.pictureBox.Size = New System.Drawing.Size(268, 392)
        Me.pictureBox.TabIndex = 23
        Me.pictureBox.TabStop = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblTiempo1, Me.lblAciertos1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 955)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1750, 32)
        Me.StatusStrip1.TabIndex = 23
        Me.StatusStrip1.Text = "StatusStrip2"
        '
        'lblTiempo1
        '
        Me.lblTiempo1.Name = "lblTiempo1"
        Me.lblTiempo1.Size = New System.Drawing.Size(54, 25)
        Me.lblTiempo1.Text = "Time:"
        '
        'lblAciertos1
        '
        Me.lblAciertos1.Name = "lblAciertos1"
        Me.lblAciertos1.Size = New System.Drawing.Size(94, 25)
        Me.lblAciertos1.Text = "Successes:"
        '
        'PictureBoxSpades
        '
        Me.PictureBoxSpades.Location = New System.Drawing.Point(1411, 60)
        Me.PictureBoxSpades.Name = "PictureBoxSpades"
        Me.PictureBoxSpades.Size = New System.Drawing.Size(268, 392)
        Me.PictureBoxSpades.TabIndex = 24
        Me.PictureBoxSpades.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1750, 987)
        Me.Controls.Add(Me.PictureBoxSpades)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.pictureBoxHearts)
        Me.Controls.Add(Me.pictureBoxDiamonds)
        Me.Controls.Add(Me.pictureBoxClubs)
        Me.Controls.Add(Me.labelJugador)
        Me.Controls.Add(Me.deck)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        CType(Me.deck, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBoxClubs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBoxDiamonds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBoxHearts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBoxSpades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labelJugador As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewGameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptioonsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangePlayerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangeBackOfDeckToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents lblTiempo As ToolStripStatusLabel
    Friend WithEvents successes As ToolStripStatusLabel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxAciertos As TextBox
    Friend WithEvents InstructionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents deck As PictureBox
    Friend WithEvents pictureBoxClubs As PictureBox
    Friend WithEvents pictureBoxDiamonds As PictureBox
    Friend WithEvents pictureBoxHearts As PictureBox
    Friend WithEvents pictureBox As PictureBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblTiempo1 As ToolStripStatusLabel
    Friend WithEvents lblAciertos1 As ToolStripStatusLabel
    Friend WithEvents PictureBoxSpades As PictureBox
End Class
