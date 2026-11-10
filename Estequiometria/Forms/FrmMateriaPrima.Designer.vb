<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMateriaPrima
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMateriaPrima))
        Me.TxtObservaciones = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtProveedor = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CboFamilia = New System.Windows.Forms.ComboBox()
        Me.CboSubFamilia = New System.Windows.Forms.ComboBox()
        Me.DgvMateriasPrimas = New System.Windows.Forms.DataGridView()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnPropiedades = New System.Windows.Forms.Button()
        Me.BtnTodos = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnAñadir = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        CType(Me.DgvMateriasPrimas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtObservaciones
        '
        Me.TxtObservaciones.Location = New System.Drawing.Point(369, 98)
        Me.TxtObservaciones.Name = "TxtObservaciones"
        Me.TxtObservaciones.Size = New System.Drawing.Size(411, 22)
        Me.TxtObservaciones.TabIndex = 37
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(373, 78)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 17)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Observaciones"
        '
        'TxtProveedor
        '
        Me.TxtProveedor.Location = New System.Drawing.Point(14, 98)
        Me.TxtProveedor.Name = "TxtProveedor"
        Me.TxtProveedor.Size = New System.Drawing.Size(327, 22)
        Me.TxtProveedor.TabIndex = 35
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 78)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 17)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Proveedor"
        '
        'TxtPrecio
        '
        Me.TxtPrecio.Location = New System.Drawing.Point(699, 40)
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(81, 22)
        Me.TxtPrecio.TabIndex = 33
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(703, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 17)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Precio"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(579, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 17)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "SubFamilia"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(492, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 17)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Familia"
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Location = New System.Drawing.Point(120, 40)
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(356, 22)
        Me.TxtDescripcion.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(117, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 17)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Descripción"
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Location = New System.Drawing.Point(14, 40)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(81, 22)
        Me.TxtCodigo.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 17)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Código"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(77, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 25)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Materia Prima"
        '
        'CboFamilia
        '
        Me.CboFamilia.FormattingEnabled = True
        Me.CboFamilia.Location = New System.Drawing.Point(495, 40)
        Me.CboFamilia.Name = "CboFamilia"
        Me.CboFamilia.Size = New System.Drawing.Size(75, 24)
        Me.CboFamilia.TabIndex = 39
        '
        'CboSubFamilia
        '
        Me.CboSubFamilia.FormattingEnabled = True
        Me.CboSubFamilia.Location = New System.Drawing.Point(581, 40)
        Me.CboSubFamilia.Name = "CboSubFamilia"
        Me.CboSubFamilia.Size = New System.Drawing.Size(75, 24)
        Me.CboSubFamilia.TabIndex = 40
        '
        'DgvMateriasPrimas
        '
        Me.DgvMateriasPrimas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvMateriasPrimas.Location = New System.Drawing.Point(13, 110)
        Me.DgvMateriasPrimas.Name = "DgvMateriasPrimas"
        Me.DgvMateriasPrimas.RowHeadersWidth = 51
        Me.DgvMateriasPrimas.RowTemplate.Height = 24
        Me.DgvMateriasPrimas.Size = New System.Drawing.Size(968, 296)
        Me.DgvMateriasPrimas.TabIndex = 42
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Location = New System.Drawing.Point(596, 78)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(340, 22)
        Me.TxtBuscar.TabIndex = 43
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TxtDescripcion)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TxtCodigo)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.TxtPrecio)
        Me.Panel1.Controls.Add(Me.CboSubFamilia)
        Me.Panel1.Controls.Add(Me.BtnCancelar)
        Me.Panel1.Controls.Add(Me.BtnGuardar)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.CboFamilia)
        Me.Panel1.Controls.Add(Me.TxtProveedor)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.TxtObservaciones)
        Me.Panel1.Location = New System.Drawing.Point(14, 419)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(967, 134)
        Me.Panel1.TabIndex = 49
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Image = CType(resources.GetObject("BtnCancelar.Image"), System.Drawing.Image)
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.Location = New System.Drawing.Point(854, 20)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(103, 30)
        Me.BtnCancelar.TabIndex = 22
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Image = Global.Estequiometria.My.Resources.Resources.disk
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(867, 90)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(90, 30)
        Me.BtnGuardar.TabIndex = 23
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Estequiometria.My.Resources.Resources.MateriasPrimas
        Me.PictureBox1.Location = New System.Drawing.Point(3, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(72, 68)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 56
        Me.PictureBox1.TabStop = False
        '
        'BtnPropiedades
        '
        Me.BtnPropiedades.Image = Global.Estequiometria.My.Resources.Resources.engranajes
        Me.BtnPropiedades.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPropiedades.Location = New System.Drawing.Point(354, 74)
        Me.BtnPropiedades.Name = "BtnPropiedades"
        Me.BtnPropiedades.Size = New System.Drawing.Size(120, 27)
        Me.BtnPropiedades.TabIndex = 51
        Me.BtnPropiedades.Text = "Propiedades"
        Me.BtnPropiedades.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnPropiedades.UseVisualStyleBackColor = True
        '
        'BtnTodos
        '
        Me.BtnTodos.Image = Global.Estequiometria.My.Resources.Resources.undo16
        Me.BtnTodos.Location = New System.Drawing.Point(954, 74)
        Me.BtnTodos.Name = "BtnTodos"
        Me.BtnTodos.Size = New System.Drawing.Size(27, 30)
        Me.BtnTodos.TabIndex = 50
        Me.BtnTodos.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Image = Global.Estequiometria.My.Resources.Resources.filtro
        Me.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBuscar.Location = New System.Drawing.Point(505, 74)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(79, 30)
        Me.BtnBuscar.TabIndex = 48
        Me.BtnBuscar.Text = "Filtro"
        Me.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.Image = Global.Estequiometria.My.Resources.Resources.Modificar
        Me.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEditar.Location = New System.Drawing.Point(122, 74)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(90, 30)
        Me.BtnEditar.TabIndex = 46
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnAñadir
        '
        Me.BtnAñadir.Image = Global.Estequiometria.My.Resources.Resources.Añadir
        Me.BtnAñadir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAñadir.Location = New System.Drawing.Point(14, 74)
        Me.BtnAñadir.Name = "BtnAñadir"
        Me.BtnAñadir.Size = New System.Drawing.Size(90, 30)
        Me.BtnAñadir.TabIndex = 45
        Me.BtnAñadir.Text = "Añadir"
        Me.BtnAñadir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAñadir.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSalir.Image = CType(resources.GetObject("BtnSalir.Image"), System.Drawing.Image)
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalir.Location = New System.Drawing.Point(891, 12)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(90, 30)
        Me.BtnSalir.TabIndex = 41
        Me.BtnSalir.Text = "Salir  "
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'FrmMateriaPrima
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1002, 573)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnPropiedades)
        Me.Controls.Add(Me.BtnTodos)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnAñadir)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.DgvMateriasPrimas)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmMateriaPrima"
        Me.Text = "Materia Prima"
        CType(Me.DgvMateriasPrimas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtObservaciones As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtProveedor As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtPrecio As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtCodigo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents CboFamilia As ComboBox
    Friend WithEvents CboSubFamilia As ComboBox
    Friend WithEvents BtnSalir As Button
    Friend WithEvents DgvMateriasPrimas As DataGridView
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnAñadir As Button
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnTodos As Button
    Friend WithEvents BtnPropiedades As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
