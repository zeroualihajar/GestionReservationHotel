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
    public partial class Information : Form
    {
        public Information(int idChambre)
        {
            InitializeComponent();
            info(idChambre);
        }

        public void info(int idChambre)
        {
            //---- Creer  la connexion vers la base des données
            SqlConnection connect = new SqlConnection(@"Data Source=localhost; Initial Catalog=ReservationHotel; Integrated Security =True");

            connect.Open();
            try
            {
                //---- La selection du reservation via l'id du chambre
                reservation rs = new reservation();
                rs = getReservationById(idChambre, connect);

                if(rs == null)
                {
                    MessageBox.Show("Cette Chambre n'est pas encore reserve");
                    return;
                }
                else
                {
                    //---- get Client 
                    client clt = new client();
                    clt = getClientByID((int)rs.idclient, connect);


                    lblId.Text = clt.idclient.ToString();
                    lblNom.Text = clt.nomclient.ToString();
                    lblPrenom.Text = clt.prenomclient.ToString();
                    lblTel.Text = clt.telephone.ToString();
                    lblIdChambre.Text = rs.idchambre.ToString();
                    lblMontant.Text = rs.montant.ToString();

                    this.Visible = true;

                    //---- Fermer la connexion
                    connect.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Cette Chambre n'est pas encore reserve");
                this.Dispose();
            }

            
        }

        public reservation getReservationById(int id , SqlConnection connect)
        {
            reservation rs = new reservation();
            
            //---- Declarer la requete de selection d'une reservation
            SqlCommand cmd = new SqlCommand("SELECT * From reservation rs WHERE rs.idchambre = " + id, connect);

            //---- Exécuter la  commande sur la base de données 
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                rs.idreservation = int.Parse(reader.GetValue(0).ToString());
                rs.debutreservation = (DateTime)reader.GetValue(1);
                rs.finreservation = (DateTime)reader.GetValue(2);
                rs.montant = float.Parse(reader.GetValue(3).ToString());
                rs.idclient = int.Parse(reader.GetValue(4).ToString());
                rs.idchambre = int.Parse(reader.GetValue(5).ToString());
               
                reader.Close();
                return rs;
            }
            reader.Close();
            return null;
        }

        public client getClientByID(int id, SqlConnection connect)
        {
            client c = new client();
            //---- Declarer la requete de selection du client
            SqlCommand cmd = new SqlCommand("SELECT * From client c WHERE c.idclient = " + id, connect);

            //---- Exécuter la  commande sur la base de données 
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                c.idclient = int.Parse(reader.GetValue(0).ToString());
                c.nomclient = (string)reader.GetValue(1);
                c.prenomclient = (string)reader.GetValue(2);
                c.telephone = int.Parse(reader.GetValue(3).ToString());
                 
                reader.Close();
                return c;
            }
            reader.Close();
            return null;

        }
    }
}
