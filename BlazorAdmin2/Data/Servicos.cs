using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace BlazorAdmin2.Data
{
    [Table("servicos")]
    public class Servicos
    {   
        [ExplicitKey]
        public int idservico { get; set; }
        public int idfornecedor { get; set; }
        public int idunidade { get; set; }
        public string alcunha { get; set; }
        public string nomeservico { get; set; }
        public double custo  { get; set; }
    }
}
