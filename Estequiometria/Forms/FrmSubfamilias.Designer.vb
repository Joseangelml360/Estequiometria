<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSubfamilias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSubfamilias))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CboFamilia = New System.Windows.Forms.ComboBox()
        Me.LblCboFamilia = New System.Windows.Forms.Label()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.DgvSubFamilias = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnTodos = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.Editar = New System.Windows.Forms.Button()
        Me.BtnAñadir = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DgvSubFamilias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CboFamilia)
        Me.Panel1.Controls.Add(Me.LblCboFamilia)
        Me.Panel1.Controls.Add(Me.TxtId)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.BtnCancelar)
        Me.Panel1.Controls.Add(Me.TxtDescripcion)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TxtCodigo)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.BtnGuardar)
        Me.Panel1.Location = New System.Drawing.Point(8, 462)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(765, 90)
        Me.Panel1.TabIndex = 10
        '
        'CboFamilia
        '
        Me.CboFamilia.FormattingEnabled = True
        Me.CboFamilia.Location = New System.Drawing.Point(382, 17)
        Me.CboFamilia.Name = "CboFamilia"
        Me.CboFamilia.Size = New System.Drawing.Size(160, 24)
        Me.CboFamilia.TabIndex = 8
        '
        'LblCboFamilia
        '
        Me.LblCboFamilia.AutoSize = True
        Me.LblCboFamilia.Location = New System.Drawing.Point(276, 18)
        Me.LblCboFamilia.Name = "LblCboFamilia"
        Me.LblCboFamilia.Size = New System.Drawing.Size(100, 17)
        Me.LblCboFamilia.TabIndex = 7
        Me.LblCboFamilia.Text = "Código Familia"
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(34, 13)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.ReadOnly = True
        Me.TxtId.Size = New System.Drawing.Size(40, 22)
        Me.TxtId.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Id"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Image = Global.Estequiometria.My.Resources.Resources.Cancelar
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.Location = New System.Drawing.Point(661, 9)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(100, 30)
        Me.BtnCancelar.TabIndex = 4
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Location = New System.Drawing.Point(99, 57)
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(443, 22)
        Me.TxtDescripcion.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Descripción"
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Location = New System.Drawing.Point(158, 17)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(100, 22)
        Me.TxtCodigo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(101, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Image = Global.Estequiometria.My.Resources.Resources.disk
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(661, 49)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(100, 30)
        Me.BtnGuardar.TabIndex = 1
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'DgvSubFamilias
        '
        Me.DgvSubFamilias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvSubFamilias.Location = New System.Drawing.Point(8, 104)
        Me.DgvSubFamilias.Name = "DgvSubFamilias"
        Me.DgvSubFamilias.RowHeadersWidth = 51
        Me.DgvSubFamilias.RowTemplate.Height = 24
        Me.DgvSubFamilias.Size = New System.Drawing.Size(765, 344)
        Me.DgvSubFamilias.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(63, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(271, 25)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Mantenimiento Subfamilias"
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Location = New System.Drawing.Point(410, 75)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(292, 22)
        Me.TxtBuscar.TabIndex = 52
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Estequiometria.My.Resources.Resources.SubFamilias
        Me.PictureBox1.Location = New System.Drawing.Point(8, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(49, 46)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 56
        Me.PictureBox1.TabStop = False
        '
        'BtnTodos
        '
        Me.BtnTodos.Image = Global.Estequiometria.My.Resources.Resources.undo16
        Me.BtnTodos.Location = New System.Drawing.Point(734, 72)
        Me.BtnTodos.Name = "BtnTodos"
        Me.BtnTodos.Size = New System.Drawing.Size(27, 30)
        Me.BtnTodos.TabIndex = 54
        Me.BtnTodos.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Image = Global.Estequiometria.My.Resources.Resources.filtro
        Me.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBuscar.Location = New System.Drawing.Point(314, 68)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(90, 30)
        Me.BtnBuscar.TabIndex = 53
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'Editar
        '
        Me.Editar.Image = Global.Estequiometria.My.Resources.Resources.Modificar
        Me.Editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Editar.Location = New System.Drawing.Point(127, 71)
        Me.Editar.Name = "Editar"
        Me.Editar.Size = New System.Drawing.Size(90, 30)
        Me.Editar.TabIndex = 9
        Me.Editar.Text = "Editar"
        Me.Editar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Editar.UseVisualStyleBackColor = True
        '
        'BtnAñadir
        '
        Me.BtnAñadir.Image = Global.Estequiometria.My.Resources.Resources.Añadir
        Me.BtnAñadir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAñadir.Location = New System.Drawing.Point(8, 71)
        Me.BtnAñadir.Name = "BtnAñadir"
        Me.BtnAñadir.Size = New System.Drawing.Size(90, 30)
        Me.BtnAñadir.TabIndex = 8
        Me.BtnAñadir.Text = "Añadir"
        Me.BtnAñadir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAñadir.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Image = Global.Estequiometria.My.Resources.Resources.Salir
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalir.Location = New System.Drawing.Point(684, 12)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(90, 30)
        Me.BtnSalir.TabIndex = 7
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'FrmSubfamilias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(786, 573)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnTodos)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Editar)
        Me.Controls.Add(Me.BtnAñadir)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.DgvSubFamilias)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmSubfamilias"
        Me.Text = "Subfamilias"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DgvSubFamilias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TxtId As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtCodigo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents Editar As Button
    Friend WithEvents BtnAñadir As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents DgvSubFamilias As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents CboFamilia As ComboBox
    Friend WithEvents LblCboFamilia As Label
    Friend WithEvents BtnTodos As Button
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
