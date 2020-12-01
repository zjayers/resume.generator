namespace resume.generator.Domain.Dto
{
    public class ApplicationUserDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string LinkedIn { get; set; }
        public string Github { get; set; }
        public string Portfolio { get; set; }

        public JobTitleDto JobTitle { get; set; }

        public CityDto City { get; set; }

        public StateDto State { get; set; }
    }
}