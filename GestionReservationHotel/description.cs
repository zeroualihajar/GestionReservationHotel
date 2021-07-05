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
    public partial class description : Form
    {
        public description(int idChambre)
        {
            InitializeComponent();
            des(idChambre);
        }

        public void des(int idChambre)
        {
            //---- Creer  la connexion vers la base des données
            SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-7N0GOOF; Initial Catalog=ReservationHotel; Integrated Security =True");

            //---- Ouvrir la connexion
            connect.Open();

            //---- La requete de selection du chambre
            chambre ch = new chambre();
            ch = getChambreById(idChambre, connect);

            hotel ht = new hotel();
            ht = getHotelById((int)ch.idhotel, connect);
            
            //---- Fermer la connexion
            connect.Close();


            lblId.Text = ch.idchambre.ToString();
            lblEtage.Text = ch.etage.ToString();
            lblCategorie.Text = ch.typechambre.ToString();
            lblHotel.Text = ht.nomhotel.ToString();
            lblPrix.Text = ch.prix.ToString();

        }

        public chambre getChambreById(int idCh, SqlConnection connect)
        {
            chambre ch = new chambre();

            //---- Declarer la requete d'insertion du client
            SqlCommand cmd = new SqlCommand("SELECT * From chambre ch WHERE ch.idchambre = " + idCh, connect);

            //---- Exécuter la  commande sur la base de données 
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                ch.idchambre = int.Parse(reader.GetValue(0).ToString());
                ch.etage = (string)reader.GetValue(1);
                ch.typechambre = (string)reader.GetValue(2);
                ch.idhotel = int.Parse(reader.GetValue(3).ToString());
                ch.prix = float.Parse(reader.GetValue(4).ToString());
                reader.Close();
                return ch;
            }
            reader.Close();
            return null;

        }

        public hotel getHotelById(int idHot, SqlConnection connect)
        {
            hotel ht = new hotel();

            //---- Declarer la requete d'insertion du client
            SqlCommand cmd = new SqlCommand("SELECT * From hotel h WHERE h.idhotel = " + idHot, connect);

            //---- Exécuter la  commande sur la base de données 
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ht.idhotel = int.Parse(reader.GetValue(0).ToString());
                ht.nomhotel = (string)reader.GetValue(1);
                ht.adresse = (string)reader.GetValue(2);
                
                reader.Close();
                return ht;
            }
            reader.Close();
            return null;

        }
    }
}
