using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRopa.Dtos.Post.DatosInventario
{
    public class DetalleVentaPDto
    {
        public int Id { get; set; }
        public int Cantidad { get; set; }
        public double ValorUnit { get; set; }
        public int IdVentaFk { get; set; }
        public int IdProducInveFk { get; set; }
        public int IdTallaFk { get; set; }
    }
}