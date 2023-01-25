using RMA_2022_23_Student_App.Models;
using SQLite;

namespace RMA_2022_23_Student_App.Data
{
    public class SubjectRepository
    {
        public string StatusMessage { get; set; }
        private SQLiteConnection conn;

        private void Init()
        {
            if (conn != null) return;
            conn = new SQLiteConnection(Database.DatabasePath, Database.Flags);
            conn.CreateTable<Subject>();
        }

        public void addNewSubject(int subjectId, string name, string professor, string classImgUrl, string primaryColor, string secondaryColor, string day, string time, string link)
        {
            int result = 0;
            try
            {
                Init();
                if (string.IsNullOrEmpty(name)) throw new Exception("Name field cannot be null or empty.");
                if (string.IsNullOrEmpty(professor)) throw new Exception("Professor name field cannot be null or empty.");
                if (string.IsNullOrEmpty(classImgUrl)) throw new Exception("Class image url field cannot be null or empty.");
                if (string.IsNullOrEmpty(primaryColor)) throw new Exception("Primary color field cannot be null or empty.");
                if (string.IsNullOrEmpty(secondaryColor)) throw new Exception("Secondary color url field cannot be null or empty.");
                if (string.IsNullOrEmpty(day)) throw new Exception("Day field cannot be null or empty.");
                if (string.IsNullOrEmpty(time)) throw new Exception("Time field cannot be null or empty.");
                if (string.IsNullOrEmpty(link)) throw new Exception("Secondary color url field cannot be null or empty.");

                List<Subject> subjects = this.GetAllSubjects();
                Subject subject = new Subject
                {
                    subjectId = subjectId,
                    name = name,
                    professor = professor,
                    classImgUrl = classImgUrl,
                    primaryColor = primaryColor,
                    secondaryColor = secondaryColor,
                    day = day,
                    time = time,
                    link = link
                };

                if(subjects.Count > 0) foreach (Subject i in subjects) if (subject.subjectId == i.subjectId) return;
                result = conn.Insert(subject);

                StatusMessage = string.Format("{0} zapis(a) dodano (Subject: {1})", result, name);
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Nije moguće dodati {0}. Greška: {1}", name, ex.Message);
            }
        }

        public Subject getSubject(int id)
        {
            try
            {
                Init();
                var query = conn.Table<Subject>().Where(s => s.subjectId == id);
                Subject subject = query.FirstOrDefault();

                if (subject != null) return subject;   
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        public List<Subject> GetAllSubjects()
        {
            try
            {
                Init();
                return conn.Table<Subject>().ToList();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("It's not possible to load data from database. {0}", ex.Message);
            }

            return new List<Subject>();
        } 
    }
}
