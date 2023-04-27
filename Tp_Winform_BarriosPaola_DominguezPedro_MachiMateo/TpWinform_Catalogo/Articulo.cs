﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpWinform_Catalogo
{
    internal class Articulo
    {
        public int codigoArticulo { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public Marca Marca { get; set; }
        public  Categoria Categoria { get; set; }
        public string urlImagen { get; set; }
        public decimal precio { get; set; }

    

        

    }
}
