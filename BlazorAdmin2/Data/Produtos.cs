using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAdmin2.Data
{
    [Table("produtos")]
    public class Produtos
    {
        [ExplicitKey]
        public int produtoid { get; set; }
        public int idfornecedor{ get; set; }
        public int idfabrico { get; set; }
        public string alcunha { get; set; }
        public string nome { get; set; }
        public int quantidade{ get; set; }
        public string contrastaria { get; set; }
        public int preco { get; set; }
        public int pvp { get; set; }
        public int customedio { get; set; }
        public int feitio { get; set; }
        public int feitiograma { get; set; }
        public int cotacao { get; set; }
    }
}
