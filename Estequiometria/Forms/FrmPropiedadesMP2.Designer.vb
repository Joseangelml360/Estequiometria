<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPropiedadesMP2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPropiedadesMP2))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.TxtMateriaPrima = New System.Windows.Forms.TextBox()
        Me.TxtUnidad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CboPropiedad = New System.Windows.Forms.ComboBox()
        Me.TxtValor = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtCodigoMateriaPrima = New System.Windows.Forms.TextBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.LblIdPropiedad = New System.Windows.Forms.Label()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnAñadir = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DgvPropiedades = New System.Windows.Forms.DataGridView()
        Me.LblCodigo = New System.Windows.Forms.Label()
        Me.LblDescripcion = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.DgvPropiedades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Codigo Materia prima"
        '
        'BtnSalir
        '
        Me.BtnSalir.Image = Global.Estequiometria.My.Resources.Resources.Salir
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalir.Location = New System.Drawing.Point(695, 11)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(90, 30)
        Me.BtnSalir.TabIndex = 57
        Me.BtnSalir.Text = "Salir "
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'TxtMateriaPrima
        '
        Me.TxtMateriaPrima.Location = New System.Drawing.Point(287, 17)
        Me.TxtMateriaPrima.Name = "TxtMateriaPrima"
        Me.TxtMateriaPrima.ReadOnly = True
        Me.TxtMateriaPrima.Size = New System.Drawing.Size(343, 22)
        Me.TxtMateriaPrima.TabIndex = 18
        '
        'TxtUnidad
        '
        Me.TxtUnidad.Location = New System.Drawing.Point(548, 54)
        Me.TxtUnidad.Name = "TxtUnidad"
        Me.TxtUnidad.Size = New System.Drawing.Size(82, 22)
        Me.TxtUnidad.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(489, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 17)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Unidad"
        '
        'CboPropiedad
        '
        Me.CboPropiedad.FormattingEnabled = True
        Me.CboPropiedad.Location = New System.Drawing.Point(94, 54)
        Me.CboPropiedad.Name = "CboPropiedad"
        Me.CboPropiedad.Size = New System.Drawing.Size(259, 24)
        Me.CboPropiedad.TabIndex = 15
        '
        'TxtValor
        '
        Me.TxtValor.Location = New System.Drawing.Point(404, 54)
        Me.TxtValor.Name = "TxtValor"
        Me.TxtValor.Size = New System.Drawing.Size(61, 22)
        Me.TxtValor.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(359, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 17)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Valor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Propiedad"
        '
        'TxtCodigoMateriaPrima
        '
        Me.TxtCodigoMateriaPrima.Location = New System.Drawing.Point(164, 18)
        Me.TxtCodigoMateriaPrima.Name = "TxtCodigoMateriaPrima"
        Me.TxtCodigoMateriaPrima.ReadOnly = True
        Me.TxtCodigoMateriaPrima.Size = New System.Drawing.Size(100, 22)
        Me.TxtCodigoMateriaPrima.TabIndex = 10
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Image = Global.Estequiometria.My.Resources.Resources.Cancelar
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.Location = New System.Drawing.Point(662, 10)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(100, 30)
        Me.BtnCancelar.TabIndex = 6
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'LblIdPropiedad
        '
        Me.LblIdPropiedad.AutoSize = True
        Me.LblIdPropiedad.Location = New System.Drawing.Point(397, 18)
        Me.LblIdPropiedad.Name = "LblIdPropiedad"
        Me.LblIdPropiedad.Size = New System.Drawing.Size(51, 17)
        Me.LblIdPropiedad.TabIndex = 58
        Me.LblIdPropiedad.Text = "Label7"
        Me.LblIdPropiedad.Visible = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Image = Global.Estequiometria.My.Resources.Resources.trash
        Me.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminar.Location = New System.Drawing.Point(226, 103)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(103, 30)
        Me.BtnEliminar.TabIndex = 61
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.Image = Global.Estequiometria.My.Resources.Resources.Modificar
        Me.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEditar.Location = New System.Drawing.Point(117, 103)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(90, 30)
        Me.BtnEditar.TabIndex = 60
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnAñadir
        '
        Me.BtnAñadir.Image = Global.Estequiometria.My.Resources.Resources.Añadir
        Me.BtnAñadir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAñadir.Location = New System.Drawing.Point(13, 103)
        Me.BtnAñadir.Name = "BtnAñadir"
        Me.BtnAñadir.Size = New System.Drawing.Size(90, 30)
        Me.BtnAñadir.TabIndex = 59
        Me.BtnAñadir.Text = "Añadir"
        Me.BtnAñadir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAñadir.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Image = Global.Estequiometria.My.Resources.Resources.disk
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(662, 50)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(100, 30)
        Me.BtnGuardar.TabIndex = 5
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(61, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(302, 25)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "Propiedades de Materia Prima"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TxtMateriaPrima)
        Me.Panel1.Controls.Add(Me.TxtUnidad)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.CboPropiedad)
        Me.Panel1.Controls.Add(Me.TxtValor)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TxtCodigoMateriaPrima)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.BtnCancelar)
        Me.Panel1.Controls.Add(Me.BtnGuardar)
        Me.Panel1.Location = New System.Drawing.Point(10, 447)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(775, 91)
        Me.Panel1.TabIndex = 54
        '
        'DgvPropiedades
        '
        Me.DgvPropiedades.AllowUserToAddRows = False
        Me.DgvPropiedades.AllowUserToDeleteRows = False
        Me.DgvPropiedades.AllowUserToOrderColumns = True
        Me.DgvPropiedades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvPropiedades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPropiedades.Location = New System.Drawing.Point(11, 139)
        Me.DgvPropiedades.Name = "DgvPropiedades"
        Me.DgvPropiedades.RowHeadersWidth = 51
        Me.DgvPropiedades.RowTemplate.Height = 24
        Me.DgvPropiedades.Size = New System.Drawing.Size(775, 302)
        Me.DgvPropiedades.TabIndex = 53
        '
        'LblCodigo
        '
        Me.LblCodigo.AutoSize = True
        Me.LblCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCodigo.Location = New System.Drawing.Point(12, 71)
        Me.LblCodigo.Name = "LblCodigo"
        Me.LblCodigo.Size = New System.Drawing.Size(59, 20)
        Me.LblCodigo.TabIndex = 62
        Me.LblCodigo.Text = "Label6"
        '
        'LblDescripcion
        '
        Me.LblDescripcion.AutoSize = True
        Me.LblDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDescripcion.Location = New System.Drawing.Point(100, 71)
        Me.LblDescripcion.Name = "LblDescripcion"
        Me.LblDescripcion.Size = New System.Drawing.Size(59, 20)
        Me.LblDescripcion.TabIndex = 63
        Me.LblDescripcion.Text = "Label7"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Estequiometria.My.Resources.Resources.GEARS_ico
        Me.PictureBox1.Location = New System.Drawing.Point(10, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(49, 46)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 64
        Me.PictureBox1.TabStop = False
        '
        'FrmPropiedadesMP2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 548)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LblDescripcion)
        Me.Controls.Add(Me.LblCodigo)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.LblIdPropiedad)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnAñadir)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DgvPropiedades)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmPropiedadesMP2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmPropiedadesMP2"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DgvPropiedades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents BtnSalir As Button
    Friend WithEvents TxtMateriaPrima As TextBox
    Friend WithEvents TxtUnidad As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CboPropiedad As ComboBox
    Friend WithEvents TxtValor As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtCodigoMateriaPrima As TextBox
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents LblIdPropiedad As Label
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnAñadir As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DgvPropiedades As DataGridView
    Friend WithEvents LblCodigo As Label
    Friend WithEvents LblDescripcion As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
