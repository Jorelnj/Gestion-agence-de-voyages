using Frmtiket;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ticket_transport;

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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
                loadData();
            else
                txtSearch.Clear();
        }

        private void loadData()
        {
            /*string value = txtSearch.Text.ToLower();
            var tickets = productBLO.GetBy
            (
                x =>
                x.Reference.ToLower().Contains(value) ||
                x.Name.ToLower().Contains(value)
            ).OrderBy(x => x.Reference).ToArray();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = products;
            lblRowCount.Text = $"{dataGridView1.RowCount} rows";
            dataGridView1.ClearSelection();*/
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Form f = new FrmTicket(loadData);
            f.Show();
        }

        private void FormTicketList_Load(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    Form f = new FrmTicket
                    (
                        dataGridView1.SelectedRows[i].DataBoundItem as Ticket,
                        loadData
                    );
                    f.ShowDialog();
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            List<FormTicketListPrint> items = new List<FormTicketListPrint>();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                Ticket t = dataGridView1.Rows[i].DataBoundItem as Ticket;
                items.Add
                (
                    new FormTicketListPrint
                    (
                        t.Nom,
                        t.Prenom,
                        t.Age,
                        t.Sexe,
                        t.VilleDepart,
                        t.VilleArrivee,
                        float.Parse(t.Siege),
                        t.PrixTicket.ToString(),
                        t.Remboussement.ToString(),
                        t.NumeroCNI,
                        t.Observation,
                        float.Parse(t.Telephone)
                    )
                );
            }
            Form f = new TicketPreview("TicketListRpt.rdlc", items);
            f.Show();
        }
    }
}
