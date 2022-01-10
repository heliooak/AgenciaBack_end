using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgenciaExplorer.Models
{
    public class Comprar
    {
        [Key]
        public int Id_Compra { get; set; }
        public string Email { get; set; }
        [ForeignKey("CadastrarCidade")]
        public int Id_Cidade { get; set; }
        public virtual CadastrarCidade CadastrarCidade { get; set; }
    }
}
