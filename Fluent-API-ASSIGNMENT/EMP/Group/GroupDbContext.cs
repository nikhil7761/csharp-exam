using Microsoft.EntityFrameworkCore;

namespace EMP.Group;


public class GroupDbContext : DbContext
{
public DbSet <Employee> Employees {get; set;}
public DbSet <Department> Departments {get; set;}

protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
optionsBuilder.UseMySQL("Server=localhost;Database=employee_net;User ID=root;Password=root");
}

protected override void OnModelCreating(ModelBuilder modelBuilder)
{

modelBuilder.Entity<Employee>()
            .ToTable("Employee")
            .Property(p=>p.Id)
            .HasColumnName("Eno");
modelBuilder.Entity<Employee>()
            .Property(p=>p.DepartmentId)
            .HasColumnName("Dno");
modelBuilder.Entity<Department>()
            .ToTable("Department")
             .Property(p=>p.Id)
            .HasColumnName("Dno");

           

}


}
