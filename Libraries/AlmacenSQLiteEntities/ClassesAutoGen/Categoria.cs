using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AlmacenSQLiteEntities
{
    [Table("Categoria")]
    public class Categoria
    {
        [Key]
        [Column(TypeName = "int")]
        public int? CategoriaId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        [StringLength(50)]
        public string Nombre { get; set; } = null!;

        [Column(TypeName = "ntext")]
        public string Descripcion { get; set; } = null!;

        [InverseProperty("Categoria")]
        public virtual ICollection<Material>? Materiales { get; set; }
    }
}
