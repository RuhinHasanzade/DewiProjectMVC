using DewiProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DewiProject.Configuration
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.Property(e => e.Name).IsRequired().HasMaxLength(64);
            builder.Property(e => e.Surname).IsRequired().HasMaxLength(64);
            builder.Property(e => e.ImageUrl).IsRequired().HasMaxLength(2048);
            builder.HasOne(p=> p.Position).WithMany(e=> e.Employees).HasForeignKey(e=>e.PositionId).HasPrincipalKey(p=>p.Id).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
