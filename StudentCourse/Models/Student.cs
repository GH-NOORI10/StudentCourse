using Microsoft.VisualBasic;

namespace StudentCourse.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public DateTime Enrolled { get; set; }

        public ICollection<CourseBook> Enrollement { get; set; }=new HashSet<CourseBook>();

    }
}
