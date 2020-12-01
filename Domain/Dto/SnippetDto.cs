using System;
using System.Collections.Generic;

namespace resume.generator.Domain.Dto
{
    public class SnippetDto : BaseDto
    {
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsProfessionalExperience { get; set; }

        public ApplicationUserDto User { get; set; }
        public JobTitleDto JobTitle { get; set; }
        public CompanyDto Company { get; set; }

        public ICollection<TemplateDto> Templates { get; set; }

        public ICollection<BulletDto> Bullets { get; set; }

        public ICollection<LanguageDto> Languages { get; set; }
        public ICollection<FrameworkDto> Frameworks { get; set; }
        public ICollection<DatabaseDto> Databases { get; set; }
    }
}