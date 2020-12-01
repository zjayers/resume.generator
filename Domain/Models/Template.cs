using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace resume.generator.Domain.Models
{
    [Table("Templates")]
    public class Template : BaseModel
    {
        public virtual ApplicationUser User { get; set; }

        public virtual ICollection<School> Schools { get; set; }

        public virtual ICollection<Snippet> Snippets { get; set; }

        public virtual ICollection<Language> Languages { get; set; }
        public virtual ICollection<Framework> Frameworks { get; set; }
        public virtual ICollection<Database> Databases { get; set; }
        public virtual ICollection<Tool> Tools { get; set; }
    }
}