using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ikea.dal.models.departments;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Reflection;

namespace ikea.dal.presistance.data.configurations.departments
{
    internal class departmentconfigurations : IEntityTypeConfiguration<depatment>
    {
        public void Configure(EntityTypeBuilder<depatment> builder)

        {

            builder.Property(D=>D.Id).UseIdentityColumn( 10 , 10);
            builder.Property(d => d.name).HasColumnType("varchar(50)").IsRequired();
            builder.Property(d => d.code).HasColumnType("varchar(50)").IsRequired();
            builder.Property(D => D.createdon).HasDefaultValueSql("GETDATE()");
            builder.Property(D => D.lastmodifiedon).HasComputedColumnSql("GETDATE()");


        }
    }
}
