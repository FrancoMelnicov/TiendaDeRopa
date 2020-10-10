using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaRopa
{
    class Camisa: Prenda
    {
        private bool mangaCorta, cuelloMao;

        //getters y setters
        public bool MangaCorta
        {
            set
            {
                mangaCorta = value;
            }

            get
            {
                return mangaCorta;
            }
        }

        public bool CuelloMao
        {
            set
            {
                cuelloMao = value;
            }

            get
            {
                return cuelloMao;
            }
        }

        public Camisa(bool standar, bool premium, float precio, int cantStock, bool mangaCorta, bool cuelloMao)
        {
            this.standar = standar;
            this.premium = premium;
            this.precio = precio;
            this.cantStock = cantStock;
            this.mangaCorta = mangaCorta;
            this.cuelloMao = cuelloMao;
        }
    }
}
