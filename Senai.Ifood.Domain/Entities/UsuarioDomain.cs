using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Senai.Ifood.Domain.Entities
{
    public class UsuarioDomain : BaseDomain
    {
        [Required]
        [StringLength(40, MinimumLength = 5)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [StringLength(12, MinimumLength=4)]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        public ICollection<UsuarioPermissaoDomain> UsuariosPermissoes { get; set; }
        public ICollection<RestauranteDomain> Restaurantes { get; set; }
    }
}