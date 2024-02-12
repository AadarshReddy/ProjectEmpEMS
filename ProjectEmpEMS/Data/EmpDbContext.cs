using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectEmpEMS.Models;

namespace ProjectEmpEMS.Data
{
    public class EmpDbContext : DbContext
    {
        public EmpDbContext (DbContextOptions<EmpDbContext> options)
            : base(options)
        {
        }

        public DbSet<ProjectEmpEMS.Models.Emp> Emp { get; set; } = default!;
    }
}
