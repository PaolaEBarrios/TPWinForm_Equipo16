﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public  class Articulo
    {
        public string codigoArticulo { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public Marca Marca { get; set; }
        //public string Marca { get; set; }
        public  Categoria Categoria { get; set; }
        //public string Categoria { get; set; }
        public string urlImagen { get; set; }
        public decimal precio { get; set; }

    

        

    }
}
