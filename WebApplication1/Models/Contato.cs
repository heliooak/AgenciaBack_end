using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Contato
    {
        [Key]
        public int Id_Contato { get; set; }
        public string Email { get; set; }
        public int Mensagem { get; set; }
    }
}
