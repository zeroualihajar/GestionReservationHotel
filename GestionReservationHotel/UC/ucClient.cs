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

namespace GestionReservationHotel.UC
{
    public partial class ucClient : UserControl
    {
        public int id;
        public string nom;
        public string prenom;

        public ucClient()
        {
            InitializeComponent();

        }

        private void ucClient_Load(object sender, EventArgs e)
        {
            this.idRes.Text = id.ToString();
            this.lblNom.Text = nom;
            this.lblPrenom.Text = prenom; ;
        }

        private void ucClient_DoubleClick(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Vous etes sur de la suppression ?","Supprimer la reservation", MessageBoxButtons.YesNo);
            if(confirm == DialogResult.Yes)
            {
                //---- Creer  la connexion vers la base des données
                SqlConnection connect = new SqlConnection(@"Data Source=localhost; Initial Catalog=ReservationHotel; Integrated Security =True");

                //---- Ouvrir la connexion
                connect.Open();


                //---- Declarer la requete de Liberation du chambre
                SqlCommand cmd = new SqlCommand("DELETE  From reservation WHERE idreservation = " + this.id, connect);

                cmd.ExecuteNonQuery();

                //---- Fermer la connexion
                connect.Close();
            }
            
            
        }
    }
}
