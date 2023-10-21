using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace Banco_De_Dados_da_Locação.Models
{
    [Table("Produtos")]
    public class Produtos
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Nome")]

        public String Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a Descrição")]

        public String Descrição { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a Categoria")]

        public  String Categoria { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Aluguel")]

        public String Aluguel { get; set; }
    }
}
