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
    public partial class frmconnexion : Form
    {
        private int a = 0;
        public frmconnexion()
        {
            InitializeComponent();
        }
        public int boucle()
        {
            a++;
            return a;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmconnexion_Load(object sender, EventArgs e)
        {

        }

        private void btnsave_Click_1(object sender, EventArgs e)
        {

            try
            {
                Connexion connexion = new Connexion
                (
                textBox1.Text, textBox2.Text

                );
                connexionlogique connexionlogique = new connexionlogique();
                connexionlogique.creationConnexion(connexion);
                MessageBox.Show
                    (
                    "connexion reussit!",
                    "configuration",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                textBox1.Clear();
                textBox2.Clear();

            }
            catch (Exception )
            {

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
