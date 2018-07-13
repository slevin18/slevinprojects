using Store.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Configuration
{
    class LoginConfiguration : EntityTypeConfiguration<Login>
    {
        public LoginConfiguration()
       {
        ToTable("Login");
        Property(g => g.Username).IsRequired().HasMaxLength(50);
        Property(g => g.Password).IsRequired();
        }
    }
}
