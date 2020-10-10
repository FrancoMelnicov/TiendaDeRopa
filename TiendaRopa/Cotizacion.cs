using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaRopa
{
    class Cotizacion
    {
        private int id, codVendedor, cantUnidCot;
        private DateTime fecha;
        private float resultadoCot;
        private Pantalon pantalon;
        private Camisa camisa;

        //getters y setters
        public int Id
        {
            set
            {
                id = value;
            }

            get
            {
                return id;
            }
        }

        public int CodVendedor
        {
            set
            {
                codVendedor = value;
            }

            get
            {
                return codVendedor;
            }
        }

        public int CantUnidCot
        {
            set
            {
                cantUnidCot = value;
            }

            get
            {
                return cantUnidCot;
            }
        }
        public DateTime Fecha
        {
            set
            {
                fecha = value;
            }

            get
            {
                return fecha;
            }
        }
        public float ResultadoCot
        {
            set
            {
                resultadoCot = value;
            }

            get
            {
                return resultadoCot;
            }
        }
        public Pantalon Pantalon
        {
            set
            {
                pantalon = value;
            }

            get
            {
                return pantalon;
            }
        }
        public Camisa Camisa
        {
            set
            {
                camisa = value;
            }

            get
            {
                return camisa;
            }
        }

        //constructor con pantalon
        public Cotizacion(int codVendedor, int cantUnidCot, Pantalon pantalon)
        {
            this.codVendedor = codVendedor;
            this.cantUnidCot = cantUnidCot;
            this.pantalon = pantalon;
        }

        //constructor con camisa
        public Cotizacion(int codVendedor, int cantUnidCot, Camisa camisa)
        {
            this.codVendedor = codVendedor;
            this.cantUnidCot = cantUnidCot;
            this.camisa = camisa;
        }

        //metodo cotizar camisa
        public void cotizar(Camisa camisa)
        {
            if(camisa.MangaCorta == true)
            {
                camisa.Precio = camisa.Precio - ((camisa.Precio * 10) / 100);
            }
            
            if (camisa.CuelloMao == true)
            {
                camisa.Precio = camisa.Precio + ((camisa.Precio * 3) / 100);
            }
        }

        //metodo cotizar pantalon
        public void cotizar(Pantalon pantalon)
        {
            if(pantalon.Chupin == true)
            {
                pantalon.Precio = pantalon.Precio - ((pantalon.Precio * 12) / 100);
            }

            if(pantalon.Premium == true)
            {
                pantalon.Precio = pantalon.Precio + ((pantalon.Precio * 30) / 100);
            }
        }
    }
}
