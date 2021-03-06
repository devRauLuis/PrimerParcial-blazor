using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blazor.Entidades;
public class Productos
{
    [Key]
    public int ProductoId { get; set; }

    [Required(ErrorMessage = "La descripcion es obligatoria")]
    [MinLength(3, ErrorMessage = "La descripcion al menos {1} caracteres")]
    [MaxLength(50, ErrorMessage = "La descripcion no puede exceder {1} caracteres")]
    public string? Descripcion { get; set; }

    [Required]
    [Range(0, int.MaxValue, ErrorMessage = "El precio debe ser mayor a {1} y menor a {2}")]
    public int Existencia { get; set; }

    [Required]
    [Range(0, float.MaxValue, ErrorMessage = "El costo debe ser mayor a {1} y menor a {2}")]
    public float Costo { get; set; }

    [Required]
    [Range(0, float.MaxValue, ErrorMessage = "El costo debe ser mayor a {1} y menor a {2}")]
    public float ValorInventario { get; set; }

    [Required]
    [Range(1, float.MaxValue, ErrorMessage = "El precio debe ser mayor a {1} y menor a {2}")]
    public float Precio { get; set; }

    [Required]
    [Range(0.01, 100, ErrorMessage = "La ganancia debe ser mayor a {1} y menor a {2}")]
    public float Ganancia { get; set; }

    [ForeignKey("ProductoId")]
    public virtual List<ProductoDetalles> ProductoDetalles { get; set; } = new List<ProductoDetalles>();

}