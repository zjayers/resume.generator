using System.Collections.Generic;

namespace resume.generator.Domain.Dto
{
    public class FrameworkDto : BaseDto
    {
        public string Name { get; set; }
        public string Abbreviation { get; set; }

        public LanguageDto Language { get; set; }
        public ICollection<SnippetDto> Snippets { get; set; }
        public ICollection<TemplateDto> Templates { get; set; }
    }
}