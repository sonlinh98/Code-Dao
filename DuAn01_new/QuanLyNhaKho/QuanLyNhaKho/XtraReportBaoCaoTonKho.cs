using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using QuanLyNhaKho.DAO;
using System.Collections.Generic;

namespace QuanLyNhaKho
{
    public partial class XtraReportBaoCaoTonKho : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReportBaoCaoTonKho()
        {
            InitializeComponent();
        }

        public void InitData(List<BaoCaoNhapXuatTonDAO> dataBaoCao)
        {
            objectDataSource1.DataSource = dataBaoCao;
        }

    }
}
