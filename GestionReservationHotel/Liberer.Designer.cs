
namespace GestionReservationHotel
{
    partial class Liberer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.idChambre = new System.Windows.Forms.Label();
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(183, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Liste des Clients";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Calligraphy", 19.8F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(36, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(479, 43);
            this.label8.TabIndex = 25;
            this.label8.Text = "Reservation du Chambre";
            // 
            // idChambre
            // 
            this.idChambre.AutoSize = true;
            this.idChambre.Font = new System.Drawing.Font("Lucida Calligraphy", 19.8F, System.Drawing.FontStyle.Bold);
            this.idChambre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.idChambre.Location = new System.Drawing.Point(245, 62);
            this.idChambre.Name = "idChambre";
            this.idChambre.Size = new System.Drawing.Size(0, 43);
            this.idChambre.TabIndex = 26;
            // 
            // flowPanel
            // 
            this.flowPanel.AutoScroll = true;
            this.flowPanel.Location = new System.Drawing.Point(35, 170);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(480, 370);
            this.flowPanel.TabIndex = 27;
            // 
            // Liberer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(566, 552);
            this.Controls.Add(this.flowPanel);
            this.Controls.Add(this.idChambre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Name = "Liberer";
            this.Text = "Description";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        /*private System.Windows.Forms.Label lblEtage;
        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.Label lblHotel;
        private System.Windows.Forms.Label lblId;*/
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label idChambre;
        private System.Windows.Forms.FlowLayoutPanel flowPanel;
    }
}

        