using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Model
{
    [Table("blogs")]
    public class blog
    {
        
        public int Id { get; set; }

        public String  Title { get; set; }

        public String Description { get; set; }

        public String  Conetent { get; set; }

        public string  images { get; set; }

        public bool isfeatured { get; set; }

        public int catogreysId { get; set; }

        public catogries ? catogries { get; set; }


    }
}
