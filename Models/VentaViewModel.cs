﻿namespace Gaming_Store.Models
{
    public class VentaViewModel
    {
        public int IdVenta { get; set; }

        public string? NumeroVenta { get; set; }

        public int? IdTipoDocumentoVenta { get; set; }

        public int? IdUsuario { get; set; }

        public string? Usuario { get; set; }

        public string? DocumentoCliente { get; set; }

        public string? NombreCliente { get; set; }

        public decimal? SubTotal { get; set; }

        public decimal? ImpuestoTotal { get; set; }

        public decimal? Total { get; set; }

        public DateTime? FechaRegistro { get; set; }

        
    
    }
    
}
