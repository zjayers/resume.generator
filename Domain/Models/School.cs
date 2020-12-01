using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace resume.generator.Domain.Models
{
    [Table("Schools")]
    public class School : BaseModel
    {
        public string Name { get; set; }
        public virtual ICollection<Template> Templates { get; set; }
    }
}