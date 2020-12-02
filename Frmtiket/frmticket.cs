using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tiket_transport;
using Transport.logique;

namespace Frmtiket
{
    public partial class frmticket : Form
    {
        private int a = 0;
        public frmticket()
        {
            InitializeComponent();
            int b = 0;
            boucle();
            txtnumerotckit.Text = "N°000" + b.ToString() + a.ToString();
        }
        public int boucle()
        {
            a++;
            return a;
        }


        private void btnsave_Click(object sender, EventArgs e)
        {
            
            try
            {
                Tiket tiket = new Tiket
                (
                txtnom.Text, txtprenom.Text,
                txtage.Text, txtcni.Text, txtdepart.Text,
                txtarriver.Text, float.Parse(txtprix.Text),
                txtsierge.Text
                );
                tiketlogique tiketlogique = new tiketlogique();
                tiketlogique.creationTiket(tiket);
                MessageBox.Show
                    (
                    "sauvegarde reussit!",
                    "configuration",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                int b = 0;
                boucle();
                txtnumerotckit.Text = "N°000" + b.ToString() + a.ToString();

                txtnom.Clear();
                txtprenom.Clear();
                txtage.Clear();
                txtcni.Clear();
                txtdepart.Clear();
                txtage.Clear();
                txtprix.Clear();
                txtnom.Focus();
            }
            catch(Exception h)
            {

            }
            
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtnom_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnumerotckit_TextChanged(object sender, EventArgs e)

        {
           
        }

        private void btnincrementation_Click(object sender, EventArgs e)
        {
           
            int b = 0;
            boucle();
            txtnumerotckit.Text = "N°000" + b.ToString() +a.ToString();

        }

    }
}
