namespace Caissiere
{
    partial class EnregistrementCassier
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNom = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTelephone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPrenom = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAnnuler = new Guna.UI2.WinForms.Guna2Button();
            this.btnEnregistrer = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Caissiere.Properties.Resources._2;
            this.pictureBox1.Location = new System.Drawing.Point(46, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 190);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(459, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Telephone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(459, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Prenom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(459, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nom";
            // 
            // txtNom
            // 
            this.txtNom.BorderColor = System.Drawing.SystemColors.Highlight;
            this.txtNom.BorderRadius = 15;
            this.txtNom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNom.DefaultText = "";
            this.txtNom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNom.DisabledState.Parent = this.txtNom;
            this.txtNom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNom.FocusedState.Parent = this.txtNom;
            this.txtNom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNom.HoverState.Parent = this.txtNom;
            this.txtNom.Location = new System.Drawing.Point(569, 23);
            this.txtNom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNom.Name = "txtNom";
            this.txtNom.PasswordChar = '\0';
            this.txtNom.PlaceholderText = "";
            this.txtNom.SelectedText = "";
            this.txtNom.ShadowDecoration.Parent = this.txtNom;
            this.txtNom.Size = new System.Drawing.Size(222, 36);
            this.txtNom.TabIndex = 0;
            // 
            // txtTelephone
            // 
            this.txtTelephone.BorderRadius = 15;
            this.txtTelephone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelephone.DefaultText = "";
            this.txtTelephone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTelephone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTelephone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTelephone.DisabledState.Parent = this.txtTelephone;
            this.txtTelephone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTelephone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTelephone.FocusedState.Parent = this.txtTelephone;
            this.txtTelephone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelephone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTelephone.HoverState.Parent = this.txtTelephone;
            this.txtTelephone.Location = new System.Drawing.Point(569, 161);
            this.txtTelephone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.PasswordChar = '\0';
            this.txtTelephone.PlaceholderText = "";
            this.txtTelephone.SelectedText = "";
            this.txtTelephone.ShadowDecoration.Parent = this.txtTelephone;
            this.txtTelephone.Size = new System.Drawing.Size(222, 35);
            this.txtTelephone.TabIndex = 2;
            // 
            // txtPrenom
            // 
            this.txtPrenom.BorderRadius = 15;
            this.txtPrenom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrenom.DefaultText = "";
            this.txtPrenom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrenom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrenom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrenom.DisabledState.Parent = this.txtPrenom;
            this.txtPrenom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrenom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrenom.FocusedState.Parent = this.txtPrenom;
            this.txtPrenom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrenom.HoverState.Parent = this.txtPrenom;
            this.txtPrenom.Location = new System.Drawing.Point(570, 89);
            this.txtPrenom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.PasswordChar = '\0';
            this.txtPrenom.PlaceholderText = "";
            this.txtPrenom.SelectedText = "";
            this.txtPrenom.ShadowDecoration.Parent = this.txtPrenom;
            this.txtPrenom.Size = new System.Drawing.Size(222, 34);
            this.txtPrenom.TabIndex = 1;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BorderRadius = 20;
            this.btnAnnuler.CheckedState.Parent = this.btnAnnuler;
            this.btnAnnuler.CustomImages.Parent = this.btnAnnuler;
            this.btnAnnuler.FillColor = System.Drawing.Color.Firebrick;
            this.btnAnnuler.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.ForeColor = System.Drawing.Color.White;
            this.btnAnnuler.HoverState.Parent = this.btnAnnuler;
            this.btnAnnuler.Location = new System.Drawing.Point(633, 318);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.ShadowDecoration.Parent = this.btnAnnuler;
            this.btnAnnuler.Size = new System.Drawing.Size(159, 47);
            this.btnAnnuler.TabIndex = 4;
            this.btnAnnuler.Text = "Annuler";
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BorderRadius = 20;
            this.btnEnregistrer.CheckedState.Parent = this.btnEnregistrer;
            this.btnEnregistrer.CustomImages.Parent = this.btnEnregistrer;
            this.btnEnregistrer.FillColor = System.Drawing.Color.LimeGreen;
            this.btnEnregistrer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrer.ForeColor = System.Drawing.Color.White;
            this.btnEnregistrer.HoverState.Parent = this.btnEnregistrer;
            this.btnEnregistrer.Location = new System.Drawing.Point(443, 318);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.ShadowDecoration.Parent = this.btnEnregistrer;
            this.btnEnregistrer.Size = new System.Drawing.Size(168, 47);
            this.btnEnregistrer.TabIndex = 3;
            this.btnEnregistrer.Text = "Enregistrement";
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // EnregistrementCassier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(804, 377);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EnregistrementCassier";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Enregistrementcassier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtNom;
        private Guna.UI2.WinForms.Guna2TextBox txtTelephone;
        private Guna.UI2.WinForms.Guna2TextBox txtPrenom;
        private Guna.UI2.WinForms.Guna2Button btnAnnuler;
        private Guna.UI2.WinForms.Guna2Button btnEnregistrer;
    }
}

