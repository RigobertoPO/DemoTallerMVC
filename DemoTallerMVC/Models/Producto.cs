namespace DemoTallerMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Productos")]
    public partial class Producto
    {
        public Guid Id { get; set; }

        [StringLength(200)]
        public string Nombre { get; set; }

        public decimal? Precio { get; set; }

        public int? Existencia { get; set; }

        public int? IdMarca { get; set; }

        public virtual Marca Marca { get; set; }
    }
}
