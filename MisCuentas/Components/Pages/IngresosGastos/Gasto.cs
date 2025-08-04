using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisCuentas.Components.Pages.IngresosGastos
{
    public class Gasto
    {
        [Required]
        public decimal Monto { get; set; }

        public DateTime Fecha { get; set; } = DateTime.Now;

        [Required]
        public string Descripcion { get; set; } = string.Empty;
    }
}
