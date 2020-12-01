using System;
using System.Collections;
using System.Collections.Generic;

namespace resume.generator.Models
{
    public class State
    {
        public Guid Id { get; set; }
        public string Abbreviation { get; set; }
        public string Name { get; set; }

        public ICollection<City> Cities { get; set; }
    }
}