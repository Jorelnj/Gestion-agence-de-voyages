﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frmtiket
{
    public partial class TicketPreview : Form
    {
        private object reportPath { get; set; }
        private object items { get; set; }
        public TicketPreview()
        {
            InitializeComponent();
        }

        public TicketPreview(string reportPath, object items) : this()
        {
            this.reportPath = reportPath;
            this.items = items;
        }

        private void TicketPreview_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.ReportPath = "TicketListRpt.rdlc";
            this.reportViewer1.LocalReport.DataSources.Add
            (
                new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", items)
            );
            this.reportViewer1.RefreshReport();
        }
    }
}