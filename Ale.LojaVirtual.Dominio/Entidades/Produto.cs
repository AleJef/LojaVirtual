﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ale.LojaVirtual.Dominio.Entidades
{
    public class Produto
    {
        public int ProdutId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public string Categoria { get; set; }
    }
}
