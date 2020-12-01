using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace resume.generator.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string LinkedIn { get; set; }
        public string Github { get; set; }
        public string Portfolio { get; set; }

        public virtual JobTitle JobTitle { get; set; }

        public virtual City City { get; set; }

        public virtual State State { get; set; }
    }
}
