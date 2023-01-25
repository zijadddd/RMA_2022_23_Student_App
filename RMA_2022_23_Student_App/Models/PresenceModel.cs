namespace RMA_2022_23_Student_App.Models
{
    public class PresenceModel
    {
        public string subjectId { get; set; }
        public string week { get; set; }
        public string lectureDate { get; set; }
        public string exerciseDate { get; set; }

        public PresenceModel(string subjectId, string week, string lectureDate, string exerciseDate)
        {
            this.subjectId = subjectId;
            this.week = week;
            this.lectureDate = lectureDate;
            this.exerciseDate = exerciseDate;
        }
    }
}
