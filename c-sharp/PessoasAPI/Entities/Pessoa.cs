using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Commons_Core.Entities;

namespace PessoasAPI.Entities
{
    [Table("T_PESSOA")]
    public class Pessoa : BaseEntity
    {
        [Required]
        [Column(name: "NOME")]
        public string nome {get; set;}

        [Column(name: "IDADE")]
        public int idade {get; set;}
    }
}