using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApiLocadora.DTO
{
    public class FilmeDTO
    {
        public string Name { get; set; } = string.Empty;
        public float Preco { get; set; }
        public string Categoria { get; set; } = string.Empty;
        public int Quantidade { get; set; }
        public bool Disponivel { get; set; }
    }
}
