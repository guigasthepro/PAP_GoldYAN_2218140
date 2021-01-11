using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace BlazorAdmin2.Data
{
    public class Encomendas
    {
        //Formulário Encomenda
        [Required]
        public int IdCliente { get; set; }

        public int Telefone { get; set; }

        public string email { get; set; }

        public string morada { get; set; }

        public string CodigoPostal { get; set; }
    }
}
