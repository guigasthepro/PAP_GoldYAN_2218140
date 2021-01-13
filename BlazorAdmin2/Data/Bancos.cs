using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace BlazorAdmin2.Data
{
    [Table("bancos")]
    public class Bancos
    {
        [ExplicitKey]
        public int bancoid { get; set; }
        public string codigobanco { get; set; }
        public string nome { get; set; }
    }
}
