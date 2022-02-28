using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blazor.Entidades;

public class ProductoDetalles
{

    [Key]
    public int ProductoDetallesId { get; set; }

    [Required]
    [MaxLength(50, ErrorMessage = "La descripcion no puede exceder {1} caracteres")]
    [MinLength(3, ErrorMessage = "La descripcion al menos {1} caracteres")]
    public string? Presentacion { get; set; }

    [Required]
    [Range(0, float.MaxValue, ErrorMessage = "El costo debe ser mayor a {1} y menor a {2}")]
    public float? Cantidad { get; set; }

    [Required]
    [Range(0, float.MaxValue, ErrorMessage = "El costo debe ser mayor a {1} y menor a {2}")]
    public float? Costo { get; set; }

    [Required]
    [Range(0, float.MaxValue, ErrorMessage = "El precio debe ser mayor a {1} y menor a {2}")]
    public float? Precio { get; set; }

    [Required]
    [Range(0, float.MaxValue, ErrorMessage = "El valor inventario debe ser mayor a {1} y menor a {2}")]
    public float? ValorInventario { get; set; }

    [Required]
    [Range(0, 100, ErrorMessage = "La existencia debe ser mayor a {1} y menor a {2}, porque es un %")]
    public float? Ganancia { get; set; }

    [ForeignKey("ProductoDetallesId")]
    public Productos? Producto { get; set; }

}