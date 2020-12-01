using System;
using System.Collections.Generic;

namespace resume.generator.Models
{
    public class City
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public ICollection<State> States { get; set; }
    }
}