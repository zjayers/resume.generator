using System.Collections.Generic;

namespace resume.generator.Domain.Dto
{
    public class BulletDto : BaseDto
    {
        public string Content { get; set; }

        public ICollection<SnippetDto> Snippets { get; set; }
    }
}