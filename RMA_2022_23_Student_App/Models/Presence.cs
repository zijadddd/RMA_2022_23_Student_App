using SQLite;

namespace RMA_2022_23_Student_App.Models
{
    [Table("presence")]
    public class Presence
    {
        [Column("studentId")]
        public int studentId { get; set; }
        [Column("subjectId")]
        public int subjectId { get; set; }
        [Column("week")]
        public int week { get; set; }
        [Column("lectureDate"), MaxLength(10)]
        public string lectureDate { get; set; }
        [Column("exerciseDate"), MaxLength(10)]
        public string exerciseDate { get; set; }
        [Column("lecturePresence")]
        public int lecturePresence { get; set; }
        [Column("exercisePresence")]
        public int exercisePresence { get; set; }
    }
}
