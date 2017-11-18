﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL.Model.POCO
{
    public class Usuario
    {
        public int UsuarioId { get; set; } //CPF ou CNPJ
        public String Nome { get; set; }
        public String Email { get; set; }
        public String Senha { get; set; }
    }
}
