using Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Persistence.Data;

public class EmployeeDbContext : IdentityDbContext
{
    public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
    {
    }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    optionsBuilder.UseSqlServer("Data Source=SIVAN;Initial Catalog=EMS_EFC_DB;User ID=sa;Password=user;Connect Timeout=30;Encrypt=False;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False")
    //        .LogTo(Console.WriteLine, new[] { Command.Name }, LogLevel.Information)
    //        .EnableSensitiveDataLogging();
    //}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Employee>().ToTable("tblEmployees");
        modelBuilder.Entity<EmpContactDetail>().ToTable("tblContactDetails");
        modelBuilder.Entity<EmpType>().ToTable("tblTypes");
        modelBuilder.Entity<EmpDepartment>().ToTable("tblDepartments");
        modelBuilder.Entity<EmpAccount>().ToTable("tblAccounts");
        modelBuilder.Entity<EmpRole>().ToTable("tblRoles");
        modelBuilder.Entity<EmpAuthentication>().ToTable("tblAuthentications");
    }

    public DbSet<Employee> Employees { get; set; }
    public DbSet<EmpType> EmpTypes { get; set; }
    public DbSet<EmpDepartment> EmpDepartments { get; set; }
    public DbSet<EmpAccount> EmpAccounts { get; set; }
    public DbSet<EmpRole> EmpRole { get; set; }
    public DbSet<EmpAuthentication> EmpAuthentications { get; set; }
    public DbSet<EmpContactDetail> EmpContactDetails { get; set; }

}
