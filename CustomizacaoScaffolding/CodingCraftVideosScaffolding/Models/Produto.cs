using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodingCraftVideosScaffolding.Models
{
    [Table("Produtos")]
    [DisplayColumn("Nome")]
    public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }
        public int CategoriaId { get; set; }

        [Required]
        public String Nome { get; set; }

        public virtual Categoria Categoria { get; set; }
    }
}