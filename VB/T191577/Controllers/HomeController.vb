Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports T191577.Reports
Imports DevExpress.Web.Mvc

Namespace T191577.Controllers
	Public Class HomeController
		Inherits Controller

		Public Function Index() As ActionResult
			Return View()
		End Function

		Public Function DocumentViewerPartial() As ActionResult
            Dim report As New CategoriesReport()
			Return PartialView("_DocumentViewerPartial", report)
		End Function

		Public Function DocumentViewerExport() As ActionResult
			Dim report As New CategoriesReport()
			Return DocumentViewerExtension.ExportTo(report)
		End Function
	End Class
End Namespace