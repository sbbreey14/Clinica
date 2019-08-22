<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_PRODUCTOS
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
        Me.LST_PRODUCTOS = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BTN_CANCELAR = New System.Windows.Forms.Button()
        Me.BTN_ACEPTAR = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NUM_STOCK_CRITICO = New System.Windows.Forms.NumericUpDown()
        Me.NUM_STOCK_REAL = New System.Windows.Forms.NumericUpDown()
        Me.TXT_PRECIO = New System.Windows.Forms.TextBox()
        Me.TXT_NOMBRE = New System.Windows.Forms.TextBox()
        Me.TXT_ID = New System.Windows.Forms.TextBox()
        Me.BTN_NUEVO = New System.Windows.Forms.Button()
        Me.BTN_MODIFICAR = New System.Windows.Forms.Button()
        Me.BTN_ELIMINAR = New System.Windows.Forms.Button()
        Me.BTN_SALIR = New System.Windows.Forms.Button()
        Me.LBL_ID = New System.Windows.Forms.Label()
        Me.LBL_NOMBRE = New System.Windows.Forms.Label()
        Me.LBL_PRECIO = New System.Windows.Forms.Label()
        Me.LBL_CRITICO = New System.Windows.Forms.Label()
        Me.LBL_REAL = New System.Windows.Forms.Label()
        Me.TXT_ID1 = New System.Windows.Forms.TextBox()
        Me.TXT_NOMBRE1 = New System.Windows.Forms.TextBox()
        Me.TXT_PRECIO1 = New System.Windows.Forms.TextBox()
        Me.TXT_REAL = New System.Windows.Forms.TextBox()
        Me.TXT_CRITICO = New System.Windows.Forms.TextBox()
        Me.LBL_ESTADO = New System.Windows.Forms.Label()
        Me.Filtro_a = New System.Windows.Forms.CheckBox()
        Me.LST1_PRODUCTOS = New System.Windows.Forms.ListBox()
        Me.Filtro_b = New System.Windows.Forms.CheckBox()
        Me.Lst_aux = New System.Windows.Forms.ListBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TXT_FOTO = New System.Windows.Forms.TextBox()
        Me.TXT_FOTO2 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUM_STOCK_CRITICO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUM_STOCK_REAL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LST_PRODUCTOS
        '
        Me.LST_PRODUCTOS.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LST_PRODUCTOS.FormattingEnabled = True
        Me.LST_PRODUCTOS.ItemHeight = 15
        Me.LST_PRODUCTOS.Location = New System.Drawing.Point(22, 22)
        Me.LST_PRODUCTOS.Name = "LST_PRODUCTOS"
        Me.LST_PRODUCTOS.Size = New System.Drawing.Size(531, 199)
        Me.LST_PRODUCTOS.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.BTN_CANCELAR)
        Me.GroupBox1.Controls.Add(Me.BTN_ACEPTAR)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.NUM_STOCK_CRITICO)
        Me.GroupBox1.Controls.Add(Me.NUM_STOCK_REAL)
        Me.GroupBox1.Controls.Add(Me.TXT_PRECIO)
        Me.GroupBox1.Controls.Add(Me.TXT_NOMBRE)
        Me.GroupBox1.Controls.Add(Me.TXT_ID)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 248)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(529, 159)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(410, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 98)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'BTN_CANCELAR
        '
        Me.BTN_CANCELAR.Enabled = False
        Me.BTN_CANCELAR.Location = New System.Drawing.Point(453, 118)
        Me.BTN_CANCELAR.Name = "BTN_CANCELAR"
        Me.BTN_CANCELAR.Size = New System.Drawing.Size(75, 23)
        Me.BTN_CANCELAR.TabIndex = 11
        Me.BTN_CANCELAR.Text = "&Cancelar"
        Me.BTN_CANCELAR.UseVisualStyleBackColor = True
        '
        'BTN_ACEPTAR
        '
        Me.BTN_ACEPTAR.Enabled = False
        Me.BTN_ACEPTAR.Location = New System.Drawing.Point(372, 118)
        Me.BTN_ACEPTAR.Name = "BTN_ACEPTAR"
        Me.BTN_ACEPTAR.Size = New System.Drawing.Size(75, 23)
        Me.BTN_ACEPTAR.TabIndex = 10
        Me.BTN_ACEPTAR.Text = "&Aceptar"
        Me.BTN_ACEPTAR.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "STOCK CRÍTICO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "STOCK REAL"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "PRECIO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "NOMBRE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ID"
        '
        'NUM_STOCK_CRITICO
        '
        Me.NUM_STOCK_CRITICO.Enabled = False
        Me.NUM_STOCK_CRITICO.Location = New System.Drawing.Point(113, 126)
        Me.NUM_STOCK_CRITICO.Name = "NUM_STOCK_CRITICO"
        Me.NUM_STOCK_CRITICO.Size = New System.Drawing.Size(62, 20)
        Me.NUM_STOCK_CRITICO.TabIndex = 4
        '
        'NUM_STOCK_REAL
        '
        Me.NUM_STOCK_REAL.Enabled = False
        Me.NUM_STOCK_REAL.Location = New System.Drawing.Point(113, 100)
        Me.NUM_STOCK_REAL.Minimum = New Decimal(New Integer() {300, 0, 0, -2147483648})
        Me.NUM_STOCK_REAL.Name = "NUM_STOCK_REAL"
        Me.NUM_STOCK_REAL.Size = New System.Drawing.Size(62, 20)
        Me.NUM_STOCK_REAL.TabIndex = 3
        '
        'TXT_PRECIO
        '
        Me.TXT_PRECIO.Enabled = False
        Me.TXT_PRECIO.Location = New System.Drawing.Point(113, 74)
        Me.TXT_PRECIO.Name = "TXT_PRECIO"
        Me.TXT_PRECIO.Size = New System.Drawing.Size(100, 20)
        Me.TXT_PRECIO.TabIndex = 2
        Me.TXT_PRECIO.Text = "0"
        '
        'TXT_NOMBRE
        '
        Me.TXT_NOMBRE.Enabled = False
        Me.TXT_NOMBRE.Location = New System.Drawing.Point(113, 48)
        Me.TXT_NOMBRE.Name = "TXT_NOMBRE"
        Me.TXT_NOMBRE.Size = New System.Drawing.Size(252, 20)
        Me.TXT_NOMBRE.TabIndex = 1
        '
        'TXT_ID
        '
        Me.TXT_ID.Enabled = False
        Me.TXT_ID.Location = New System.Drawing.Point(113, 22)
        Me.TXT_ID.MaxLength = 5
        Me.TXT_ID.Name = "TXT_ID"
        Me.TXT_ID.Size = New System.Drawing.Size(47, 20)
        Me.TXT_ID.TabIndex = 0
        '
        'BTN_NUEVO
        '
        Me.BTN_NUEVO.Location = New System.Drawing.Point(22, 412)
        Me.BTN_NUEVO.Name = "BTN_NUEVO"
        Me.BTN_NUEVO.Size = New System.Drawing.Size(117, 30)
        Me.BTN_NUEVO.TabIndex = 2
        Me.BTN_NUEVO.Text = "&Nuevo"
        Me.BTN_NUEVO.UseVisualStyleBackColor = True
        '
        'BTN_MODIFICAR
        '
        Me.BTN_MODIFICAR.Location = New System.Drawing.Point(162, 412)
        Me.BTN_MODIFICAR.Name = "BTN_MODIFICAR"
        Me.BTN_MODIFICAR.Size = New System.Drawing.Size(117, 30)
        Me.BTN_MODIFICAR.TabIndex = 3
        Me.BTN_MODIFICAR.Text = "&Modificar"
        Me.BTN_MODIFICAR.UseVisualStyleBackColor = True
        '
        'BTN_ELIMINAR
        '
        Me.BTN_ELIMINAR.Location = New System.Drawing.Point(297, 412)
        Me.BTN_ELIMINAR.Name = "BTN_ELIMINAR"
        Me.BTN_ELIMINAR.Size = New System.Drawing.Size(117, 30)
        Me.BTN_ELIMINAR.TabIndex = 4
        Me.BTN_ELIMINAR.Text = "&Eliminar"
        Me.BTN_ELIMINAR.UseVisualStyleBackColor = True
        '
        'BTN_SALIR
        '
        Me.BTN_SALIR.Location = New System.Drawing.Point(434, 412)
        Me.BTN_SALIR.Name = "BTN_SALIR"
        Me.BTN_SALIR.Size = New System.Drawing.Size(117, 30)
        Me.BTN_SALIR.TabIndex = 5
        Me.BTN_SALIR.Text = "&Salir"
        Me.BTN_SALIR.UseVisualStyleBackColor = True
        '
        'LBL_ID
        '
        Me.LBL_ID.BackColor = System.Drawing.Color.Black
        Me.LBL_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBL_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_ID.ForeColor = System.Drawing.Color.White
        Me.LBL_ID.Location = New System.Drawing.Point(23, 7)
        Me.LBL_ID.Name = "LBL_ID"
        Me.LBL_ID.Size = New System.Drawing.Size(43, 15)
        Me.LBL_ID.TabIndex = 6
        Me.LBL_ID.Text = "ID"
        '
        'LBL_NOMBRE
        '
        Me.LBL_NOMBRE.BackColor = System.Drawing.Color.Black
        Me.LBL_NOMBRE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBL_NOMBRE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_NOMBRE.ForeColor = System.Drawing.Color.White
        Me.LBL_NOMBRE.Location = New System.Drawing.Point(67, 7)
        Me.LBL_NOMBRE.Name = "LBL_NOMBRE"
        Me.LBL_NOMBRE.Size = New System.Drawing.Size(287, 15)
        Me.LBL_NOMBRE.TabIndex = 7
        Me.LBL_NOMBRE.Text = "NOMBRE"
        '
        'LBL_PRECIO
        '
        Me.LBL_PRECIO.BackColor = System.Drawing.Color.Black
        Me.LBL_PRECIO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBL_PRECIO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_PRECIO.ForeColor = System.Drawing.Color.White
        Me.LBL_PRECIO.Location = New System.Drawing.Point(355, 7)
        Me.LBL_PRECIO.Name = "LBL_PRECIO"
        Me.LBL_PRECIO.Size = New System.Drawing.Size(73, 15)
        Me.LBL_PRECIO.TabIndex = 8
        Me.LBL_PRECIO.Text = "PRECIO"
        Me.LBL_PRECIO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBL_CRITICO
        '
        Me.LBL_CRITICO.BackColor = System.Drawing.Color.Black
        Me.LBL_CRITICO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBL_CRITICO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_CRITICO.ForeColor = System.Drawing.Color.White
        Me.LBL_CRITICO.Location = New System.Drawing.Point(492, 7)
        Me.LBL_CRITICO.Name = "LBL_CRITICO"
        Me.LBL_CRITICO.Size = New System.Drawing.Size(60, 15)
        Me.LBL_CRITICO.TabIndex = 9
        Me.LBL_CRITICO.Text = "CRITICO"
        Me.LBL_CRITICO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBL_REAL
        '
        Me.LBL_REAL.BackColor = System.Drawing.Color.Black
        Me.LBL_REAL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBL_REAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_REAL.ForeColor = System.Drawing.Color.White
        Me.LBL_REAL.Location = New System.Drawing.Point(430, 7)
        Me.LBL_REAL.Name = "LBL_REAL"
        Me.LBL_REAL.Size = New System.Drawing.Size(60, 15)
        Me.LBL_REAL.TabIndex = 10
        Me.LBL_REAL.Text = "REAL"
        Me.LBL_REAL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TXT_ID1
        '
        Me.TXT_ID1.Location = New System.Drawing.Point(22, 224)
        Me.TXT_ID1.MaxLength = 5
        Me.TXT_ID1.Name = "TXT_ID1"
        Me.TXT_ID1.Size = New System.Drawing.Size(44, 20)
        Me.TXT_ID1.TabIndex = 12
        '
        'TXT_NOMBRE1
        '
        Me.TXT_NOMBRE1.Location = New System.Drawing.Point(67, 224)
        Me.TXT_NOMBRE1.Name = "TXT_NOMBRE1"
        Me.TXT_NOMBRE1.Size = New System.Drawing.Size(287, 20)
        Me.TXT_NOMBRE1.TabIndex = 12
        '
        'TXT_PRECIO1
        '
        Me.TXT_PRECIO1.Location = New System.Drawing.Point(355, 224)
        Me.TXT_PRECIO1.Name = "TXT_PRECIO1"
        Me.TXT_PRECIO1.Size = New System.Drawing.Size(73, 20)
        Me.TXT_PRECIO1.TabIndex = 13
        '
        'TXT_REAL
        '
        Me.TXT_REAL.Location = New System.Drawing.Point(429, 224)
        Me.TXT_REAL.Name = "TXT_REAL"
        Me.TXT_REAL.Size = New System.Drawing.Size(60, 20)
        Me.TXT_REAL.TabIndex = 14
        '
        'TXT_CRITICO
        '
        Me.TXT_CRITICO.Location = New System.Drawing.Point(491, 224)
        Me.TXT_CRITICO.Name = "TXT_CRITICO"
        Me.TXT_CRITICO.Size = New System.Drawing.Size(60, 20)
        Me.TXT_CRITICO.TabIndex = 15
        '
        'LBL_ESTADO
        '
        Me.LBL_ESTADO.BackColor = System.Drawing.Color.Black
        Me.LBL_ESTADO.ForeColor = System.Drawing.Color.White
        Me.LBL_ESTADO.Location = New System.Drawing.Point(1, 447)
        Me.LBL_ESTADO.Name = "LBL_ESTADO"
        Me.LBL_ESTADO.Size = New System.Drawing.Size(598, 21)
        Me.LBL_ESTADO.TabIndex = 16
        Me.LBL_ESTADO.Text = "Ordena los datos por ID del producto."
        '
        'Filtro_a
        '
        Me.Filtro_a.AutoSize = True
        Me.Filtro_a.Location = New System.Drawing.Point(559, 204)
        Me.Filtro_a.Name = "Filtro_a"
        Me.Filtro_a.Size = New System.Drawing.Size(29, 17)
        Me.Filtro_a.TabIndex = 17
        Me.Filtro_a.Text = " "
        Me.Filtro_a.UseVisualStyleBackColor = True
        '
        'LST1_PRODUCTOS
        '
        Me.LST1_PRODUCTOS.FormattingEnabled = True
        Me.LST1_PRODUCTOS.Location = New System.Drawing.Point(22, 22)
        Me.LST1_PRODUCTOS.Name = "LST1_PRODUCTOS"
        Me.LST1_PRODUCTOS.Size = New System.Drawing.Size(529, 199)
        Me.LST1_PRODUCTOS.TabIndex = 18
        '
        'Filtro_b
        '
        Me.Filtro_b.AutoSize = True
        Me.Filtro_b.Location = New System.Drawing.Point(559, 226)
        Me.Filtro_b.Name = "Filtro_b"
        Me.Filtro_b.Size = New System.Drawing.Size(15, 14)
        Me.Filtro_b.TabIndex = 19
        Me.Filtro_b.UseVisualStyleBackColor = True
        '
        'Lst_aux
        '
        Me.Lst_aux.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lst_aux.FormattingEnabled = True
        Me.Lst_aux.ItemHeight = 15
        Me.Lst_aux.Location = New System.Drawing.Point(580, 41)
        Me.Lst_aux.Name = "Lst_aux"
        Me.Lst_aux.Size = New System.Drawing.Size(266, 199)
        Me.Lst_aux.TabIndex = 20
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "images (* PNG) |* PNG"
        '
        'TXT_FOTO
        '
        Me.TXT_FOTO.Location = New System.Drawing.Point(580, 262)
        Me.TXT_FOTO.Name = "TXT_FOTO"
        Me.TXT_FOTO.Size = New System.Drawing.Size(262, 20)
        Me.TXT_FOTO.TabIndex = 21
        '
        'TXT_FOTO2
        '
        Me.TXT_FOTO2.Location = New System.Drawing.Point(559, 288)
        Me.TXT_FOTO2.Name = "TXT_FOTO2"
        Me.TXT_FOTO2.Size = New System.Drawing.Size(288, 20)
        Me.TXT_FOTO2.TabIndex = 22
        '
        'FRM_PRODUCTOS
        '
        Me.AcceptButton = Me.BTN_ACEPTAR
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(854, 464)
        Me.Controls.Add(Me.TXT_FOTO2)
        Me.Controls.Add(Me.TXT_FOTO)
        Me.Controls.Add(Me.Lst_aux)
        Me.Controls.Add(Me.Filtro_b)
        Me.Controls.Add(Me.Filtro_a)
        Me.Controls.Add(Me.LBL_ESTADO)
        Me.Controls.Add(Me.TXT_CRITICO)
        Me.Controls.Add(Me.TXT_REAL)
        Me.Controls.Add(Me.TXT_PRECIO1)
        Me.Controls.Add(Me.TXT_NOMBRE1)
        Me.Controls.Add(Me.TXT_ID1)
        Me.Controls.Add(Me.LBL_REAL)
        Me.Controls.Add(Me.LBL_CRITICO)
        Me.Controls.Add(Me.LBL_PRECIO)
        Me.Controls.Add(Me.LBL_NOMBRE)
        Me.Controls.Add(Me.LBL_ID)
        Me.Controls.Add(Me.BTN_SALIR)
        Me.Controls.Add(Me.BTN_ELIMINAR)
        Me.Controls.Add(Me.BTN_MODIFICAR)
        Me.Controls.Add(Me.BTN_NUEVO)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LST_PRODUCTOS)
        Me.Controls.Add(Me.LST1_PRODUCTOS)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_PRODUCTOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MANTENEDOR DE PRODUCTOS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUM_STOCK_CRITICO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUM_STOCK_REAL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LST_PRODUCTOS As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents NUM_STOCK_CRITICO As NumericUpDown
    Friend WithEvents NUM_STOCK_REAL As NumericUpDown
    Friend WithEvents TXT_PRECIO As TextBox
    Friend WithEvents TXT_NOMBRE As TextBox
    Friend WithEvents TXT_ID As TextBox
    Friend WithEvents BTN_NUEVO As Button
    Friend WithEvents BTN_MODIFICAR As Button
    Friend WithEvents BTN_ELIMINAR As Button
    Friend WithEvents BTN_SALIR As Button
    Friend WithEvents BTN_CANCELAR As Button
    Friend WithEvents BTN_ACEPTAR As Button
    Friend WithEvents LBL_ID As Label
    Friend WithEvents LBL_NOMBRE As Label
    Friend WithEvents LBL_PRECIO As Label
    Friend WithEvents LBL_CRITICO As Label
    Friend WithEvents LBL_REAL As Label
    Friend WithEvents TXT_ID1 As TextBox
    Friend WithEvents TXT_NOMBRE1 As TextBox
    Friend WithEvents TXT_PRECIO1 As TextBox
    Friend WithEvents TXT_REAL As TextBox
    Friend WithEvents TXT_CRITICO As TextBox
    Friend WithEvents LBL_ESTADO As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Filtro_a As CheckBox
    Friend WithEvents LST1_PRODUCTOS As ListBox
    Friend WithEvents Filtro_b As CheckBox
    Friend WithEvents Lst_aux As ListBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TXT_FOTO As TextBox
    Friend WithEvents TXT_FOTO2 As TextBox
End Class
