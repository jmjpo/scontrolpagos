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

Public Partial Class Seg_aro_autorizaciones_role
	Private _aro_codrol As Integer 
	Public Overridable Property Aro_codrol As Integer
		Get
	        Return Me._aro_codrol
		End Get
		Set(ByVal value As Integer)
	        Me._aro_codrol = value
		End Set
	End Property
	
	Private _aro_codopc As Integer 
	Public Overridable Property Aro_codopc As Integer
		Get
	        Return Me._aro_codopc
		End Get
		Set(ByVal value As Integer)
	        Me._aro_codopc = value
		End Set
	End Property
	
	Private _aro_codaxo As Integer 
	Public Overridable Property Aro_codaxo As Integer
		Get
	        Return Me._aro_codaxo
		End Get
		Set(ByVal value As Integer)
	        Me._aro_codaxo = value
		End Set
	End Property
	
	Private _seg_rol_roles As Seg_rol_roles 
	Private Property Seg_rol_roles As Seg_rol_roles
		Get
	        Return Me._seg_rol_roles
		End Get
		Set(ByVal value As Seg_rol_roles)
	        Me._seg_rol_roles = value
		End Set
	End Property
	
	Private _seg_axo_acciones_x_opcion As Seg_axo_acciones_x_opcion 
	Private Property Seg_axo_acciones_x_opcion As Seg_axo_acciones_x_opcion
		Get
	        Return Me._seg_axo_acciones_x_opcion
		End Get
		Set(ByVal value As Seg_axo_acciones_x_opcion)
	        Me._seg_axo_acciones_x_opcion = value
		End Set
	End Property
	
End Class
