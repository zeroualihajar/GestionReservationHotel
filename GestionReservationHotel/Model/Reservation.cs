using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionReservationHotel.Model
{
    class Reservation
    {
        public DateTime debut { get; set; }
        public DateTime fin { get; set; }
        public float montant { get; set; }
        public int idClient { get; set; }
        public int idChambre { get; set; }

        public Reservation(DateTime debut, DateTime fin, double montant, int idClient, int idChambre)
        {

            this.debut = debut;
            this.fin = fin;
            this.montant = float.Parse(montant.ToString());
            this.idClient = idClient;
            this.idChambre = idChambre;
        }
        

    }
}
