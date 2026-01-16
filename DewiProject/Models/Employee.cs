using DewiProject.Models.Common;

namespace DewiProject.Models
{
    public class Employee : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public int PositionId { get; set; } 
        public Position? Position { get; set; }
    }
}
