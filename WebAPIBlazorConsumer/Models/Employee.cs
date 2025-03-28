namespace WebAPIBlazorConsumer.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string ImageURL { get; set; }
        public int DepartmentID { get; set; }

        public Department Department { get; set; }
    }
}
