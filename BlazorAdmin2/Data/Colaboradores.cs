using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace BlazorAdmin2.Data
{
    [Table("colaboradores")]
    public class Colaboradores
    {
        [ExplicitKey]
        public int idcolaborador { get; set; }
        public int idservico { get; set; }
        public int idprofissao { get; set; }
        public string nome { get; set; }
        public string Username { get; set; }
        public string Password  { get; set; }
        public string permissoes { get; set; }
        public int ganhoph { get; set; }
        public int telefone { get; set; }
        public string email { get; set; }
        public int comissao { get; set; }


    }
}
