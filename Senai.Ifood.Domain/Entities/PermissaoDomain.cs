using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Senai.Ifood.Domain.Entities
{
    public class PermissaoDomain : BaseDomain
    {
        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string Nome { get; set; }

        public ICollection<UsuarioPermissaoDomain> UsuariosPermissoes { get; set; }
    }
}