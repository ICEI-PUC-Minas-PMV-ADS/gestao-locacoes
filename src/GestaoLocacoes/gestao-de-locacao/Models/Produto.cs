using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gestao_de_locacao.Models
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Nome!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a Descrição!")]
        public string Descrição { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Ano de Categoria!")]
        public string Categoria { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Ano do Preço!")]
        public int Preço { get; set; }
    }
}
