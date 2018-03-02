using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Senai.Ifood.Domain.Entities
{
    public class ClienteDomain : BaseDomain
    {
        [Required]
        [StringLength(100, MinimumLength = 5)]
        public string Nome { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 2)]
        public string Sexo { get; set; }


        [Required]
        [ForeignKey("UsuarioId")]
        public UsuarioDomain Usuario { get; set; }

        [Required]
        public int UsuarioId { get; set; }
    }
}