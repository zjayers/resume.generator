using System.Collections.Generic;

namespace resume.generator.Domain.Dto
{
    public class TemplateDto : BaseDto
    {
        public ApplicationUserDto User { get; set; }

        public ICollection<SchoolDto> Schools { get; set; }

        public ICollection<SnippetDto> Snippets { get; set; }

        public ICollection<LanguageDto> Languages { get; set; }
        public ICollection<FrameworkDto> Frameworks { get; set; }
        public ICollection<DatabaseDto> Databases { get; set; }
        public ICollection<ToolDto> Tools { get; set; }
    }
}