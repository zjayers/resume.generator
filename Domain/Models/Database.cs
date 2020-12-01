using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace resume.generator.Domain.Models
{
    [Table("Databases")]
    public class Database : BaseModel
    {
        public string Abbreviation { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Snippet> Snippets { get; set; }
        public virtual ICollection<Template> Templates { get; set; }
    }
}