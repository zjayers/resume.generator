using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace resume.generator.Domain.Models
{
    [Table("Snippets")]
    public class Snippet : BaseModel
    {
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsProfessionalExperience { get; set; }

        public virtual ApplicationUser User { get; set; }
        public virtual JobTitle JobTitle { get; set; }
        public virtual Company Company { get; set; }

        public virtual ICollection<Template> Templates { get; set; }

        public virtual ICollection<Bullet> Bullets { get; set; }

        public virtual ICollection<Language> Languages { get; set; }
        public virtual ICollection<Framework> Frameworks { get; set; }
        public virtual ICollection<Database> Databases { get; set; }
    }
}