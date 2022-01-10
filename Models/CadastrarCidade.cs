using System.ComponentModel.DataAnnotations;

namespace AgenciaExplorer.Models
{
    public class CadastrarCidade
    {
        [Key]
        public int Id_Cidade { get; set; }
        public string Nome_Cidade { get; set; }
        public string Valor { get; set; }
        public string Moeda { get; set; }
        public virtual List<Comprar> Comprar { get; set; }
    }
}
