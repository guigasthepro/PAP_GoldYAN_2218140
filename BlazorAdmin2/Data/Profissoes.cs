using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace BlazorAdmin2.Data
{
    [Table("profissoes")]
    public class Profissoes
    {
        [ExplicitKey]
        public int idprofissao { get; set; }
        public string codigo { get; set; }
        public string nome { get; set; }
    }
}
