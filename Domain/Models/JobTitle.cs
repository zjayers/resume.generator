using System.ComponentModel.DataAnnotations.Schema;

namespace resume.generator.Domain.Models
{
    [Table("JobTitles")]
    public class JobTitle : BaseModel
    {
        public string Title { get; set; }
    }
}