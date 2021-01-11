using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAdmin2.Data
{
    public class Modelos
    {
        [Required]
        public string referencia { get; set; }

        public string unidade { get; set; }
        public string descricao { get; set; }
        public string tipoproducao { get; set; }
        public string tipopeca { get; set; }
        public string fornecedor { get; set; }
        public string reffornecedor { get; set; }

    }
}
