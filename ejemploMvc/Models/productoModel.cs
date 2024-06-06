using System;

namespace ejemploMvc.Models
{
    public class productoModel
    {
        public Guid Id { get; set; } = Guid.Empty;
        public string Nombre { get; set; } = string.Empty;
        public decimal Precio { get; set; } = 0;
    }
}