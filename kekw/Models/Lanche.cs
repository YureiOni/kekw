using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kekw.Models
{
    public class Lanche
    {
        public int LancheId { get; set; }
        public string  Nome { get; set; }
        public string  DestricaoCurta { get; set; }
        public string DescricaoDetalhada { get; set; }
        public decimal Preco { get; set; }
        public string ImagemUrl { get; set; }
        public string  ImagemThumbnail { get; set; }
        public bool IsLanchePreferido { get; set; }
        public bool Estoque { get; set; }

        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
