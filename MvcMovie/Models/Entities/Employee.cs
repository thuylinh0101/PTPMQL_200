using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
namespace MvcMovie.Models.Entities
{
    public class Employee {
        [Key]
        public required string EmployeeID { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }

    }
}