using Microsoft.EntityFrameworkCore;
using PortfolioProject.Models;
using PortfolioProject.Models.Entities;

namespace PortfolioProject.Data
{
    public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    { }

        public DbSet<Contact> Contacts { get; set; }
    public DbSet<Project> Projects { get; set; }



}
}