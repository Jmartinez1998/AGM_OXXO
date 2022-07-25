﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OXXO.Models
{
    public class message
    {
        public bool status { get; set; }
        public string mensaje { get; set; }

        public bool permiso { get; set; }

        public List<Comercio> data { get; set; }
        public List<Documento> datad { get; set; }

        public List<Perfil> perfilPermisosData { get; set; }
    }


}
