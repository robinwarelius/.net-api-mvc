using System.ComponentModel.DataAnnotations;

namespace InlamningsUppgiftFixxo.ViewModels;

public class ProductAddRequestViewModel
{
    [Required]
    public string? Title { get; set; }

    [Required]
    public double? Price { get; set; }

    [Required]
    public int? Rating { get; set; }

    [Required]
    public string? ImageUrl { get; set; }

    [Required]
    public string? Details { get; set; }

    [Required]
    public int? SKU { get; set; }

    [Required]
    public string? Brand { get; set; }

    [Required]
    public DateTime? Date { get; set; }

    [Required]
    public string? Color { get; set; }

    [Required]
    public Guid? CategoryId { get; set; }
}

       

