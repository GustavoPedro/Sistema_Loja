using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeBStudio.Control.DTO
{
    public class EnvelopeDTO
    {
        public int IdEnvelope { get; set; }
        public bool Baixa { get; set; }
        public int IdCliente { get; set; }
        public string Observacao { get; set; }
        public decimal Preco { get; set; }
        public decimal Sinal { get; set; }
        public decimal Total { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string DataEntrada { get; set; }
        public string DataEntrega { get; set; }
        public string  Atend { get; set; }
        public string FormaPagamento { get; set; }
     
    }
}
