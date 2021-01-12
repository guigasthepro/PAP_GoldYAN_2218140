using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAdmin2.Data
{
    [Table ("molde")]
    public class Moldes
    {
        [ExplicitKey]
        public int idmolde { get; set; }
        public string codigo { get; set; }
        public string descricao { get; set; }
        public int idfproduto { get; set; }
        public int Gaveta { get; set; }
        public DateTime tempo { get; set; }
        public int peso { get; set; }
    }
}
