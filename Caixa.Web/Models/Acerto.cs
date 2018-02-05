﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Caixa.Web.Models
{
    [Table("Acerto")]
    public class Acerto
    {
        public int Id { get; set; }

        public float Entrada { get; set; }
        public float Saida { get; set; }
        public float? Subtotal { get; set; }

        [Display(Name ="Comissão")]
        public float? Comissao { get; set; }
        public float? Quebra { get; set; }
        public float? Despesa { get; set; }
        public float? Total { get; set; }
        public DateTime Data { get; set; }

        [Display(Name = "Máquina")]
        [ForeignKey("Maquina")]
        public int IdMaquina { get; set; }
        public Maquinas Maquina { get; set; }

        [Display(Name = "Estabelecimento")]
        [ForeignKey("Estabelecimento")]
        public int IdEstabelecimento { get; set; }
        public Estabelecimentos Estabelecimento { get; set; }
    }
}