'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class cliente
    Public Property Id_cliente As Integer
    Public Property nombre_cliente As String
    Public Property apellido_cliente As String
    Public Property dni_cliente As Integer
    Public Property correo_cliente As String
    Public Property telefono_cliente As Integer
    Public Property direccion_cliente As String
    Public Property fecha_cliente As Date

    Public Overridable Property venta As ICollection(Of venta) = New HashSet(Of venta)

End Class
