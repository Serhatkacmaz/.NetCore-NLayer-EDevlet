using EDevlet.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EDevlet.Repository.Seeds
{
    internal class CompanySeed : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasData(
                new Company { Id = 1, Name = "Kordsa", Sector = "Tekstil", CreatedDate = DateTime.Now },
                new Company { Id = 2, Name = "Türk Hava Yolları", Sector = "Havacılık", CreatedDate = DateTime.Now },
                new Company { Id = 3, Name = "Turkcell", Sector = "Telekomünikasyon", CreatedDate = DateTime.Now });
        }
    }
}
