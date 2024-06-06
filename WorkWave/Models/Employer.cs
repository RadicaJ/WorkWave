using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkWave.Models
{
    public class Employer
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string EmployerName { get; set; }


        [Column(TypeName = "int")]
        public int PhoneNumber { get; set; }

        [Column(TypeName = "nvarchar(35)")]
        public string Location { get; set; } = "Expense";


        [Column(TypeName = "decimal(18, 2)")]
        public decimal Ratings { get; set; }


    }
}
