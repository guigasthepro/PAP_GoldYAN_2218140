using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace BlazorAdmin2.Data
{
    [Table("unidades")]
    public class Unidades
    {
        [ExplicitKey]
        public int idunidade { get; set; }
        public string indice { get; set; }
        public string descricao { get; set; }
    }
}
