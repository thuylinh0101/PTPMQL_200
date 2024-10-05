using System.ComponentModel.DataAnnotations;
using Microsoft.Build.Framework;
namespace MvcMovie.Models.Entities
{
public class Customer
{
    [Key]
    public  string CustomerID { get; set; }
    [MinLength(3)]
    public  string FullName { get; set; }
    public string? Address { get; set; }
    [DataType(DataType.EmailAddress)]
    public  string Email { get; set; }
}
}