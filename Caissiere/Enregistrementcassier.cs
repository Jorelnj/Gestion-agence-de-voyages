using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using caissierlogique;
using caissiereclass;


 namespace Caissiere
{
    public partial class EnregistrementCassier : Form
    {
        public EnregistrementCassier()
        {
            InitializeComponent();
          
        }

        private void btnEnregistrement_Click(object sender, EventArgs e)
        {
            try
            {
                Caissiere caissiere = new Caissiere
                (
                txtNom.Text,
                txtPrenom.Text,
                txtTelephone.Text
                );
                LogiqueCaissiere Logiquecaissiere = new LogiqueCaissiere();
                Logiquecaissiere.creationTicket(caissiere);
                MessageBox.Show
                    (
                    "sauvegarde reussit!",
                    "configuration",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );

                txtNom.Focus();
                txtNom.Clear();
                txtPrenom.Clear();
                txtTelephone.Clear();
                
            }
            catch (Exception)
            {

            }
        }
    }
}
