using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kekw.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string CategoriaNome { get; set; }
        public string Destricao { get; set; }
        public List<Lanche> Lanches { get; set; }
    }
}
