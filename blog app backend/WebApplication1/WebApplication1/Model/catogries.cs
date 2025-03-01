using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Model
{
    [Table("catogries")]
    public class catogries
    {
        public int id { get; set; }

        public String Name { get; set; }
    }
}
