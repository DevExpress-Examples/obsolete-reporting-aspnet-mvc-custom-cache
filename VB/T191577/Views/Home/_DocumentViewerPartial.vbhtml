@ModelType XtraReport
@Html.DevExpress().DocumentViewer(Sub(settings)
                                      settings.Name = "documentViewer"
    
                                      settings.CallbackRouteValues = New With {.Controller = "Home", .Action = "DocumentViewerPartial"}
                                      settings.ExportRouteValues = New With {.Controller = "Home", .Action = "DocumentViewerExport"}
    
                                      settings.Report = Model

                                      settings.CacheReportDocument = Sub(sender, e)
                                                                         e.Key = Guid.NewGuid().ToString()
                                                                         Session(e.Key) = e.SaveDocumentToMemoryStream()
                                                                     End Sub
                                      settings.RestoreReportDocumentFromCache = Sub(sender, e)
                                                                                    Dim stream As Stream = CType(Session(e.Key), Stream)
                                                                                    If Not IsNothing(stream) Then
                                                                                        e.RestoreDocumentFromStream(stream)
                                                                                    End If
                                                                                End Sub
                                  End Sub).GetHtml()
