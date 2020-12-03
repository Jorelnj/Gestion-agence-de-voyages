namespace Frmtiket
{
    partial class FrmTicket
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.btncancel = new System.Windows.Forms.Button();
            this.txtprenom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcni = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsexe = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtobservation = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtprix = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtsiege = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtarriver = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtnumerotckit = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtdepart = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtRemboussement = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 146);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(114, 146);
            this.txtnom.Margin = new System.Windows.Forms.Padding(4);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(148, 24);
            this.txtnom.TabIndex = 0;
            this.txtnom.TextChanged += new System.EventHandler(this.txtnom_TextChanged);
            // 
            // btncancel
            // 
            this.btncancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btncancel.Location = new System.Drawing.Point(431, 318);
            this.btncancel.Margin = new System.Windows.Forms.Padding(4);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(483, 131);
            this.btncancel.TabIndex = 13;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // txtprenom
            // 
            this.txtprenom.Location = new System.Drawing.Point(114, 186);
            this.txtprenom.Margin = new System.Windows.Forms.Padding(4);
            this.txtprenom.Name = "txtprenom";
            this.txtprenom.Size = new System.Drawing.Size(148, 24);
            this.txtprenom.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 192);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prenom";
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(114, 228);
            this.txtage.Margin = new System.Windows.Forms.Padding(4);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(148, 24);
            this.txtage.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 234);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Age";
            // 
            // txtcni
            // 
            this.txtcni.Location = new System.Drawing.Point(431, 192);
            this.txtcni.Margin = new System.Windows.Forms.Padding(4);
            this.txtcni.Name = "txtcni";
            this.txtcni.Size = new System.Drawing.Size(148, 24);
            this.txtcni.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(331, 198);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "numero CNI";
            // 
            // txtsexe
            // 
            this.txtsexe.Location = new System.Drawing.Point(114, 272);
            this.txtsexe.Margin = new System.Windows.Forms.Padding(4);
            this.txtsexe.Name = "txtsexe";
            this.txtsexe.Size = new System.Drawing.Size(148, 24);
            this.txtsexe.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 275);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sexe";
            // 
            // btnsave
            // 
            this.btnsave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnsave.Location = new System.Drawing.Point(3, 314);
            this.btnsave.Margin = new System.Windows.Forms.Padding(4);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(420, 135);
            this.btnsave.TabIndex = 12;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtobservation
            // 
            this.txtobservation.Location = new System.Drawing.Point(776, 286);
            this.txtobservation.Margin = new System.Windows.Forms.Padding(4);
            this.txtobservation.Name = "txtobservation";
            this.txtobservation.Size = new System.Drawing.Size(148, 24);
            this.txtobservation.TabIndex = 11;
            this.txtobservation.TextChanged += new System.EventHandler(this.txtobservation_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(676, 286);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 18);
            this.label6.TabIndex = 21;
            this.label6.Text = "Observation";
            // 
            // txtprix
            // 
            this.txtprix.Location = new System.Drawing.Point(776, 195);
            this.txtprix.Margin = new System.Windows.Forms.Padding(4);
            this.txtprix.Name = "txtprix";
            this.txtprix.Size = new System.Drawing.Size(148, 24);
            this.txtprix.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(676, 195);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 18);
            this.label7.TabIndex = 19;
            this.label7.Text = "prix ticket";
            // 
            // txtsiege
            // 
            this.txtsiege.Location = new System.Drawing.Point(776, 146);
            this.txtsiege.Margin = new System.Windows.Forms.Padding(4);
            this.txtsiege.Name = "txtsiege";
            this.txtsiege.Size = new System.Drawing.Size(148, 24);
            this.txtsiege.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(676, 152);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 18);
            this.label8.TabIndex = 17;
            this.label8.Text = "Numero siege";
            // 
            // txtarriver
            // 
            this.txtarriver.Location = new System.Drawing.Point(431, 275);
            this.txtarriver.Margin = new System.Windows.Forms.Padding(4);
            this.txtarriver.Name = "txtarriver";
            this.txtarriver.Size = new System.Drawing.Size(148, 24);
            this.txtarriver.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(331, 281);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 18);
            this.label9.TabIndex = 15;
            this.label9.Text = "Arriver";
            // 
            // txtnumerotckit
            // 
            this.txtnumerotckit.Location = new System.Drawing.Point(250, 102);
            this.txtnumerotckit.Margin = new System.Windows.Forms.Padding(4);
            this.txtnumerotckit.Name = "txtnumerotckit";
            this.txtnumerotckit.ReadOnly = true;
            this.txtnumerotckit.Size = new System.Drawing.Size(478, 24);
            this.txtnumerotckit.TabIndex = 14;
            this.txtnumerotckit.TextChanged += new System.EventHandler(this.txtnumerotckit_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(331, 234);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 18);
            this.label10.TabIndex = 13;
            this.label10.Text = "Depart";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 102);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(217, 18);
            this.label11.TabIndex = 23;
            this.label11.Text = "TICKET DE VOYAGE JOUR N°";
            // 
            // txtdepart
            // 
            this.txtdepart.Location = new System.Drawing.Point(431, 231);
            this.txtdepart.Margin = new System.Windows.Forms.Padding(4);
            this.txtdepart.Name = "txtdepart";
            this.txtdepart.Size = new System.Drawing.Size(148, 24);
            this.txtdepart.TabIndex = 6;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(431, 146);
            this.txtTelephone.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(148, 24);
            this.txtTelephone.TabIndex = 4;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(331, 146);
            this.lblTel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(77, 18);
            this.lblTel.TabIndex = 25;
            this.lblTel.Text = "Télèphone";
            // 
            // txtRemboussement
            // 
            this.txtRemboussement.Location = new System.Drawing.Point(776, 234);
            this.txtRemboussement.Margin = new System.Windows.Forms.Padding(4);
            this.txtRemboussement.Name = "txtRemboussement";
            this.txtRemboussement.Size = new System.Drawing.Size(148, 24);
            this.txtRemboussement.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(632, 237);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 18);
            this.label12.TabIndex = 29;
            this.label12.Text = "Remboussement";
            // 
            // frmticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 592);
            this.Controls.Add(this.txtRemboussement);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.txtdepart);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtobservation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtprix);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtsiege);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtarriver);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtnumerotckit);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtsexe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtcni);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtprenom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmticket";
            this.Text = "z";
            this.Load += new System.EventHandler(this.frmticket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.TextBox txtprenom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsexe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtobservation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtprix;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtsiege;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtarriver;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtnumerotckit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtdepart;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtRemboussement;
        private System.Windows.Forms.Label label12;
    }
}

