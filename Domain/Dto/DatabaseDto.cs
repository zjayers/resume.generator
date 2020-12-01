using System.Collections.Generic;

namespace resume.generator.Domain.Dto
{
    public class DatabaseDto : BaseDto
    {
        public string Abbreviation { get; set; }
        public string Name { get; set; }

        public ICollection<SnippetDto> Snippets { get; set; }
        public ICollection<TemplateDto> Templates { get; set; }
    }
}