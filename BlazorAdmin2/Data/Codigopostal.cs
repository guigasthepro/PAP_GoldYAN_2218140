using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace BlazorAdmin2.Data
{
    [Table("codigopostal")]
    public class Codigopostal
    {
        [ExplicitKey]
        public int idcodigopostal { get; set; }
        public string codigopostal { get; set; }
        public string descricao { get; set; }
    }
}
