using GoShop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GoShop.Data.EntityConfigurations;

public class MobilePhoneEntityConfiguration : IEntityTypeConfiguration<MobilePhoneEntity>
{
    public void Configure(EntityTypeBuilder<MobilePhoneEntity> builder)
    {
        builder.ToTable("MobilePhones");
        builder.HasKey(t => t.Id);

        builder.Property(t => t.UserId).IsRequired();
        builder.Property(t => t.MobilePhoneHardwareId).IsRequired();
        builder.Property(t => t.MobilePhoneSoftwareId).IsRequired();
        builder.Property(t => t.Year).IsRequired();
        builder.Property(t => t.Price).IsRequired();
        builder.Property(t => t.Brand).IsRequired().HasMaxLength(255);
        builder.Property(t => t.Model).IsRequired().HasMaxLength(255);
        builder.Property(t => t.Condition).IsRequired().HasMaxLength(255);
        builder.Property(t => t.Description).IsRequired().HasMaxLength(255);

        builder.HasOne(t => t.MobilePhoneHardware)
            .WithOne(x => x.MobilePhone)
            .HasForeignKey<MobilePhoneHardwareEntity>(x => x.MobilePhoneId);

        builder.HasOne(t => t.MobilePhoneSoftware)
           .WithOne(x => x.MobilePhone)
           .HasForeignKey<MobilePhoneSoftwareEntity>(x => x.MobilePhoneId);

        builder.HasOne(t => t.User)
         .WithMany(x => x.MobilePhones)
         .HasForeignKey(x => x.UserId);
    }
}