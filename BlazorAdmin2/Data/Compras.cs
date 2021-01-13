using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace BlazorAdmin2.Data
{
    [Table("faturas")]
    public class Compras
    {
        [ExplicitKey]
        public int idfatura { get; set; }
        public int idfornecedor { get; set; }
        public int idproduto { get; set; }
        public string tipo { get; set; }
        public int custo { get; set; }
        public int pago { get; set; }
        public int peso { get; set; }
        public int quantidade { get; set; }
        public int feitio { get; set; }
        public int cotacao { get; set; }
        public int pvp { get; set; }




    }
}
