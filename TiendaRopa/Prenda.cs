using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaRopa
{
    class Prenda
    {
        protected bool standar, premium;
        protected float precio;
        protected int cantStock;

        //getters y setters
        public bool Standar
        {
            set
            {
                standar = value;
            }

            get
            {
                return standar;
            }
        }

        public bool Premium
        {
            set
            {
                premium = value;
            }

            get
            {
                return premium;
            }
        }
        public float Precio
        {
            set
            {
                precio = value;
            }

            get
            {
                return precio;
            }
        }
        public int CantStock
        {
            set
            {
                cantStock = value;
            }

            get
            {
                return cantStock;
            }
        }
    }
}
