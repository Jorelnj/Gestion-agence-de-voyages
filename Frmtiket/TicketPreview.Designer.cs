
namespace Frmtiket
{
    partial class TicketPreview
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TicketPreview1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // TicketPreview1
            // 
            this.TicketPreview1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TicketPreview1.Location = new System.Drawing.Point(0, 0);
            this.TicketPreview1.Name = "TicketPreview1";
            this.TicketPreview1.ServerReport.BearerToken = null;
            this.TicketPreview1.Size = new System.Drawing.Size(800, 450);
            this.TicketPreview1.TabIndex = 0;
            this.TicketPreview1.Load += new System.EventHandler(this.TicketPreviewr1_Load);
            // 
            // TicketPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TicketPreview1);
            this.Name = "TicketPreview";
            this.Text = "TicketPreview";
            this.Load += new System.EventHandler(this.TicketPreview_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer TicketPreview1;
    }
}