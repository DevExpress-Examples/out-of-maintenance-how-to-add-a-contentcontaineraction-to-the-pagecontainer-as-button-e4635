Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace WindowsFormsApplication35
	Public Class Person
		' Fields...
		Private _ID As Integer
		Private _LastName As String
		Private _FirstName As String

		Public Property FirstName() As String
			Get
				Return _FirstName
			End Get
			Set(ByVal value As String)
				_FirstName = value
			End Set
		End Property

		Public Property LastName() As String
			Get
				Return _LastName
			End Get
			Set(ByVal value As String)
				_LastName = value
			End Set
		End Property

		Public Property ID() As Integer
			Get
				Return _ID
			End Get
			Set(ByVal value As Integer)
				_ID = value
			End Set
		End Property
		Public Overrides Function ToString() As String
			Return String.Format("{0} {1} ID № {2}", FirstName, LastName, ID)
		End Function
	End Class
End Namespace
