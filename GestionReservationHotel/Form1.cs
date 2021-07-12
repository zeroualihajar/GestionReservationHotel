using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionReservationHotel
{
    public partial class Form1 : Form
    {
        DCDataContext bd = new DCDataContext();

        // Liste des chambres
        public List<chambre> GetChambres()
        {
            List<chambre> chambres = bd.chambre.ToList();
            return chambres;
        }

        public void afficher()
        {
            foreach (chambre ch in GetChambres())
            {
                ucChambre uc = new ucChambre();
                uc.idChambre = int.Parse(ch.idchambre.ToString());
                /*if (Exist(uc.idChambre))
                {
                    uc.BackgroundImage = global::GestionReservationHotel.Properties.Resources.close;
                }*/
                flowPanel.Controls.Add(uc);
            }
            
        }

        public Form1()
        {
            InitializeComponent();
            afficher();
        }

        //---- Verifier si la chambre est reserve
        public bool Exist(int id)
        {
            List<reservation> res = new List<reservation>();
            res = bd.reservation.ToList();

            foreach (reservation r in res)
            {
                if (r.idchambre == id) return true;
            }
            return false;
        }
    }
}
