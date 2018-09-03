using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeBStudio.Control.DTO
{
   public class Produto
    {
        public int IdProduto  { get; set; }
        public int IdEnvelope { get; set; }
        public string NomeProduto { get; set; }        
        public int Qnt { get; set; }
        public string Cortes { get; set; }
        public decimal Total { get; set; }
        public decimal ValorUnit { get; set; }
        
    }
}
