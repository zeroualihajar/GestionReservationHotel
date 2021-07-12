
namespace GestionReservationHotel.UC
{
    partial class ucClient
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.idRes = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // idRes
            // 
            this.idRes.AutoSize = true;
            this.idRes.Location = new System.Drawing.Point(4, 22);
            this.idRes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idRes.Name = "idRes";
            this.idRes.Size = new System.Drawing.Size(102, 18);
            this.idRes.TabIndex = 0;
            this.idRes.Text = "id Reseravtion";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(132, 22);
            this.lblNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(82, 18);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nom Client";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(289, 22);
            this.lblPrenom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(82, 18);
            this.lblPrenom.TabIndex = 2;
            this.lblPrenom.Text = "Nom Client";
            // 
            // ucClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.idRes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucClient";
            this.Size = new System.Drawing.Size(414, 58);
            this.Load += new System.EventHandler(this.ucClient_Load);
            this.DoubleClick += new System.EventHandler(this.ucClient_DoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idRes;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
    }
}
