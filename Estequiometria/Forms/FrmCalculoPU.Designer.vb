<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCalculoPU
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCalculoPU))
        Me.GrpParteA = New System.Windows.Forms.GroupBox()
        Me.CboFormulaA = New System.Windows.Forms.ComboBox()
        Me.TxtEqOH = New System.Windows.Forms.TextBox()
        Me.TxtDescripcionA = New System.Windows.Forms.TextBox()
        Me.LblDescripcionA = New System.Windows.Forms.Label()
        Me.LblEqOH = New System.Windows.Forms.Label()
        Me.LblFormulaA = New System.Windows.Forms.Label()
        Me.GrpParteB = New System.Windows.Forms.GroupBox()
        Me.CboFormulaB = New System.Windows.Forms.ComboBox()
        Me.TxtDescripcionB = New System.Windows.Forms.TextBox()
        Me.TxtEqNCO = New System.Windows.Forms.TextBox()
        Me.LblFormulaB = New System.Windows.Forms.Label()
        Me.LblEqNCO = New System.Windows.Forms.Label()
        Me.LblDescripcionB = New System.Windows.Forms.Label()
        Me.GrpRelacion = New System.Windows.Forms.GroupBox()
        Me.LblPartesB = New System.Windows.Forms.Label()
        Me.NumParteB = New System.Windows.Forms.NumericUpDown()
        Me.LblPartesA = New System.Windows.Forms.Label()
        Me.NumParteA = New System.Windows.Forms.NumericUpDown()
        Me.GrpResultados = New System.Windows.Forms.GroupBox()
        Me.TxtExcesoNCO = New System.Windows.Forms.TextBox()
        Me.LblExcesoNCO = New System.Windows.Forms.Label()
        Me.TxtIndiceNCO = New System.Windows.Forms.TextBox()
        Me.LblIndiceNCO = New System.Windows.Forms.Label()
        Me.TxtEqNCOTotal = New System.Windows.Forms.TextBox()
        Me.LblEqNCOTotal = New System.Windows.Forms.Label()
        Me.TxtEqOHTotal = New System.Windows.Forms.TextBox()
        Me.LblEqOHTotal = New System.Windows.Forms.Label()
        Me.DgvCalculo = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnCalcular = New System.Windows.Forms.Button()
        Me.BtnAutomatico = New System.Windows.Forms.Button()
        Me.GrpParteA.SuspendLayout()
        Me.GrpParteB.SuspendLayout()
        Me.GrpRelacion.SuspendLayout()
        CType(Me.NumParteB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumParteA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpResultados.SuspendLayout()
        CType(Me.DgvCalculo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrpParteA
        '
        Me.GrpParteA.Controls.Add(Me.CboFormulaA)
        Me.GrpParteA.Controls.Add(Me.TxtEqOH)
        Me.GrpParteA.Controls.Add(Me.TxtDescripcionA)
        Me.GrpParteA.Controls.Add(Me.LblDescripcionA)
        Me.GrpParteA.Controls.Add(Me.LblEqOH)
        Me.GrpParteA.Controls.Add(Me.LblFormulaA)
        Me.GrpParteA.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpParteA.Location = New System.Drawing.Point(12, 50)
        Me.GrpParteA.Name = "GrpParteA"
        Me.GrpParteA.Size = New System.Drawing.Size(504, 143)
        Me.GrpParteA.TabIndex = 0
        Me.GrpParteA.TabStop = False
        Me.GrpParteA.Text = "Parte A"
        '
        'CboFormulaA
        '
        Me.CboFormulaA.FormattingEnabled = True
        Me.CboFormulaA.Location = New System.Drawing.Point(117, 35)
        Me.CboFormulaA.Name = "CboFormulaA"
        Me.CboFormulaA.Size = New System.Drawing.Size(345, 24)
        Me.CboFormulaA.TabIndex = 5
        '
        'TxtEqOH
        '
        Me.TxtEqOH.Location = New System.Drawing.Point(117, 108)
        Me.TxtEqOH.Name = "TxtEqOH"
        Me.TxtEqOH.ReadOnly = True
        Me.TxtEqOH.Size = New System.Drawing.Size(100, 22)
        Me.TxtEqOH.TabIndex = 4
        '
        'TxtDescripcionA
        '
        Me.TxtDescripcionA.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescripcionA.Location = New System.Drawing.Point(117, 70)
        Me.TxtDescripcionA.Name = "TxtDescripcionA"
        Me.TxtDescripcionA.ReadOnly = True
        Me.TxtDescripcionA.Size = New System.Drawing.Size(345, 26)
        Me.TxtDescripcionA.TabIndex = 3
        '
        'LblDescripcionA
        '
        Me.LblDescripcionA.AutoSize = True
        Me.LblDescripcionA.Location = New System.Drawing.Point(29, 75)
        Me.LblDescripcionA.Name = "LblDescripcionA"
        Me.LblDescripcionA.Size = New System.Drawing.Size(82, 17)
        Me.LblDescripcionA.TabIndex = 2
        Me.LblDescripcionA.Text = "Descripción"
        '
        'LblEqOH
        '
        Me.LblEqOH.AutoSize = True
        Me.LblEqOH.Location = New System.Drawing.Point(59, 113)
        Me.LblEqOH.Name = "LblEqOH"
        Me.LblEqOH.Size = New System.Drawing.Size(46, 17)
        Me.LblEqOH.TabIndex = 1
        Me.LblEqOH.Text = "EqOH"
        '
        'LblFormulaA
        '
        Me.LblFormulaA.AutoSize = True
        Me.LblFormulaA.Location = New System.Drawing.Point(29, 35)
        Me.LblFormulaA.Name = "LblFormulaA"
        Me.LblFormulaA.Size = New System.Drawing.Size(72, 17)
        Me.LblFormulaA.TabIndex = 0
        Me.LblFormulaA.Text = "Fórmula A"
        '
        'GrpParteB
        '
        Me.GrpParteB.Controls.Add(Me.CboFormulaB)
        Me.GrpParteB.Controls.Add(Me.TxtDescripcionB)
        Me.GrpParteB.Controls.Add(Me.TxtEqNCO)
        Me.GrpParteB.Controls.Add(Me.LblFormulaB)
        Me.GrpParteB.Controls.Add(Me.LblEqNCO)
        Me.GrpParteB.Controls.Add(Me.LblDescripcionB)
        Me.GrpParteB.Location = New System.Drawing.Point(553, 50)
        Me.GrpParteB.Name = "GrpParteB"
        Me.GrpParteB.Size = New System.Drawing.Size(499, 143)
        Me.GrpParteB.TabIndex = 1
        Me.GrpParteB.TabStop = False
        Me.GrpParteB.Text = "Parte B"
        '
        'CboFormulaB
        '
        Me.CboFormulaB.FormattingEnabled = True
        Me.CboFormulaB.Location = New System.Drawing.Point(120, 35)
        Me.CboFormulaB.Name = "CboFormulaB"
        Me.CboFormulaB.Size = New System.Drawing.Size(325, 24)
        Me.CboFormulaB.TabIndex = 11
        '
        'TxtDescripcionB
        '
        Me.TxtDescripcionB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescripcionB.Location = New System.Drawing.Point(120, 70)
        Me.TxtDescripcionB.Name = "TxtDescripcionB"
        Me.TxtDescripcionB.ReadOnly = True
        Me.TxtDescripcionB.Size = New System.Drawing.Size(325, 26)
        Me.TxtDescripcionB.TabIndex = 9
        '
        'TxtEqNCO
        '
        Me.TxtEqNCO.Location = New System.Drawing.Point(120, 108)
        Me.TxtEqNCO.Name = "TxtEqNCO"
        Me.TxtEqNCO.ReadOnly = True
        Me.TxtEqNCO.Size = New System.Drawing.Size(100, 22)
        Me.TxtEqNCO.TabIndex = 10
        '
        'LblFormulaB
        '
        Me.LblFormulaB.AutoSize = True
        Me.LblFormulaB.Location = New System.Drawing.Point(32, 35)
        Me.LblFormulaB.Name = "LblFormulaB"
        Me.LblFormulaB.Size = New System.Drawing.Size(72, 17)
        Me.LblFormulaB.TabIndex = 6
        Me.LblFormulaB.Text = "Fórmula B"
        '
        'LblEqNCO
        '
        Me.LblEqNCO.AutoSize = True
        Me.LblEqNCO.Location = New System.Drawing.Point(62, 113)
        Me.LblEqNCO.Name = "LblEqNCO"
        Me.LblEqNCO.Size = New System.Drawing.Size(55, 17)
        Me.LblEqNCO.TabIndex = 7
        Me.LblEqNCO.Text = "EqNCO"
        '
        'LblDescripcionB
        '
        Me.LblDescripcionB.AutoSize = True
        Me.LblDescripcionB.Location = New System.Drawing.Point(32, 70)
        Me.LblDescripcionB.Name = "LblDescripcionB"
        Me.LblDescripcionB.Size = New System.Drawing.Size(82, 17)
        Me.LblDescripcionB.TabIndex = 8
        Me.LblDescripcionB.Text = "Descripción"
        '
        'GrpRelacion
        '
        Me.GrpRelacion.Controls.Add(Me.LblPartesB)
        Me.GrpRelacion.Controls.Add(Me.NumParteB)
        Me.GrpRelacion.Controls.Add(Me.LblPartesA)
        Me.GrpRelacion.Controls.Add(Me.NumParteA)
        Me.GrpRelacion.Location = New System.Drawing.Point(12, 211)
        Me.GrpRelacion.Name = "GrpRelacion"
        Me.GrpRelacion.Size = New System.Drawing.Size(1040, 75)
        Me.GrpRelacion.TabIndex = 2
        Me.GrpRelacion.TabStop = False
        Me.GrpRelacion.Text = "Relación de mezcla A/B"
        '
        'LblPartesB
        '
        Me.LblPartesB.AutoSize = True
        Me.LblPartesB.Location = New System.Drawing.Point(582, 37)
        Me.LblPartesB.Name = "LblPartesB"
        Me.LblPartesB.Size = New System.Drawing.Size(114, 17)
        Me.LblPartesB.TabIndex = 3
        Me.LblPartesB.Text = "Cantidad parte B"
        '
        'NumParteB
        '
        Me.NumParteB.Location = New System.Drawing.Point(715, 35)
        Me.NumParteB.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.NumParteB.Name = "NumParteB"
        Me.NumParteB.Size = New System.Drawing.Size(120, 22)
        Me.NumParteB.TabIndex = 2
        Me.NumParteB.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'LblPartesA
        '
        Me.LblPartesA.AutoSize = True
        Me.LblPartesA.Location = New System.Drawing.Point(169, 37)
        Me.LblPartesA.Name = "LblPartesA"
        Me.LblPartesA.Size = New System.Drawing.Size(114, 17)
        Me.LblPartesA.TabIndex = 1
        Me.LblPartesA.Text = "Cantidad parte A"
        '
        'NumParteA
        '
        Me.NumParteA.Location = New System.Drawing.Point(302, 35)
        Me.NumParteA.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumParteA.Name = "NumParteA"
        Me.NumParteA.Size = New System.Drawing.Size(120, 22)
        Me.NumParteA.TabIndex = 0
        Me.NumParteA.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'GrpResultados
        '
        Me.GrpResultados.Controls.Add(Me.TxtExcesoNCO)
        Me.GrpResultados.Controls.Add(Me.LblExcesoNCO)
        Me.GrpResultados.Controls.Add(Me.TxtIndiceNCO)
        Me.GrpResultados.Controls.Add(Me.LblIndiceNCO)
        Me.GrpResultados.Controls.Add(Me.TxtEqNCOTotal)
        Me.GrpResultados.Controls.Add(Me.LblEqNCOTotal)
        Me.GrpResultados.Controls.Add(Me.TxtEqOHTotal)
        Me.GrpResultados.Controls.Add(Me.LblEqOHTotal)
        Me.GrpResultados.Location = New System.Drawing.Point(12, 350)
        Me.GrpResultados.Name = "GrpResultados"
        Me.GrpResultados.Size = New System.Drawing.Size(1040, 75)
        Me.GrpResultados.TabIndex = 3
        Me.GrpResultados.TabStop = False
        Me.GrpResultados.Text = "Resultados"
        '
        'TxtExcesoNCO
        '
        Me.TxtExcesoNCO.BackColor = System.Drawing.Color.LightYellow
        Me.TxtExcesoNCO.Location = New System.Drawing.Point(896, 28)
        Me.TxtExcesoNCO.Name = "TxtExcesoNCO"
        Me.TxtExcesoNCO.ReadOnly = True
        Me.TxtExcesoNCO.Size = New System.Drawing.Size(100, 22)
        Me.TxtExcesoNCO.TabIndex = 7
        Me.TxtExcesoNCO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LblExcesoNCO
        '
        Me.LblExcesoNCO.AutoSize = True
        Me.LblExcesoNCO.Location = New System.Drawing.Point(803, 33)
        Me.LblExcesoNCO.Name = "LblExcesoNCO"
        Me.LblExcesoNCO.Size = New System.Drawing.Size(87, 17)
        Me.LblExcesoNCO.TabIndex = 6
        Me.LblExcesoNCO.Text = "Exceso NCO"
        '
        'TxtIndiceNCO
        '
        Me.TxtIndiceNCO.BackColor = System.Drawing.Color.LightYellow
        Me.TxtIndiceNCO.Location = New System.Drawing.Point(627, 28)
        Me.TxtIndiceNCO.Name = "TxtIndiceNCO"
        Me.TxtIndiceNCO.ReadOnly = True
        Me.TxtIndiceNCO.Size = New System.Drawing.Size(100, 22)
        Me.TxtIndiceNCO.TabIndex = 5
        Me.TxtIndiceNCO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LblIndiceNCO
        '
        Me.LblIndiceNCO.AutoSize = True
        Me.LblIndiceNCO.Location = New System.Drawing.Point(517, 31)
        Me.LblIndiceNCO.Name = "LblIndiceNCO"
        Me.LblIndiceNCO.Size = New System.Drawing.Size(104, 17)
        Me.LblIndiceNCO.TabIndex = 4
        Me.LblIndiceNCO.Text = "Índice NCO/OH"
        '
        'TxtEqNCOTotal
        '
        Me.TxtEqNCOTotal.BackColor = System.Drawing.Color.LightYellow
        Me.TxtEqNCOTotal.Location = New System.Drawing.Point(336, 28)
        Me.TxtEqNCOTotal.Name = "TxtEqNCOTotal"
        Me.TxtEqNCOTotal.ReadOnly = True
        Me.TxtEqNCOTotal.Size = New System.Drawing.Size(100, 22)
        Me.TxtEqNCOTotal.TabIndex = 3
        Me.TxtEqNCOTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LblEqNCOTotal
        '
        Me.LblEqNCOTotal.AutoSize = True
        Me.LblEqNCOTotal.Location = New System.Drawing.Point(283, 33)
        Me.LblEqNCOTotal.Name = "LblEqNCOTotal"
        Me.LblEqNCOTotal.Size = New System.Drawing.Size(55, 17)
        Me.LblEqNCOTotal.TabIndex = 2
        Me.LblEqNCOTotal.Text = "EqNCO"
        '
        'TxtEqOHTotal
        '
        Me.TxtEqOHTotal.BackColor = System.Drawing.Color.LightYellow
        Me.TxtEqOHTotal.Location = New System.Drawing.Point(89, 28)
        Me.TxtEqOHTotal.Name = "TxtEqOHTotal"
        Me.TxtEqOHTotal.ReadOnly = True
        Me.TxtEqOHTotal.Size = New System.Drawing.Size(100, 22)
        Me.TxtEqOHTotal.TabIndex = 1
        Me.TxtEqOHTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LblEqOHTotal
        '
        Me.LblEqOHTotal.AutoSize = True
        Me.LblEqOHTotal.Location = New System.Drawing.Point(32, 33)
        Me.LblEqOHTotal.Name = "LblEqOHTotal"
        Me.LblEqOHTotal.Size = New System.Drawing.Size(46, 17)
        Me.LblEqOHTotal.TabIndex = 0
        Me.LblEqOHTotal.Text = "EqOH"
        '
        'DgvCalculo
        '
        Me.DgvCalculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCalculo.Location = New System.Drawing.Point(12, 461)
        Me.DgvCalculo.Name = "DgvCalculo"
        Me.DgvCalculo.RowHeadersWidth = 51
        Me.DgvCalculo.RowTemplate.Height = 24
        Me.DgvCalculo.Size = New System.Drawing.Size(1032, 179)
        Me.DgvCalculo.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 441)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Cálculo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(422, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(211, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Cálculo Poliuretanos"
        '
        'BtnVolver
        '
        Me.BtnVolver.Image = Global.Estequiometria.My.Resources.Resources.undo16
        Me.BtnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnVolver.Location = New System.Drawing.Point(731, 305)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(90, 30)
        Me.BtnVolver.TabIndex = 25
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnVolver.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Image = Global.Estequiometria.My.Resources.Resources.Controller
        Me.BtnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLimpiar.Location = New System.Drawing.Point(827, 296)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(104, 48)
        Me.BtnLimpiar.TabIndex = 24
        Me.BtnLimpiar.Text = "Introducir " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "valores"
        Me.BtnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Estequiometria.My.Resources.Resources.Reacción
        Me.PictureBox1.Location = New System.Drawing.Point(370, -4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(49, 46)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'BtnSalir
        '
        Me.BtnSalir.Image = Global.Estequiometria.My.Resources.Resources.Salir
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalir.Location = New System.Drawing.Point(980, 12)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(90, 30)
        Me.BtnSalir.TabIndex = 10
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnCalcular
        '
        Me.BtnCalcular.Image = Global.Estequiometria.My.Resources.Resources.calculator
        Me.BtnCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCalcular.Location = New System.Drawing.Point(553, 302)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(90, 30)
        Me.BtnCalcular.TabIndex = 8
        Me.BtnCalcular.Text = "Manual"
        Me.BtnCalcular.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCalcular.UseVisualStyleBackColor = True
        '
        'BtnAutomatico
        '
        Me.BtnAutomatico.Image = Global.Estequiometria.My.Resources.Resources.calculator
        Me.BtnAutomatico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAutomatico.Location = New System.Drawing.Point(404, 302)
        Me.BtnAutomatico.Name = "BtnAutomatico"
        Me.BtnAutomatico.Size = New System.Drawing.Size(112, 30)
        Me.BtnAutomatico.TabIndex = 7
        Me.BtnAutomatico.Text = "Automático"
        Me.BtnAutomatico.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAutomatico.UseVisualStyleBackColor = True
        '
        'FrmCalculoPU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1082, 653)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnCalcular)
        Me.Controls.Add(Me.BtnAutomatico)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DgvCalculo)
        Me.Controls.Add(Me.GrpResultados)
        Me.Controls.Add(Me.GrpRelacion)
        Me.Controls.Add(Me.GrpParteB)
        Me.Controls.Add(Me.GrpParteA)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmCalculoPU"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmCalculoPU"
        Me.GrpParteA.ResumeLayout(False)
        Me.GrpParteA.PerformLayout()
        Me.GrpParteB.ResumeLayout(False)
        Me.GrpParteB.PerformLayout()
        Me.GrpRelacion.ResumeLayout(False)
        Me.GrpRelacion.PerformLayout()
        CType(Me.NumParteB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumParteA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpResultados.ResumeLayout(False)
        Me.GrpResultados.PerformLayout()
        CType(Me.DgvCalculo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GrpParteA As GroupBox
    Friend WithEvents CboFormulaA As ComboBox
    Friend WithEvents TxtEqOH As TextBox
    Friend WithEvents TxtDescripcionA As TextBox
    Friend WithEvents LblDescripcionA As Label
    Friend WithEvents LblEqOH As Label
    Friend WithEvents LblFormulaA As Label
    Friend WithEvents GrpParteB As GroupBox
    Friend WithEvents CboFormulaB As ComboBox
    Friend WithEvents TxtDescripcionB As TextBox
    Friend WithEvents TxtEqNCO As TextBox
    Friend WithEvents LblFormulaB As Label
    Friend WithEvents LblEqNCO As Label
    Friend WithEvents LblDescripcionB As Label
    Friend WithEvents GrpRelacion As GroupBox
    Friend WithEvents LblPartesB As Label
    Friend WithEvents NumParteB As NumericUpDown
    Friend WithEvents LblPartesA As Label
    Friend WithEvents NumParteA As NumericUpDown
    Friend WithEvents GrpResultados As GroupBox
    Friend WithEvents TxtExcesoNCO As TextBox
    Friend WithEvents LblExcesoNCO As Label
    Friend WithEvents TxtIndiceNCO As TextBox
    Friend WithEvents LblIndiceNCO As Label
    Friend WithEvents TxtEqNCOTotal As TextBox
    Friend WithEvents LblEqNCOTotal As Label
    Friend WithEvents TxtEqOHTotal As TextBox
    Friend WithEvents LblEqOHTotal As Label
    Friend WithEvents DgvCalculo As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnAutomatico As Button
    Friend WithEvents BtnCalcular As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnVolver As Button
End Class
