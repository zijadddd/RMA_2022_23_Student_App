using RMA_2022_23_Student_App.Models;
using SQLite;
using System.Windows.Input;

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

        public List<SubjectModel> getAllStudentSubjects(int studentId)
        {
            try
            {
                Init();
                List<StudentSubject> studentSubjects = conn.Table<StudentSubject>().Where(ss => ss.studentId == studentId).ToList();
                List<SubjectModel> subjects = new List<SubjectModel>();
                List<Subject> allSubjects = new List<Subject>(_subjectRepository.GetAllSubjects());
                for (int i = 0; i < studentSubjects.Count; i++)
                {
                    Subject subject = new Subject();
                    for(int j = 0; j < allSubjects.Count; j++)
                    {
                        if (allSubjects[j].subjectId == studentSubjects[i].subjectId)
                        {
                            subject = allSubjects[j];
                            break;
                        }
                    }                
                    if (subject != null) subjects.Add(new SubjectModel(subject.subjectId, subject.name, subject.professor, subject.classImgUrl, subject.primaryColor, subject.secondaryColor));
                }
                return subjects;
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        public void addStudentToSubject(int studentId, int subjectId, int isActivePendingOrCompleted ,string presence, string seminarWork, string firstPartialExam, string secondPartialExam, string finalExam)
        {
            try
            {
                if (string.IsNullOrEmpty(presence)) throw new Exception("Presence field cannot be null or empty.");
                if (string.IsNullOrEmpty(seminarWork)) throw new Exception("Seminar work field cannot be null or empty.");
                if (string.IsNullOrEmpty(firstPartialExam)) throw new Exception("First partial exam field cannot be null or empty.");
                if (string.IsNullOrEmpty(secondPartialExam)) throw new Exception("Second partial exam field cannot be null or empty.");
                if (string.IsNullOrEmpty(finalExam)) throw new Exception("Final exam field cannot be null or empty.");

                Init();
                conn.Insert(new StudentSubject { 
                    studentId = studentId,
                    subjectId = subjectId,
                    isActivePendingOrCompleted = isActivePendingOrCompleted,
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

        public StudentSubject getStudentInfoAboutSubject(int studentId, int subjectId)
        {
            try
            {
                Init();
                var query = conn.Table<StudentSubject>().Where(s => s.studentId == studentId && s.subjectId == subjectId);
                StudentSubject studentSubject = query.FirstOrDefault();

                if (studentSubject != null) return studentSubject;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
    }
}
