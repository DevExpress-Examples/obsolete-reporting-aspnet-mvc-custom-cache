Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI

Namespace T191577.Reports
	Partial Public Class CategoriesReport
		Inherits DevExpress.XtraReports.UI.XtraReport

		Public Sub New()
			InitializeComponent()
			pbPicture.DataBindings.Add("Image", Nothing, "Picture")
		End Sub

		Private Sub CategoriesReport_DataSourceDemanded(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.DataSourceDemanded
			Me.DataSource = Category.GetCategories()
		End Sub

	End Class
End Namespace
