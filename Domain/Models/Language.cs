using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace resume.generator.Domain.Models
{
    [Table("Languages")]
    public class Language : BaseModel
    {
        public string Abbreviation { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Framework> Frameworks { get; set; }
        public virtual ICollection<Snippet> Snippets { get; set; }
        public virtual ICollection<Template> Templates { get; set; }
    }
}