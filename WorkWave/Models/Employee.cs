using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WorkWave.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string EmployeeName { get; set; }


        [Column(TypeName = "int")]
        public int PhoneNumber { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Ratings { get; set; }

        [Column(TypeName = "nvarchar(30)")]
        public string Experience { get; set; }


    }
}
