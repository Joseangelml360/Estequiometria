<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmComponentes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmComponentes))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnCompletar100 = New System.Windows.Forms.Button()
        Me.TxtMateriaPrima = New System.Windows.Forms.TextBox()
        Me.NumCantidad = New System.Windows.Forms.NumericUpDown()
        Me.TxtBuscarMP = New System.Windows.Forms.TextBox()
        Me.CboMateriaprima = New System.Windows.Forms.ComboBox()
        Me.BtnTerminar = New System.Windows.Forms.Button()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.BtnAjustarA100 = New System.Windows.Forms.Button()
        Me.TxtSumaComponentes = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DgvComponentes = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnAñadir = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.NumCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvComponentes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(62, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(223, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Componentes fórmula"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(94, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Producto"
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodigo.Location = New System.Drawing.Point(179, 64)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.ReadOnly = True
        Me.TxtCodigo.Size = New System.Drawing.Size(100, 26)
        Me.TxtCodigo.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Mat. Prima:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(437, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Cantidad"
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescripcion.Location = New System.Drawing.Point(302, 64)
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.ReadOnly = True
        Me.TxtDescripcion.Size = New System.Drawing.Size(313, 26)
        Me.TxtDescripcion.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnCompletar100)
        Me.Panel1.Controls.Add(Me.TxtMateriaPrima)
        Me.Panel1.Controls.Add(Me.NumCantidad)
        Me.Panel1.Controls.Add(Me.TxtBuscarMP)
        Me.Panel1.Controls.Add(Me.CboMateriaprima)
        Me.Panel1.Controls.Add(Me.BtnTerminar)
        Me.Panel1.Controls.Add(Me.BtnAceptar)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(7, 450)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(776, 106)
        Me.Panel1.TabIndex = 23
        '
        'BtnCompletar100
        '
        Me.BtnCompletar100.BackColor = System.Drawing.Color.GreenYellow
        Me.BtnCompletar100.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCompletar100.Location = New System.Drawing.Point(630, 67)
        Me.BtnCompletar100.Name = "BtnCompletar100"
        Me.BtnCompletar100.Size = New System.Drawing.Size(35, 22)
        Me.BtnCompletar100.TabIndex = 31
        Me.BtnCompletar100.Text = "100"
        Me.BtnCompletar100.UseVisualStyleBackColor = False
        '
        'TxtMateriaPrima
        '
        Me.TxtMateriaPrima.Location = New System.Drawing.Point(94, 67)
        Me.TxtMateriaPrima.Name = "TxtMateriaPrima"
        Me.TxtMateriaPrima.Size = New System.Drawing.Size(327, 22)
        Me.TxtMateriaPrima.TabIndex = 30
        '
        'NumCantidad
        '
        Me.NumCantidad.DecimalPlaces = 3
        Me.NumCantidad.Location = New System.Drawing.Point(507, 65)
        Me.NumCantidad.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.NumCantidad.Name = "NumCantidad"
        Me.NumCantidad.Size = New System.Drawing.Size(120, 22)
        Me.NumCantidad.TabIndex = 26
        '
        'TxtBuscarMP
        '
        Me.TxtBuscarMP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBuscarMP.Location = New System.Drawing.Point(94, 38)
        Me.TxtBuscarMP.Name = "TxtBuscarMP"
        Me.TxtBuscarMP.Size = New System.Drawing.Size(296, 26)
        Me.TxtBuscarMP.TabIndex = 25
        '
        'CboMateriaprima
        '
        Me.CboMateriaprima.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboMateriaprima.DropDownWidth = 160
        Me.CboMateriaprima.FormattingEnabled = True
        Me.CboMateriaprima.Location = New System.Drawing.Point(396, 42)
        Me.CboMateriaprima.Name = "CboMateriaprima"
        Me.CboMateriaprima.Size = New System.Drawing.Size(25, 24)
        Me.CboMateriaprima.TabIndex = 24
        '
        'BtnTerminar
        '
        Me.BtnTerminar.Image = Global.Estequiometria.My.Resources.Resources.undo16
        Me.BtnTerminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTerminar.Location = New System.Drawing.Point(671, 3)
        Me.BtnTerminar.Name = "BtnTerminar"
        Me.BtnTerminar.Size = New System.Drawing.Size(90, 30)
        Me.BtnTerminar.TabIndex = 21
        Me.BtnTerminar.Text = "Terminar"
        Me.BtnTerminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnTerminar.UseVisualStyleBackColor = True
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Image = Global.Estequiometria.My.Resources.Resources.luzverde
        Me.BtnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAceptar.Location = New System.Drawing.Point(671, 62)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(90, 30)
        Me.BtnAceptar.TabIndex = 22
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'BtnAjustarA100
        '
        Me.BtnAjustarA100.Location = New System.Drawing.Point(179, 410)
        Me.BtnAjustarA100.Name = "BtnAjustarA100"
        Me.BtnAjustarA100.Size = New System.Drawing.Size(112, 30)
        Me.BtnAjustarA100.TabIndex = 29
        Me.BtnAjustarA100.Text = "Ajustar a 100"
        Me.BtnAjustarA100.UseVisualStyleBackColor = True
        '
        'TxtSumaComponentes
        '
        Me.TxtSumaComponentes.Location = New System.Drawing.Point(683, 414)
        Me.TxtSumaComponentes.Name = "TxtSumaComponentes"
        Me.TxtSumaComponentes.Size = New System.Drawing.Size(100, 22)
        Me.TxtSumaComponentes.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(544, 414)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 17)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Suma componentes"
        '
        'DgvComponentes
        '
        Me.DgvComponentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvComponentes.Location = New System.Drawing.Point(7, 143)
        Me.DgvComponentes.Name = "DgvComponentes"
        Me.DgvComponentes.RowHeadersWidth = 51
        Me.DgvComponentes.RowTemplate.Height = 24
        Me.DgvComponentes.Size = New System.Drawing.Size(776, 265)
        Me.DgvComponentes.TabIndex = 24
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Estequiometria.My.Resources.Resources.molecula_edited
        Me.PictureBox1.Location = New System.Drawing.Point(7, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(49, 46)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Image = Global.Estequiometria.My.Resources.Resources.trash
        Me.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminar.Location = New System.Drawing.Point(248, 105)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(100, 30)
        Me.BtnEliminar.TabIndex = 20
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.Image = Global.Estequiometria.My.Resources.Resources.Modificar
        Me.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEditar.Location = New System.Drawing.Point(131, 105)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(90, 30)
        Me.BtnEditar.TabIndex = 19
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnAñadir
        '
        Me.BtnAñadir.Image = Global.Estequiometria.My.Resources.Resources.Añadir
        Me.BtnAñadir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAñadir.Location = New System.Drawing.Point(14, 105)
        Me.BtnAñadir.Name = "BtnAñadir"
        Me.BtnAñadir.Size = New System.Drawing.Size(90, 30)
        Me.BtnAñadir.TabIndex = 18
        Me.BtnAñadir.Text = "Añadir"
        Me.BtnAñadir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAñadir.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Image = Global.Estequiometria.My.Resources.Resources.Salir
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalir.Location = New System.Drawing.Point(711, 12)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(77, 30)
        Me.BtnSalir.TabIndex = 17
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'FrmComponentes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 564)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DgvComponentes)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnAjustarA100)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.TxtSumaComponentes)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnAñadir)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.TxtDescripcion)
        Me.Controls.Add(Me.TxtCodigo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmComponentes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Componentes"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.NumCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvComponentes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtCodigo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnAñadir As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnTerminar As Button
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CboMateriaprima As ComboBox
    Friend WithEvents DgvComponentes As DataGridView
    Friend WithEvents TxtBuscarMP As TextBox
    Friend WithEvents BtnAjustarA100 As Button
    Friend WithEvents TxtSumaComponentes As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents NumCantidad As NumericUpDown
    Friend WithEvents TxtMateriaPrima As TextBox
    Friend WithEvents BtnCompletar100 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
