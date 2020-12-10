﻿using System;
using System.Collections.Generic;

namespace Requestnet.Infrastructure
{
    public partial class Marca
    {
        public Marca()
        {
            InventarioEquipos = new HashSet<InventarioEquipos>();
        }

        public int IdMarca { get; set; }

        public virtual ICollection<InventarioEquipos> InventarioEquipos { get; set; }
    }
}