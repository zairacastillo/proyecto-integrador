﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure

Partial Public Class PROYECTO2Entities
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=PROYECTO2Entities")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub

    Public Overridable Property categoria() As DbSet(Of categoria)
    Public Overridable Property cliente() As DbSet(Of cliente)
    Public Overridable Property detalle_venta() As DbSet(Of detalle_venta)
    Public Overridable Property empleado() As DbSet(Of empleado)
    Public Overridable Property perfil() As DbSet(Of perfil)
    Public Overridable Property producto() As DbSet(Of producto)
    Public Overridable Property venta() As DbSet(Of venta)

End Class
