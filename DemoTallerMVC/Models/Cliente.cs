namespace DemoTallerMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cliente
    {
        public Guid Id { get; set; }

        [StringLength(13)]
        public string RFC { get; set; }

        [StringLength(120)]
        public string Nombre { get; set; }

        [StringLength(10)]
        public string Telefono { get; set; }

        [StringLength(50)]
        public string Correo { get; set; }
    }
}
