'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by the ClassGenerator.ttinclude code generation file.
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------
Imports System
Imports System.Data
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Data.Common
Imports System.Collections.Generic
Imports Telerik.OpenAccess
Imports Telerik.OpenAccess.Metadata
Imports Telerik.OpenAccess.Data.Common
Imports Telerik.OpenAccess.Metadata.Fluent
Imports Telerik.OpenAccess.Metadata.Fluent.Advanced
Imports scontrolpagos

Public Partial Class Seg_men_menus
	Private _men_codigo As Integer 
	Public Overridable Property Men_codigo As Integer
		Get
	        Return Me._men_codigo
		End Get
		Set(ByVal value As Integer)
	        Me._men_codigo = value
		End Set
	End Property
	
	Private _men_codmen_padre As Integer 
	Public Overridable Property Men_codmen_padre As Integer
		Get
	        Return Me._men_codmen_padre
		End Get
		Set(ByVal value As Integer)
	        Me._men_codmen_padre = value
		End Set
	End Property
	
	Private _men_descripcion As String 
	Public Overridable Property Men_descripcion As String
		Get
	        Return Me._men_descripcion
		End Get
		Set(ByVal value As String)
	        Me._men_descripcion = value
		End Set
	End Property
	
	Private _men_titulo As String 
	Public Overridable Property Men_titulo As String
		Get
	        Return Me._men_titulo
		End Get
		Set(ByVal value As String)
	        Me._men_titulo = value
		End Set
	End Property
	
	Private _men_orden As Integer 
	Public Overridable Property Men_orden As Integer
		Get
	        Return Me._men_orden
		End Get
		Set(ByVal value As Integer)
	        Me._men_orden = value
		End Set
	End Property
	
	Private _seg_men_menus1 As Seg_men_menus 
	Private Property Seg_men_menus1 As Seg_men_menus
		Get
	        Return Me._seg_men_menus1
		End Get
		Set(ByVal value As Seg_men_menus)
	        Me._seg_men_menus1 = value
		End Set
	End Property
	
	Private _seg_oxm_opciones_x_menus As IList(Of Seg_oxm_opciones_x_menu)  = new List(Of Seg_oxm_opciones_x_menu)
	Private ReadOnly Property Seg_oxm_opciones_x_menus As IList(Of Seg_oxm_opciones_x_menu)
		Get
	        Return Me._seg_oxm_opciones_x_menus
		End Get
	End Property
	
	Private _seg_men_menus11 As IList(Of Seg_men_menus)  = new List(Of Seg_men_menus)
	Private ReadOnly Property Seg_men_menus11 As IList(Of Seg_men_menus)
		Get
	        Return Me._seg_men_menus11
		End Get
	End Property
	
End Class
