using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Senai.Ifood.Domain.Entities
{
    public class EspecialidadeDomain : BaseDomain
    {
        [Required]
        [StringLength(50, MinimumLength = 4)]
        public string Nome { get; set; }

        public ICollection<RestauranteDomain> Restaurantes { get; set; }
    }
}