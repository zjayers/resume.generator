using AutoMapper;
using resume.generator.Domain.Dto;
using resume.generator.Domain.Models;

namespace resume.generator.Domain.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ApplicationUser, ApplicationUserDto>();
            CreateMap<Bullet, BulletDto>();
            CreateMap<City, CityDto>();
            CreateMap<City, CityWithoutStatesDto>();
            CreateMap<Company, CompanyDto>();
            CreateMap<Database, DatabaseDto>();
            CreateMap<Framework, FrameworkDto>();
            CreateMap<JobTitle, JobTitleDto>();
            CreateMap<Language, LanguageDto>();
            CreateMap<School, SchoolDto>();
            CreateMap<Snippet, SnippetDto>();
            CreateMap<State, StateDto>();
            CreateMap<State, StateWithoutCitiesDto>();
            CreateMap<Template, TemplateDto>();
            CreateMap<Tool, ToolDto>();
        }
    }
}