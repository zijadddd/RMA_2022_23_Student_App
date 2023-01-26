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
                    if (subject != null) subjects.Add(new SubjectModel(subject.subjectId, subject.name, subject.professor, subject.classImgUrl, subject.primaryColor, subject.secondaryColor, subject.day, subject.time, subject.link, this.getNumberOfStudents(subject.subjectId)));
                }
                return subjects;
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        public void addStudentToSubject(int studentId, int subjectId, int isActivePendingOrCompleted ,string presence, string seminarWork, string homework, string firstPartialExam, string secondPartialExam, string finalExam)
        {
            try
            {
                if (string.IsNullOrEmpty(presence)) throw new Exception("Presence field cannot be null or empty.");
                if (string.IsNullOrEmpty(seminarWork)) throw new Exception("Seminar work field cannot be null or empty.");
                if (string.IsNullOrEmpty(homework)) throw new Exception("Homework field cannot be null or empty.");
                if (string.IsNullOrEmpty(firstPartialExam)) throw new Exception("First partial exam field cannot be null or empty.");
                if (string.IsNullOrEmpty(secondPartialExam)) throw new Exception("Second partial exam field cannot be null or empty.");
                if (string.IsNullOrEmpty(finalExam)) throw new Exception("Final exam field cannot be null or empty.");

                Init();
                StudentSubject studentSubject = new StudentSubject
                {
                    studentId = studentId,
                    subjectId = subjectId,
                    isActivePendingOrCompleted = isActivePendingOrCompleted,
                    presence = presence,
                    seminarWork = seminarWork,
                    homework = homework,
                    firstPartialExam = firstPartialExam,
                    secondPartialExam = secondPartialExam,
                    finalExam = finalExam,                   
                };

                var query = conn.Table<StudentSubject>().ToList();
                if (query.Count > 0) foreach (StudentSubject i in query) if (studentSubject.studentId == i.studentId && studentSubject.subjectId == i.subjectId) return;
                conn.Insert(studentSubject);
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

        public SubjectModel getInfoAboutSubject(int subjectId)
        {
            try
            {
                Init();
                var query = conn.Table<Subject>().Where(s => s.subjectId == subjectId);
                Subject subject = query.FirstOrDefault();

                if (subject != null) return new SubjectModel(subject.subjectId, subject.name, subject.professor, subject.classImgUrl, subject.primaryColor, subject.secondaryColor, subject.day, subject.time, subject.link, this.getNumberOfStudents(subject.subjectId));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        public int getNumberOfStudents(int subjectId)
        {
            try
            {
                Init();
                var query = conn.Table<StudentSubject>().Where(s => s.subjectId == subjectId);
                int students = 0;
                foreach (StudentSubject studentSubject in query) students++;
                if (query == null) return 0;
                else return students;
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return 0;
        }

        public List<Student> getStudentsOfClass(int subjectId)
        {
            try
            {
                Init();
                var query = conn.Table<StudentSubject>().Where(s => s.subjectId == subjectId);
                List<Student> students = new List<Student>();
                foreach(StudentSubject i in query)
                {
                    var student = conn.Table<Student>().Where(s => s.studentId == i.studentId);
                    var temp = student.FirstOrDefault();
                    students.Add(temp);
                }
                return students;
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        public int GetNumOfActiveSubjects(int studentId)
        {
            try
            {
                Init();
                return conn.Table<StudentSubject>().Where(s => s.isActivePendingOrCompleted == 0 && s.studentId == studentId).ToList().Count;
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("It's not possible to load data from database. {0}", ex.Message);
            }

            return 0;
        }

        public int GetNumOfPendingSubjects(int studentId)
        {
            try
            {
                Init();
                return conn.Table<StudentSubject>().Where(s => s.isActivePendingOrCompleted == 1 && s.studentId == studentId).ToList().Count;
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("It's not possible to load data from database. {0}", ex.Message);
            }

            return 0;
        }

        public int GetNumOfCompletedSubjects(int studentId)
        {
            try
            {
                Init();
                return conn.Table<StudentSubject>().Where(s => s.isActivePendingOrCompleted == 2 && s.studentId == studentId).ToList().Count;
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("It's not possible to load data from database. {0}", ex.Message);
            }

            return 0;
        }
    }
}
