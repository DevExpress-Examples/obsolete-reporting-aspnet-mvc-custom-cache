using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace T191577.Reports {
    public partial class CategoriesReport : DevExpress.XtraReports.UI.XtraReport {
        public CategoriesReport() {
            InitializeComponent();
            pbPicture.DataBindings.Add("Image", null, "Picture");
        }

        private void CategoriesReport_DataSourceDemanded(object sender, EventArgs e) {
            this.DataSource = Category.GetCategories();
        }

    }
}
