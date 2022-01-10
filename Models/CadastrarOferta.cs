using System.ComponentModel.DataAnnotations;

namespace AgenciaExplorer.Models
{
    public class CadastrarOferta
    {
        [Key]
        public int Id_Oferta { get; set; }
        public string Nome_Carro { get; set;}
        public string Preco { get; set; }

    }
}
