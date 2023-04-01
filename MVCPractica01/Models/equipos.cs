using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVCPractica01.Models
{
    public class equipos
    {
        [Key]

        [Display(Name = "ID")]
        public int id_equipos { get; set; }
        [Display(Name = "Nombre")]
        public string? nombre { get; set; }
        [Display(Name = "descripcion")]
        public string? descripcion { get; set; }
        [Display(Name = "tipo id")]
        public int? tipo_equipo_id { get; set; }
        [Display(Name = "Marca id")]
        public int marca_id { get; set; }
        [Display(Name = "Modelo")]
        public string? modelo { get; set; }
        [Display(Name = "año compra")]
        public int? anio_compra { get; set; }
        [Display(Name = "Costo")]
        public decimal? costo { get; set; }
        [Display(Name = "Vida Util")]
        public int? vida_util { get; set; }
        [Display(Name = "id estado equipo")]
        public int estado_equipo_id { get; set; }
        [Display(Name = "Estado")]
        public char? estado { get; set; }
    }
}
