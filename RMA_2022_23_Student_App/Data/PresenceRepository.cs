using RMA_2022_23_Student_App.Models;
using SQLite;

namespace RMA_2022_23_Student_App.Data
{
    public class PresenceRepository
    {
        private SQLiteConnection conn;

        private void Init()
        {
            if (conn != null) return;
            conn = new SQLiteConnection(Database.DatabasePath, Database.Flags);
            conn.CreateTable<Presence>();
        }

        public void addPresence(int studentId, int subjectId, string lectureDate, string exerciseDate, int lecturePresence, int exercisePresence)
        {
            try
            {
                Init();

                if(!string.IsNullOrEmpty(lectureDate) && string.IsNullOrEmpty(exerciseDate))
                {
                    var query = conn.Table<Presence>().Where(p => p.studentId == studentId && p.subjectId == subjectId && p.lectureDate.Length == 0 && p.exerciseDate.Length > 0).FirstOrDefault();
                    if(query != null)
                    {
                        query.lectureDate = lectureDate;
                        query.lecturePresence = lecturePresence;
                        conn.RunInTransaction(() =>
                        {
                            conn.Update(query);
                        });
                    } else
                    {
                        Presence presence = new Presence
                        {
                            studentId = studentId,
                            subjectId = subjectId,
                            lectureDate = lectureDate,
                            exerciseDate = "",
                            lecturePresence = lecturePresence,
                            exercisePresence = 0
                        };
                        conn.Insert(presence);
                    }
                } else if (string.IsNullOrEmpty(lectureDate) && !string.IsNullOrEmpty(exerciseDate))
                {
                    var query = conn.Table<Presence>().Where(p => p.studentId == studentId && p.subjectId == subjectId && p.lectureDate.Length > 0 && p.exerciseDate.Length == 0).FirstOrDefault();
                    if (query != null)
                    {
                        query.exerciseDate = exerciseDate;
                        query.exercisePresence = exercisePresence;
                        conn.RunInTransaction(() =>
                        {
                            conn.Update(query);
                        });
                    }
                    else
                    {
                        Presence presence = new Presence
                        {
                            studentId = studentId,
                            subjectId = subjectId,
                            lectureDate = "",
                            exerciseDate = exerciseDate,
                            lecturePresence = 0,
                            exercisePresence = exercisePresence
                        };
                        conn.Insert(presence);
                    }
                } else
                { 
                    Presence presence = new Presence
                    {
                        studentId = studentId,
                        subjectId = subjectId,
                        lectureDate = lectureDate,
                        exerciseDate = exerciseDate,
                        lecturePresence = lecturePresence,
                        exercisePresence = exercisePresence
                    };

                    List<Presence> presences = GetAllPresence(studentId, subjectId);
                    if (presences.Count > 0) foreach (Presence i in presences) if (i.lectureDate == lectureDate && i.exerciseDate == exerciseDate && i.subjectId == subjectId) return;
                    conn.Insert(presence);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public List<Presence> GetAllPresence(int studentId, int subjectId)
        {
            try
            {
                Init();
                return conn.Table<Presence>().Where(p => p.studentId == studentId && p.subjectId == subjectId).ToList();
            }
            catch (Exception ex) { }

            return new List<Presence>();
        }
    }
}
