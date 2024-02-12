using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectEmpEMS.Models;

namespace ProjectEmpEMS.Data
{
    public class DeptDbContext : DbContext
    {
        public DeptDbContext (DbContextOptions<DeptDbContext> options)
            : base(options)
        {
        }

        public DbSet<ProjectEmpEMS.Models.Dept> Dept { get; set; } = default!;
    }
}
