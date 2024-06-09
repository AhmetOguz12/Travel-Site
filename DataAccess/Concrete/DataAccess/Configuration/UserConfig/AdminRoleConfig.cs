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
    public class AdminRoleConfig : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasKey(ur => new { ur.UserId, ur.RoleId });

            var UserRoleId = "42F93D7D-28CA-4008-84BE-0982B1DFB4AD";
            var AdminRoleId = "FBA4D3E5-F0D0-4545-899F-BDA60B750D54";
            var AdminUserId = "3F740C69-F4D4-4057-B149-53414E36BC69";

            var adminRole = new List<IdentityUserRole<string>>()
            {
                new()
                {
                    UserId = AdminUserId,
                    RoleId = AdminRoleId,
                },
                new()
                {
                    UserId = AdminUserId,
                    RoleId = UserRoleId,
                }
            };
            builder.HasData(adminRole);

        }
    }
}
