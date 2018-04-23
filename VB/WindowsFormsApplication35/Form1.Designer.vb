Imports Microsoft.VisualBasic
Imports System
Namespace WindowsFormsApplication35
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim tileItemElement1 As New DevExpress.XtraEditors.TileItemElement()
			Dim tileItemElement2 As New DevExpress.XtraEditors.TileItemElement()
			Me.documentManager1 = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
			Me.windowsUIView1 = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView(Me.components)
			Me.dockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
			Me.document1 = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(Me.components)
			Me.document1Tile = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(Me.components)
			Me.tileContainer1 = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer(Me.components)
			Me.document2 = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(Me.components)
			Me.document2Tile = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(Me.components)
			Me.document3 = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(Me.components)
			Me.pageGroup1 = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.PageGroup(Me.components)
			Me.page1 = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Page(Me.components)
			CType(Me.documentManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.windowsUIView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.document1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.document1Tile, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tileContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.document2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.document2Tile, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.document3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pageGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.page1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' documentManager1
			' 
			Me.documentManager1.ContainerControl = Me
			Me.documentManager1.View = Me.windowsUIView1
			Me.documentManager1.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() { Me.windowsUIView1})
			' 
			' windowsUIView1
			' 
			Me.windowsUIView1.ContentContainers.AddRange(New DevExpress.XtraBars.Docking2010.Views.WindowsUI.IContentContainer() { Me.tileContainer1, Me.pageGroup1, Me.page1})
			Me.windowsUIView1.Documents.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseDocument() { Me.document1, Me.document2, Me.document3})
			Me.windowsUIView1.Tiles.AddRange(New DevExpress.XtraBars.Docking2010.Views.WindowsUI.BaseTile() { Me.document1Tile, Me.document2Tile})
'			Me.windowsUIView1.QueryControl += New DevExpress.XtraBars.Docking2010.Views.QueryControlEventHandler(Me.windowsUIView1_QueryControl);
			' 
			' dockManager1
			' 
			Me.dockManager1.Form = Me
			Me.dockManager1.TopZIndexControls.AddRange(New String() { "DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
			' 
			' document1
			' 
			Me.document1.Caption = "GridView"
			Me.document1.ControlName = "document1"
			' 
			' document1Tile
			' 
			Me.document1Tile.ActivationTarget = Me.page1
			Me.document1Tile.Document = Me.document1
			tileItemElement1.Text = "GridView"
			tileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
			Me.document1Tile.Elements.Add(tileItemElement1)
			Me.document1Tile.Name = "document1Tile"
			' 
			' tileContainer1
			' 
			Me.tileContainer1.Items.AddRange(New DevExpress.XtraBars.Docking2010.Views.WindowsUI.BaseTile() { Me.document1Tile, Me.document2Tile})
			Me.tileContainer1.Name = "tileContainer1"
			' 
			' document2
			' 
			Me.document2.Caption = "CardView"
			Me.document2.ControlName = "document2"
			' 
			' document2Tile
			' 
			Me.document2Tile.ActivationTarget = Me.pageGroup1
			Me.document2Tile.Document = Me.document2
			tileItemElement2.Text = "CardView"
			tileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
			Me.document2Tile.Elements.Add(tileItemElement2)
			Me.tileContainer1.SetID(Me.document2Tile, 1)
			Me.document2Tile.Name = "document2Tile"
			' 
			' document3
			' 
			Me.document3.Caption = "TreeList"
			Me.document3.ControlName = "document1"
			' 
			' pageGroup1
			' 
			Me.pageGroup1.Items.AddRange(New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document() { Me.document2, Me.document3})
			Me.pageGroup1.Name = "pageGroup1"
			Me.pageGroup1.Parent = Me.tileContainer1
			' 
			' page1
			' 
			Me.page1.Document = Me.document1
			Me.page1.Name = "page1"
			Me.page1.Parent = Me.tileContainer1
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(771, 528)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.documentManager1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.windowsUIView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dockManager1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.document1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.document1Tile, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tileContainer1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.document2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.document2Tile, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.document3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pageGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.page1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private documentManager1 As DevExpress.XtraBars.Docking2010.DocumentManager
		Private WithEvents windowsUIView1 As DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView
		Private tileContainer1 As DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer
		Private document1Tile As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile
		Private document1 As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document
		Private document2Tile As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile
		Private document2 As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document
		Private dockManager1 As DevExpress.XtraBars.Docking.DockManager
		Private pageGroup1 As DevExpress.XtraBars.Docking2010.Views.WindowsUI.PageGroup
		Private document3 As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document
		Private page1 As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Page
	End Class
End Namespace

