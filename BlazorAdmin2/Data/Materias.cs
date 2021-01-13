using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace BlazorAdmin2.Data
{
    [Table("materias")]
    public class Materias
    {
        [ExplicitKey]
        public int idmateria { get; set; }
        public string alcunha { get; set; }
        public string nome { get; set; }
    }
}
