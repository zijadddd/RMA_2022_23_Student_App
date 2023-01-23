using RMA_2022_23_Student_App.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            conn.CreateTable<StudentSubject>();
        }

        public void addNewSubject(string name, string professor, string classImgUrl, string primaryColor, string secondaryColor)
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

                result = conn.Insert(new Subject
                {
                    name = name,
                    professor = professor,
                    classImgUrl = classImgUrl,
                    primaryColor = primaryColor,
                    secondaryColor = secondaryColor
                });

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

        public List<SubjectModel> GetAllSubjects()
        {
            try
            {
                Init();
                List<SubjectModel> subjects = new List<SubjectModel>();
                List<Subject> subjectsDemo = conn.Table<Subject>().ToList();
                for(int i = 0; i < subjectsDemo.Count; i++)
                {
                    subjects.Add(new SubjectModel(subjectsDemo[i].subjectId, subjectsDemo[i].name, subjectsDemo[i].professor, subjectsDemo[i].classImgUrl, subjectsDemo[i].primaryColor, subjectsDemo[i].secondaryColor));
                }
                return subjects;
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("It's not possible to load data from database. {0}", ex.Message);
            }

            return new List<SubjectModel>();
        }

        public class SubjectModel
        {
            public int subjectId;
            public string name { get; set; }
            public string professor { get; set; }
            public string classImgUrl { get; set; }
            public Color primaryColor { get; set; }
            public Color secondaryColor { get; set; }
            public SubjectModel(int subjectId, string name, string professor, string classImgUrl, string primaryColor, string secondaryColor)
            {
                this.subjectId = subjectId;
                this.name = name;
                this.professor = professor;
                this.classImgUrl = classImgUrl;
                this.primaryColor = Color.FromHex(primaryColor);
                this.secondaryColor = Color.FromHex(secondaryColor);
            }
        }
    }
}
