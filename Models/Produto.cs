using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace e_shop.API.Models
{
    public class Produto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public string Tamanho { get; set; }
        public string Colecao { get; set; }
        public string Descricao { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Preco { get; set; }
        public string ImagemUrl { get; set; }
    }
}
