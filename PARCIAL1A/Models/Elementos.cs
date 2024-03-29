﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PARCIAL1A.Models
{
    public class Elementos
    {
        [Key]
        public int ElementoID { get; set; }
        public int EmpresaID { get; set; }
        public string Elemento { get; set; }
        public int CantidadMinima { get; set; }
        public int UnidadMedida { get; set; }
        public decimal Costo { get; set; }
        public string Estado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime Fechamodificacion { get; set; }
        public string Inventario  { get; set; }
    }
}
