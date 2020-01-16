using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantPOO
{
    public class Restaurant
    {
        private Cuisine _cuisine;
        private Trésorerie _trésorerie;
        private Client[] _clients;
        private Salle _salle;
        private Employé[] _employés;
        private Menu _menu;

        public void AccueillirClients(params Client[] clients)
        {
            // Ajouter un client au restaurant
        }
    }
}