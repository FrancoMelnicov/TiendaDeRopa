using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaRopa
{
    class Pantalon:Prenda
    {
        private bool comunes, chupin;

        //getters y setters
        public bool Comunes
        {
            set
            {
                comunes = value;
            }

            get
            {
                return comunes;
            }
        }

        public bool Chupin
        {
            set
            {
                chupin = value;
            }

            get
            {
                return chupin;
            }
        }

        //metodo constructor
        public Pantalon(bool standar, bool premium, float precio, int cantStock, bool comunes, bool chupin)
        {
            this.standar = standar;
            this.premium = premium;
            this.precio = precio;
            this.cantStock = cantStock;
            this.comunes = comunes;
            this.chupin = chupin;
        }
    }
}
