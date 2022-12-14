namespace StudentCourse.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public string CourseCode { get; set; }

        public ICollection<CourseBook> Enrollement { get; set; }

    }
}
