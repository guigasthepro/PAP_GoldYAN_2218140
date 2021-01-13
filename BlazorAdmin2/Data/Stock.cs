using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace BlazorAdmin2.Data
{
    [Table("stock")]
    public class Stock
    {
        [ExplicitKey]
        public int idstock { get; set; }
        public int idproduto { get; set; }
        public int quantidade { get; set; }

    }
}
