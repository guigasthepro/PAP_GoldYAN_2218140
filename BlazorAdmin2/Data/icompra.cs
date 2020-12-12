using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BlazorAdmin2.Data
{
    public class icompra
    {
        //Cabeçalho Compra//
        [Required]
        public string Fornecedor { get; set; }

        [Required]
        public int Numero { get; set; }

        public string Pagamento { get; set; }

        public DateTime Data { get; set; }

        public string Vencimento { get; set; }

        public void DataAgora()
        {
            Data = DateTime.Now;
        }



    }

}
