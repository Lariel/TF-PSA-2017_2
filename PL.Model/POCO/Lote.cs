﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL.Model.POCO
{
    public class Lote
    {
        public int LoteId { get; set; }
        public virtual ICollection<Bem> Bens { get; set; }
    }
}
