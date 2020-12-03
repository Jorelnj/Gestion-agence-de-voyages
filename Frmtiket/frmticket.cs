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
    public partial class FrmTicket : Form
    {
        private Action callBack;
        private int a = 0;
        private Ticket oldTicket;
        public FrmTicket()
        {
            InitializeComponent();
            int b = 0;
            boucle();
            txtnumerotckit.Text = "N°000" + b.ToString() + a.ToString();
        }

        public FrmTicket(Action callBack) : this()
        {
            this.callBack = callBack;
        }

        public FrmTicket(Ticket tiket, Action callBack) : this(callBack)
        {
            this.oldTicket = tiket;
            txtnom.Text = tiket.Nom;
            txtprenom.Text = tiket.Prenom;
            txtage.Text = tiket.Age;
            txtsexe.Text = tiket.Sexe;
            txtTelephone.Text = tiket.Telephone;
            txtcni.Text = tiket.numero_CNI;
            txtdepart.Text = tiket.ville_de_Depart;
            txtarriver.Text = tiket.ville_Arriver;
            txtsiege.Text = tiket.Siege;
            txtprix.Text = tiket.prix_tiket.ToString();
            txtRemboussement.Text = tiket.Remboussement.ToString();
            txtobservation.Text = tiket.Observation;

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
                Ticket tiket = new Ticket
                (
                txtnom.Text,
                txtprenom.Text,
                txtage.Text, 
                txtcni.Text,
                txtdepart.Text,
                txtarriver.Text,
                float.Parse(txtprix.Text),
                txtsexe.Text,
                txtTelephone.Text,
                txtsiege.Text,
                 float.Parse(txtRemboussement.Text)


                );
                tiketlogique tiketlogique = new tiketlogique();
                tiketlogique.creationTicket(tiket);
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
                txtsexe.Clear();
                txtnom.Focus();
                txtTelephone.Clear();
                txtRemboussement.Clear();
                txtsiege.Clear();
                txtarriver.Clear();
                txtobservation.Clear();
            }
            catch(Exception)
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

        private void frmticket_Load(object sender, EventArgs e)
        {

        }

        private void txtobservation_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
