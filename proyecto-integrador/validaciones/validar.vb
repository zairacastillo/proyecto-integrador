Imports System.Text.RegularExpressions
Imports System.IO

Module Validaciones

    Public Function Validar_precio(ByVal e As KeyPressEventArgs) As Boolean
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
            Return False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
            Return False
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = False
            Return False
        Else
            e.Handled = True
            Return True
        End If
    End Function

    Public Function Validar_numeros(ByVal e As KeyPressEventArgs) As Boolean
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
            Return False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
            Return False
        Else
            e.Handled = True
            Return True
        End If
    End Function


    Public Function Validar_letras(ByVal e As KeyPressEventArgs) As Boolean
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
            Return False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
            Return False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
            Return False
        Else
            e.Handled = True
            Return True
        End If
    End Function



    Public Function TBVacios(ByVal listTB) As Boolean
        '^\S+$
        For Each tb In listTB
            If IsNull_textbox(tb) Then
                Return True
            End If
        Next
        Return False
    End Function



    ' Valida un textbox, retorna True si un textbox es nulo
    '
    Public Function IsNull_textbox(ByVal p_textbox As TextBox) As Boolean
        If p_textbox.Text = "" Then
            Return True ' Textbox nulo
        End If
        Return False ' Textbox no nulo
    End Function

    ' Valida un combobox, retorna True si un combobox esta vacio
    '

    Public Function Vacio_Combo(combo As ComboBox) As Boolean
        If combo.SelectedIndex = -1 Then
            Return True ' Combobox vacio
        End If
        Return False ' Combobox no vacio

    End Function



    Public Function validar_email(ByRef txt As TextBox) As Boolean
        If txt.Text <> "" Then
            Dim texto As New Regex("^[0-9a-zA-Z-_@.]*$", RegexOptions.IgnoreCase)
            Dim arobase As New Regex("[@]", RegexOptions.IgnoreCase)
            Dim punto As New Regex("[.]", RegexOptions.IgnoreCase)
            If (Not arobase.IsMatch(txt.Text)) Or (Not punto.IsMatch(txt.Text)) Or (Not texto.IsMatch(txt.Text)) Then
                MessageBox.Show("Correo invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
            Return True
        Else
            Return False
        End If

    End Function


End Module

