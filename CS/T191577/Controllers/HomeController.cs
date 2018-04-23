using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using T191577.Reports;
using DevExpress.Web.Mvc;

namespace T191577.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }

        public ActionResult DocumentViewerPartial() {
            CategoriesReport report = new CategoriesReport();
            return PartialView("_DocumentViewerPartial", report);
        }

        public ActionResult DocumentViewerExport() {
            CategoriesReport report = new CategoriesReport();
            return DocumentViewerExtension.ExportTo(report);
        }
    }
}