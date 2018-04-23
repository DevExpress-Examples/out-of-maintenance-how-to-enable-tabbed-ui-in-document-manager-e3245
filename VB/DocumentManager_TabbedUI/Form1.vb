Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraBars.Docking2010.Views.Tabbed
Imports DevExpress.XtraEditors

Namespace DocumentManager_TabbedUI
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			AddDocumentManager()
			For i As Integer = 0 To 2
				AddChildForm()
			Next i
		End Sub
		Private Sub AddDocumentManager()
			Dim manager As New DocumentManager()
			manager.MdiParent = Me
			manager.View = New TabbedView()
		End Sub
		Private count As Integer
		Private Sub AddChildForm()
			Dim childForm As New Form()
			count += 1
			childForm.Text = "Child Form " & (count).ToString()

			Dim btn As New SimpleButton()
			btn.Text = "Button " & count.ToString()
			btn.Parent = childForm

			childForm.MdiParent = Me
			childForm.Show()
		End Sub
	End Class
End Namespace