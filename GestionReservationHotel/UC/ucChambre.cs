using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionReservationHotel
{
    public partial class ucChambre : UserControl
    {
        DCDataContext bd = new DCDataContext();
        public int idChambre { get; set; }
        
        public ucChambre()
        {
            InitializeComponent();
        }

        private void ucChambre_Load(object sender, EventArgs e)
        {
            idChambrelbl.Text = idChambre.ToString();
        }


        
        private void reserverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formulaire form = new Formulaire(idChambre);
            form.Visible = true;
            
        }

        private void descriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            description des = new description(idChambre);
            des.Visible = true;
        }

        private void libererToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Liberer lib = new Liberer(this.idChambre);
                lib.Visible = true;
            }
            catch
            {

            }
            
            

            //this.BackgroundImage = global::GestionReservationHotel.Properties.Resources.open;


        }

        private void detailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Information info = new Information(idChambre);
           // info.Visible = true;
        }
    }
}
