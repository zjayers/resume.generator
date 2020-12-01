using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace resume.generator.Domain.Models
{
    [Table("Frameworks")]
    public class Framework : BaseModel
    {
        public string Name { get; set; }
        public string Abbreviation { get; set; }

        public virtual Language Language { get; set; }
        public virtual ICollection<Snippet> Snippets { get; set; }
        public virtual ICollection<Template> Templates { get; set; }
    }
}