using GestionReservationHotel.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionReservationHotel
{
    public partial class Formulaire : Form
    {
        public int idCh;

        //---- Creer  la connexion vers la base des données
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-7N0GOOF; Initial Catalog=ReservationHotel; Integrated Security =True");
        public Formulaire(int idChambre)
        {
            idCh = idChambre;
            InitializeComponent();
        }

        private void reserver_Click(object sender, EventArgs e)
        {
            string nom = this.nomClienttxt.Text;
            string prenom = this.prenomClienttxt.Text;
            int telephone = int.Parse(this.telephonetxt.Text);

            DateTime debut = (DateTime)this.dateDebuttxt.Value;
            DateTime fin = (DateTime)this.dateFintxt.Value;


            if (existe(debut, fin, idCh, connect))
            {
                MessageBox.Show("Cette chambre est reserve pour cette date");
            }
            else
            {
                
                //----- get idClient
                int idClient = InsertClient(nom, prenom, telephone, connect);

                //----- get chambre 
                chambre c = getChambreById(idCh, connect);

                
                //---- Calcule de nombre de jours pour calculer le montant total
                TimeSpan duration = fin > debut ? fin - debut : debut - fin;
                double nbrJours = duration.TotalDays;
                double montant = nbrJours * (double)c.prix;


                Reservation res = new Reservation(debut, fin, montant, idClient, int.Parse(c.idchambre.ToString()));

                //---- Declarer la requete d'insertion du client
                SqlCommand cmd2 = new SqlCommand("INSERT INTO reservation VALUES ('" + res.debut + "', '" + res.fin + "', '" + montant + "', '" + res.idClient + "', '" + res.idChambre + "')", connect);

                //---- Executer la commande
                cmd2.ExecuteNonQuery();

                //---- Fermer la connexion
                connect.Close();
                this.Hide();
            }

        }

        private int InsertClient(string nom, string prenom, int telephone, SqlConnection connect)
        {
            int id = 0;
            //------ Insertion dans la base de client
            Client client = new Client(nom, prenom, telephone);
            
            //---- Declarer la requete d'insertion du client
            SqlCommand cmd = new SqlCommand("INSERT INTO client VALUES ('" + client.nomClient + "', '" + client.prenomClient + "' , '" + client.telephone + "')", connect);

            //---- Executer la commande
            cmd.ExecuteNonQuery();

            //---- Selectionnet l'id de client apres l'insertion
            SqlCommand cmd1 = new SqlCommand("SELECT c.idclient From client c", connect);

            //---- Exécuter la  commande sur la base de données 
            cmd1.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                id = int.Parse(dr["idclient"].ToString());
            }
            
            return id;
        }

        public chambre getChambreById(int idCh, SqlConnection connect)
        {
       
            chambre ch = new chambre();
            
            //---- Declarer la requete d'insertion du client
            SqlCommand cmd = new SqlCommand("SELECT * From chambre ch WHERE ch.idchambre = "+idCh, connect);

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

        private void annuler_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public bool existe(DateTime debut, DateTime fin, int id, SqlConnection connect)
        {
            
            connect.Close();
            
            //---- Ouvrir la connexion
            connect.Open();

            //---- Declarer la requete d'insertion du client
            
            SqlCommand cmd = new SqlCommand("SELECT * From reservation rs WHERE rs.idchambre = " + id, connect);

            //---- Exécuter la  commande sur la base de données 
            SqlDataReader reader = cmd.ExecuteReader();

            List<reservation> reservations = new List<reservation>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    reservation rs = new reservation();
                    rs.idreservation = int.Parse(reader.GetValue(0).ToString());
                    rs.debutreservation = (DateTime)reader.GetValue(1);
                    rs.finreservation = (DateTime)reader.GetValue(2);
                    rs.montant = float.Parse(reader.GetValue(3).ToString());
                    rs.idclient = int.Parse(reader.GetValue(4).ToString());
                    rs.idchambre = int.Parse(reader.GetValue(5).ToString());

                    reservations.Add(rs);
                    
                }
            }
            
            reader.Close();

            foreach (reservation res in reservations)
            {
                if ((res.debutreservation >= debut) && (res.finreservation <= fin))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
