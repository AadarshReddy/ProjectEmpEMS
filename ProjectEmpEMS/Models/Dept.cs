using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectEmpEMS.Models
{
    [Table("Dept")]
    public class Dept
    {
        [Key]
        public int DeptCode { get; set; }
        public string? DeptName { get; set;}
    }
}
