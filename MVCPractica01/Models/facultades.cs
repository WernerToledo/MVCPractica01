using System.ComponentModel.DataAnnotations;

namespace wedApi_join.Model
{
    public class facultades
    {
        [Key]
        public int facultad_id { get; set; }
        public string nombre_facultad { get; set; }
    }
}
