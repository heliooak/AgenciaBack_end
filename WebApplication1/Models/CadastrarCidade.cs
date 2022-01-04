using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class CadastrarCidade
    {
        [Key]
        public int Id { get; set; }
        public string Nome_Cidade  { get; set; }
        public string Tipo_Moeda { get; set; }
        public string Preco { get; set; }
        public virtual List<Comprar> Comprar { get; set; }
    }
}
