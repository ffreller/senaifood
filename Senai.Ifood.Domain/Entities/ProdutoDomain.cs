using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Senai.Ifood.Domain.Entities
{
    public class ProdutoDomain : BaseDomain
    {
        [Required]
        [StringLength(30, MinimumLength = 4)]
        public string Nome { get; set; }

        [StringLength(50, MinimumLength = 4)]
        public string Descricao { get; set; }

        [Required]
        public Boolean Ativo { get; set; }

        [Required]
        public decimal Valor { get; set; }
        
        [ForeignKey("RestauranteId")]
        public RestauranteDomain Restaurante { get; set; }
        public int RestauranteId { get; set; }
    }
}