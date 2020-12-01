using System.ComponentModel.DataAnnotations.Schema;

namespace resume.generator.Domain.Models
{
    [Table("Companies")]
    public class Company : BaseModel
    {
        public string LogoUrl { get; set; }
        public string Name { get; set; }
    }
}