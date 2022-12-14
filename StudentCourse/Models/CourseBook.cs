namespace StudentCourse.Models
{
    public class CourseBook
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }

        public Course Course { get; set; }  
        public Student Student { get; set; }  
    }
}
