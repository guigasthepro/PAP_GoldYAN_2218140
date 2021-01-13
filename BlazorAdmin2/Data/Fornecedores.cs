using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace BlazorAdmin2.Data
{
    [Table ("fornecedores")]
    public class Fornecedores
    {
        //Cabeçalho Encomenda//
        [ExplicitKey]
        [Required]
        public int idfornecedorr { get; set; }
        [Required]
        public int idbanco { get; set; }
        [Required]
        public string alcunhafornecedor { get; set; }
        public string nomefornecedor { get; set; }
        public int datacriada { get; set; }
        public int telemovel { get; set; }
        public int telefone { get; set; }
        public string morada { get; set; }
        public int idcodigopostal { get; set; }
        public int nif { get; set; }
        public string iban { get; set; }
    }
}
