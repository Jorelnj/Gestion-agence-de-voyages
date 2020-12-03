﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ticket_transport;
using Transport.logique;

namespace Frmticket
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

        public FrmTicket(Ticket ticket, Action callBack) : this(callBack)
        {
            this.oldTicket = ticket;
            txtnom.Text = ticket.Nom;
            txtprenom.Text = ticket.Prenom;
            txtage.Text = ticket.Age;
            txtsexe.Text = ticket.Sexe;
            txtTelephone.Text = ticket.Telephone;
            txtcni.Text = ticket.numero_CNI;
            txtdepart.Text = ticket.ville_de_Depart;
            txtarriver.Text = ticket.ville_Arriver;
            txtsiege.Text = ticket.Siege;
            txtprix.Text = ticket.prix_ticket.ToString();
            txtRemboussement.Text = ticket.Remboussement.ToString();
            txtobservation.Text = ticket.Observation;

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
                Ticket ticket = new Ticket
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
                ticketlogique ticketlogique = new ticketlogique();
                ticketlogique.creationTicket(ticket);
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
