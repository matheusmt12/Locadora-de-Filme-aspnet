using System.ComponentModel.DataAnnotations;

namespace WebApiLocadora.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;
        public bool Active { get; set; }
        public ICollection<Locacao> Locacoes { get; set; }
    }
}
