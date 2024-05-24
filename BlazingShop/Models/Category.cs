using System.ComponentModel.DataAnnotations;

namespace BlazingShop.Models;

public class Category
{
    [Key]
    [Required(ErrorMessage = "Id é obrigatório")]
    public int Id { get; set; }

    [Required(ErrorMessage = "Título é obrigatório")]
    [MaxLength(50, ErrorMessage = "Título deve ter no máximo 5 e 50 caracteres")]
    [MinLength(5, ErrorMessage = "Título deve ter no mínimo 5 e 50 caracteres")]
    public string Title { get; set; } = string.Empty;

    public List<Product> Products { get; set; } = new();
}
