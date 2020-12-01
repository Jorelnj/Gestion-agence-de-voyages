namespace Frmtiket
{
    partial class frmconnexion
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
            this.btnsave = new System.Windows.Forms.Button();
            this.txtemail = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btncancel = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtmot_de_passe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.LimeGreen;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsave.Location = new System.Drawing.Point(61, 361);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(121, 43);
            this.btnsave.TabIndex = 0;
            this.btnsave.Text = "CONNEXION";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click_1);
            // 
            // txtemail
            // 
            this.txtemail.AutoSize = true;
            this.txtemail.Location = new System.Drawing.Point(58, 118);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(51, 18);
            this.txtemail.TabIndex = 1;
            this.txtemail.Text = "EMAIL";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(153, 118);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 39);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.Crimson;
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btncancel.Location = new System.Drawing.Point(218, 361);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(126, 43);
            this.btncancel.TabIndex = 3;
            this.btncancel.Text = "ANNULER";
            this.btncancel.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(153, 246);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(222, 42);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtmot_de_passe
            // 
            this.txtmot_de_passe.AutoSize = true;
            this.txtmot_de_passe.Location = new System.Drawing.Point(16, 249);
            this.txtmot_de_passe.Name = "txtmot_de_passe";
            this.txtmot_de_passe.Size = new System.Drawing.Size(120, 18);
            this.txtmot_de_passe.TabIndex = 4;
            this.txtmot_de_passe.Text = "MOT DE PASSE";
            // 
            // frmconnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(396, 469);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtmot_de_passe);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.btnsave);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmconnexion";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmconnexion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label txtemail;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label txtmot_de_passe;
    }
}

