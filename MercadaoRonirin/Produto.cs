using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadaoRonirin
{
    internal class Produto
    {
    }
    public class Produtin
    {
        public string CodigoBarras { get; set; }
        public string Nome { get; set; }
        public decimal ValorUnitario { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorTotal => ValorUnitario * Quantidade;
    }

}
