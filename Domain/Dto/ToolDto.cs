using System.Collections.Generic;

namespace resume.generator.Domain.Dto
{
    public class ToolDto : BaseDto
    {
        public string Name { get; set; }
        public ICollection<TemplateDto> Templates { get; set; }
    }
}