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

Public Partial Class Seg_opc_opciones
	Private _opc_codigo As Integer 
	Public Overridable Property Opc_codigo As Integer
		Get
	        Return Me._opc_codigo
		End Get
		Set(ByVal value As Integer)
	        Me._opc_codigo = value
		End Set
	End Property
	
	Private _opc_descripcion As String 
	Public Overridable Property Opc_descripcion As String
		Get
	        Return Me._opc_descripcion
		End Get
		Set(ByVal value As String)
	        Me._opc_descripcion = value
		End Set
	End Property
	
	Private _opc_titulo As String 
	Public Overridable Property Opc_titulo As String
		Get
	        Return Me._opc_titulo
		End Get
		Set(ByVal value As String)
	        Me._opc_titulo = value
		End Set
	End Property
	
	Private _opc_formulario As String 
	Public Overridable Property Opc_formulario As String
		Get
	        Return Me._opc_formulario
		End Get
		Set(ByVal value As String)
	        Me._opc_formulario = value
		End Set
	End Property
	
	Private _seg_oxm_opciones_x_menus As IList(Of Seg_oxm_opciones_x_menu)  = new List(Of Seg_oxm_opciones_x_menu)
	Private ReadOnly Property Seg_oxm_opciones_x_menus As IList(Of Seg_oxm_opciones_x_menu)
		Get
	        Return Me._seg_oxm_opciones_x_menus
		End Get
	End Property
	
	Private _seg_axo_acciones_x_opcions As IList(Of Seg_axo_acciones_x_opcion)  = new List(Of Seg_axo_acciones_x_opcion)
	Private ReadOnly Property Seg_axo_acciones_x_opcions As IList(Of Seg_axo_acciones_x_opcion)
		Get
	        Return Me._seg_axo_acciones_x_opcions
		End Get
	End Property
	
End Class