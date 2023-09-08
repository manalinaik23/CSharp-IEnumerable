using System.ComponentModel.DataAnnotations;

namespace IEnumerableandIqueryable.Model
{
    public class Employee
    {
        [Key]
        public Guid EmpId { get; set; }
        public string Empname { get; set; }
        public int Age { get; set; }
        public double salary { get; set; }
    }
}
