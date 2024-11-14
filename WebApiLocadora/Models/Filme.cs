using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiLocadora.Models
{
    [Table("filmes")]
    public class Filme
    {
        [Key]
        public int Id { get; set; }

        [Column("Name")]
        public string Name { get; set; } = string.Empty;

        [Column("Price")]
        public float Preco { get; set; }
        [Column("Categoria")]
        public string Categoria { get; set; } = string.Empty;
        [Column("Quantity")]
        public int Quantidade { get; set; }
        [Column("Disponivel")]
        public bool Disponivel {  get; set; }
        public ICollection<Locacao> Locacoes { get; set; }


    }
}
