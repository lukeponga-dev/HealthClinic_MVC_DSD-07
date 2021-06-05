using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HealthClinic_MVC.Data
{
    public class Identity_HealthClinicdbContext : Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityDbContext
    {
        public Identity_HealthClinicdbContext(DbContextOptions<Identity_HealthClinicdbContext> options)
            : base(options)
        {
        }
    }
}
