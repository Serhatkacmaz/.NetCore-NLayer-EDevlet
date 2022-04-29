namespace EDevlet.Core.Models
{
    public class Company : BaseEntity
    {
        public string Name { get; set; }
        public string Sector { get; set; }
        public string Location { get; set; }
        public int EmployeeNumber { get; set; }
    }
}
