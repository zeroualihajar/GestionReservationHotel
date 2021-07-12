using GestionReservationHotel.UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionReservationHotel
{
    public partial class Liberer : Form
    {
        public Liberer(int id)
        {
            InitializeComponent();
            lib(id);
        }

        public void lib(int id)
        {
            this.idChambre.Text = id.ToString();

            //---- Creer  la connexion vers la base des données
            SqlConnection connect = new SqlConnection(@"Data Source=localhost; Initial Catalog=ReservationHotel; Integrated Security =True");

            //---- Ouvrir la connexion
            connect.Open();

            List<reservation> listRes = new List<reservation>();

            //---- Declarer la requete de selection du reservation selon son id de la chambre
            SqlCommand cmd = new SqlCommand("SELECT * From reservation res WHERE res.idchambre = " + id, connect);

            //---- Exécuter la  commande sur la base de données 
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                reservation reserv = new reservation();
                reserv.idreservation = int.Parse(reader.GetValue(0).ToString());
                reserv.idclient = int.Parse(reader.GetValue(4).ToString());
                listRes.Add(reserv);
            }
            reader.Close();

            if(listRes.Count == 0)
            {
                MessageBox.Show("Pas de Reseravtion pour cette chambre");
                
                //---- Fermer la connexion
                connect.Close();
                this.Dispose();
            }
            else
            {
                List<client> listClt = new List<client>();

                foreach (reservation res in listRes)
                {
                    //---- Declarer la requete de selection du client selon son id
                    SqlCommand cmd2 = new SqlCommand("SELECT * From client cl WHERE cl.idclient = " + res.idclient, connect);

                    //---- Exécuter la  commande sur la base de données 
                    SqlDataReader read = cmd2.ExecuteReader();

                    while (read.Read())
                    {
                        client cl = new client();
                        cl.idclient = int.Parse(read.GetValue(0).ToString());
                        cl.nomclient = (string)read.GetValue(1);
                        cl.prenomclient = (string)read.GetValue(2);
                        listClt.Add(cl);
                    }

                    read.Close();
                }

                foreach (reservation rs in listRes)
                {
                    foreach (client cl in listClt)
                    {
                        if (rs.idclient == cl.idclient)
                        {
                            ucClient uc = new ucClient();
                            uc.id = (int)rs.idreservation;
                            uc.nom = cl.nomclient;
                            uc.prenom = cl.prenomclient;
                            flowPanel.Controls.Add(uc);
                        }
                    }
                }

                //---- Fermer la connexion
                connect.Close();
            }
        }
    }
}
