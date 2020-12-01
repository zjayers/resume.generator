using System.Collections.Generic;

namespace resume.generator.Domain.Dto
{
    public class StateDto : BaseDto
    {
        public string Abbreviation { get; set; }
        public string Name { get; set; }

        public ICollection<CityWithoutStatesDto> Cities { get; set; }
    }
}