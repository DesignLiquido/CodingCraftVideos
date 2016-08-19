using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CodingCraftVideosScaffolding.Models
{
    [DisplayColumn("Nome")]
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }

        [Required]
        public string Nome { get; set; }

        public virtual ICollection<Produto> Produtos { get; set; }
    }
}