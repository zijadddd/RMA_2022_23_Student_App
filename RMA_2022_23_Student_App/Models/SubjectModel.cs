namespace RMA_2022_23_Student_App.Models
{
    public class SubjectModel
    {
        public string subjectId { get; set; }
        public string name { get; set; }
        public string professor { get; set; }
        public string classImgUrl { get; set; }
        public Color primaryColor { get; set; }
        public Color secondaryColor { get; set; }
        public string day { get; set; }
        public string time { get; set; }
        public string link { get; set; }

        public int numOfStudents { get; set; }

        public SubjectModel(int subjectId, string name, string professor, string classImgUrl, string primaryColor, string secondaryColor, string day, string time, string link, int numOfStudents)
        {
            this.subjectId = subjectId.ToString();
            this.name = name;
            this.professor = professor;
            this.classImgUrl = classImgUrl;
            this.primaryColor = Color.FromHex(primaryColor);
            this.secondaryColor = Color.FromHex(secondaryColor);
            this.day = day;
            this.time = time;
            this.link = link;
            this.numOfStudents = numOfStudents;
        }
    }
}
