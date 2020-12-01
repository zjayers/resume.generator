using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace resume.generator.Domain.Models
{
    [Table("Bullets")]
    public class Bullet : BaseModel
    {
        public string Content { get; set; }

        public virtual ICollection<Snippet> Snippets { get; set; }
    }
}