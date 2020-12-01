using System.Collections.Generic;

namespace resume.generator.Domain.Dto
{
    public class CityDto : BaseDto
    {
        public string Name { get; set; }
        public ICollection<StateWithoutCitiesDto> States { get; set; }
    }
}