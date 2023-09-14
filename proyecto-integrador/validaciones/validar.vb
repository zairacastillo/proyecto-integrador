Imports System.Text.RegularExpressions
Imports System.IO

Module Validaciones

    Public Function Validar_digitos(ByVal e As TextBox, ByVal n As Integer) As Boolean
        Dim a As String = CStr(e.Text)
        If a.Length <= n Then
            Return True
        Else
            Return False
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

    ' Valida si un textbox contiene un email
    '

    'Public Function IsEmail(ByVal p_textbox As TextBox) As Boolean
    '    Dim t As String = CStr(p_textbox.Text)
    '    If t = String.Empty Then
    '        Return False ' Campo vacio
    '    Else
    '        ' Compruebo si el formato de la dirección es correcto
    '        Dim re As Regex = New Regex("^[\w._%-]+@[\w.-]+\.[a-zA-Z]{2,4}$")
    '        Dim m As Match = re.Match(t)
    '        If m.Captures.Count <> 0 Then
    '            Return True 'Si es un email valido

    '        Else
    '            Return False 'No es un email valido

    '        End If
    '    End If
    'End Function




    Public Function IsEmail(ByRef txt As TextBox) As Boolean
        If txt.Text <> "" Then
            Dim texto As New Regex("^[0-9a-zA-Z-_@.]*$", RegexOptions.IgnoreCase)
            Dim arobase As New Regex("[@]", RegexOptions.IgnoreCase)
            Dim punto As New Regex("[.]", RegexOptions.IgnoreCase)
            If (Not arobase.IsMatch(txt.Text)) Or (Not punto.IsMatch(txt.Text)) Or (Not texto.IsMatch(txt.Text)) Then
                Return False
            End If
            Return True
        Else
            Return False
        End If

    End Function


    Public Function TBVacios(ByVal listTB) As Boolean
        '^\S+$
        For Each tb In listTB
            If Not Regex.IsMatch(tb.Text.Trim, "^\S+$") Then
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

    'Valida un datetimepicker, retorna True si se selecciono un año que es mayor a 2000

    Public Function Validar_fechaCum(DateT As DateTimePicker) As Boolean
        Dim vMes As Integer = DateT.Value.Year


        If vMes > 2000 Then
            Return True ' Es mayor
        Else
            Return False ' No es mayor
        End If
    End Function


    Public Sub Validar_RadioN(ByVal gr As GroupBox, ByVal nom As String)
        For Each b As RadioButton In gr.Controls.OfType(Of RadioButton)()
            If b.Text = nom Then
                b.Checked = True
            End If
        Next

    End Sub

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

