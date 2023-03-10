using SQLite;
using SQLiteNetExtensions.Attributes;

namespace RMA_2022_23_Student_App.Models
{
    [Table("subjects")]
    public class Subject
    {
        [PrimaryKey]
        public int subjectId { get; set; }
        [MaxLength(100)]
        public string name { get; set; }
        [MaxLength(100)]
        public string professor { get; set; }
        [MaxLength(1000)]
        public string classImgUrl { get; set; }
        [MaxLength(10)]
        public string primaryColor { get; set; } 
        [MaxLength(10)]
        public string secondaryColor { get; set; }
        [MaxLength(100)]
        public string day { get; set; }
        [MaxLength(100)]
        public string time { get; set; }
        [MaxLength(200)]
        public string link { get; set; }
    }
}
