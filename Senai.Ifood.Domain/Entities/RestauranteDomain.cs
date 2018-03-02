using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Senai.Ifood.Domain.Entities
{
    public class RestauranteDomain : BaseDomain
    {
        [Required]
        [StringLength(30, MinimumLength = 2)]
        public string Nome { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 5)]
        public string Responsavel { get; set; }

        [StringLength(40, MinimumLength = 5)]
        public string Site { get; set; }

        [StringLength(11, MinimumLength = 10)]
        public string Telefone { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 5)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [ForeignKey("EspecialidadesId")]
        public EspecialidadeDomain Especialidades { get; set; }
        public int EspecialidadesId { get; set; }

        [ForeignKey("UsuarioId")]
        public UsuarioDomain Usuario { get; set; }
        public int UsuarioId { get; set; }

        public ICollection<ProdutoDomain> Produtos { get; set; }
    }
}