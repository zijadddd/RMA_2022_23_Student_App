using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMA_2022_23_Student_App.Models
{
    [Table("students")]
    public class Student
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(50)]
        public string firstName { get; set; }
        [MaxLength(50)]
        public string lastName { get; set; }
        [MaxLength(10)]
        public string birthDate { get; set; }
        [MaxLength(100)]
        public string location { get; set; }
        [MaxLength(20)]
        public string phoneNumber { get; set; }
        [MaxLength(50)]
        public string email { get; set; }
        public string password { get; set; }
        [MaxLength(10)]
        public string index { get; set; }
        [MaxLength(100)]
        public string university { get; set; }
        [MaxLength(100)]
        public string faculty { get; set; }
        [MaxLength(100)]
        public string department { get; set; }
    }
}
