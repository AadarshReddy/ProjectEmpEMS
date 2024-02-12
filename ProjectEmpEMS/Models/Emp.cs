using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectEmpEMS.Models
{
    [Table("Employee")]
    public class Emp
    {
        [Key]
        public int EmpCode { get; set; }
        public DateTime DOB { get; set; }
        public string? EmpName { get; set; }

        public string? Email { get; set; }

        public string? DeptCode { get; set; }

    }
}
  
