<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128596681/13.2.13%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T191577)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/T191577/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/T191577/Controllers/HomeController.vb))
* [Category.cs](./CS/T191577/Models/Category.cs) (VB: [Category.vb](./VB/T191577/Models/Category.vb))
* [CategoriesReport.cs](./CS/T191577/Reports/CategoriesReport.cs) (VB: [CategoriesReport.vb](./VB/T191577/Reports/CategoriesReport.vb))
* **[_DocumentViewerPartial.cshtml](./CS/T191577/Views/Home/_DocumentViewerPartial.cshtml)**
<!-- default file list end -->
# How to use the built-in caching functionality of the ASP.NET MVC Document Viewer
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/t191577)**
<!-- run online end -->


<p>This example illustrates how to make the <a href="http://documentation.devexpress.com/#XtraReports/CustomDocument5193">DocumentViewer</a> store its document on the client between postbacks.<br><br>When the Document Viewer extension performs a callback to the server (for example, when a page is changed), the report document is restored from the cache. So, it is not necessary to recreate a report document and data is not retrieved from the database. The Document Viewer manages a cached document by using the <a href="http://documentation.devexpress.com/#XtraReports/DevExpressXtraReportsWebASPxDocumentViewer_CacheReportDocumenttopic">CacheReportDocument</a> and <a href="http://documentation.devexpress.com/#XtraReports/DevExpressXtraReportsWebASPxDocumentViewer_RestoreReportDocumentFromCachetopic">RestoreReportDocumentFromCache</a> delegates.</p>
<p>To be able to use this approach, it is necessary to move your report data binding code to its <a href="https://documentation.devexpress.com/#XtraReports/DevExpressXtraReportsUIXtraReportBase_DataSourceDemandedtopic">DataSourceDemanded</a> event handler.</p>
<p><br>To learn how to accomplish this task in ASP.NET WebForms applications, see the following code example: <a href="https://www.devexpress.com/Support/Center/p/E1946">How to use the caching functionality of the Document Viewer</a> <br><strong><br>Note:</strong> No document caching is required when using the newer <a href="https://documentation.devexpress.com/#AspNet/CustomDocument114491">ASPxWebDocumentViewer</a> control that utilizes the HTML5/JS technology and provides asynchronous building of documents out of the box.</p>

<br/>


