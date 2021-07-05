using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionReservationHotel.Model
{
    class Client
    {
        public int idClient { get; set; }
        public string nomClient { get; set; }
        public string prenomClient { get; set; }
        public int telephone { get; set; }

        public Client(string nom, string prenom, int telephone)
        {
            this.nomClient = nom;
            this.prenomClient = prenom;
            this.telephone = telephone;
        }


    }
}
