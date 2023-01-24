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
        public SubjectModel(int subjectId, string name, string professor, string classImgUrl, string primaryColor, string secondaryColor)
        {
            this.subjectId = subjectId.ToString();
            this.name = name;
            this.professor = professor;
            this.classImgUrl = classImgUrl;
            this.primaryColor = Color.FromHex(primaryColor);
            this.secondaryColor = Color.FromHex(secondaryColor);
        }
    }
}
