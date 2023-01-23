using RMA_2022_23_Student_App.Models;
using SQLite;

namespace RMA_2022_23_Student_App.Data
{
    public class StudentSubjectRepository
    {
        public string StatusMessage { get; set; }
        private SQLiteConnection conn;
        private StudentRepository _studentRepository;
        private SubjectRepository _subjectRepository;

        private void Init()
        {
            if (conn != null) return;
            conn = new SQLiteConnection(Database.DatabasePath, Database.Flags);
            conn.CreateTable<StudentSubject>();

            _studentRepository = new StudentRepository();
            _subjectRepository = new SubjectRepository();
        }

        public List<Subject> getAllStudentSubjects(int studentId)
        {
            try
            {
                Init();
                List<StudentSubject> studentSubjects = conn.Table<StudentSubject>().Where(ss => ss.studentId == studentId).ToList();
                if (studentSubjects == null || studentSubjects.Count == 0) return null;
                List<Subject> subjects = new List<Subject>();
                for (int i = 0; i < studentSubjects.Count; i++)
                {
                    var query = conn.Table<Subject>().Where(s => s.subjectId == studentSubjects[i].subjectId);
                    Subject subject = query.FirstOrDefault();

                    if (subject != null) subjects.Add(subject);
                }
                return subjects;
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        /*
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
         
         */


        public void addStudentToSubject(int studentId, int subjectId, string presence, string seminarWork, string firstPartialExam, string secondPartialExam, string finalExam)
        {
            try
            {
                if (string.IsNullOrEmpty(presence)) throw new Exception("Presence field cannot be null or empty.");
                if (string.IsNullOrEmpty(seminarWork)) throw new Exception("Seminar work field cannot be null or empty.");
                if (string.IsNullOrEmpty(firstPartialExam)) throw new Exception("First partial exam field cannot be null or empty.");
                if (string.IsNullOrEmpty(secondPartialExam)) throw new Exception("Second partial exam field cannot be null or empty.");
                if (string.IsNullOrEmpty(finalExam)) throw new Exception("Final exam field cannot be null or empty.");

                Init();
                StudentSubject studentSubject = new StudentSubject();
                var queryOne = conn.Table<Student>().Where(s => s.studentId == studentId);
                Student student = queryOne.FirstOrDefault();
                var queryTwo = conn.Table<Subject>().Where(s => s.subjectId == subjectId);
                Subject subject = queryTwo.FirstOrDefault();

                if (student != null) studentSubject.studentId = studentId;
                if (subject != null) studentSubject.subjectId = subjectId;

                conn.Insert(new StudentSubject { 
                    studentId = studentId,
                    subjectId = subjectId,
                    presence = presence,
                    seminarWork = seminarWork,
                    firstPartialExam = firstPartialExam,
                    secondPartialExam = secondPartialExam,
                    finalExam = finalExam

                });
                } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
