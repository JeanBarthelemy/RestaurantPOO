using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantPOO
{
    public class Menu
    {
        private Plat[] _plats;

        public Plat[] Consulter()
        {
            return _plats;
        }
    }
}