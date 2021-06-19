using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dio.Web.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}
