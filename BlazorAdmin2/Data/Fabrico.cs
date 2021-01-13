using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace BlazorAdmin2.Data
{
    [Table("fabrico")]
    public class Fabrico
    {
        [ExplicitKey]
        public  int idfabrico { get; set; }
    }
}
