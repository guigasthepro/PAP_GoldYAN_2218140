using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAdmin2.Data
{
    [Table ("modelos")]
    public class Modelos
    {
        [ExplicitKey]
        [Required]
        public int idmodelo { get; set; }
        public int idmolde { get; set; }
        public string alcunha { get; set; }
        public string nome { get; set; }
        public int idmateria { get; set; }
        public int idservicos { get; set; }
        public int produtoidf { get; set; }

    }
}
