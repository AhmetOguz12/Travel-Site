using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.DataAccess.Configuration.UserConfig
{
    internal class RolesConfig : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            var UserRoleId = "42F93D7D-28CA-4008-84BE-0982B1DFB4AD";
            var AdminRoleId = "FBA4D3E5-F0D0-4545-899F-BDA60B750D54";

            var Roles = new List<IdentityRole>
            {
                new IdentityRole()
                {
                    Id = UserRoleId,
                    Name = "userRole",
                    NormalizedName= "userRoleId".ToUpper(),
                    ConcurrencyStamp = UserRoleId
                },
            new IdentityRole()
            {
                Id = AdminRoleId,
                Name = "adminRole",
                NormalizedName = "adminRole".ToUpper(),
                ConcurrencyStamp = AdminRoleId
            }

        };
            builder.HasData(Roles);
        }
    }
}
