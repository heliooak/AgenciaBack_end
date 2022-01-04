using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class CadastrarCliente
    {
        [Key]
        public int Id_Cliente { get; set; }
        public string Nome_Cliente { get; set; }
        public int CPF { get; set; }
        public string Email_Cliente { get; set; }
    }
}
