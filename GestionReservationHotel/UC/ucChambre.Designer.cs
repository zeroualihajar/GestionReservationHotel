
namespace GestionReservationHotel
{
    partial class ucChambre
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
            this.components = new System.ComponentModel.Container();
            this.idChambrelbl = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.libererToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reserverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // idChambrelbl
            // 
            this.idChambrelbl.AutoSize = true;
            this.idChambrelbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.idChambrelbl.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idChambrelbl.Location = new System.Drawing.Point(57, 0);
            this.idChambrelbl.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.idChambrelbl.Name = "idChambrelbl";
            this.idChambrelbl.Size = new System.Drawing.Size(22, 23);
            this.idChambrelbl.TabIndex = 0;
            this.idChambrelbl.Text = "0";
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.menuStrip.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.libererToolStripMenuItem,
            this.reserverToolStripMenuItem,
            this.detailToolStripMenuItem,
            this.descriptionToolStripMenuItem});
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(270, 108);
            // 
            // libererToolStripMenuItem
            // 
            this.libererToolStripMenuItem.Name = "libererToolStripMenuItem";
            this.libererToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.libererToolStripMenuItem.Text = "Liberer";
            this.libererToolStripMenuItem.Click += new System.EventHandler(this.libererToolStripMenuItem_Click);
            // 
            // reserverToolStripMenuItem
            // 
            this.reserverToolStripMenuItem.Name = "reserverToolStripMenuItem";
            this.reserverToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.reserverToolStripMenuItem.Text = "Reserver";
            this.reserverToolStripMenuItem.Click += new System.EventHandler(this.reserverToolStripMenuItem_Click);
            // 
            // detailToolStripMenuItem
            // 
            this.detailToolStripMenuItem.Name = "detailToolStripMenuItem";
            this.detailToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.detailToolStripMenuItem.Text = "Information du Client";
            this.detailToolStripMenuItem.Click += new System.EventHandler(this.detailToolStripMenuItem_Click);
            // 
            // descriptionToolStripMenuItem
            // 
            this.descriptionToolStripMenuItem.Name = "descriptionToolStripMenuItem";
            this.descriptionToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.descriptionToolStripMenuItem.Text = "Description du chmabre";
            this.descriptionToolStripMenuItem.Click += new System.EventHandler(this.descriptionToolStripMenuItem_Click);
            // 
            // ucChambre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::GestionReservationHotel.Properties.Resources.open;
            this.ContextMenuStrip = this.menuStrip;
            this.Controls.Add(this.idChambrelbl);
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "ucChambre";
            this.Size = new System.Drawing.Size(140, 108);
            this.Load += new System.EventHandler(this.ucChambre_Load);
            this.menuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idChambrelbl;
        private System.Windows.Forms.ContextMenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem libererToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reserverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descriptionToolStripMenuItem;
    }
}
