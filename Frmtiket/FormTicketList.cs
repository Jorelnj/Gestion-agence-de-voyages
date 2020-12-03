using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frmticket
{
    public partial class FormTicketList : Form
    {
        public FormTicketList()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void loadData()
        {
            string value = txtSearch.Text.ToLower();
            var tickets = productBLO.GetBy
            (
                x =>
                x.Reference.ToLower().Contains(value) ||
                x.Name.ToLower().Contains(value)
            ).OrderBy(x => x.Reference).ToArray();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = products;
            lblRowCount.Text = $"{dataGridView1.RowCount} rows";
            dataGridView1.ClearSelection();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Form f = new FrmTicket(loadData);
        }
    }
}
