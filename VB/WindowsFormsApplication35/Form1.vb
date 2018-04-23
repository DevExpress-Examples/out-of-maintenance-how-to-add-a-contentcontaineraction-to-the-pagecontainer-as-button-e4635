Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Card
Imports DevExpress.XtraBars.Docking2010.Views.WindowsUI
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraEditors

Namespace WindowsFormsApplication35
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			page1.Buttons.AddAction(ContentContainerAction.Exit)

		End Sub

		Private Sub windowsUIView1_QueryControl(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs) Handles windowsUIView1.QueryControl

			If e.Document.Caption = "CardView" Then
				e.Control = CreateNewGrid(New CardView())
			End If
			If e.Document.Caption = "GridView" Then
				e.Control = CreateNewGrid(New GridView())
			End If
			If e.Document.Caption = "TreeList" Then
				e.Control = New ListBoxControl() With {.DataSource = GetData()}
			End If


		End Sub
		Public Function CreateNewGrid(ByVal View As BaseView) As GridControl
			Dim grid As New GridControl()
			grid.DataSource = GetData()
			grid.MainView = View
			Return grid
		End Function
		Public Function GetData() As List(Of Person)
			Dim list As New List(Of Person)()
			list.Add(New Person() With {.FirstName = "Alex", .LastName = "Hunt", .ID = 12321})
			list.Add(New Person() With {.FirstName = "James", .LastName = "Bond", .ID = 87452})
			list.Add(New Person() With {.FirstName = "Sam", .LastName = "Winchester", .ID = 43598})
			list.Add(New Person() With {.FirstName = "Din", .LastName = "Winchester", .ID = 31561})
			list.Add(New Person() With {.FirstName = "Derek", .LastName = "Morgan", .ID = 29873})
			Return list
		End Function
	End Class
End Namespace
