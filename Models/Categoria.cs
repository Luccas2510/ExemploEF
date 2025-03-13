using System.ComponentModel.DataAnnotations;

namespace ExemploEF.Models
{
    public class Categoria
    {
        [Key]
        public Guid CategoriaId { get; set; }
        public string Nome { get; set; }
        //Ralacionando as entidades Produto e Categoria (1 Categoria - N Produtos)
        //Cada categoria pode conter muitos produtos
        public IEnumerable<Produto>? Produtos { get; set; }
    }
}
