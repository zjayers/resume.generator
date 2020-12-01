using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace resume.generator.Domain.Models
{
    [Table("Cities")]
    public class City : BaseModel
    {
        public string Name { get; set; }
        public virtual ICollection<State> States { get; set; }
    }
}