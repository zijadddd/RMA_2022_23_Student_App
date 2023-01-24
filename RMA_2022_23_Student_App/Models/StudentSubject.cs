using SQLite;

namespace RMA_2022_23_Student_App.Models
{
    [Table("studentsubject")]
    public class StudentSubject
    {
        [Column ("studentId")]
        public int studentId { get; set; }
        [Column("subjectId")]
        public int subjectId { get; set; }

        [Column("isActivePendingOrCompleted")]
        public int isActivePendingOrCompleted { get; set; } // 0 - Active, 1 - Pending, 2 - Completed

        [MaxLength(10)]
        public string presence { get; set; }
        [MaxLength(10)]
        public string seminarWork { get; set; }
        [MaxLength(10)]
        public string firstPartialExam { get; set; }
        [MaxLength(10)]
        public string secondPartialExam { get; set; }
        [MaxLength(10)]
        public string finalExam { get; set; }

    }
}
