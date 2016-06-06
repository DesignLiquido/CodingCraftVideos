using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASPNETIdentityChavesInt.Models
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        public Guid ProdutoId { get; set; }

        [Required]
        public String Nome { get; set; }
    }
}
