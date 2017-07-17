﻿using Modelo.Tabelas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Modelo.Cadastros
{
    public class Produto
    {
        public long? ProdutoId { get; set; }
        public string Nome { get; set; }

        public long? CategoriaID { get; set; }
        public long? FabricanteID { get; set; }

        public Categoria Categoria { get; set; }
        public Fabricante Fabricante { get; set; }
    }
}