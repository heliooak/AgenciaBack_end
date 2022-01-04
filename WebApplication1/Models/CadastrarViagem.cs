using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class CadastrarViagem
    {
        [Key]
        public int Id_Pacote { get; set; }
        public string Nome_Cidade { get; set; }
        public string Preco { get; set; }
    }
}
