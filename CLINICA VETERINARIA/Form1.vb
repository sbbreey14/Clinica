Option Explicit Off
Imports System.ComponentModel
Imports VB = Microsoft.VisualBasic

Public Class FRM_PRODUCTOS
    Private Sub BTN_NUEVO_Click(sender As Object, e As EventArgs) Handles BTN_NUEVO.Click
        Me.Text = "NUEVO PRODUCTO"
        TXT_ID.Text = ""
        TXT_NOMBRE.Text = ""
        TXT_PRECIO.Text = ""
        NUM_STOCK_REAL.Value = 0
        NUM_STOCK_CRITICO.Value = 0
        TXT_ID.Enabled = True
        BTN_NUEVO.Enabled = False
        BTN_MODIFICAR.Enabled = False
        BTN_ELIMINAR.Enabled = False
        BTN_CANCELAR.Enabled = True
        TXT_ID.Focus()
    End Sub

    Private Sub TXT_ID_TextChanged(sender As Object, e As EventArgs) Handles TXT_ID.TextChanged
        If TXT_ID.Text = "" Then
            BTN_ACEPTAR.Enabled = False
        Else
            BTN_ACEPTAR.Enabled = True
        End If
    End Sub

    Private Sub TXT_ID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_ID.KeyPress
        If Not (e.KeyChar >= "0" And e.KeyChar <= "9") And e.KeyChar <> Chr(8) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub BTN_ACEPTAR_Click(sender As Object, e As EventArgs) Handles BTN_ACEPTAR.Click
        ' AQUÍ SE DEBE HACER LA VALIDACIÓN
        If BTN_ACEPTAR.Text = "&Aceptar" Then
            Existe = False
            For Contador = 0 To LST_PRODUCTOS.Items.Count() - 1
                Item = LST_PRODUCTOS.Items.Item(Contador)
                ID = Trim(Item.ToString.Substring(0, 5))
                If ID = TXT_ID.Text Then
                    Existe = True
                    Exit For
                End If
            Next

            If Existe Then
                MsgBox("Error, Ya existe el producto.")
                TXT_ID.SelectAll()
                TXT_ID.Focus()
                Exit Sub
            End If

            ' Me.AcceptButton = None
            BTN_ACEPTAR.Text = "&Guardar"
            TXT_ID.Enabled = False
            TXT_NOMBRE.Enabled = True
            TXT_PRECIO.Enabled = True
            NUM_STOCK_REAL.Enabled = True
            NUM_STOCK_CRITICO.Enabled = True
            BTN_CANCELAR.Enabled = True
            TXT_NOMBRE.Focus()
        Else
            If TXT_NOMBRE.Text = "" Then
                MsgBox("Error, Debe ingresar el nombre del producto.")
                TXT_NOMBRE.Focus()
                Exit Sub
            End If
            LST_PRODUCTOS.Items.Add(FormatoItem(TXT_ID.Text, TXT_NOMBRE.Text, TXT_PRECIO.Text, NUM_STOCK_REAL.Value, NUM_STOCK_CRITICO.Value))
            BTN_ACEPTAR.Text = "&Aceptar"
            TXT_NOMBRE.Text = ""
            TXT_PRECIO.Text = ""
            NUM_STOCK_REAL.Value = 0
            NUM_STOCK_CRITICO.Value = 0
            TXT_ID.Enabled = False
            TXT_NOMBRE.Enabled = False
            TXT_PRECIO.Enabled = False
            NUM_STOCK_REAL.Enabled = False
            NUM_STOCK_CRITICO.Enabled = False
            BTN_NUEVO.Enabled = True
            BTN_MODIFICAR.Enabled = True
            BTN_ELIMINAR.Enabled = True
            BTN_CANCELAR.Enabled = True
            TXT_ID.SelectAll()
            Me.AcceptButton = BTN_ACEPTAR
            BTN_NUEVO.Focus()
        End If
    End Sub

    Private Sub BTN_CANCELAR_Click(sender As Object, e As EventArgs) Handles BTN_CANCELAR.Click
        Me.Text = "MANTENEDOR DE PRODUCTOS"
        TXT_ID.Enabled = False
        TXT_NOMBRE.Enabled = False
        TXT_PRECIO.Enabled = False
        NUM_STOCK_REAL.Enabled = False
        NUM_STOCK_CRITICO.Enabled = False
        BTN_NUEVO.Enabled = True
        BTN_MODIFICAR.Enabled = True
        BTN_ELIMINAR.Enabled = True
        BTN_ACEPTAR.Enabled = False
        BTN_CANCELAR.Enabled = False
        BTN_ACEPTAR.Text = "&Aceptar"
        BTN_NUEVO.Focus()
    End Sub

    Private Sub BTN_SALIR_Click(sender As Object, e As EventArgs) Handles BTN_SALIR.Click
        Me.Close()
    End Sub

    Private Sub TXT_PRECIO_LostFocus(sender As Object, e As EventArgs) Handles TXT_PRECIO.LostFocus
        TXT_PRECIO.Text = Format(TXT_PRECIO.Text, "Currency")
    End Sub

    Private Sub TXT_PRECIO_GotFocus(sender As Object, e As EventArgs) Handles TXT_PRECIO.GotFocus
        TXT_PRECIO.Text = Format(TXT_PRECIO.Text, "General Number")
    End Sub

    Private Function Centrar(Texto, Numero)
        Espacios = Space(Math.Truncate(Numero - Len(Texto)) / 2)
        Valor = Espacios & Texto & Espacios
        Return Valor
    End Function

    Private Sub FRM_PRODUCTOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' LST_PRODUCTOS.Items.Add("          1         2         3         4         5         6         7         ")
        ' LST_PRODUCTOS.Items.Add("01234567890123456789012345678901234567890123456789012345678901234567890123456789")
        Dim ARCHIVO As New System.IO.StreamReader("PRODUCTOS.TXT")
        Dim REGISTRO As String
        REGISTRO = ARCHIVO.ReadLine()
        While REGISTRO <> ""
            Campos = REGISTRO.ToString.Split(";")
            LST_PRODUCTOS.Items.Add(FormatoItem(Campos(0), Campos(1), Campos(2), Campos(3), Campos(4)))
            REGISTRO = ARCHIVO.ReadLine()
        End While
        ARCHIVO.Close()
    End Sub

    Private Sub FRM_PRODUCTOS_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MsgBox("Closed")
    End Sub

    Private Function FormatoItem(ID, NOMBRE, PRECIO, REAL, CRITICO)
        ID = ID.PadRight(5)
        NOMBRE = NOMBRE.PadRight(40)
        PRECIO = Format(PRECIO, "CURRENCY").PadLeft(10)
        REAL = Centrar(REAL.ToString.PadRight(3), 9)
        CRITICO = Centrar(CRITICO.ToString.PadRight(3), 8)
        Return ID & " " & NOMBRE & " " & PRECIO & " " & REAL & " " & CRITICO
    End Function

    Private Function ExtraerDatos(Item)
        Dim Campos(5)
        Campos(0) = Trim(Item.ToString.Substring(0, 5))
        Campos(1) = Trim(Item.ToString.Substring(6, 40))
        Campos(2) = Trim(Item.ToString.Substring(47, 10))
        Campos(3) = Trim(Item.ToString.Substring(56, 9))
        Campos(4) = Trim(Item.ToString.Substring(64, 8))
        Return Campos
    End Function

    Private Sub LST_PRODUCTOS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LST_PRODUCTOS.SelectedIndexChanged
        Item = LST_PRODUCTOS.SelectedItem
        Campos = ExtraerDatos(Item)

        Dim entero1, entero2 As Integer
        Integer.TryParse(Campos(3), entero1)
        Integer.TryParse(Campos(4), entero2)

        TXT_ID.Text = Campos(0)
        TXT_NOMBRE.Text = Campos(1)
        TXT_PRECIO.Text = Campos(2)
        NUM_STOCK_REAL.Value = entero1
        NUM_STOCK_CRITICO.Value = entero2
    End Sub

    Private Sub BTN_ELIMINAR_Click(sender As Object, e As EventArgs) Handles BTN_ELIMINAR.Click
        LST_PRODUCTOS.Items.RemoveAt(LST_PRODUCTOS.SelectedIndex())
    End Sub

    Private Sub BTN_MODIFICAR_Click(sender As Object, e As EventArgs) Handles BTN_MODIFICAR.Click
        TXT_ID.Enabled = False
        TXT_NOMBRE.Enabled = True
        BTN_NUEVO.Enabled = False
        BTN_MODIFICAR.Enabled = False
        BTN_ELIMINAR.Enabled = False
        BTN_ACEPTAR.Enabled = True
        BTN_CANCELAR.Enabled = True
        BTN_SALIR.Enabled = False

        If TXT_NOMBRE.Text <> "" Then
            LST_PRODUCTOS.Items.Insert(1, TXT_NOMBRE.Text)
        End If
    End Sub

    '' MOUSEHOBER / MOUSELEAVER ''

    Private Sub BTN_NUEVO_MouseHover(sender As Object, e As EventArgs) Handles BTN_NUEVO.MouseHover
        LBL_ESTADO.Text = "Agregar un producto"
    End Sub
    Private Sub BTN_NUEVO_MouseLeave(sender As Object, e As EventArgs) Handles BTN_NUEVO.MouseLeave
        LBL_ESTADO.Text = ""
    End Sub

    Private Sub BTN_ELIMINAR_MouseHover(sender As Object, e As EventArgs) Handles BTN_ELIMINAR.MouseHover
        LBL_ESTADO.Text = "Eliminar un producto"
    End Sub
    Private Sub BTN_ELIMINAR_MouseLeave(sender As Object, e As EventArgs) Handles BTN_ELIMINAR.MouseLeave
        LBL_ESTADO.Text = ""
    End Sub

    Private Sub BTN_MODIFICAR_MouseHover(sender As Object, e As EventArgs) Handles BTN_MODIFICAR.MouseHover
        LBL_ESTADO.Text = "Modificar un producto"
    End Sub
    Private Sub BTN_MODIFICAR_MouseLeave(sender As Object, e As EventArgs) Handles BTN_MODIFICAR.MouseLeave
        LBL_ESTADO.Text = ""
    End Sub

    Private Sub LBL_ID_MouseHover(sender As Object, e As EventArgs) Handles LBL_ID.MouseHover, LBL_NOMBRE.MouseHover,
                                               LBL_PRECIO.MouseHover, LBL_REAL.MouseHover, LBL_CRITICO.MouseHover
        Datos = sender.ToString.Split
        LBL_ESTADO.Text = "Ordenar por " & Datos(2) & " del producto"
    End Sub
    Private Sub LBL_ID_MouseLeave(sender As Object, e As EventArgs) Handles LBL_ID.MouseLeave, LBL_NOMBRE.MouseLeave,
                                                   LBL_PRECIO.MouseLeave, LBL_REAL.MouseLeave, LBL_CRITICO.MouseLeave
        LBL_ESTADO.Text = ""
    End Sub

    Private Sub BTN_SALIR_MouseHover(sender As Object, e As EventArgs) Handles BTN_SALIR.MouseHover
        LBL_ESTADO.Text = "Salir del formulario"
    End Sub
    Private Sub BTN_SALIR_MouseLeave(sender As Object, e As EventArgs) Handles BTN_SALIR.MouseLeave
        LBL_ESTADO.Text = ""
    End Sub

    '' ORDENAR ASCENDENTEMENTE O DESCENDENTEMENTE ''

    Private Sub LBL_ID_Click(sender As Object, e As EventArgs) Handles LBL_ID.Click
        Dim ARCHIVO As New System.IO.StreamReader("PRODUCTOS.TXT")
        Dim REGISTRO As String
        REGISTRO = ARCHIVO.ReadLine()
        While REGISTRO <> ""
            Campos = REGISTRO.ToString.Split(";")

            REGISTRO = ARCHIVO.ReadLine()
        End While
        ARCHIVO.Close()
    End Sub
End Class
