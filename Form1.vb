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

            Me.AcceptButton = None
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
            TXT_ID.Enabled = True
            TXT_NOMBRE.Enabled = False
            TXT_PRECIO.Enabled = False
            NUM_STOCK_REAL.Enabled = False
            NUM_STOCK_CRITICO.Enabled = False
            TXT_ID.SelectAll()
            Me.AcceptButton = BTN_ACEPTAR
            TXT_ID.Focus()

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

        Dim ARCHIVO As New System.IO.StreamWriter("PRODUCTOS.TXT")
        Dim REGISTRO As String
        For Punt = 0 To LST_PRODUCTOS.Items.Count - 1
            Campos1 = ExtraerDatos(LST_PRODUCTOS.Items.Item(Punt))
            ARCHIVO.WriteLine( Campos1(0) & ";" & Campos1(1) & ";" & Int(Campos1(2)) & ";" & Campos1(3) & ";" & Campos1(4))
        Next
        ARCHIVO.Close()
        Me.Close()
    End Sub

    Private Sub TXT_PRECIO_TextChanged(sender As Object, e As EventArgs) Handles TXT_PRECIO.TextChanged

    End Sub

    Private Sub TXT_PRECIO_LostFocus(sender As Object, e As EventArgs) Handles TXT_PRECIO.LostFocus
        TXT_PRECIO.Text = Format(TXT_PRECIO.Text, "Currency")
    End Sub

    Private Sub TXT_PRECIO_GotFocus(sender As Object, e As EventArgs) Handles TXT_PRECIO.GotFocus
        TXT_PRECIO.Text = Format(TXT_PRECIO.Text, "General Number")
    End Sub

    Private Sub TXT_NOMBRE_TextChanged(sender As Object, e As EventArgs) Handles TXT_NOMBRE.TextChanged

    End Sub

    Private Sub BTN_MODIFICAR_Click(sender As Object, e As EventArgs) Handles BTN_MODIFICAR.Click
        If TXT_ID.Text = "" Then
            MsgBox("Error, debe seleccionar un producto en el listado.")
            LST_PRODUCTOS.Focus()
            Exit Sub
        End If
        Me.Text = "MODIFICAR PRODUCTO"
        TXT_NOMBRE.Enabled = True
        TXT_PRECIO.Enabled = True
        NUM_STOCK_REAL.Enabled = True
        NUM_STOCK_CRITICO.Enabled = True
        BTN_ACEPTAR.Enabled = True
        BTN_CANCELAR.Enabled = True
        BTN_NUEVO.Enabled = False
        BTN_MODIFICAR.Enabled = False
        BTN_ELIMINAR.Enabled = False
        BTN_ACEPTAR.Text = "&Guardar"
        TXT_NOMBRE.SelectAll()
        TXT_NOMBRE.Focus()

        lista = LST_PRODUCTOS.SelectedIndex
        LST1_PRODUCTOS.Items.Clear()

        For Punt = 0 To LST_PRODUCTOS.Items.Count - 1
            aux = LST_PRODUCTOS.Items.Item(Punt)
            If LST_PRODUCTOS.Items.Item(Punt) = LST_PRODUCTOS.Items.Item(lista) Then
            Else LST1_PRODUCTOS.Items.Add(aux)
            End If

        Next
        LST_PRODUCTOS.Items.Clear()

        For Punt = 0 To LST1_PRODUCTOS.Items.Count - 1
            aux = LST1_PRODUCTOS.Items.Item(Punt)
            LST_PRODUCTOS.Items.Add(aux)
        Next
        If lista > 0 Then
            Campos1 = ExtraerDatos(LST_PRODUCTOS.Items.Item(lista))
            MsgBox(Campos1(0))

        End If

    End Sub
    Private Function Centrar(Texto, Numero)
        Espacios = Space(Math.Truncate(Numero - Len(Texto)) / 2)
        Valor = Espacios & Texto & Espacios
        Return Valor
    End Function

    Private Sub FRM_PRODUCTOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' LST_PRODUCTOS.Items.Add("          1         2         3         4         5         6         7     ")
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
    End Sub

    Private Sub LBL_ID_MouseHover(sender As Object, e As EventArgs) Handles LBL_ID.MouseHover, LBL_NOMBRE.MouseHover,
                                                   LBL_PRECIO.MouseHover
        Datos = sender.ToString.Split
        LBL_ESTADO.Text = "Ordenar por " & Datos(2) & " del producto"
    End Sub

    Private Sub LBL_ID_MouseLeave(sender As Object, e As EventArgs) Handles LBL_ID.MouseLeave, LBL_NOMBRE.MouseLeave,
                                                   LBL_PRECIO.MouseLeave, LBL_REAL.MouseLeave, LBL_CRITICO.MouseLeave
        LBL_ESTADO.Text = ""
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
        Campos(3) = Trim(Item.ToString.Substring(58, 9))
        Campos(4) = Trim(Item.ToString.Substring(66, 9))
        Return Campos
    End Function

    Private Sub LST_PRODUCTOS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LST_PRODUCTOS.SelectedIndexChanged
        Item = LST_PRODUCTOS.SelectedItem
        Campos = ExtraerDatos(Item)
        TXT_ID.Text = Campos(0)
        TXT_NOMBRE.Text = Campos(1)
        TXT_PRECIO.Text = Campos(2)
        NUM_STOCK_REAL.Value = Campos(3)
        NUM_STOCK_CRITICO.Value = Campos(4)
    End Sub

    Private Sub LBL_REAL_MouseHover(sender As Object, e As EventArgs) Handles LBL_REAL.MouseHover, LBL_CRITICO.MouseHover
        Datos = sender.ToString.Split
        LBL_ESTADO.Text = "Ordenar por stock " & Datos(2) & " del producto"

    End Sub

    Private Sub BTN_NUEVO_MouseLeave(sender As Object, e As EventArgs) Handles BTN_NUEVO.MouseLeave, BTN_MODIFICAR.MouseLeave, BTN_ELIMINAR.MouseLeave, BTN_SALIR.MouseLeave
        LBL_ESTADO.Text = ""
    End Sub

    Private Sub BTN_NUEVO_MouseHover(sender As Object, e As EventArgs) Handles BTN_NUEVO.MouseHover
        LBL_ESTADO.Text = "Agregar producto"

    End Sub

    Private Sub BTN_MODIFICAR_MouseHover(sender As Object, e As EventArgs) Handles BTN_MODIFICAR.MouseHover
        LBL_ESTADO.Text = "Modificar producto"

    End Sub

    Private Sub BTN_ELIMINAR_MouseHover(sender As Object, e As EventArgs) Handles BTN_ELIMINAR.MouseHover
        LBL_ESTADO.Text = "Eliminar producto"
    End Sub

    Private Sub BTN_SALIR_MouseHover(sender As Object, e As EventArgs) Handles BTN_SALIR.MouseHover
        LBL_ESTADO.Text = "Cerrar el programa"
    End Sub

    Private Sub ORDENAR(sender As Object, e As EventArgs) Handles LBL_ID.Click,
    LBL_NOMBRE.Click, LBL_REAL.Click, LBL_CRITICO.Click
        Manejador = sender.ToString.Split()
        If Manejador(2) = "ID" Then
            Columna = 0
        End If
        If Manejador(2) = "NOMBRE" Then
            Columna = 1
        End If

        If Manejador(2) = "REAL" Then
            Columna = 3
        End If
        If Manejador(2) = "CRITICO" Then
            Columna = 4
        End If
        For Punt1 = 0 To LST_PRODUCTOS.Items.Count - 2
            For Punt2 = Punt1 + 1 To LST_PRODUCTOS.Items.Count - 1
                Campos1 = ExtraerDatos(LST_PRODUCTOS.Items.Item(Punt1))
                Campos2 = ExtraerDatos(LST_PRODUCTOS.Items.Item(Punt2))
                If Campos2(Columna) < Campos1(Columna) Then
                    Aux = LST_PRODUCTOS.Items.Item(Punt1)
                    LST_PRODUCTOS.Items.Item(Punt1) = LST_PRODUCTOS.Items.Item(Punt2)
                    LST_PRODUCTOS.Items.Item(Punt2) = Aux
                End If
            Next
        Next

    End Sub

    Private Sub BTN_ELIMINAR_Click(sender As Object, e As EventArgs) Handles BTN_ELIMINAR.Click
        Me.Text = "Eliminar producto"
        lista = LST_PRODUCTOS.SelectedIndex
        If lista >= 0 Then

            A = MsgBox("Esta seguro de eliminar?")
            If A = 1 Then
                LST1_PRODUCTOS.Items.Clear()

                For Punt = 0 To LST_PRODUCTOS.Items.Count - 1
                    aux = LST_PRODUCTOS.Items.Item(Punt)
                    If LST_PRODUCTOS.Items.Item(Punt) = LST_PRODUCTOS.Items.Item(lista) Then
                    Else LST1_PRODUCTOS.Items.Add(aux)
                    End If

                Next
                LST_PRODUCTOS.Items.Clear()

                For Punt = 0 To LST1_PRODUCTOS.Items.Count - 1
                    aux = LST1_PRODUCTOS.Items.Item(Punt)
                    LST_PRODUCTOS.Items.Add(aux)
                Next





            End If





        End If
    End Sub



    Private Sub LBL_PRECIO_Click(sender As Object, e As EventArgs) Handles LBL_PRECIO.Click
        Manejador = sender.ToString.Split()
        If Manejador(2) = "PRECIO" Then
            Columna = 2
        End If
        For Punt1 = 0 To LST_PRODUCTOS.Items.Count - 2
            For Punt2 = Punt1 + 1 To LST_PRODUCTOS.Items.Count - 1
                Campos1 = ExtraerDatos(LST_PRODUCTOS.Items.Item(Punt1))
                Campos2 = ExtraerDatos(LST_PRODUCTOS.Items.Item(Punt2))

                If Int(Campos2(Columna)) < Int(Campos1(Columna)) Then
                    Aux = LST_PRODUCTOS.Items.Item(Punt1)
                    LST_PRODUCTOS.Items.Item(Punt1) = LST_PRODUCTOS.Items.Item(Punt2)
                    LST_PRODUCTOS.Items.Item(Punt2) = Aux
                End If
            Next
        Next
    End Sub

    Private Sub TXT_ID1_TextChanged(sender As Object, e As EventArgs) Handles TXT_ID1.TextChanged

        TXT_NOMBRE1.Text = ""
        TXT_PRECIO1.Text = ""
        TXT_REAL.Text = ""
        TXT_CRITICO.Text = ""
        If Not Filtro_a.Checked And Not Filtro_b.Checked Then
            For Punt = 0 To LST_PRODUCTOS.Items.Count - 1
                Campos = ExtraerDatos(LST_PRODUCTOS.Items.Item(Punt))
                If Campos(0).ToString.Substring(0, Len(TXT_ID1.Text)) = TXT_ID1.Text Then
                    LST_PRODUCTOS.SelectedIndex = Punt
                    Exit Sub
                End If
            Next
        Else
            LST_PRODUCTOS.Items.Clear()
            For Punt = 0 To Lst_aux.Items.Count - 1
                Campos = ExtraerDatos(Lst_aux.Items.Item(Punt))
                If Campos(0).ToString.Substring(0, Len(TXT_ID1.Text)) = TXT_ID1.Text Then
                    LST_PRODUCTOS.Items.Add(Lst_aux.Items.Item(Punt))
                End If
            Next
        End If
        If Not Filtro_b.Checked Then
            For Punt = 0 To LST_PRODUCTOS.Items.Count - 1
                Campos = ExtraerDatos(LST_PRODUCTOS.Items.Item(Punt))
                If Campos(0).ToString.Substring(0, Len(TXT_ID1.Text)) = TXT_ID1.Text Then
                    LST_PRODUCTOS.SelectedIndex = Punt
                    Exit Sub
                End If
            Next
        Else
            LST_PRODUCTOS.Items.Clear()
            For Punt = 0 To Lst_aux.Items.Count - 1
                Campos = ExtraerDatos(Lst_aux.Items.Item(Punt))
                a = Campos(0).ToString
                b = TXT_ID1.Text.ToString
                c = InStr(a, b)

                If c > 0 Then
                    LST_PRODUCTOS.Items.Add(Lst_aux.Items.Item(Punt))
                End If
            Next

        End If

    End Sub

    Private Sub TXT_NOMBRE1_TextChanged(sender As Object, e As EventArgs) Handles TXT_NOMBRE1.TextChanged
        TXT_ID1.Text = ""
        TXT_PRECIO1.Text = ""
        TXT_REAL.Text = ""
        TXT_CRITICO.Text = ""
        If Not Filtro_a.Checked And Not Filtro_b.Checked Then
            For Punt = 0 To LST_PRODUCTOS.Items.Count - 1
                Campos = ExtraerDatos(LST_PRODUCTOS.Items.Item(Punt))
                If Campos(1).ToString.Substring(0, Len(TXT_NOMBRE1.Text)) = TXT_NOMBRE1.Text Then
                    LST_PRODUCTOS.SelectedIndex = Punt

                    Exit Sub
                End If
            Next
        Else
            LST_PRODUCTOS.Items.Clear()
            For Punt = 0 To Lst_aux.Items.Count - 1
                Campos = ExtraerDatos(Lst_aux.Items.Item(Punt))
                If Campos(1).ToString.Substring(0, Len(TXT_NOMBRE1.Text)) = TXT_NOMBRE1.Text Then
                    LST_PRODUCTOS.Items.Add(Lst_aux.Items.Item(Punt))

                End If

            Next
        End If
        If Not Filtro_b.Checked Then
            For Punt = 0 To LST_PRODUCTOS.Items.Count - 1
                Campos = ExtraerDatos(LST_PRODUCTOS.Items.Item(Punt))
                If Campos(1).ToString.Substring(0, Len(TXT_NOMBRE1.Text)) = TXT_NOMBRE1.Text Then
                    LST_PRODUCTOS.SelectedIndex = Punt
                    Exit Sub
                End If
            Next
        Else
            LST_PRODUCTOS.Items.Clear()
            For Punt = 0 To Lst_aux.Items.Count - 1
                Campos = ExtraerDatos(Lst_aux.Items.Item(Punt))
                a = Campos(1).ToString
                b = TXT_NOMBRE1.Text.ToString
                c = InStr(a, b)

                If c > 0 Then
                    LST_PRODUCTOS.Items.Add(Lst_aux.Items.Item(Punt))
                End If
            Next

        End If

    End Sub

    Private Sub TXT_PRECIO1_TextChanged(sender As Object, e As EventArgs) Handles TXT_PRECIO1.TextChanged
        TXT_ID1.Text = ""
        TXT_NOMBRE1.Text = ""

        TXT_REAL.Text = ""
        TXT_CRITICO.Text = ""
        If Not Filtro_a.Checked And Not Filtro_b.Checked Then
            For Punt = 0 To LST_PRODUCTOS.Items.Count - 1
                Campos = ExtraerDatos(LST_PRODUCTOS.Items.Item(Punt))
                If Campos(2).ToString.Substring(0, Len(TXT_PRECIO1.Text)) = TXT_PRECIO1.Text Then
                    LST_PRODUCTOS.SelectedIndex = Punt
                    Exit Sub
                End If
            Next
        Else
            LST_PRODUCTOS.Items.Clear()
            For Punt = 0 To Lst_aux.Items.Count - 1
                Campos = ExtraerDatos(Lst_aux.Items.Item(Punt))
                If Campos(2).ToString.Substring(0, Len(TXT_PRECIO1.Text)) = TXT_PRECIO1.Text Then
                    LST_PRODUCTOS.Items.Add(Lst_aux.Items.Item(Punt))
                End If
            Next
        End If
        If Not Filtro_b.Checked Then
            For Punt = 0 To LST_PRODUCTOS.Items.Count - 1
                Campos = ExtraerDatos(LST_PRODUCTOS.Items.Item(Punt))
                If Campos(2).ToString.Substring(0, Len(TXT_PRECIO1.Text)) = TXT_PRECIO1.Text Then
                    LST_PRODUCTOS.SelectedIndex = Punt
                    Exit Sub
                End If
            Next
        Else
            LST_PRODUCTOS.Items.Clear()
            For Punt = 0 To Lst_aux.Items.Count - 1
                Campos = ExtraerDatos(Lst_aux.Items.Item(Punt))
                a = Campos(2).ToString
                b = TXT_PRECIO1.Text.ToString
                c = InStr(a, b)

                If c > 0 Then
                    LST_PRODUCTOS.Items.Add(Lst_aux.Items.Item(Punt))
                End If
            Next

        End If
    End Sub

    Private Sub TXT_REAL_TextChanged(sender As Object, e As EventArgs) Handles TXT_REAL.TextChanged
        TXT_ID1.Text = ""
        TXT_NOMBRE1.Text = ""
        TXT_PRECIO1.Text = ""

        TXT_CRITICO.Text = ""
        If Not Filtro_a.Checked And Not Filtro_b.Checked Then
            For Punt = 0 To LST_PRODUCTOS.Items.Count - 1
                Campos = ExtraerDatos(LST_PRODUCTOS.Items.Item(Punt))
                If Campos(3).ToString.Substring(0, Len(TXT_REAL.Text)) = TXT_REAL.Text Then
                    LST_PRODUCTOS.SelectedIndex = Punt
                    Exit Sub
                End If
            Next
        Else
            LST_PRODUCTOS.Items.Clear()
            For Punt = 0 To Lst_aux.Items.Count - 1
                Campos = ExtraerDatos(Lst_aux.Items.Item(Punt))
                If Campos(3).ToString.Substring(0, Len(TXT_REAL.Text)) = TXT_REAL.Text Then
                    LST_PRODUCTOS.Items.Add(Lst_aux.Items.Item(Punt))
                End If
            Next
        End If
        If Not Filtro_b.Checked Then
            For Punt = 0 To LST_PRODUCTOS.Items.Count - 1
                Campos = ExtraerDatos(LST_PRODUCTOS.Items.Item(Punt))
                If Campos(3).ToString.Substring(0, Len(TXT_REAL.Text)) = TXT_REAL.Text Then
                    LST_PRODUCTOS.SelectedIndex = Punt
                    Exit Sub
                End If
            Next
        Else
            LST_PRODUCTOS.Items.Clear()
            For Punt = 0 To Lst_aux.Items.Count - 1
                Campos = ExtraerDatos(Lst_aux.Items.Item(Punt))
                a = Campos(3).ToString
                b = TXT_REAL.Text.ToString
                c = InStr(a, b)

                If c > 0 Then
                    LST_PRODUCTOS.Items.Add(Lst_aux.Items.Item(Punt))
                End If
            Next

        End If
    End Sub

    Private Sub TXT_CRITICO_TextChanged(sender As Object, e As EventArgs) Handles TXT_CRITICO.TextChanged
        TXT_ID1.Text = ""
        TXT_NOMBRE1.Text = ""
        TXT_PRECIO1.Text = ""
        TXT_REAL.Text = ""

        If Not Filtro_a.Checked And Not Filtro_b.Checked Then
            For Punt = 0 To LST_PRODUCTOS.Items.Count - 1
                Campos = ExtraerDatos(LST_PRODUCTOS.Items.Item(Punt))
                If Campos(4).ToString.Substring(0, Len(TXT_CRITICO.Text)) = TXT_CRITICO.Text.ToString Then
                    LST_PRODUCTOS.SelectedIndex = Punt
                    Exit Sub
                End If
            Next
        Else
            LST_PRODUCTOS.Items.Clear()
            For Punt = 0 To Lst_aux.Items.Count - 1
                Campos = ExtraerDatos(Lst_aux.Items.Item(Punt))
                If Campos(4).ToString.Substring(0, Len(TXT_CRITICO.Text)) = TXT_CRITICO.Text.ToString Then
                    LST_PRODUCTOS.Items.Add(Lst_aux.Items.Item(Punt))
                End If
            Next
        End If
        If Not Filtro_b.Checked Then
            For Punt = 0 To LST_PRODUCTOS.Items.Count - 1
                Campos = ExtraerDatos(LST_PRODUCTOS.Items.Item(Punt))
                If Campos(4).ToString.Substring(0, Len(TXT_CRITICO.Text)) = TXT_CRITICO.Text.ToString Then
                    LST_PRODUCTOS.SelectedIndex = Punt
                    Exit Sub
                End If
            Next
        Else
            LST_PRODUCTOS.Items.Clear()
            For Punt = 0 To Lst_aux.Items.Count - 1
                Campos = ExtraerDatos(Lst_aux.Items.Item(Punt))
                a = Campos(4).ToString
                b = TXT_CRITICO.Text.ToString
                c = InStr(a, b)

                If c > 0 Then
                    LST_PRODUCTOS.Items.Add(Lst_aux.Items.Item(Punt))
                End If
            Next

        End If
    End Sub

    Private Sub TXT_NOMBRE1_MouseHover(sender As Object, e As EventArgs) Handles TXT_NOMBRE1.MouseHover
        LBL_ESTADO.Text = "Ingrese nombre a buscar, debe respetar mayusculas"
    End Sub

    Private Sub TXT_NOMBRE1_MouseLeave(sender As Object, e As EventArgs) Handles TXT_NOMBRE1.MouseLeave
        LBL_ESTADO.Text = ""
    End Sub

    Private Sub Filtro_CheckedChanged(sender As Object, e As EventArgs) Handles Filtro_a.CheckedChanged
        If Filtro_a.Checked Then
            Lst_aux.Items.Clear()
            For Punt = 0 To LST_PRODUCTOS.Items.Count - 1
                Lst_aux.Items.Add(LST_PRODUCTOS.Items.Item(Punt))
            Next

        Else
            LST_PRODUCTOS.Items.Clear()
            For Punt = 0 To Lst_aux.Items.Count - 1
                LST_PRODUCTOS.Items.Add(Lst_aux.Items.Item(Punt))
            Next
        End If
    End Sub

    Private Sub ListBox_aux_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Lst_aux.SelectedIndexChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles Filtro_b.CheckedChanged


        If Filtro_b.Checked Then
            Lst_aux.Items.Clear()
            For Punt = 0 To LST_PRODUCTOS.Items.Count - 1
                Lst_aux.Items.Add(LST_PRODUCTOS.Items.Item(Punt))
            Next
        Else
            LST_PRODUCTOS.Items.Clear()
            For Punt = 0 To Lst_aux.Items.Count - 1
                LST_PRODUCTOS.Items.Add(Lst_aux.Items.Item(Punt))
            Next
        End If


    End Sub



    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        LBL_ESTADO.Text = "Doble click para modificar imagen"

    End Sub

    Private Sub PictureBox1_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox1.DoubleClick
        If OpenFileDialog1.ShowDialog() = 1 Then
            TXT_FOTO.Text = OpenFileDialog1.FileName
            PictureBox1.Image = Image.FromFile(TXT_FOTO.Text)

        End If
        'TXT_FOTO2.Text = System.IO.Directory.GetCurrentDirectory() & "\" & TXT_ID.Text & ".PNG"
        '   ' If TXT_FOTO2.Text <> TXT_FOTO.Text Then
        '   If System.IO.File.Exists(TXT_FOTO2.Text) Then
        ' System.IO.File.Delete(TXT_FOTO2.Text)
        '  End If
        '    System.IO.File.Copy(TXT_FOTO.Text, TXT_FOTO2.Text)
        '   End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub TXT_ID1_MouseHover(sender As Object, e As EventArgs) Handles TXT_ID1.MouseHover
        LBL_ESTADO.Text = "Ingrese id a buscar"

    End Sub

    Private Sub TXT_ID1_MouseLeave(sender As Object, e As EventArgs) Handles TXT_ID1.MouseLeave
        LBL_ESTADO.Text = ""

    End Sub


    Private Sub TXT_PRECIO1_MouseLeave(sender As Object, e As EventArgs) Handles TXT_PRECIO1.MouseLeave
        LBL_ESTADO.Text = ""

    End Sub

    Private Sub TXT_PRECIO1_MouseHover(sender As Object, e As EventArgs) Handles TXT_PRECIO1.MouseHover
        LBL_ESTADO.Text = " Ingrese precio a buscar, debe respetar '$' y puntos "

    End Sub

    Private Sub TXT_REAL_MouseLeave(sender As Object, e As EventArgs) Handles TXT_REAL.MouseLeave
        LBL_ESTADO.Text = ""

    End Sub

    Private Sub TXT_REAL_MouseHover(sender As Object, e As EventArgs) Handles TXT_REAL.MouseHover
        LBL_ESTADO.Text = "Ingrese stock real a buscar"

    End Sub

    Private Sub TXT_CRITICO_MouseLeave(sender As Object, e As EventArgs) Handles TXT_CRITICO.MouseLeave
        LBL_ESTADO.Text = ""

    End Sub

    Private Sub TXT_CRITICO_MouseHover(sender As Object, e As EventArgs) Handles TXT_CRITICO.MouseHover
        LBL_ESTADO.Text = "Ingrese stock critico a buscar"

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TXT_FOTO.TextChanged

    End Sub

    Private Function aux1(sender As Object, e As MouseEventArgs) Handles BTN_CANCELAR.MouseClick
        a = True
        Return a
    End Function
End Class

