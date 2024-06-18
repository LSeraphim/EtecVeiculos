using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EtecVeiculos.Api.Models
{
    public class Marca
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "Nome")]
        public string Nome { get; set; }
    }
}