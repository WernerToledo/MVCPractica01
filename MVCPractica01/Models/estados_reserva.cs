using System.ComponentModel.DataAnnotations;

namespace wedApi_join.Model
{
    public class estados_reserva
    {
        [Key]
        public int estado_res_id { get; set; }
        public string estado { get; set; }
    }
}
