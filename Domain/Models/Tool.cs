using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace resume.generator.Domain.Models
{
    [Table("Tools")]
    public class Tool : BaseModel
    {
        public string Name { get; set; }
        public virtual ICollection<Template> Templates { get; set; }
    }
}