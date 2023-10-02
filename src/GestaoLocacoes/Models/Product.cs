using System.ComponentModel.DataAnnotations;

namespace GestaoLocacoes.Models;

public class Product
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public required string Categorie { get; set; }
    public decimal RentPriceByDay { get; set; }
}
