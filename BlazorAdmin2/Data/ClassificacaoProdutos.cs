using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace BlazorAdmin2.Data
{
    public class ClassificacaoProdutos
    {

        [ExplicitKey]
        public int classificacaoid { get; set; }
        public int codigo { get; set; }
        public string descricao { get; set; }
        public string codigoat { get; set; }
        public bool inventario { get; set; }
    }
}
