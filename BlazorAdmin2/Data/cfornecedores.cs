using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace BlazorAdmin2.Data
{
    public class cfornecedores
    {
        //Cabeçalho Encomenda//
        [Required]
        public string CodigoFornecedor { get; set; }

        [Required]
        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        //Formulario Encomenda//

        public string designacao { get; set; }
        public int telefone { get; set; }
        public int telemovel { get; set; }
        public string morada { get; set; }
        public string codigopostal { get; set; }
        public string pais { get; set; }
        public string email { get; set; }
        public string apontamentos { get; set; }

    }
}
