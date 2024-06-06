using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WorkWave.Models
{
    public class Job
    {

        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string JobTitle { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string JobDesc { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime DateAndTime { get; set; }

        [Column(TypeName = "int")]
        public int DaysDuration { get; set; } 

        [Column(TypeName = "nvarchar(35)")]
        public string Location { get; set; }

        [Column(TypeName = "int")]
        public int Salary { get; set; }


    }
}
