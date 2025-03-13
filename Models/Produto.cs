using System.ComponentModel.DataAnnotations;

namespace ExemploEF.Models
{
    public class Produto
    {
        [Key]
        public Guid ProdutoId { get; set; }
        public string Nome { get; set; }
        public int Estoque { get; set; }
        //Ralacionando as entidades Produto e Categoria (1 Categoria - N Produtos)
        //Cada Produto pode pertencer apenas a uma categoria
        public Guid CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }
    }
}
