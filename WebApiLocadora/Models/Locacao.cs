using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiLocadora.Models
{
    public class Locacao
    {
        [Key]
        public int IdLocacao { get; set; }
        [Column("DataLocacao")]
        public DateTime DataDeLocacao { get; set; }
        [Column("DataEntrega")]
        public DateTime DataDeEntrega { get; set; }
        public  Cliente Cliente { get; set; }
        public Filme Filme { get; set; }
    }
}
