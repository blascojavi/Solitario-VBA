<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listings
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SolitaireDataSet = New solitario.solitaireDataSet()
        Me.RecordBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RecordTableAdapter = New solitario.solitaireDataSetTableAdapters.RecordTableAdapter()
        Me.TableAdapterManager = New solitario.solitaireDataSetTableAdapters.TableAdapterManager()
        Me.DataGridViewRecords = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlayerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HitsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WinDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecordBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxPartidasJugadas = New System.Windows.Forms.TextBox()
        Me.TextBoxtiempoDeJuego = New System.Windows.Forms.TextBox()
        Me.TextBoxUltimaPartida = New System.Windows.Forms.TextBox()
        CType(Me.SolitaireDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecordBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecordBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SolitaireDataSet
        '
        Me.SolitaireDataSet.DataSetName = "solitaireDataSet"
        Me.SolitaireDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RecordBindingSource
        '
        Me.RecordBindingSource.DataMember = "Record"
        Me.RecordBindingSource.DataSource = Me.SolitaireDataSet
        '
        'RecordTableAdapter
        '
        Me.RecordTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.RecordTableAdapter = Me.RecordTableAdapter
        Me.TableAdapterManager.UpdateOrder = solitario.solitaireDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DataGridViewRecords
        '
        Me.DataGridViewRecords.AutoGenerateColumns = False
        Me.DataGridViewRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewRecords.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.PlayerDataGridViewTextBoxColumn, Me.HitsDataGridViewTextBoxColumn, Me.TimeDataGridViewTextBoxColumn, Me.WinDateDataGridViewTextBoxColumn})
        Me.DataGridViewRecords.DataSource = Me.RecordBindingSource1
        Me.DataGridViewRecords.Location = New System.Drawing.Point(27, 63)
        Me.DataGridViewRecords.Name = "DataGridViewRecords"
        Me.DataGridViewRecords.RowHeadersWidth = 62
        Me.DataGridViewRecords.RowTemplate.Height = 28
        Me.DataGridViewRecords.Size = New System.Drawing.Size(1099, 255)
        Me.DataGridViewRecords.TabIndex = 3
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.Width = 150
        '
        'PlayerDataGridViewTextBoxColumn
        '
        Me.PlayerDataGridViewTextBoxColumn.DataPropertyName = "Player"
        Me.PlayerDataGridViewTextBoxColumn.HeaderText = "Player"
        Me.PlayerDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.PlayerDataGridViewTextBoxColumn.Name = "PlayerDataGridViewTextBoxColumn"
        Me.PlayerDataGridViewTextBoxColumn.Width = 150
        '
        'HitsDataGridViewTextBoxColumn
        '
        Me.HitsDataGridViewTextBoxColumn.DataPropertyName = "Hits"
        Me.HitsDataGridViewTextBoxColumn.HeaderText = "Hits"
        Me.HitsDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.HitsDataGridViewTextBoxColumn.Name = "HitsDataGridViewTextBoxColumn"
        Me.HitsDataGridViewTextBoxColumn.Width = 150
        '
        'TimeDataGridViewTextBoxColumn
        '
        Me.TimeDataGridViewTextBoxColumn.DataPropertyName = "Time"
        Me.TimeDataGridViewTextBoxColumn.HeaderText = "Time"
        Me.TimeDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TimeDataGridViewTextBoxColumn.Name = "TimeDataGridViewTextBoxColumn"
        Me.TimeDataGridViewTextBoxColumn.Width = 150
        '
        'WinDateDataGridViewTextBoxColumn
        '
        Me.WinDateDataGridViewTextBoxColumn.DataPropertyName = "WinDate"
        Me.WinDateDataGridViewTextBoxColumn.HeaderText = "WinDate"
        Me.WinDateDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.WinDateDataGridViewTextBoxColumn.Name = "WinDateDataGridViewTextBoxColumn"
        Me.WinDateDataGridViewTextBoxColumn.Width = 150
        '
        'RecordBindingSource1
        '
        Me.RecordBindingSource1.DataMember = "Record"
        Me.RecordBindingSource1.DataSource = Me.SolitaireDataSet
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 547)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Partidas Jugadas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(483, 547)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Tiempo de Juego"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(892, 547)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "ultima Partida"
        '
        'TextBoxPartidasJugadas
        '
        Me.TextBoxPartidasJugadas.Location = New System.Drawing.Point(218, 544)
        Me.TextBoxPartidasJugadas.Name = "TextBoxPartidasJugadas"
        Me.TextBoxPartidasJugadas.Size = New System.Drawing.Size(100, 26)
        Me.TextBoxPartidasJugadas.TabIndex = 7
        '
        'TextBoxtiempoDeJuego
        '
        Me.TextBoxtiempoDeJuego.Location = New System.Drawing.Point(649, 544)
        Me.TextBoxtiempoDeJuego.Name = "TextBoxtiempoDeJuego"
        Me.TextBoxtiempoDeJuego.Size = New System.Drawing.Size(100, 26)
        Me.TextBoxtiempoDeJuego.TabIndex = 8
        '
        'TextBoxUltimaPartida
        '
        Me.TextBoxUltimaPartida.Location = New System.Drawing.Point(1063, 541)
        Me.TextBoxUltimaPartida.Name = "TextBoxUltimaPartida"
        Me.TextBoxUltimaPartida.Size = New System.Drawing.Size(100, 26)
        Me.TextBoxUltimaPartida.TabIndex = 9
        '
        'listings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1301, 792)
        Me.Controls.Add(Me.TextBoxUltimaPartida)
        Me.Controls.Add(Me.TextBoxtiempoDeJuego)
        Me.Controls.Add(Me.TextBoxPartidasJugadas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridViewRecords)
        Me.Name = "listings"
        Me.Text = "listings"
        CType(Me.SolitaireDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecordBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewRecords, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecordBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SolitaireDataSet As solitaireDataSet
    Friend WithEvents RecordBindingSource As BindingSource
    Friend WithEvents RecordTableAdapter As solitaireDataSetTableAdapters.RecordTableAdapter
    Friend WithEvents TableAdapterManager As solitaireDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DataGridViewRecords As DataGridView
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PlayerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HitsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WinDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RecordBindingSource1 As BindingSource
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxPartidasJugadas As TextBox
    Friend WithEvents TextBoxtiempoDeJuego As TextBox
    Friend WithEvents TextBoxUltimaPartida As TextBox
End Class
