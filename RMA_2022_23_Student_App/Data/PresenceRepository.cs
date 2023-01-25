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

        public void addPresence(int studentId, int subjectId, int week, string lectureDate, string exerciseDate, int lecturePresence, int exercisePresence)
        {
            try
            {
                //if (presence.lectureDate == "null" && presence.exerciseDate != "null") 
                Init();
                Presence presence = new Presence
                {
                    studentId = studentId,
                    subjectId = subjectId,
                    week = week,
                    lectureDate = lectureDate,
                    exerciseDate = exerciseDate,
                    lecturePresence = lecturePresence,
                    exercisePresence = exercisePresence
                };

                List<Presence> presences = GetAllPresence(studentId, subjectId);
                if (presences.Count > 0) foreach (Presence i in presences) if (i.lectureDate == lectureDate && i.exerciseDate == exerciseDate && i.subjectId == subjectId) return;
                conn.Insert(presence);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void addLecturePresence(int studentId, int subjectId, int week, string lectureDate, string exerciseDate, int lecturePresence, int exercisePresence)
        {
            try
            {
                Init();
                var query = conn.Table<Presence>().Where(p => p.week == week && p.subjectId == subjectId).ToList();
                if(query.Count > 0)
                {
                    conn.Execute("UPDATE presence SET lecturePresence = ? WHERE week = ?", lecturePresence, week);
                    conn.Execute("UPDATE presence SET lectureDate = ? WHERE week = ?", lectureDate, week);
                } else
                {
                    Presence presence = new Presence
                    {
                        studentId = studentId,
                        subjectId = subjectId,
                        week = week,
                        lectureDate = lectureDate,
                        exerciseDate = "",
                        lecturePresence = lecturePresence,
                        exercisePresence = exercisePresence
                    };
                    conn.Insert(presence);
                }

            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void addExercisePresence(int studentId, int subjectId, int week, string lectureDate, string exerciseDate, int lecturePresence, int exercisePresence)
        {
            try
            {
                Init();
                var query = conn.Table<Presence>().Where(p => p.week == week && p.subjectId == subjectId).ToList();
                if (query.Count > 0)
                {
                    conn.Execute("UPDATE presence SET exercisePresence = ? WHERE week = ?", exercisePresence, week);
                    conn.Execute("UPDATE presence SET exerciseDate = ? WHERE week = ?", exerciseDate, week);
                }
                else
                {
                    Presence presence = new Presence
                    {
                        studentId = studentId,
                        subjectId = subjectId,
                        week = week,
                        lectureDate = "",
                        exerciseDate = exerciseDate,
                        lecturePresence = lecturePresence,
                        exercisePresence = exercisePresence
                    };
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
