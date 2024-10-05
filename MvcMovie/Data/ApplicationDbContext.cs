using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;
using MvcMovie.Models.Entities;

namespace MvcMovie.Data{
    public class  ApplicationDbContext :DbContext{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options){

        }
        public DbSet<Student> Students {get;set;}
        public DbSet<Person> Person {get;set;}
        public DbSet<Employee> Employee {get;set;}
        public DbSet<Customer> Customer {get;set;} = default!;
    
    
    }

}