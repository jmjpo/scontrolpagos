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

Public Partial Class Soc_tds_tipos_de_socios
	Private _tds_codigo As Integer 
	Public Overridable Property Tds_codigo As Integer
		Get
	        Return Me._tds_codigo
		End Get
		Set(ByVal value As Integer)
	        Me._tds_codigo = value
		End Set
	End Property
	
	Private _tds_inicial As String 
	Public Overridable Property Tds_inicial As String
		Get
	        Return Me._tds_inicial
		End Get
		Set(ByVal value As String)
	        Me._tds_inicial = value
		End Set
	End Property
	
	Private _tds_nombre As String 
	Public Overridable Property Tds_nombre As String
		Get
	        Return Me._tds_nombre
		End Get
		Set(ByVal value As String)
	        Me._tds_nombre = value
		End Set
	End Property
	
	Private _tds_usuario_modificacion As String 
	Public Overridable Property Tds_usuario_modificacion As String
		Get
	        Return Me._tds_usuario_modificacion
		End Get
		Set(ByVal value As String)
	        Me._tds_usuario_modificacion = value
		End Set
	End Property
	
	Private _tds_usuario_grabacion As String 
	Public Overridable Property Tds_usuario_grabacion As String
		Get
	        Return Me._tds_usuario_grabacion
		End Get
		Set(ByVal value As String)
	        Me._tds_usuario_grabacion = value
		End Set
	End Property
	
	Private _tds_fecha_modificacion As Date? 
	Public Overridable Property Tds_fecha_modificacion As Date?
		Get
	        Return Me._tds_fecha_modificacion
		End Get
		Set(ByVal value As Date?)
	        Me._tds_fecha_modificacion = value
		End Set
	End Property
	
	Private _tds_fecha_grabacion As Date? 
	Public Overridable Property Tds_fecha_grabacion As Date?
		Get
	        Return Me._tds_fecha_grabacion
		End Get
		Set(ByVal value As Date?)
	        Me._tds_fecha_grabacion = value
		End Set
	End Property
	
	Private _tds_monto_pago As Decimal? 
	Public Overridable Property Tds_monto_pago As Decimal?
		Get
	        Return Me._tds_monto_pago
		End Get
		Set(ByVal value As Decimal?)
	        Me._tds_monto_pago = value
		End Set
	End Property
	
	Private _soc_soc_socios As IList(Of Soc_soc_socios)  = new List(Of Soc_soc_socios)
	Private ReadOnly Property Soc_soc_socios As IList(Of Soc_soc_socios)
		Get
	        Return Me._soc_soc_socios
		End Get
	End Property
	
End Class
